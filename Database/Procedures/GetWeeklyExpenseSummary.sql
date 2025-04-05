SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetWeeklyExpenseSummary
GO
CREATE PROCEDURE GetWeeklyExpenseSummary
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @expense_type NVARCHAR(100);
    DECLARE @cursor CURSOR;

    -- Start building the dynamic SQL query
    SET @sql = N'
    WITH CTE_Expense AS (
        SELECT 
            FORMAT(ENTRY_DATE, ''MMM dd, yyyy'') AS Weekday,
            ISNULL(EXPENSE_FROM, '''') AS EXPENSE_FROM,';

    -- Initialize cursor to loop over expense types
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE());

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @expense_type;

    -- Dynamically generate SUM columns
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '
            SUM(CASE WHEN EXPENSE_TYPE = ''' + @expense_type + ''' THEN EXPENSE_AMOUNT ELSE 0 END) AS [' + @expense_type + '],';
        FETCH NEXT FROM @cursor INTO @expense_type;
    END;

    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Append totals and GROUP BY
    SET @sql = LEFT(@sql, LEN(@sql) - 1) + ', 
            SUM(EXPENSE_AMOUNT) AS Total_Amount,
            FORMAT(ENTRY_DATE, ''MMM dd, yyyy'') AS Date
        FROM SLN_EXPENSE
        WHERE ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())
        AND IS_DELETED = 0
        GROUP BY ENTRY_DATE, EXPENSE_FROM

        UNION ALL

        SELECT 
            ''Total'' AS Weekday,
            ISNULL(EXPENSE_FROM, '''') AS EXPENSE_FROM,';

    -- Reuse cursor for totals
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE());

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @expense_type;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '
            SUM(CASE WHEN EXPENSE_TYPE = ''' + @expense_type + ''' THEN EXPENSE_AMOUNT ELSE 0 END) AS [' + @expense_type + '],';
        FETCH NEXT FROM @cursor INTO @expense_type;
    END;

    CLOSE @cursor;
    DEALLOCATE @cursor;

    SET @sql = LEFT(@sql, LEN(@sql) - 1) + ',
            SUM(EXPENSE_AMOUNT) AS Total_Amount,
            NULL AS Date
        FROM SLN_EXPENSE
        WHERE ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())
        AND IS_DELETED = 0
        GROUP BY EXPENSE_FROM
    )

    SELECT
        Weekday,
        ISNULL(EXPENSE_FROM, '''') AS EXPENSE_FROM,';

    -- Final SELECT with dynamic columns
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE());

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @expense_type;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '[' + @expense_type + '],';
        FETCH NEXT FROM @cursor INTO @expense_type;
    END;

    CLOSE @cursor;
    DEALLOCATE @cursor;

    SET @sql = LEFT(@sql, LEN(@sql) - 1) + ',
        Total_Amount
    FROM CTE_Expense
    ORDER BY Date DESC, EXPENSE_FROM;';

    -- Execute the dynamic SQL
    EXEC sp_executesql @sql;
END;
GO
