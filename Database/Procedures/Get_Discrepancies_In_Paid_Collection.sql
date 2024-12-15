-- Drop the procedure if it already exists
IF OBJECT_ID('Get_Discrepancies_In_Paid_Collection', 'P') IS NOT NULL
    DROP PROCEDURE Get_Discrepancies_In_Paid_Collection;
GO

-- Create the procedure
CREATE PROCEDURE Get_Discrepancies_In_Paid_Collection
AS
BEGIN
    ;WITH FeeDetails AS (
        SELECT SUM(PAID_AMOUNT) AS PAID_AMOUNT, PAID_DATE
        FROM SLN_FEE
		where IS_DELETED=0
        GROUP BY PAID_DATE
    ),
    Collection_Details AS (
        SELECT SUM(COLLECTION_AMOUNT) AS COLLECTION_AMOUNT, ENTRY_DATE  
        FROM SLN_COLLECTION
		where IS_DELETED=0
        GROUP BY ENTRY_DATE
    )
    SELECT 
        COALESCE(F.PAID_DATE, C.ENTRY_DATE) AS DATE,
        COALESCE(F.PAID_AMOUNT, 0) AS PAID_AMOUNT,
        COALESCE(C.COLLECTION_AMOUNT, 0) AS COLLECTION_AMOUNT,
        COALESCE(F.PAID_AMOUNT, 0) - COALESCE(C.COLLECTION_AMOUNT, 0) AS DIFFERENCE_AMOUNT
    FROM 
        FeeDetails F
    FULL OUTER JOIN 
        Collection_Details C 
        ON F.PAID_DATE = C.ENTRY_DATE
    WHERE 
        COALESCE(F.PAID_AMOUNT, 0) <> COALESCE(C.COLLECTION_AMOUNT, 0)
    ORDER BY 
        DATE DESC;
END;
GO
