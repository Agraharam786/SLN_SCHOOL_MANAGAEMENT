
IF OBJECT_ID('SLNSP_GETSECTIONDETAILS', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE SLNSP_GETSECTIONDETAILS;
END
GO

CREATE PROCEDURE SLNSP_GETSECTIONDETAILS	
	@CLASS Varchar(10)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
	

		SELECT DISTINCT SECTION
		FROM SLN_ADMISIONS
		where CLASS=@CLASS 

	
END;

GO


/*
exec SLNSP_GETSECTIONDETAILS 'UKG'
select distinct SECTION  from SLN_ADMISIONS


*/