SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetMonthlyTransactionSummaryForBank
GO
CREATE PROCEDURE GetMonthlyTransactionSummaryForBank
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @columns NVARCHAR(MAX);

    -- Dynamically create the list of months
    SET @columns = '';
    SELECT @columns = STRING_AGG(QUOTENAME(Month), ',') 
    FROM (
        SELECT DISTINCT 
            UPPER(LEFT(DATENAME(MONTH, DATEFROMPARTS(YEAR(TRANSACTION_DATE), MONTH(TRANSACTION_DATE), 1)), 3)) + ' ' + CAST(YEAR(TRANSACTION_DATE) AS NVARCHAR) AS Month
        FROM SLN_BANK_TRANSACTIONS
        WHERE TRANSACTION_DATE >= DATEADD(MONTH, -12, GETDATE())
		AND IS_DELETED =0
    ) AS Months;

    -- Construct dynamic SQL for the pivot
    SET @sql = N'
    WITH CTE_TransactionSummary AS (
        -- Summarize data for each month in the past 12 months
        SELECT 
            UPPER(LEFT(DATENAME(MONTH, DATEFROMPARTS(YEAR(TRANSACTION_DATE), MONTH(TRANSACTION_DATE), 1)), 3)) + '' '' + CAST(YEAR(TRANSACTION_DATE) AS NVARCHAR) AS Month,
            TRANSACTION_FROM,
            TRANSACTION_TO,
            SUM(TRANSACTION_AMOUNT) AS Total_Amount,
            YEAR(TRANSACTION_DATE) AS Year,
            MONTH(TRANSACTION_DATE) AS MonthNum
        FROM SLN_BANK_TRANSACTIONS
        WHERE TRANSACTION_DATE >= DATEADD(MONTH, -12, GETDATE())  -- Limit to the last 12 months
		AND IS_DELETED =0
        GROUP BY YEAR(TRANSACTION_DATE), MONTH(TRANSACTION_DATE), TRANSACTION_FROM, TRANSACTION_TO

        UNION ALL

        -- Create the total row summing all data for the past 12 months
        SELECT 
            ''Total'' AS Month,
            ''Total'' AS TRANSACTION_FROM,
            ''Total'' AS TRANSACTION_TO,
            SUM(TRANSACTION_AMOUNT) AS Total_Amount,
            NULL AS Year,
            NULL AS MonthNum
        FROM SLN_BANK_TRANSACTIONS
        WHERE TRANSACTION_DATE >= DATEADD(MONTH, -12, GETDATE())
		AND IS_DELETED =0
    )
    -- Final SELECT to output the CTE results with PIVOT
    SELECT TRANSACTION_FROM, TRANSACTION_TO, ' + @columns + N'
    FROM 
    (
        SELECT 
            CASE 
                WHEN Month = ''Total'' THEN ''Total'' 
                ELSE TRANSACTION_FROM 
            END AS TRANSACTION_FROM,
            CASE 
                WHEN Month = ''Total'' THEN ''Total'' 
                ELSE TRANSACTION_TO 
            END AS TRANSACTION_TO,
            Month, 
            Total_Amount
        FROM CTE_TransactionSummary
    ) AS SourceTable
    PIVOT 
    (
        SUM(Total_Amount)
        FOR Month IN (' + @columns + N')
    ) AS PivotTable
    ORDER BY 
        CASE WHEN TRANSACTION_FROM = ''Total'' THEN 1 ELSE 0 END,  -- Ensure the Total row comes last
        TRANSACTION_FROM, 
        TRANSACTION_TO;
    ';

    -- Debugging: Print the generated SQL (optional)
    PRINT @sql;

    -- Execute the dynamic SQL
    EXEC sp_executesql @sql;
END;
GO
