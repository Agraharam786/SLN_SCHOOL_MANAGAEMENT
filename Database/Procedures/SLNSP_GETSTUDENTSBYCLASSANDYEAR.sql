/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTSBYCLASSANDYEAR]    Script Date: 28-Sep-24 11:59:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE IF EXISTS [dbo].[SLNSP_GETSTUDENTSBYCLASSANDYEAR];
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSTUDENTSBYCLASSANDYEAR]
    @CLASSNAME NVARCHAR(50),
    @ACADEMIC_YEAR VARCHAR(10) = '',
    @SECTION VARCHAR(20) = ''
AS
BEGIN
    SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance

    IF (@ACADEMIC_YEAR <> '' AND @CLASSNAME <> '')
    BEGIN
        ;WITH FeeData AS (
            SELECT 
                STUDENT_NAME,
                CLASS,
                ACADEMIC_YEAR,
                SECTION,
                FATHER_NAME,
                SUM(PAID_AMOUNT) AS FEE_PAID 
            FROM 
                SLN_FEE 
            WHERE 
                CLASS = @CLASSNAME 
                AND ACADEMIC_YEAR = @ACADEMIC_YEAR 
                AND SECTION = @SECTION
				AND FEE_TYPE IN('School Fee')  
            GROUP BY 
                STUDENT_NAME, CLASS, ACADEMIC_YEAR, SECTION, FATHER_NAME
        )
        SELECT 
            A.FIRST_NAME,
            A.CLASS,
            A.ACADEMIC_YEAR,            
            L.AMOUNT AS TOTAL_SCHOOL_FEE,
			F.FEE_PAID,
			case when IS_FREE_STUDENT = 1 then 0
			when IS_HALF_FEE = 1 then (ISNULL(L.AMOUNT, 0)) / 2 - (ISNULL(F.FEE_PAID, 0))
			else (ISNULL(L.AMOUNT, 0)) - (ISNULL(F.FEE_PAID, 0))
			end AS PENDING_AMOUNT,
            CASE 
                WHEN L.AMOUNT > 0 THEN 
                    CAST(ISNULL(F.FEE_PAID, 0) * 100.0 / L.AMOUNT AS DECIMAL(5, 2))
                ELSE 
                    0.00
            END AS FEE_PAID_PERCENTAGE,
			A.DISCOUNT_AMOUNT,
			case when A.IS_FEE_CLEAR = 1 then 'CLEAR' else 'Not Clear' end FEE_STATUS ,
			case when A.IS_FREE_STUDENT = 1 then 'NO FEE' else '' end FREE_STUDENT ,
			case when A.IS_HALF_FEE = 1 then 'HALF FEE' else '' end HALF_FEE ,        			
			A.MOBILE_NUM   ,
			A.SECTION ,
			A.FATHER_NAME ,
			A.VILLAGE_NAME ,	
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
        WHERE 
            A.CLASS = @CLASSNAME 
            AND A.ACADEMIC_YEAR = @ACADEMIC_YEAR 
            AND A.SECTION = @SECTION
			ORDER BY F.FEE_PAID
    END
    ELSE 
    BEGIN 
        SELECT TOP 0 
            FIRST_NAME,
            CLASS,
            ACADEMIC_YEAR,            
            0 AS TOTAL_SCHOOL_FEE,
			0 AS FEE_PAID,
			0 AS PENDING_AMOUNT,
            0 AS PERCENTAGE_PAID,
            'No Data' AS FEE_PAID_PERCENTAGE,
			MOBILE_NUM   ,
			SECTION ,
			FATHER_NAME ,
			VILLAGE_NAME ,	
			GENDER 
        FROM 
            SLN_ADMISIONS
    END
END;
GO


/*

	exec [SLNSP_GETSTUDENTSBYCLASSANDYEAR] 'Jr Inter','2024-2025','MPC'
	
	exec [SLNSP_GETSTUDENTSBYCLASSANDYEAR] 'Jr Inter','2024-2025','BiPC'
	
	exec [SLNSP_GETSTUDENTSBYCLASSANDYEAR] 'Jr Inter','2024-2025','CEC'
	exec [SLNSP_GETSTUDENTSBYCLASSANDYEAR] 'LKG','2024-2025','A'

*/