IF OBJECT_ID('SLNSP_DeleteBankTransactionDetails', 'P') IS NOT NULL
BEGIN
    DROP PROCEDURE SLNSP_DeleteBankTransactionDetails;
END
GO
CREATE PROCEDURE SLNSP_DeleteBankTransactionDetails
					  @TRANSACTION_ID INT =0 
AS
	BEGIN

	UPDATE SLN_BANK_TRANSACTIONS
	SET IS_DELETED=1,
	LST_UPDATED_TMSP=GetDATE()
	WHERE TRANSACTION_ID=@TRANSACTION_ID

	END
/*
	exec SLNSP_DeleteBankTransactionDetails 2
	select * from SLN_BANK_TRANSACTIONS
*/