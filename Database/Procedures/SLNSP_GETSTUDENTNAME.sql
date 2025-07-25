
IF OBJECT_ID('SLNSP_GETSTUDENTNAME', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE SLNSP_GETSTUDENTNAME;
END
GO

CREATE PROCEDURE SLNSP_GETSTUDENTNAME
	--@STUDENT_NAME Varchar(50), Commented to load entire student data while loading
	@CLASS Varchar(10),
	@SECTION Varchar(10),
	@ACADEMIC_YEAR varchar(10) ='2025-2026'
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
	/*	WITH CTE AS (SELECT FIRST_NAME, CLASS
		FROM SLN_ADMISIONS
		where FIRST_NAME like '%' +@STUDENT_NAME + '%' )
		SELECT A.FIRST_NAME
		FROM SLN_ADMISIONS A
		JOIN CTE ON A.FIRST_NAME = CTE.FIRST_NAME  AND A.CLASS= @CLASS;
		*/

		SELECT FIRST_NAME
		FROM SLN_ADMISIONS
		where CLASS=@CLASS AND SECTION =@SECTION
		AND ACADEMIC_YEAR ='2025-2026'

	
END;

GO


/*
exec SLNSP_GETSTUDENTNAME 'UKG','A'
exec SLNSP_GETSTUDENTNAME 'Jr Inter','MPC'
select * from SLN_ADMISIONS

SELECT *
		FROM SLN_ADMISIONS
		where CLASS='UKG'

			WITH CTE AS (SELECT FIRST_NAME, CLASS
		FROM SLN_ADMISIONS
		where FIRST_NAME like '%SAI%' )
		SELECT A.FIRST_NAME
		FROM SLN_ADMISIONS A
		JOIN CTE ON A.FIRST_NAME = CTE.FIRST_NAME  AND A.CLASS= 'LKG';

*/