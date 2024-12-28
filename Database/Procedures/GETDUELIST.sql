/****** Object:  StoredProcedure [dbo].[GETDUELIST]    Script Date: 14-Dec-24  ******/ 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE IF EXISTS [dbo].[GETDUELIST];
GO

CREATE PROCEDURE [dbo].[GETDUELIST]
AS
BEGIN
    SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance

    ;WITH FeeData AS (
        SELECT     
            STUDENT_NAME,    
            CLASS,    
            ACADEMIC_YEAR,    
            SECTION,    
            FATHER_NAME,    
            SUM(PAID_AMOUNT) AS TOTAL_FEE_PAID     
        FROM     
            SLN_FEE     
        WHERE     
            FEE_TYPE IN('School Fee')  
        GROUP BY     
            STUDENT_NAME, CLASS, ACADEMIC_YEAR, SECTION, FATHER_NAME    
    )
    SELECT     
        A.FIRST_NAME,    
        A.CLASS,    
        A.ACADEMIC_YEAR,
        L.AMOUNT AS TOTAL_SCHOOL_FEE, 
		ISNULL(F.TOTAL_FEE_PAID, 0) AS FEE_PAID,
        (L.Amount - ISNULL(F.TOTAL_FEE_PAID, 0)) AS PENDING_AMOUNT,
        CASE     
            WHEN L.AMOUNT > 0 THEN     
                CAST(ISNULL(F.TOTAL_FEE_PAID, 0) * 100.0 / L.AMOUNT AS DECIMAL(5, 2))    
            ELSE     
                0.00    
        END AS FEE_PAID_PERCENTAGE, 
        A.MOBILE_NUM,    
        A.SECTION,    
        A.FATHER_NAME,    
        A.VILLAGE_NAME,     
        A.GENDER     
    FROM     
        SLN_ADMISIONS A     
    LEFT JOIN FeeData F ON A.FIRST_NAME = F.STUDENT_NAME     
        AND A.ACADEMIC_YEAR = F.ACADEMIC_YEAR     
        AND A.CLASS = F.CLASS     
        AND A.SECTION = F.SECTION     
        AND A.FATHER_NAME = F.FATHER_NAME    
    LEFT JOIN SLN_FEEAMOUNT_LKP L ON A.CLASS = L.CLASS     
        AND A.ACADEMIC_YEAR = L.ACADEMIC_YEAR     
        AND L.FEE_TYPE = 'School Fee' -- Adjust fee type if needed 
    ORDER BY 
        PENDING_AMOUNT DESC,  -- Outstanding due students first
        A.CLASS, 
        A.SECTION;
END;
GO
