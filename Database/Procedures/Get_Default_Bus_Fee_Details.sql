-- Drop the procedure if it already exists
IF OBJECT_ID('Get_Default_Bus_Fee_Details', 'P') IS NOT NULL
    DROP PROCEDURE Get_Default_Bus_Fee_Details;
GO

-- Create the procedure with optional filtering parameters
CREATE PROCEDURE Get_Default_Bus_Fee_Details   
AS
BEGIN
    BEGIN TRY
        ;WITH ADMISION_DETAILS AS (
            SELECT top 0
                ADMISION_ID, FIRST_NAME, CLASS, SECTION, ACADEMIC_YEAR, MOBILE_NUM, GENDER, FATHER_NAME,VILLAGE_NAME
            FROM 
                SLN_ADMISIONS
        ),
        FEE_DETAILS AS (
            SELECT top 0
                ADMISSION_ID, SUM(PAID_AMOUNT) AS BUS_FEE_PAID_AMOUNT
            FROM 
                SLN_FEE 
            WHERE 
                FEE_TYPE = 'Bus Fee' 
                AND IS_DELETED = 0
            GROUP BY 
                ADMISSION_ID
        )
        SELECT 
            A.FIRST_NAME,
            A.CLASS,
            A.SECTION,
            A.ACADEMIC_YEAR,
            COALESCE(F.BUS_FEE_PAID_AMOUNT, 0) AS BUS_FEE_PAID_AMOUNT,
			A.VILLAGE_NAME,
            A.MOBILE_NUM,
            A.GENDER,
            A.FATHER_NAME
        FROM 
            ADMISION_DETAILS A
        LEFT JOIN 
            FEE_DETAILS F 
            ON A.ADMISION_ID = F.ADMISSION_ID
        ORDER BY 
            A.CLASS , A.SECTION, F.BUS_FEE_PAID_AMOUNT,VILLAGE_NAME;
    END TRY
    BEGIN CATCH
        -- Error handling
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END;
GO

/*


	Get_Bus_Fee_Details 'UKG','A','2024-2025'
	Get_Bus_Fee_Details '1','A','2024-2025'
	Get_Bus_Fee_Details '5','A','2024-2025'
*/