SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetYearlyExpenseSummary
GO
CREATE PROCEDURE GetYearlyExpenseSummary
AS
BEGIN
    -- Common Table Expression for detail and total rows
    WITH CTE AS (
        -- Actual expense records grouped
        SELECT 
            ISNULL(EXPENSE_FROM, '') AS EXPENSE_FROM,
            EXPENSE_TYPE,
            SUM(EXPENSE_AMOUNT) AS EXPENSE_AMOUNT
        FROM SLN_EXPENSE
        WHERE IS_DELETED = 0
        GROUP BY EXPENSE_FROM, EXPENSE_TYPE

        UNION ALL

        -- Total row (uses NULLs to avoid confusion in grouping)
        SELECT 
            'Total' AS EXPENSE_FROM,
            NULL AS EXPENSE_TYPE,
            SUM(EXPENSE_AMOUNT) AS EXPENSE_AMOUNT
        FROM SLN_EXPENSE
        WHERE IS_DELETED = 0
    )

    -- Final result ordered with Total at the end
    SELECT *
    FROM CTE
    ORDER BY EXPENSE_FROM,
        CASE WHEN EXPENSE_FROM = 'Total' THEN 1 ELSE 0 END,
        EXPENSE_AMOUNT;
END;
GO
