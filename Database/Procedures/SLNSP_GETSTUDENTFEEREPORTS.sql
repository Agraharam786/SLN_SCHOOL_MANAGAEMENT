
IF OBJECT_ID('SLNSP_GETSTUDENTFEEREPORTS', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE SLNSP_GETSTUDENTFEEREPORTS;
END
GO

CREATE PROCEDURE SLNSP_GETSTUDENTFEEREPORTS	
	@CLASS Varchar(10),
	@ACADEMIC_YEAR Varchar(10),
	@SECTION  Varchar(10),
	@STUDENT_NAME Varchar(50)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT  FEE_ID
				,FEE_TYPE
				,STUDENT_NAME
				,FATHER_NAME
				,GENDER
				,CLASS
				,SECTION
				,BILL_NUMBER
				,PAID_AMOUNT
				,[DESCRIPTION]
				,ACADEMIC_YEAR				
				,PAID_DATE	
				,VILLAGE_NAME
				,ADMISSION_ID
		FROM SLN_FEE
		where  STUDENT_NAME =@STUDENT_NAME 
		AND CLASS=@CLASS and ACADEMIC_YEAR= @ACADEMIC_YEAR
		AND SECTION=@SECTION
		AND  IS_DELETED=0
		order by FEE_ID Desc
	
END;

GO


/*
exec SLNSP_GETSTUDENTFEEREPORTS '1','2024-2025','A','VICTOR .C.V'

select * from SLN_FEE
where STUDENT_NAME = 'VICTOR .C.V'
		AND CLASS='1' and ACADEMIC_YEAR= '2024-2025'
		AND SECTION='A'
		AND  IS_DELETED=0
		order by FEE_ID Desc
	

*/