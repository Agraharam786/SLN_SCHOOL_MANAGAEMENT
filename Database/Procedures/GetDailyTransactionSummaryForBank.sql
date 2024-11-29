SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetDailyTransactionSummaryForBank
GO
CREATE PROCEDURE GetDailyTransactionSummaryForBank
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);

    -- Construct dynamic SQL to fetch transaction data for the current day
    SET @sql = N'
    WITH CTE_TransactionSummary AS (
        -- Summarize data for the current day, grouped by TRANSACTION_FROM, TRANSACTION_TO
        SELECT 
            CAST(TRANSACTION_DATE AS DATE) AS TransactionDate,
            TRANSACTION_FROM,
            TRANSACTION_TO,
            SUM(TRANSACTION_AMOUNT) AS Total_Amount
        FROM SLN_BANK_TRANSACTIONS
        WHERE TRANSACTION_DATE = CAST(GETDATE() AS DATE)  -- Use GETDATE() to filter by the current date
        AND IS_DELETED = 0
        GROUP BY CAST(TRANSACTION_DATE AS DATE), TRANSACTION_FROM, TRANSACTION_TO
    )
    -- Final SELECT to output the transaction data for the current day
    SELECT 
        FORMAT(TransactionDate, ''dd-MMM-yyyy'') AS Date,  -- Format the date as dd-MMM-yyyy
        TRANSACTION_FROM,
        TRANSACTION_TO,
        Total_Amount
    FROM CTE_TransactionSummary
    ORDER BY TRANSACTION_FROM, TRANSACTION_TO;
    ';

    -- Debugging: Print the generated SQL (optional)
    PRINT @sql;

    -- Execute the dynamic SQL
    EXEC sp_executesql @sql;
END;
GO
