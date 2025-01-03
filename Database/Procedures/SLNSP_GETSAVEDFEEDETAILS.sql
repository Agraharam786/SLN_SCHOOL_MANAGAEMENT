 
 
 /****** Object:  StoredProcedure [dbo].[SLNSP_GETSAVEDFEEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('SLNSP_GETSAVEDFEEDETAILS', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE SLNSP_GETSAVEDFEEDETAILS;
END
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSAVEDFEEDETAILS]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		  SELECT   FEE_ID  
				,FEE_TYPE  
				,STUDENT_NAME  
				,FATHER_NAME 
				,PAID_DATE 
				,PAID_AMOUNT  
				,BILL_NUMBER 
				,[DESCRIPTION]  
				,CLASS  
				,SECTION
				,ACADEMIC_YEAR 
				,VILLAGE_NAME  
				,ADMISSION_ID  
			  FROM SLN_FEE  
			  Where IS_DELETED=0  
			  ORDER BY PAID_DATE DESC 
	
END;

GO
