
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEREPORT]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE [dbo].[SLNSP_GETEXPENSEREPORT]

GO

CREATE PROCEDURE [dbo].[SLNSP_GETEXPENSEREPORT]			
			@EXPENSE_TYPE Varchar(50) =NULL,	
			@FROM_DATE Date,
			@TO_DATE Date	
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 	
	IF(@EXPENSE_TYPE <>'ALL')
		BEGIN
			SELECT 
					EXPENSE_TYPE,				
					SUM(EXPENSE_AMOUNT) EXPENSE_AMOUNT
				
			FROM SLN_EXPENSE
			where EXPENSE_TYPE = @EXPENSE_TYPE  AND 
			ENTRY_DATE BETWEEN @FROM_DATE AND @TO_DATE
			AND IS_DELETED = 0
			GROUP BY
			EXPENSE_TYPE		
			order by EXPENSE_TYPE 
		END
	ELSE
		BEGIN
				SELECT 
					EXPENSE_TYPE,				
					SUM(EXPENSE_AMOUNT) EXPENSE_AMOUNT				
			FROM SLN_EXPENSE	
			WHERE
			ENTRY_DATE BETWEEN @FROM_DATE AND @TO_DATE
			AND IS_DELETED = 0
			GROUP BY
			EXPENSE_TYPE		
			order by EXPENSE_TYPE 
		END
	
END;

GO

/*

	exec [SLNSP_GETEXPENSEREPORT] 'ALL','2024-08-01','2024-09-01'
	exec [SLNSP_GETEXPENSEREPORT] 'Bus Maintanance','2024-08-01','2024-09-01'
	
*/