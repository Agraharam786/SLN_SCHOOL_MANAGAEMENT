/****** Object:  StoredProcedure [dbo].[SLNSP_GETEMAIL_FIANACIALSUMMARY]    Script Date: 28-Sep-24 10:56:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS [SLNSP_GETEMAIL_FIANACIALSUMMARY]
GO

CREATE PROCEDURE [dbo].[SLNSP_GETEMAIL_FIANACIALSUMMARY]
AS
BEGIN
    SET NOCOUNT ON;

    -- Common Table Expression (CTE) for the collections, expenses, and fees
    WITH CollectionData AS (
        -- Today's Collection
        SELECT 1 AS PeriodOrder, 'Today' AS Period, ISNULL(SUM(c.COLLECTION_AMOUNT), 0) AS Collected_Amount, 0 AS Expense_Amount, 0 AS Fee_Amount
        FROM SLN_COLLECTION c
        WHERE c.IS_DELETED = 0 AND c.ENTRY_DATE = CAST(GETDATE() AS DATE)

        UNION ALL

        -- Today's Expense
        SELECT 1 AS PeriodOrder, 'Today' AS Period, 0 AS Collected_Amount, ISNULL(SUM(e.EXPENSE_AMOUNT), 0) AS Expense_Amount, 0 AS Fee_Amount
        FROM SLN_EXPENSE e
        WHERE e.IS_DELETED = 0 AND e.ENTRY_DATE = CAST(GETDATE() AS DATE)

        UNION ALL

        -- Today's Fee
        SELECT 1 AS PeriodOrder, 'Today' AS Period, 0 AS Collected_Amount, 0 AS Expense_Amount, ISNULL(SUM(f.PAID_AMOUNT), 0) AS Fee_Amount
        FROM SLN_FEE f
        WHERE f.IS_DELETED = 0 AND f.PAID_DATE = CAST(GETDATE() AS DATE)

        UNION ALL

        -- This Week's Collection
        SELECT 2 AS PeriodOrder, 'This Week' AS Period, ISNULL(SUM(c.COLLECTION_AMOUNT), 0) AS Collected_Amount, 0 AS Expense_Amount, 0 AS Fee_Amount
        FROM SLN_COLLECTION c
        WHERE c.IS_DELETED = 0 AND c.ENTRY_DATE BETWEEN DATEADD(DAY, 1 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE)) AND GETDATE()

        UNION ALL

        -- This Week's Expense
        SELECT 2 AS PeriodOrder, 'This Week' AS Period, 0 AS Collected_Amount, ISNULL(SUM(e.EXPENSE_AMOUNT), 0) AS Expense_Amount, 0 AS Fee_Amount
        FROM SLN_EXPENSE e
        WHERE e.IS_DELETED = 0 AND e.ENTRY_DATE BETWEEN DATEADD(DAY, 1 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE)) AND GETDATE()

        UNION ALL

        -- This Week's Fee
        SELECT 2 AS PeriodOrder, 'This Week' AS Period, 0 AS Collected_Amount, 0 AS Expense_Amount, ISNULL(SUM(f.PAID_AMOUNT), 0) AS Fee_Amount
        FROM SLN_FEE f
        WHERE f.IS_DELETED = 0 AND f.PAID_DATE BETWEEN DATEADD(DAY, 1 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE)) AND GETDATE()

        UNION ALL

        -- This Month's Collection
        SELECT 3 AS PeriodOrder, 'This Month' AS Period, ISNULL(SUM(c.COLLECTION_AMOUNT), 0) AS Collected_Amount, 0 AS Expense_Amount, 0 AS Fee_Amount
        FROM SLN_COLLECTION c
        WHERE c.IS_DELETED = 0 AND c.ENTRY_DATE BETWEEN CAST(DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AS DATE) AND GETDATE()

        UNION ALL

        -- This Month's Expense
        SELECT 3 AS PeriodOrder, 'This Month' AS Period, 0 AS Collected_Amount, ISNULL(SUM(e.EXPENSE_AMOUNT), 0) AS Expense_Amount, 0 AS Fee_Amount
        FROM SLN_EXPENSE e
        WHERE e.IS_DELETED = 0 AND e.ENTRY_DATE BETWEEN CAST(DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AS DATE) AND GETDATE()

        UNION ALL

        -- This Month's Fee
        SELECT 3 AS PeriodOrder, 'This Month' AS Period, 0 AS Collected_Amount, 0 AS Expense_Amount, ISNULL(SUM(f.PAID_AMOUNT), 0) AS Fee_Amount
        FROM SLN_FEE f
        WHERE f.IS_DELETED = 0 AND f.PAID_DATE BETWEEN CAST(DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0) AS DATE) AND GETDATE()

        UNION ALL

        -- This Year's Collection
        SELECT 4 AS PeriodOrder, 'This Year' AS Period, ISNULL(SUM(c.COLLECTION_AMOUNT), 0) AS Collected_Amount, 0 AS Expense_Amount, 0 AS Fee_Amount
        FROM SLN_COLLECTION c
        WHERE c.IS_DELETED = 0 AND c.ENTRY_DATE BETWEEN CAST(DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0) AS DATE) AND GETDATE()

        UNION ALL

        -- This Year's Expense
        SELECT 4 AS PeriodOrder, 'This Year' AS Period, 0 AS Collected_Amount, ISNULL(SUM(e.EXPENSE_AMOUNT), 0) AS Expense_Amount, 0 AS Fee_Amount
        FROM SLN_EXPENSE e
        WHERE e.IS_DELETED = 0 AND e.ENTRY_DATE BETWEEN CAST(DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0) AS DATE) AND GETDATE()

        UNION ALL

        -- This Year's Fee
        SELECT 4 AS PeriodOrder, 'This Year' AS Period, 0 AS Collected_Amount, 0 AS Expense_Amount, ISNULL(SUM(f.PAID_AMOUNT), 0) AS Fee_Amount
        FROM SLN_FEE f
        WHERE f.IS_DELETED = 0 AND f.PAID_DATE BETWEEN CAST(DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0) AS DATE) AND GETDATE()
    )

    -- Summarizing results and ordering by chronological order
    SELECT Period AS TimePeriod, 
           SUM(Collected_Amount) AS CollectionAmount, 
           SUM(Expense_Amount) AS ExpenseAmount, 
           SUM(Fee_Amount) AS FeeAmount,
           SUM(Collected_Amount) - SUM(Expense_Amount) AS OutStandingAmount
    FROM CollectionData
    GROUP BY Period, PeriodOrder
    ORDER BY PeriodOrder;

END;
