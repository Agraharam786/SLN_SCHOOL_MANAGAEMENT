
--select * from SLN_BANK_TRANSACTIONS

DROP TABLE IF EXISTS SLN_BANK_TRANSACTIONS
CREATE TABLE dbo.SLN_BANK_TRANSACTIONS
(
    TRANSACTION_ID INT IDENTITY(1, 1) NOT NULL ,
	TRANSACTION_FROM VARCHAR(50) NOT NULL,
	TRANSACTION_TO VARCHAR(50) NOT NULL,	
	TRANSACTION_AMOUNT INT  NOT NULL,
	TRANSACTION_DATE DATETIME,
	[DESCRIPTION] VARCHAR(MAX),
	DEPOSITED_BY VARCHAR(50) NOT NULL,
	IS_DELETED BIT,
	LST_UPDATED_TMSP DATETIME,
	LST_UPATED_ID VARCHAR(50),
	CONSTRAINT PK_SLN_BANK_TRANSACTIONS PRIMARY KEY (TRANSACTION_ID)
);