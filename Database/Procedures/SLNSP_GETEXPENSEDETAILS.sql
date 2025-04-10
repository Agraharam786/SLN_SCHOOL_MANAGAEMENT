IF OBJECT_ID('SLNSP_GETEXPENSEDETAILS', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE IF EXISTS SLNSP_GETEXPENSEDETAILS;
END
GO
CREATE PROCEDURE SLNSP_GETEXPENSEDETAILS
	@FETCHALL BIT =0
    
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN
	IF @FETCHALL =0
		Select TOP 15 EXPENSE_ID,
					  EXPENSE_FROM,
					  EXPENSE_TYPE,
					  [DESCRIPTION],
					  EXPENSE_AMOUNT,
					  ENTRY_DATE
		FROM SLN_EXPENSE
		WHERE IS_DELETED=0
		ORDER BY ENTRY_DATE DESC
	ELSE
		Select  EXPENSE_ID,
					  EXPENSE_FROM,
					  EXPENSE_TYPE,
					  [DESCRIPTION],
					  EXPENSE_AMOUNT,
					  ENTRY_DATE
		FROM SLN_EXPENSE
		WHERE IS_DELETED=0
		ORDER BY ENTRY_DATE DESC
	 
	END   

END

/*
exec SLNSP_GETEXPENSEDETAILS 0
exec SLNSP_GETEXPENSEDETAILS 1
*/
