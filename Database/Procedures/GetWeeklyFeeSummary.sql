SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetWeeklyFeeSummary
GO
CREATE PROCEDURE GetWeeklyFeeSummary
AS
BEGIN
    -- Declare a variable to hold dynamic SQL
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @fee_type NVARCHAR(MAX);
    DECLARE @cursor CURSOR;

    -- Start building the dynamic SQL query
    SET @sql = N'
    WITH CTE_FeeSummary AS (
        SELECT 
            FORMAT(PAID_DATE, ''MMM dd, yyyy'') AS Weekday,  -- Format date as "MMM DD, YYYY"
            ';

    -- Dynamically generate the fee types
    SET @fee_type = '';

    -- Cursor to iterate over distinct fee types
    SET @cursor = CURSOR FOR
        SELECT DISTINCT FEE_TYPE
        FROM SLN_FEE
        WHERE IS_DELETED = 0
        AND PAID_DATE >= DATEADD(DAY, -7, GETDATE());  -- Limit to the last 7 days

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @fee_type;

    -- Construct SUM expressions for each fee type dynamically
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '
            SUM(CASE WHEN FEE_TYPE = ''' + @fee_type + ''' THEN PAID_AMOUNT ELSE 0 END) AS [' + @fee_type + '],';
        FETCH NEXT FROM @cursor INTO @fee_type;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma from the last fee type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Add additional columns for sorting purposes
    SET @sql = @sql + ' ,
            SUM(PAID_AMOUNT) AS Total_Amount,
            FORMAT(PAID_DATE, ''MMM dd, yyyy'') AS Date  -- Add formatted date for sorting
        FROM SLN_FEE
        WHERE PAID_DATE >= DATEADD(DAY, -7, GETDATE())  -- Limit to the last 7 days
        AND IS_DELETED = 0
        GROUP BY PAID_DATE

        UNION ALL

        -- Add Total row
        SELECT 
            ''Total'' AS Weekday,';

    -- Reuse the same dynamic SUM statements for the total row
    SET @cursor = CURSOR FOR
        SELECT DISTINCT FEE_TYPE
        FROM SLN_FEE
        WHERE IS_DELETED = 0
        AND PAID_DATE >= DATEADD(DAY, -7, GETDATE());  -- Limit to the last 7 days

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @fee_type;

    -- Add SUM statements for the 'Total' row
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '
            SUM(CASE WHEN FEE_TYPE = ''' + @fee_type + ''' THEN PAID_AMOUNT ELSE 0 END) AS [' + @fee_type + '],';
        FETCH NEXT FROM @cursor INTO @fee_type;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma for the last fee type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Finalize the total row and the query
    SET @sql = @sql + ',
            SUM(PAID_AMOUNT) AS Total_Amount,
            NULL AS Date
        FROM SLN_FEE
        WHERE PAID_DATE >= DATEADD(DAY, -7, GETDATE())
        AND IS_DELETED = 0
    )
    SELECT
        Weekday,';  -- Include weekday in the final select

    -- Dynamically add the fee type columns in the final SELECT statement
    SET @cursor = CURSOR FOR
        SELECT DISTINCT FEE_TYPE
        FROM SLN_FEE
        WHERE IS_DELETED = 0
        AND PAID_DATE >= DATEADD(DAY, -7, GETDATE());  -- Limit to the last 7 days

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @fee_type;

    -- Dynamically add the fee types to the SELECT statement
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '[' + @fee_type + '],';
        FETCH NEXT FROM @cursor INTO @fee_type;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma from the last fee type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Add the Total_Amount column to the final SELECT statement
    SET @sql = @sql + ' ,
        Total_Amount
    FROM CTE_FeeSummary
    ORDER BY Date DESC;';  -- Order by date to show most recent at the top

    -- Execute the dynamic SQL
    EXEC sp_executesql @sql;
END;
GO
