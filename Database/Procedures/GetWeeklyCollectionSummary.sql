SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetWeeklyCollectionSummary
GO
CREATE PROCEDURE GetWeeklyCollectionSummary
AS
BEGIN
    -- Declare variables for dynamic SQL construction
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @collection_types NVARCHAR(MAX);
    DECLARE @cursor CURSOR;

    -- Start building the dynamic SQL query
    SET @sql = N'
    WITH CTE_Collection AS (
        SELECT 
            CONVERT(VARCHAR, ENTRY_DATE, 107) AS CollectionDate,  -- Format date as "MMM DD, YYYY"
            0 AS RowOrder,                                         -- 0 for regular rows
            ';

    -- Dynamically generate the collection types for those having non-zero collections
    SET @collection_types = '';
    
    -- Cursor to iterate over distinct collection types with valid data
    SET @cursor = CURSOR FOR
        SELECT DISTINCT COLLECTION_TYPE
        FROM SLN_COLLECTION
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())  -- Limit to last 7 days
        AND COLLECTION_AMOUNT > 0;

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @collection_types;

    -- Construct SUM expressions for each collection type dynamically
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '
            SUM(CASE WHEN COLLECTION_TYPE = ''' + @collection_types + ''' THEN COLLECTION_AMOUNT ELSE 0 END) AS [' + @collection_types + '],';
        FETCH NEXT FROM @cursor INTO @collection_types;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma from the last collection type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Add additional columns for total amounts
    SET @sql = @sql + ',
            SUM(COLLECTION_AMOUNT) AS Total_Amount
        FROM SLN_COLLECTION
        WHERE ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())  -- Limit to last 7 days
        AND IS_DELETED = 0
        GROUP BY CONVERT(VARCHAR, ENTRY_DATE, 107)

        UNION ALL

        -- Add the Total row
        SELECT 
            ''Total'' AS CollectionDate,';  -- No need for RowOrder in the final output

    -- Reuse the same dynamic SUM statements for the total row
    SET @cursor = CURSOR FOR
        SELECT DISTINCT COLLECTION_TYPE
        FROM SLN_COLLECTION
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())
        AND COLLECTION_AMOUNT > 0;

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @collection_types;

    -- Add SUM statements for the 'Total' row
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '
            SUM(CASE WHEN COLLECTION_TYPE = ''' + @collection_types + ''' THEN COLLECTION_AMOUNT ELSE 0 END) AS [' + @collection_types + '],';
        FETCH NEXT FROM @cursor INTO @collection_types;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma from the last collection type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Finalize the total row
    SET @sql = @sql + ',
        SUM(COLLECTION_AMOUNT) AS Total_Amount,
        1 AS RowOrder  -- RowOrder 1 for the total row
    FROM SLN_COLLECTION
    WHERE ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())
    AND IS_DELETED = 0
    )

    -- Final SELECT wrapping the result and hiding RowOrder
    SELECT CollectionDate,';

    -- Add the dynamic collection types to the final SELECT statement
    SET @cursor = CURSOR FOR
        SELECT DISTINCT COLLECTION_TYPE
        FROM SLN_COLLECTION
        WHERE IS_DELETED = 0
        AND ENTRY_DATE >= DATEADD(DAY, -7, GETDATE())
        AND COLLECTION_AMOUNT > 0;

    OPEN @cursor;
    FETCH NEXT FROM @cursor INTO @collection_types;

    -- Add the collection types to the final SELECT
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = @sql + '[' + @collection_types + '],';
        FETCH NEXT FROM @cursor INTO @collection_types;
    END;

    -- Close and deallocate the cursor
    CLOSE @cursor;
    DEALLOCATE @cursor;

    -- Remove the trailing comma from the last collection type
    SET @sql = LEFT(@sql, LEN(@sql) - 1);

    -- Add the final Total_Amount column and exclude RowOrder in the final SELECT
    SET @sql = @sql + ' Total_Amount
    FROM CTE_Collection
    ORDER BY RowOrder, CollectionDate DESC;';  -- Use RowOrder to ensure the total row is at the bottom

    -- Execute the dynamic SQL
    EXEC sp_executesql @sql;
END;
GO
