
IF OBJECT_ID('SLNSP_GETDISTINCTACADEMICYEARS', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE SLNSP_GETDISTINCTACADEMICYEARS;
END
GO

CREATE PROCEDURE SLNSP_GETDISTINCTACADEMICYEARS
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
	
			SELECT ACADEMIC_YEAR
		FROM (
			SELECT 'Select Year' AS ACADEMIC_YEAR, 0 AS SortOrder
			UNION ALL
			SELECT DISTINCT ACADEMIC_YEAR, 1 AS SortOrder
			FROM SLN_ADMISIONS
		) AS YearData
		ORDER BY SortOrder, ACADEMIC_YEAR DESC

	
END;

GO


/*
exec SLNSP_GETDISTINCTACADEMICYEARS 

*/