SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetMonthlyExpenseSummary
GO
CREATE PROCEDURE GetMonthlyExpenseSummary
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
            UPPER(LEFT(DATENAME(MONTH, DATEFROMPARTS(YEAR(ENTRY_DATE), MONTH(ENTRY_DATE), 1)), 3)) + '' '' + CAST(YEAR(ENTRY_DATE) AS NVARCHAR) AS Month,
            ';

    -- Dynamically generate the expense types
    SET @expense_types = '';

    -- Cursor to iterate over distinct expense types
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE;

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
            YEAR(ENTRY_DATE) AS Year,
            MONTH(ENTRY_DATE) AS MonthNum
        FROM SLN_EXPENSE
        WHERE ENTRY_DATE >= DATEADD(MONTH, -12, GETDATE())  -- Limit to last 12 months
        GROUP BY YEAR(ENTRY_DATE), MONTH(ENTRY_DATE)

        UNION ALL

        SELECT 
            ''Total'' AS Month,
            ';

    -- Reuse the same dynamic SUM statements for the total row
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE;

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
    SET @sql = @sql + ',
            SUM(EXPENSE_AMOUNT) AS Total_Amount,
            NULL AS Year,
            NULL AS MonthNum
        FROM SLN_EXPENSE
        WHERE ENTRY_DATE >= DATEADD(MONTH, -12, GETDATE())
    )
    SELECT
        Month,';

    -- Dynamically add the expense types to the final SELECT statement
    SET @cursor = CURSOR FOR
        SELECT DISTINCT EXPENSE_TYPE
        FROM SLN_EXPENSE;

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @expense_types;

    -- Dynamically add the expense types to the final SELECT statement
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
    ORDER BY Year DESC, MonthNum DESC;';

    -- Print dynamic SQL for debugging (can be removed later)
    -- PRINT @sql;

    -- Execute the dynamic SQL
    EXEC sp_executesql @sql;
END;
GO
