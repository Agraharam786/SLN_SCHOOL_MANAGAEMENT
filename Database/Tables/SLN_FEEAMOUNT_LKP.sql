DROP TABLE IF EXISTS dbo.SLN_FEEAMOUNT_LKP;
GO

-- Recreate the table
CREATE TABLE dbo.SLN_FEEAMOUNT_LKP
(
    FEEAMOUNT_ID INT IDENTITY(1, 1) NOT NULL, -- Auto-incrementing primary key
    FEE_TYPE VARCHAR(50),                    -- Type of fee (e.g., Tuition, Lab)
    CLASS VARCHAR(50),                        -- Class associated with the fee
    ACADEMIC_YEAR VARCHAR(50),                -- Academic year for the fee
	AMOUNT INT,
    [DESCRIPTION] VARCHAR(MAX),               -- Detailed description of the fee
    LST_UPDATED_TMSP DATETIME,                -- Last updated timestamp
    LST_UPDATED_ID VARCHAR(50)                -- ID of the user who last updated
);
GO