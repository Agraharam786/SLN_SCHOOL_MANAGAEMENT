/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATECOLLECTION]    Script Date: 28-Sep-24 11:59:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 DROP PROCEDURE IF EXISTS [SLNSP_INSERTORUPDATECOLLECTION];
 GO

CREATE PROCEDURE [dbo].[SLNSP_INSERTORUPDATECOLLECTION]
	@CollectionId INT =0,
    @CollectionType VARCHAR(255),
    @Description VARCHAR(255),
    @CollectionAmount INT,
	@BankDepositAmount INT,
	@InCash INT,
    @EntryDate DATETIME,
    @IsDeleted BIT,
    @CorrectedAmount INT
AS
BEGIN
    --SET NOCOUNT ON;
	IF @CollectionId>0
		BEGIN
		UPDATE SLN_COLLECTION
				SET [DESCRIPTION] = @Description,
					COLLECTION_TYPE =@CollectionType,
					COLLECTION_AMOUNT = @CollectionAmount,
					BANK_DEPOSITED_AMOUNT=@BankDepositAmount,
					IN_CASH=@InCash,
					ENTRY_DATE = @EntryDate,
					IS_DELETED = @IsDeleted,
					CORRECTED_AMOUNT = @CorrectedAmount,
					LST_UPDATED_TMSP=GetDATE(),
					LST_UPATED_ID='Admin'
		  WHERE COLLECTION_ID = @CollectionId
			END
	ELSE
		BEGIN
			 INSERT INTO SLN_COLLECTION (COLLECTION_TYPE, DESCRIPTION, COLLECTION_AMOUNT,BANK_DEPOSITED_AMOUNT,IN_CASH, ENTRY_DATE, IS_DELETED, CORRECTED_AMOUNT,LST_UPDATED_TMSP,LST_UPATED_ID)
			VALUES (@CollectionType, @Description, @CollectionAmount,@BankDepositAmount,@InCash, @EntryDate, @IsDeleted, @CorrectedAmount,GetDATE(),'Admin')
		
		END

END

/*
INSERT INTO SLN_COLLECTION (COLLECTION_TYPE, DESCRIPTION, COLLECTION_AMOUNT,BANK_DEPOSITED_AMOUNT,IN_CASH, ENTRY_DATE, IS_DELETED, CORRECTED_AMOUNT)
        VALUES ('Primary', 'Daily Collection send 10000 to bank and remaining in cash', 20000,10000,10000, getdate(), 0, 0)

		select * from SLN_COLLECTION
		*/
GO