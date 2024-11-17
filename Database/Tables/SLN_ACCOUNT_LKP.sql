DROP TABLE IF EXISTS dbo.SLN_ACCOUNT_LKP;
GO

-- Recreate the table
CREATE TABLE dbo.SLN_ACCOUNT_LKP
(
    ACCOUNT_ID INT IDENTITY(1, 1) NOT NULL, -- Auto-incrementing primary key
    ACCOUNT_NUMBER VARCHAR(50),                   
    BANK_NAME VARCHAR(50),                        
    ACCOUNT_USING_FOR VARCHAR(50),
	HAS_NET_BANKING BIT,
	HAS_CHECK_BOOK BIT,
    [DESCRIPTION] VARCHAR(MAX),               
    LST_UPDATED_TMSP DATETIME,                -- Last updated timestamp
    LST_UPDATED_ID VARCHAR(50)                -- ID of the user who last updated
);
GO