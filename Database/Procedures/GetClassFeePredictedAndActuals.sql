SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE IF EXISTS GetClassFeePredictedAndActuals
GO
CREATE PROCEDURE GetClassFeePredictedAndActuals
    @CLASSNAME NVARCHAR(50) = NULL,         -- Class filter (optional)
    @Academic_Year VARCHAR(10) = NULL,  -- Academic Year filter (optional)
    @Section NVARCHAR(50) = NULL        -- Section filter (optional)
AS
BEGIN
    -- Common Table Expression to calculate the strength from SLN_ADMISSION table
    ;WITH AdmissionData AS (
        SELECT 
            A.CLASS,
            A.ACADEMIC_YEAR,
            A.SECTION,
            COUNT(*) AS STRENGTH  -- Count of students from SLN_ADMISSION
        FROM 
            SLN_ADMISIONS A
        WHERE 
            -- Apply filters
             (@CLASSNAME IS NULL OR A.CLASS = @CLASSNAME)
            AND (@Academic_Year IS NULL OR A.ACADEMIC_YEAR = @Academic_Year)
            AND (@Section IS NULL OR A.SECTION = @Section)
        GROUP BY 
            A.CLASS,
            A.ACADEMIC_YEAR,
            A.SECTION
    ),
    FeeData AS (
        SELECT                 
            F.CLASS,
            F.ACADEMIC_YEAR,
            F.SECTION,
            L.AMOUNT AS CLASS_FEE_AMOUNT,
            SUM(F.PAID_AMOUNT) AS TOTAL_FEE_PAID
        FROM 
            SLN_FEE F
        LEFT JOIN SLN_FEEAMOUNT_LKP L 
            ON F.CLASS = L.CLASS 
            AND F.ACADEMIC_YEAR = L.ACADEMIC_YEAR
        WHERE 
            F.IS_DELETED = 0
            AND F.FEE_TYPE = 'School Fee'
            -- Apply filters
            AND (@CLASSNAME IS NULL OR F.CLASS = @CLASSNAME)
            AND (@Academic_Year IS NULL OR F.ACADEMIC_YEAR = @Academic_Year)
            AND (@Section IS NULL OR F.SECTION = @Section)
        GROUP BY 
            F.CLASS,
            F.ACADEMIC_YEAR,
            F.SECTION,
            L.AMOUNT
    ),
    result AS (
        SELECT 
            A.CLASS,
            A.ACADEMIC_YEAR,
            A.SECTION,
            A.CLASS_FEE_AMOUNT * B.STRENGTH AS PREDICTED_AMOUNT, -- Use the student count from SLN_ADMISSION
            A.TOTAL_FEE_PAID,
            B.STRENGTH
        FROM FeeData A
        JOIN AdmissionData B 
            ON A.CLASS = B.CLASS 
            AND A.ACADEMIC_YEAR = B.ACADEMIC_YEAR
            AND A.SECTION = B.SECTION
    ),
    FinalResult AS (
        SELECT 
            CLASS,
            ACADEMIC_YEAR,
            SECTION,
            PREDICTED_AMOUNT,
            TOTAL_FEE_PAID,
            CAST(ISNULL(TOTAL_FEE_PAID, 0) * 100.0 / PREDICTED_AMOUNT AS DECIMAL(5, 2)) AS FEE_PAID_PERCENTAGE,
            STRENGTH  -- Include student count in final output
        FROM result
    )
    SELECT PREDICTED_AMOUNT,
           TOTAL_FEE_PAID, 
		   FEE_PAID_PERCENTAGE AS [% PAID],
		   STRENGTH FROM FinalResult order by CLASS, SECTION;
END;
GO
