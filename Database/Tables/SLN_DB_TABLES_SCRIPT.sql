
DROP TABLE IF EXISTS SLN_ADMISIONS
CREATE TABLE dbo.SLN_ADMISIONS
(
    ADMISION_ID INT IDENTITY(1, 1) NOT NULL ,
    FIRST_NAME VARCHAR(50) NOT NULL ,
    LAST_NAME VARCHAR(50)  NULL,
	CLASS VARCHAR(10) NOT NULL ,
	ACADEMIC_YEAR VARCHAR(10) NOT NULL,
	VILLAGE_NAME VARCHAR(150)  NOT NULL ,	
	MOBILE_NUM VARCHAR(10)  ,	
	GENDER VARCHAR(10),
	AADHAR_NUM VARCHAR(12)  NULL,
	FATHER_NAME VARCHAR(50)  NULL,
	MOTHER_NAME VARCHAR(50)  NULL,	
	SECTION VARCHAR(5),
	CASTE VARCHAR(10),
	LST_UPDATED_TMSP DATETIME,
	LST_UPATED_ID VARCHAR(50),
	CONSTRAINT PK_SLN_ADMISIONS PRIMARY KEY (FIRST_NAME,CLASS,ACADEMIC_YEAR,SECTION)
);



DROP TABLE IF EXISTS SLN_ADMISIONS_STG
CREATE TABLE dbo.SLN_ADMISIONS_STG
(
    FIRST_NAME VARCHAR(50) NOT NULL ,
    LAST_NAME VARCHAR(50)  NULL,
	CLASS VARCHAR(10) NOT NULL ,
	ACADEMIC_YEAR VARCHAR(10) NULL,
	VILLAGE_NAME VARCHAR(150)  NOT NULL ,	
	MOBILE_NUM VARCHAR(10)  ,	
	GENDER VARCHAR(10),
	AADHAR_NUM VARCHAR(12)  NULL,
	FATHER_NAME VARCHAR(50)  NULL,
	MOTHER_NAME VARCHAR(50)  NULL,	
	SECTION VARCHAR(5),
	CASTE VARCHAR(10),
	LST_UPDATED_TMSP DATETIME,
	LST_UPATED_ID VARCHAR(50)	
);

DROP TABLE IF EXISTS SLN_FEE
CREATE TABLE dbo.SLN_FEE
(
    FEE_ID int IDENTITY(1,1) NOT NULL,
	FEE_TYPE varchar(50) NOT NULL,
	STUDENT_NAME varchar(50) NULL,
	FATHER_NAME varchar(50) NULL,
	CLASS varchar(10) NOT NULL,
	PAID_AMOUNT int NOT NULL,
	VILLAGE_NAME varchar(150) NOT NULL,
	PAID_DATE datetime NULL,
	ACADEMIC_YEAR varchar(10) NULL,
	SECTION VARCHAR(10) NOT NULL,
	BILL_NUMBER VARCHAR(50) NULL,
	MOBILE_NUM varchar(10) NULL,
	GENDER varchar(10) NULL,
	DESCRIPTION varchar(250) NULL,
	IS_DELETED bit NULL,
	CORRECTED_AMOUNT int NULL,
	ADMISSION_ID int NULL,
	LST_UPDATED_TMSP datetime NULL,
	LST_UPATED_ID varchar(50) NULL,
	CONSTRAINT PK_SLN_FEE PRIMARY KEY (FEE_ID,FEE_TYPE)
);

DROP TABLE IF EXISTS SLN_COLLECTION_TYPE_LKP
CREATE TABLE SLN_COLLECTION_TYPE_LKP (
    COLLECTION_TYPE_ID INT IDENTITY(1,1) PRIMARY KEY,
    COLLECTION_TYPE VARCHAR(100),
    Description VARCHAR(255),
    LST_UPDATED_TMSP DATETIME,
    LST_UPATED_ID VARCHAR(50)
	);

	
DROP TABLE IF EXISTS SLN_EXPENSE_TYPE_LKP
CREATE TABLE SLN_EXPENSE_TYPE_LKP (
    EXPENSE_TYPE_ID INT IDENTITY(1,1) PRIMARY KEY,
    EXPENSE_TYPE VARCHAR(100),
    Description VARCHAR(255),
    LST_UPDATED_TMSP DATETIME,
    LST_UPATED_ID VARCHAR(50)
	);

DROP TABLE IF EXISTS SLN_COLLECTION
CREATE TABLE dbo.SLN_COLLECTION
(
    COLLECTION_ID INT IDENTITY(1, 1) NOT NULL ,
	COLLECTION_TYPE VARCHAR(50) NOT NULL,
	[DESCRIPTION] VARCHAR(MAX),
	COLLECTION_AMOUNT INT  NOT NULL,
	ENTRY_DATE DATETIME,
	IS_DELETED BIT,
	CORRECTED_AMOUNT INT,
	LST_UPDATED_TMSP DATETIME,
	LST_UPATED_ID VARCHAR(50),
	CONSTRAINT PK_SLN_COLLECTION PRIMARY KEY (COLLECTION_ID,COLLECTION_TYPE)
);

DROP TABLE IF EXISTS SLN_FEETYPE_LKP
CREATE TABLE dbo.SLN_FEETYPE_LKP
(
    FEETYPE_ID INT IDENTITY(1, 1) NOT NULL ,
	FEE_TYPE VARCHAR(50),
	LST_UPDATED_TMSP DATETIME,
	LST_UPATED_ID VARCHAR(50),
);

DROP TABLE IF EXISTS SLN_VILLAGE_LKP
CREATE TABLE dbo.SLN_VILLAGE_LKP
(
    VILLAGE_ID INT IDENTITY(1, 1) NOT NULL ,
	VILLAGE_NAME VARCHAR(200),
	LST_UPDATED_TMSP DATETIME,
	LST_UPATED_ID VARCHAR(50),
);
/*
select * from SLN_ADMISIONS
select * from SLN_FEE
select * from SLN_COLLECTION
select * from SLN_FEETYPE
select * from SLN_VILLAGE


*/
