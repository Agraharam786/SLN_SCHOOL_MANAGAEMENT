SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GET_YearlyFinancialSummary
GO
CREATE PROCEDURE GET_YearlyFinancialSummary
AS
BEGIN
    ;WITH FinancialDetails AS (
        SELECT
            (SELECT SUM(PAID_AMOUNT) FROM SLN_FEE WHERE IS_DELETED = 0) AS FEECOLLECTEDAMOUNT,
            (SELECT SUM(COLLECTION_AMOUNT) FROM SLN_COLLECTION WHERE IS_DELETED = 0) AS COLLECTIONAMOUNT,
            (SELECT SUM(EXPENSE_AMOUNT) FROM SLN_EXPENSE WHERE IS_DELETED = 0) AS EXPENSEAMOUNT
    )
    SELECT 
        -- Fee Collected Amount (formatted)
        REVERSE(STUFF(STUFF(REVERSE(CONVERT(VARCHAR, FEECOLLECTEDAMOUNT)), 4, 0, ','), 7, 0, ',')) AS FEE_COLLECTED_AMOUNT,
        
        -- Collection Amount (formatted)
        REVERSE(STUFF(STUFF(REVERSE(CONVERT(VARCHAR, COLLECTIONAMOUNT)), 4, 0, ','), 7, 0, ',')) AS COLLECTION_AMOUNT,

        -- Expense Amount (formatted)
        REVERSE(STUFF(STUFF(REVERSE(CONVERT(VARCHAR, EXPENSEAMOUNT)), 4, 0, ','), 7, 0, ',')) AS EXPENSE_AMOUNT,

        -- Fee Collected vs Collection
        REVERSE(STUFF(STUFF(REVERSE(CONVERT(VARCHAR, FEECOLLECTEDAMOUNT - COLLECTIONAMOUNT)), 4, 0, ','), 7, 0, ',')) AS [FEE_PAID Vs COLLECTION],

        -- Collection vs Expense
        REVERSE(STUFF(STUFF(REVERSE(CONVERT(VARCHAR, COLLECTIONAMOUNT - EXPENSEAMOUNT)), 4, 0, ','), 7, 0, ',')) AS [COLLECTION Vs EXPENSE]
    FROM 
        FinancialDetails;
END;
GO
