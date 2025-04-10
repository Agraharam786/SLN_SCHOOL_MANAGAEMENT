SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetFeeSummaryByClassAndMonthWithFilters
GO
CREATE PROCEDURE GetFeeSummaryByClassAndMonthWithFilters
    @CLASSNAME NVARCHAR(50) = NULL,      -- Optional Class filter
	@ACADEMIC_YEAR VARCHAR(10) = NULL,  -- Optional Academic Year filter
    @Section NVARCHAR(50) = NULL    -- Optional Section filter
    
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
            UPPER(LEFT(DATENAME(MONTH, DATEFROMPARTS(YEAR(PAID_DATE), MONTH(PAID_DATE), 1)), 3)) + '' '' + CAST(YEAR(PAID_DATE) AS NVARCHAR) AS Month,
            CLASS,
            SECTION,';

    -- Dynamically generate the fee types
    SET @fee_type = '';

    -- Cursor to iterate over distinct fee types
    SET @cursor = CURSOR FOR
        SELECT DISTINCT FEE_TYPE
        FROM SLN_FEE
        WHERE IS_DELETED=0;

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
    SET @sql = @sql + ',
            SUM(PAID_AMOUNT) AS Total_Amount,
            YEAR(PAID_DATE) AS Year,
            MONTH(PAID_DATE) AS MonthNum
        FROM SLN_FEE
        WHERE PAID_DATE >= DATEADD(MONTH, -12, GETDATE()) -- Limit to last 12 months
        AND IS_DELETED=0';

    -- Apply filters for Class, Section, and ACADEMIC_YEAR if provided
    IF @CLASSNAME IS NOT NULL
        SET @sql = @sql + ' AND CLASS = @CLASSNAME';
    IF @Section IS NOT NULL
        SET @sql = @sql + ' AND SECTION = @Section';
    IF @ACADEMIC_YEAR IS NOT NULL
        SET @sql = @sql + ' AND ACADEMIC_YEAR = @ACADEMIC_YEAR';

    -- Continue building the query
    SET @sql = @sql + '
        GROUP BY YEAR(PAID_DATE), MONTH(PAID_DATE), CLASS, SECTION

        UNION ALL

        SELECT 
            ''Total'' AS Month,
            NULL AS CLASS,
            NULL AS SECTION,';

    -- Reuse the same dynamic SUM statements for the total row
    SET @cursor = CURSOR FOR
        SELECT DISTINCT FEE_TYPE
        FROM SLN_FEE
        WHERE IS_DELETED=0;

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
            NULL AS Year,
            NULL AS MonthNum
        FROM SLN_FEE
        WHERE PAID_DATE >= DATEADD(MONTH, -12, GETDATE())
        AND IS_DELETED=0';

    -- Apply filters for the total row if provided
    IF @CLASSNAME IS NOT NULL
        SET @sql = @sql + ' AND CLASS = @CLASSNAME';
    IF @Section IS NOT NULL
        SET @sql = @sql + ' AND SECTION = @Section';
    IF @ACADEMIC_YEAR IS NOT NULL
        SET @sql = @sql + ' AND ACADEMIC_YEAR = @ACADEMIC_YEAR';

    -- Continue building the query
    SET @sql = @sql + '
    )
    SELECT
        Month,
        CLASS,
        SECTION,';

    -- Dynamically add the fee type columns in the final SELECT statement
    SET @cursor = CURSOR FOR
        SELECT DISTINCT FEE_TYPE
        FROM SLN_FEE
        WHERE IS_DELETED=0;

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
    SET @sql = @sql + ',
        Total_Amount
    FROM CTE_FeeSummary
    ORDER BY Year DESC, MonthNum DESC, CLASS, SECTION;';

    -- Execute the dynamic SQL with the passed parameters
    EXEC sp_executesql @sql, N'@CLASSNAME NVARCHAR(50), @Section NVARCHAR(50), @ACADEMIC_YEAR VARCHAR(10)', @CLASSNAME, @Section, @ACADEMIC_YEAR;
END;
GO
