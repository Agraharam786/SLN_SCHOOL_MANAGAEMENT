SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetWeeklyExpenseSummary
GO
CREATE PROCEDURE GetWeeklyExpenseSummary
AS
BEGIN
    -- Declare variables for dynamic SQL construction
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @expense_types NVARCHAR(MAX);
    DECLARE @cursor CURSOR;

    -- Start building the dynamic SQL query
    SET @sql = N'
    WITH CTE_Expense AS (
        SELECT 
            FORMAT(ENTRY_DATE, ''MMM dd, yyyy'') AS Weekday,  -- Format as "MMM DD, YYYY"
            ';

    -- Dynamically generate the expense types
    SET @expense_types = '';

    -- Cursor to iterate over distinct expense types
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE());  -- Limit to last 7 days

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @expense_types;

    -- Construct SUM expressions for each expense type dynamically
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '
            SUM(CASE WHEN EXPENSE_TYPE = ''' + @expense_types + ''' THEN EXPENSE_AMOUNT ELSE 0 END) AS [' + @expense_types + '],';
        FETCH NEXT FROM @cursor INTO @expense_types;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma from the last expense type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Add additional columns for sorting purposes
    SET @sql = @sql + ',
            SUM(EXPENSE_AMOUNT) AS Total_Amount,
            FORMAT(ENTRY_DATE, ''MMM dd, yyyy'') AS Date  -- Convert date to "MMM DD, YYYY" format
        FROM SLN_EXPENSE
        WHERE ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())  -- Limit to last 7 days
        AND IS_DELETED = 0
        GROUP BY ENTRY_DATE

        UNION ALL

        -- Add Total row
        SELECT 
            ''Total'' AS Weekday,';

    -- Reuse the same dynamic SUM statements for the total row
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE());  -- Limit to last 7 days

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @expense_types;

    -- Add SUM statements for the 'Total' row
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '
            SUM(CASE WHEN EXPENSE_TYPE = ''' + @expense_types + ''' THEN EXPENSE_AMOUNT ELSE 0 END) AS [' + @expense_types + '],';
        FETCH NEXT FROM @cursor INTO @expense_types;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma for the last expense type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Finalize the total row and the query
    SET @sql = @sql + ' ,
            SUM(EXPENSE_AMOUNT) AS Total_Amount,
            NULL AS Date
        FROM SLN_EXPENSE
        WHERE ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())
        AND IS_DELETED = 0
    )
    SELECT
        Weekday,';  -- Include weekday in the final select

    -- Dynamically add the expense types to the final SELECT statement
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE());  -- Limit to last 7 days

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @expense_types;

    -- Add the expense types to the final SELECT statement
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '[' + @expense_types + '],';
        FETCH NEXT FROM @cursor INTO @expense_types;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma from the last expense type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Add the Total_Amount column to the final SELECT statement
    SET @sql = @sql + ',
        Total_Amount
    FROM CTE_Expense
    ORDER BY Date DESC;';  -- Order by date to show most recent at the top

    -- Execute the dynamic SQL
    EXEC sp_executesql @sql;
END;
GO
