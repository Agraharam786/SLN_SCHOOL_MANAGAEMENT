/*
USE [SLNDB]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_SLN_ADMISIONS_LOAD]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_SLN_ADMISIONS_LOAD]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_LOADSTUDENTDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_LOADSTUDENTDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATEFEEPAYMENT]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_INSERTORUPDATEFEEPAYMENT]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATEEXPENSE]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_INSERTORUPDATEEXPENSE]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATECOLLECTION]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_INSERTORUPDATECOLLECTION]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYSTUDENTDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSUMMARYSTUDENTDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYFEEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSUMMARYFEEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYEXPENSEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSUMMARYEXPENSEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYCOLLECTIONEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSUMMARYCOLLECTIONEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYCOLLECTIONDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSUMMARYCOLLECTIONDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTSBYCLASSANDYEAR]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSTUDENTSBYCLASSANDYEAR]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTNAME]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSTUDENTNAME]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTFEEDETAILSBYFILTERS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSTUDENTFEEDETAILSBYFILTERS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTFEEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSTUDENTFEEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSAVEDFEEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETSAVEDFEEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFEEREPORTDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETFEEREPORTDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFEEREPORT_BYFEETYPE]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETFEEREPORT_BYFEETYPE]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFATHERNAME]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETFATHERNAME]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEREPORT_BYFEETYPE]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETEXPENSEREPORT_BYFEETYPE]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEREPORT]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETEXPENSEREPORT]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETEXPENSEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETDISTINCTCLASSNAME]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETDISTINCTCLASSNAME]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETDISTINCTACADEMICYEARS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETDISTINCTACADEMICYEARS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETCOLLECTIONREPORT]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETCOLLECTIONREPORT]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETCOLLECTIONDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETCOLLECTIONDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETBULKINSERTDATA]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_GETBULKINSERTDATA]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_FEETYPEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_FEETYPEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_EXPENSETYPEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_EXPENSETYPEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETEFEEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_DELETEFEEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETEEXPENSEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_DELETEEXPENSEDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETECOLLECTIONDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_DELETECOLLECTIONDETAILS]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_COLLECTIONTYPEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
DROP PROCEDURE [dbo].[SLNSP_COLLECTIONTYPEDETAILS]
GO
/****** Object:  Table [dbo].[SLN_VILLAGE_LKP]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_VILLAGE_LKP]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_VILLAGE_LKP]
GO
/****** Object:  Table [dbo].[SLN_FEETYPE_LKP]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_FEETYPE_LKP]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_FEETYPE_LKP]
GO
/****** Object:  Table [dbo].[SLN_FEE]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_FEE]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_FEE]
GO
/****** Object:  Table [dbo].[SLN_EXPENSE_TYPE_LKP]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_EXPENSE_TYPE_LKP]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_EXPENSE_TYPE_LKP]
GO
/****** Object:  Table [dbo].[SLN_EXPENSE]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_EXPENSE]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_EXPENSE]
GO
/****** Object:  Table [dbo].[SLN_COLLECTION_TYPE_LKP]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_COLLECTION_TYPE_LKP]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_COLLECTION_TYPE_LKP]
GO
/****** Object:  Table [dbo].[SLN_COLLECTION]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_COLLECTION]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_COLLECTION]
GO
/****** Object:  Table [dbo].[SLN_ADMISIONS_STG]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_ADMISIONS_STG]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_ADMISIONS_STG]
GO
/****** Object:  Table [dbo].[SLN_ADMISIONS]    Script Date: 27-Jul-24 10:13:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_ADMISIONS]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_ADMISIONS]
GO
*/
/****** Object:  Table [dbo].[SLN_ADMISIONS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_ADMISIONS](
	[ADMISION_ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [varchar](50) NOT NULL,
	[LAST_NAME] [varchar](50) NULL,
	[CLASS] [varchar](10) NOT NULL,
	[ACADEMIC_YEAR] [varchar](10) NOT NULL,
	[VILLAGE_NAME] [varchar](150) NOT NULL,
	[MOBILE_NUM] [varchar](10) NULL,
	[GENDER] [varchar](10) NULL,
	[AADHAR_NUM] [varchar](12) NULL,
	[FATHER_NAME] [varchar](50) NULL,
	[MOTHER_NAME] [varchar](50) NULL,
	[SECTION] [varchar](5) NULL,
	[CASTE] [varchar](10) NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL,
 CONSTRAINT [PK_SLN_ADMISIONS] PRIMARY KEY CLUSTERED 
(
	[FIRST_NAME] ASC,
	[CLASS] ASC,
	[ACADEMIC_YEAR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLN_ADMISIONS_STG]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_ADMISIONS_STG](
	[FIRST_NAME] [varchar](50) NOT NULL,
	[LAST_NAME] [varchar](50) NULL,
	[CLASS] [varchar](10) NOT NULL,
	[ACADEMIC_YEAR] [varchar](10) NULL,
	[VILLAGE_NAME] [varchar](150) NOT NULL,
	[MOBILE_NUM] [varchar](10) NULL,
	[GENDER] [varchar](10) NULL,
	[AADHAR_NUM] [varchar](12) NULL,
	[FATHER_NAME] [varchar](50) NULL,
	[MOTHER_NAME] [varchar](50) NULL,
	[SECTION] [varchar](5) NULL,
	[CASTE] [varchar](10) NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLN_COLLECTION]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_COLLECTION](
	[COLLECTION_ID] [int] IDENTITY(1,1) NOT NULL,
	[COLLECTION_TYPE] [varchar](50) NOT NULL,
	[DESCRIPTION] [varchar](max) NULL,
	[COLLECTION_AMOUNT] [int] NOT NULL,
	[ENTRY_DATE] [datetime] NULL,
	[IS_DELETED] [bit] NULL,
	[CORRECTED_AMOUNT] [int] NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL,
 CONSTRAINT [PK_SLN_COLLECTION] PRIMARY KEY CLUSTERED 
(
	[COLLECTION_ID] ASC,
	[COLLECTION_TYPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLN_COLLECTION_TYPE_LKP]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_COLLECTION_TYPE_LKP](
	[COLLECTION_TYPE_ID] [int] IDENTITY(1,1) NOT NULL,
	[COLLECTION_TYPE] [varchar](100) NULL,
	[Description] [varchar](255) NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[COLLECTION_TYPE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLN_EXPENSE]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_EXPENSE](
	[EXPENSE_ID] [int] IDENTITY(1,1) NOT NULL,
	[EXPENSE_TYPE] [varchar](50) NOT NULL,
	[DESCRIPTION] [varchar](max) NULL,
	[EXPENSE_AMOUNT] [int] NOT NULL,
	[ENTRY_DATE] [datetime] NULL,
	[IS_DELETED] [bit] NULL,
	[EXP_CORRECTED_AMOUNT] [int] NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL,
 CONSTRAINT [PK_SLN_EXPENSE] PRIMARY KEY CLUSTERED 
(
	[EXPENSE_ID] ASC,
	[EXPENSE_TYPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLN_EXPENSE_TYPE_LKP]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_EXPENSE_TYPE_LKP](
	[EXPENSE_TYPE_ID] [int] IDENTITY(1,1) NOT NULL,
	[EXPENSE_TYPE] [varchar](100) NULL,
	[Description] [varchar](255) NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[EXPENSE_TYPE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLN_FEE]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_FEE](
	[FEE_ID] [int] IDENTITY(1,1) NOT NULL,
	[FEE_TYPE] [varchar](50) NOT NULL,
	[STUDENT_NAME] [varchar](50) NULL,
	[FATHER_NAME] [varchar](50) NULL,
	[CLASS] [varchar](10) NOT NULL,
	[PAID_AMOUNT] [int] NOT NULL,
	[VILLAGE_NAME] [varchar](150) NOT NULL,
	[PAID_DATE] [datetime] NULL,
	[ACADEMIC_YEAR] [varchar](10) NULL,
	[MOBILE_NUM] [varchar](10) NULL,
	[GENDER] [varchar](10) NULL,
	[DESCRIPTION] [varchar](250) NULL,
	[IS_DELETED] [bit] NULL,
	[CORRECTED_AMOUNT] [int] NULL,
	[ADMISSION_ID] [int] NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL,
 CONSTRAINT [PK_SLN_FEE] PRIMARY KEY CLUSTERED 
(
	[FEE_ID] ASC,
	[FEE_TYPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLN_FEETYPE_LKP]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_FEETYPE_LKP](
	[FEETYPE_ID] [int] IDENTITY(1,1) NOT NULL,
	[FEE_TYPE] [varchar](50) NULL,
	[DESCRIPTION] [varchar](max) NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SLN_VILLAGE_LKP]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_VILLAGE_LKP](
	[VILLAGE_ID] [int] IDENTITY(1,1) NOT NULL,
	[VILLAGE_NAME] [varchar](200) NULL,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_COLLECTIONTYPEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_COLLECTIONTYPEDETAILS]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
			
		SELECT DISTINCT COLLECTION_TYPE
		FROM SLN_COLLECTION_TYPE_LKP		
		ORDER BY  COLLECTION_TYPE DESC
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETECOLLECTIONDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLNSP_DELETECOLLECTIONDETAILS]
					  @Collection_Id INT =0 
AS
	BEGIN

	UPDATE SLN_COLLECTION
	SET IS_DELETED=1,
	LST_UPDATED_TMSP=GetDATE()
	WHERE COLLECTION_ID=@Collection_Id

	END
/*
	exec SLNSP_DELETECOLLECTIONDETAILS 2
	select * from SLN_COLLECTION
*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETEEXPENSEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLNSP_DELETEEXPENSEDETAILS]
					  @EXPENSE_ID INT =0 
AS
	BEGIN
    
	UPDATE SLN_EXPENSE
	SET IS_DELETED=1,
	LST_UPDATED_TMSP=GetDATE()
	WHERE EXPENSE_ID=@EXPENSE_ID


	END
/*
	exec SLNSP_DELETEEXPENSEDETAILS 2
	select * from SLN_EXPENSE
*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETEFEEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLNSP_DELETEFEEDETAILS]
					  @FEE_ID INT =0 
AS
	BEGIN
    
	UPDATE SLN_FEE
	SET IS_DELETED=1,
	LST_UPDATED_TMSP=GetDATE()
	WHERE FEE_ID=@FEE_ID


	END
/*
	exec SLNSP_DELETEFEEDETAILS 2
	select * from SLN_EXPENSE
*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_EXPENSETYPEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_EXPENSETYPEDETAILS]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
			
		SELECT DISTINCT EXPENSE_TYPE
		FROM SLN_EXPENSE_TYPE_LKP		
		ORDER BY  EXPENSE_TYPE DESC
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_FEETYPEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_FEETYPEDETAILS]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
			
		SELECT DISTINCT FEE_TYPE
		FROM SLN_FEETYPE_LKP		
		ORDER BY  FEE_TYPE DESC
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETBULKINSERTDATA]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[SLNSP_GETBULKINSERTDATA]
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
	SELECT  FIRST_NAME ,
			LAST_NAME ,
			CLASS   ,
			ACADEMIC_YEAR ,
			VILLAGE_NAME ,	
			MOBILE_NUM   ,	
			GENDER ,
			AADHAR_NUM ,
			FATHER_NAME ,
			MOTHER_NAME ,	
			SECTION ,
			CASTE
	FROM 
		SLN_ADMISIONS_STG
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETCOLLECTIONDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLNSP_GETCOLLECTIONDETAILS]
	@FETCHALL BIT =0
    
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN
	IF @FETCHALL =0
		Select TOP 15 COLLECTION_ID,
				COLLECTION_TYPE,
				[DESCRIPTION],
				COLLECTION_AMOUNT,
				ENTRY_DATE
		FROM SLN_COLLECTION
		WHERE IS_DELETED=0
		ORDER BY COLLECTION_ID DESC
	ELSE
		Select COLLECTION_ID,
				COLLECTION_TYPE,
				[DESCRIPTION],
				COLLECTION_AMOUNT,
				ENTRY_DATE
		FROM SLN_COLLECTION
		WHERE IS_DELETED=0
		ORDER BY COLLECTION_ID DESC
	 
	END   

END

/*
exec SLNSP_GETCOLLECTIONDETAILS 0
exec SLNSP_GETCOLLECTIONDETAILS 1
*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETCOLLECTIONREPORT]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETCOLLECTIONREPORT]			
			@COLLECTION_TYPE Varchar(50) ,	
			@FROM_DATE Date,
			@TO_DATE Date	
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 	
	IF(@COLLECTION_TYPE <>'')
		BEGIN
			SELECT 
					COLLECTION_TYPE,				
					SUM(COLLECTION_AMOUNT) COLLECTION_AMOUNT
				
			FROM SLN_COLLECTION
			where  COLLECTION_TYPE = @COLLECTION_TYPE
			AND ENTRY_DATE BETWEEN @FROM_DATE AND @TO_DATE
			AND IS_DELETED = 0
			GROUP BY
			COLLECTION_TYPE		
			order by COLLECTION_TYPE 
		END
	ELSE
		BEGIN
			SELECT 
					COLLECTION_TYPE,				
					SUM(COLLECTION_AMOUNT) COLLECTION_AMOUNT
				
			FROM SLN_COLLECTION
			where  
			ENTRY_DATE BETWEEN @FROM_DATE AND @TO_DATE
			AND IS_DELETED = 0
			GROUP BY
			COLLECTION_TYPE		
			order by COLLECTION_TYPE 
		END
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETDISTINCTACADEMICYEARS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETDISTINCTACADEMICYEARS]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
	
			SELECT ACADEMIC_YEAR
		FROM (
			SELECT 'Select Year' AS ACADEMIC_YEAR, 0 AS SortOrder
			UNION ALL
			SELECT DISTINCT ACADEMIC_YEAR, 1 AS SortOrder
			FROM SLN_ADMISIONS
		) AS YearData
		ORDER BY SortOrder, ACADEMIC_YEAR DESC

	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETDISTINCTCLASSNAME]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETDISTINCTCLASSNAME]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
	SELECT 'Select Class' AS CLASS
	UNION ALL
	SELECT  distinct CLASS 
	FROM 
		SLN_ADMISIONS S
		--ORDER by S.CLASS
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLNSP_GETEXPENSEDETAILS]
	@FETCHALL BIT =0
    
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN
	IF @FETCHALL =0
		Select TOP 15 EXPENSE_ID,
					  EXPENSE_TYPE,
					  [DESCRIPTION],
					  EXPENSE_AMOUNT,
					  ENTRY_DATE
		FROM SLN_EXPENSE
		WHERE IS_DELETED=0
		ORDER BY EXPENSE_ID DESC
	ELSE
		Select  EXPENSE_ID,
					  EXPENSE_TYPE,
					  [DESCRIPTION],
					  EXPENSE_AMOUNT,
					  ENTRY_DATE
		FROM SLN_EXPENSE
		WHERE IS_DELETED=0
		ORDER BY EXPENSE_ID DESC
	 
	END   

END

/*
exec SLNSP_GETEXPENSEDETAILS 0
exec SLNSP_GETEXPENSEDETAILS 1
*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEREPORT]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETEXPENSEREPORT]			
			@EXPENSE_TYPE Varchar(50) =NULL,	
			@FROM_DATE Date,
			@TO_DATE Date	
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 	
	IF(@EXPENSE_TYPE <>'')
		BEGIN
			SELECT 
					EXPENSE_TYPE,				
					SUM(EXPENSE_AMOUNT) EXPENSE_AMOUNT
				
			FROM SLN_EXPENSE
			where  EXPENSE_TYPE = @EXPENSE_TYPE
			AND ENTRY_DATE BETWEEN @FROM_DATE AND @TO_DATE
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEREPORT_BYFEETYPE]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETEXPENSEREPORT_BYFEETYPE]			
			@EXPENSE_TYPE Varchar(50),	
			@FROM_DATE Date,
			@TO_DATE Date	
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT 
				EXPENSE_TYPE,				
				SUM(EXPENSE_AMOUNT) EXPENSE_AMOUNT
				
		FROM SLN_EXPENSE
		where  EXPENSE_TYPE = @EXPENSE_TYPE
        AND ENTRY_DATE BETWEEN @FROM_DATE AND @TO_DATE
        AND IS_DELETED = 0
		GROUP BY
		EXPENSE_TYPE		
		order by EXPENSE_TYPE 
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFATHERNAME]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETFATHERNAME]
	@STUDENT_NAME Varchar(50),
	@CLASS Varchar(10)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
			WITH CTE AS (
			SELECT ADMISION_ID
			FROM SLN_ADMISIONS
			WHERE FIRST_NAME = @STUDENT_NAME AND CLASS =@CLASS 
		)
		SELECT A.FATHER_NAME, A.VILLAGE_NAME, A.GENDER,A.MOBILE_NUM, A.ADMISION_ID
		FROM SLN_ADMISIONS A
		JOIN CTE ON A.ADMISION_ID = CTE.ADMISION_ID;
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFEEREPORT_BYFEETYPE]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETFEEREPORT_BYFEETYPE]	
			@CLASS Varchar(10),
			@ACADEMIC_YEAR Varchar(10),
			@FEE_TYPE Varchar(50),	
			@FROM_DATE Date,
			@TO_DATE Date	
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT 
				ADMISSION_ID,
				STUDENT_NAME,
				FATHER_NAME,
				FEE_TYPE,				
				SUM(PAID_AMOUNT) PAID_AMOUNT,
				CLASS,
				ACADEMIC_YEAR
				
		FROM SLN_FEE
		where  CLASS = @CLASS 
        AND ACADEMIC_YEAR = @ACADEMIC_YEAR 
        AND FEE_TYPE = @FEE_TYPE
        AND PAID_DATE BETWEEN @FROM_DATE AND @TO_DATE
        AND IS_DELETED = 0
		GROUP BY
		ADMISSION_ID,
		STUDENT_NAME,
		FATHER_NAME,
		FEE_TYPE,
		CLASS,
		ACADEMIC_YEAR		
		order by ADMISSION_ID 
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFEEREPORTDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETFEEREPORTDETAILS]	
			@CLASS Varchar(10),
			@ACADEMIC_YEAR Varchar(10),
			@FEE_TYPE Varchar(50),	
			@FROM_DATE Date,
			@TO_DATE Date	
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT  FEE_ID
				,FEE_TYPE
				,STUDENT_NAME
				,FATHER_NAME
				,CLASS
				,PAID_AMOUNT
				,[DESCRIPTION]
				,ACADEMIC_YEAR				
				,PAID_DATE	
				,VILLAGE_NAME
				,ADMISSION_ID
		FROM SLN_FEE
		where  CLASS = @CLASS 
        AND ACADEMIC_YEAR = @ACADEMIC_YEAR 
        AND FEE_TYPE = @FEE_TYPE
        AND PAID_DATE BETWEEN @FROM_DATE AND @TO_DATE
        AND IS_DELETED = 0
		order by FEE_ID Desc
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSAVEDFEEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSAVEDFEEDETAILS]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT   FEE_ID
				,FEE_TYPE
				,STUDENT_NAME
				,FATHER_NAME
				,CLASS
				,PAID_AMOUNT
				,[DESCRIPTION]
				,ACADEMIC_YEAR				
				,PAID_DATE	
				,VILLAGE_NAME
				,ADMISSION_ID
		FROM SLN_FEE
		Where IS_DELETED=0
		ORDER BY FEE_ID DESC
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTFEEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSTUDENTFEEDETAILS]	
	@STUDENT_NAME Varchar(50),
	@FATHER_NAME Varchar(50),
	@CLASS Varchar(10),
	@ACADEMIC_YEAR Varchar(10)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT   FEE_ID
				,FEE_TYPE
				,STUDENT_NAME
				,FATHER_NAME
				,CLASS
				,PAID_AMOUNT
				,VILLAGE_NAME
				,PAID_DATE
				,ACADEMIC_YEAR
				,ADMISSION_ID
		FROM SLN_FEE
		where  STUDENT_NAME =@STUDENT_NAME AND FATHER_NAME=@FATHER_NAME
		AND CLASS=@CLASS and ACADEMIC_YEAR= @ACADEMIC_YEAR
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTFEEDETAILSBYFILTERS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSTUDENTFEEDETAILSBYFILTERS]	
	@STUDENT_NAME Varchar(50),
	@FATHER_NAME Varchar(50),
	@CLASS Varchar(10),
	@ACADEMIC_YEAR Varchar(10)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT  FEE_ID
				,FEE_TYPE
				,STUDENT_NAME
				,FATHER_NAME
				,CLASS
				,PAID_AMOUNT
				,[DESCRIPTION]
				,ACADEMIC_YEAR				
				,PAID_DATE	
				,VILLAGE_NAME
				,ADMISSION_ID
		FROM SLN_FEE
		where  STUDENT_NAME =@STUDENT_NAME AND FATHER_NAME=@FATHER_NAME
		AND CLASS=@CLASS and ACADEMIC_YEAR= @ACADEMIC_YEAR
		AND  IS_DELETED=0
		order by FEE_ID Desc
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTNAME]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSTUDENTNAME]
	--@STUDENT_NAME Varchar(50), Commented to load entire student data while loading
	@CLASS Varchar(10),
	@SECTION Varchar(10)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
	/*	WITH CTE AS (SELECT FIRST_NAME, CLASS
		FROM SLN_ADMISIONS
		where FIRST_NAME like '%' +@STUDENT_NAME + '%' )
		SELECT A.FIRST_NAME
		FROM SLN_ADMISIONS A
		JOIN CTE ON A.FIRST_NAME = CTE.FIRST_NAME  AND A.CLASS= @CLASS;
		*/

		SELECT FIRST_NAME
		FROM SLN_ADMISIONS
		where CLASS=@CLASS AND SECTION =@SECTION

END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTSBYCLASSANDYEAR]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSTUDENTSBYCLASSANDYEAR]
    @CLASSNAME NVARCHAR(50),
	@ACADEMIC_YEAR Varchar(10)=''
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 if(@ACADEMIC_YEAR <> '' AND @CLASSNAME <> '')
	SELECT  FIRST_NAME ,
			LAST_NAME ,
			CLASS   ,
			ACADEMIC_YEAR ,
			VILLAGE_NAME ,	
			MOBILE_NUM   ,	
			GENDER ,
			AADHAR_NUM ,
			FATHER_NAME ,
			MOTHER_NAME ,	
			SECTION ,
			CASTE
	FROM 
		SLN_ADMISIONS
	WHERE 
		CLASS = @CLASSNAME AND ACADEMIC_YEAR = @ACADEMIC_YEAR 
	ELSE
	BEGIN 
		SELECT  top 0 FIRST_NAME ,
			LAST_NAME ,
			CLASS   ,
			ACADEMIC_YEAR ,
			VILLAGE_NAME ,	
			MOBILE_NUM   ,	
			GENDER ,
			AADHAR_NUM ,
			FATHER_NAME ,
			MOTHER_NAME ,	
			SECTION ,
			CASTE
	FROM 
		SLN_ADMISIONS
	
	END
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYCOLLECTIONDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSUMMARYCOLLECTIONDETAILS]
   
AS
BEGIN
  SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
    
    DECLARE @Today DATE = GETDATE();
    DECLARE @ThisWeekStart DATE = DATEADD(DAY, 1 - DATEPART(WEEKDAY, @Today), @Today);
    DECLARE @ThisMonthStart DATE = DATEADD(DAY, 1 - DATEPART(DAY, @Today), @Today);
    DECLARE @ThisYearStart DATE = DATEFROMPARTS(YEAR(@Today), 1, 1);

	
   ; WITH ExpenseSummary AS (
        -- Today's expenses
        SELECT 
            'Today' AS Time_Frame,
			 CASE WHEN SUM(COLLECTION_AMOUNT) > 0 THEN SUM(COLLECTION_AMOUNT) ELSE 0 END AS TOTAL_COLLECTION
        FROM 
            SLN_COLLECTION
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE = @Today
    
        UNION ALL
    
        -- This week's expenses
        SELECT 
            'This Week' AS Time_Frame,
            CASE WHEN SUM(COLLECTION_AMOUNT) > 0 THEN SUM(COLLECTION_AMOUNT) ELSE 0 END AS TOTAL_COLLECTION
        FROM 
            SLN_COLLECTION
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisWeekStart AND @Today
    
        UNION ALL
    
        -- This month's expenses
        SELECT 
            'This Month' AS Time_Frame,
           CASE WHEN SUM(COLLECTION_AMOUNT) > 0 THEN SUM(COLLECTION_AMOUNT) ELSE 0 END AS TOTAL_COLLECTION
        FROM 
            SLN_COLLECTION
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisMonthStart AND @Today
    
        UNION ALL
    
        -- This year's expenses
        SELECT 
            'This Year' AS Time_Frame,
            CASE WHEN SUM(COLLECTION_AMOUNT) > 0 THEN SUM(COLLECTION_AMOUNT) ELSE 0 END AS TOTAL_COLLECTION
        FROM 
            SLN_COLLECTION
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisYearStart AND @Today
    )
    
    SELECT *
    FROM ExpenseSummary
    ORDER BY 
        CASE 
            WHEN Time_Frame = 'Today' THEN 1
            WHEN Time_Frame = 'This Week' THEN 2
            WHEN Time_Frame = 'This Month' THEN 3
            WHEN Time_Frame = 'This Year' THEN 4
            ELSE 5 -- For any unexpected value, put it last
        END
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYCOLLECTIONEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSUMMARYCOLLECTIONEDETAILS]
   
AS
BEGIN
  SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
    
    DECLARE @Today DATE = GETDATE();
    DECLARE @ThisWeekStart DATE = DATEADD(DAY, 1 - DATEPART(WEEKDAY, @Today), @Today);
    DECLARE @ThisMonthStart DATE = DATEADD(DAY, 1 - DATEPART(DAY, @Today), @Today);
    DECLARE @ThisYearStart DATE = DATEFROMPARTS(YEAR(@Today), 1, 1);

	
   ; WITH ExpenseSummary AS (
        -- Today's expenses
        SELECT 
            'Today' AS TimeFrame,
			 CASE WHEN SUM(COLLECTION_AMOUNT) > 0 THEN SUM(COLLECTION_AMOUNT) ELSE 0 END AS TOTAL_COLLECTION
        FROM 
            SLN_COLLECTION
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE = @Today
    
        UNION ALL
    
        -- This week's expenses
        SELECT 
            'This Week' AS TimeFrame,
            CASE WHEN SUM(COLLECTION_AMOUNT) > 0 THEN SUM(COLLECTION_AMOUNT) ELSE 0 END AS TOTAL_COLLECTION
        FROM 
            SLN_COLLECTION
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisWeekStart AND @Today
    
        UNION ALL
    
        -- This month's expenses
        SELECT 
            'This Month' AS TimeFrame,
           CASE WHEN SUM(COLLECTION_AMOUNT) > 0 THEN SUM(COLLECTION_AMOUNT) ELSE 0 END AS TOTAL_COLLECTION
        FROM 
            SLN_COLLECTION
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisMonthStart AND @Today
    
        UNION ALL
    
        -- This year's expenses
        SELECT 
            'This Year' AS TimeFrame,
            CASE WHEN SUM(COLLECTION_AMOUNT) > 0 THEN SUM(COLLECTION_AMOUNT) ELSE 0 END AS TOTAL_COLLECTION
        FROM 
            SLN_COLLECTION
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisYearStart AND @Today
    )
    
    SELECT *
    FROM ExpenseSummary
    ORDER BY 
        CASE 
            WHEN TimeFrame = 'Today' THEN 1
            WHEN TimeFrame = 'This Week' THEN 2
            WHEN TimeFrame = 'This Month' THEN 3
            WHEN TimeFrame = 'This Year' THEN 4
            ELSE 5 -- For any unexpected value, put it last
        END
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYEXPENSEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSUMMARYEXPENSEDETAILS] 
AS
BEGIN
    SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
    
    DECLARE @Today DATE = GETDATE();
    DECLARE @ThisWeekStart DATE = DATEADD(DAY, 1 - DATEPART(WEEKDAY, @Today), @Today);
    DECLARE @ThisMonthStart DATE = DATEADD(DAY, 1 - DATEPART(DAY, @Today), @Today);
    DECLARE @ThisYearStart DATE = DATEFROMPARTS(YEAR(@Today), 1, 1);


   ; WITH ExpenseSummary AS (
        -- Today's expenses
        SELECT 
            'Today' AS Time_Frame,
            CASE WHEN SUM(EXPENSE_AMOUNT) > 0 THEN SUM(EXPENSE_AMOUNT) ELSE 0 END AS TOTAL_EXPENSE
        FROM 
            SLN_EXPENSE
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE = @Today
    
        UNION ALL
    
        -- This week's expenses
        SELECT 
            'This Week' AS Time_Frame,
            CASE WHEN SUM(EXPENSE_AMOUNT) > 0 THEN SUM(EXPENSE_AMOUNT) ELSE 0 END AS TOTAL_EXPENSE
        FROM 
            SLN_EXPENSE
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisWeekStart AND @Today
    
        UNION ALL
    
        -- This month's expenses
        SELECT 
            'This Month' AS Time_Frame,
             CASE WHEN SUM(EXPENSE_AMOUNT) > 0 THEN SUM(EXPENSE_AMOUNT) ELSE 0 END AS TOTAL_EXPENSE
        FROM 
            SLN_EXPENSE
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisMonthStart AND @Today
    
        UNION ALL
    
        -- This year's expenses
        SELECT 
            'This Year' AS Time_Frame,
             CASE WHEN SUM(EXPENSE_AMOUNT) > 0 THEN SUM(EXPENSE_AMOUNT) ELSE 0 END AS TOTAL_EXPENSE
        FROM 
            SLN_EXPENSE
        WHERE 
            IS_DELETED = 0
            AND ENTRY_DATE BETWEEN @ThisYearStart AND @Today
    )
    
    SELECT *
    FROM ExpenseSummary
    ORDER BY 
        CASE 
            WHEN Time_Frame = 'Today' THEN 1
            WHEN Time_Frame = 'This Week' THEN 2
            WHEN Time_Frame = 'This Month' THEN 3
            WHEN Time_Frame = 'This Year' THEN 4
            ELSE 5 -- For any unexpected value, put it last
        END
END;
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYFEEDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSUMMARYFEEDETAILS] 
AS
BEGIN
    SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
    
    DECLARE @Today DATE = GETDATE();
    DECLARE @ThisWeekStart DATE = DATEADD(DAY, 1 - DATEPART(WEEKDAY, @Today), @Today);
    DECLARE @ThisMonthStart DATE = DATEADD(DAY, 1 - DATEPART(DAY, @Today), @Today);
    DECLARE @ThisYearStart DATE = DATEFROMPARTS(YEAR(@Today), 1, 1);

   ; WITH ExpenseSummary AS (
        -- Today's expenses
        SELECT 
            'Today' AS Time_Frame,
            CASE WHEN SUM(PAID_AMOUNT) > 0 THEN SUM(PAID_AMOUNT) ELSE 0 END AS TOTAL_FEE_PAID
        FROM 
            SLN_FEE
        WHERE 
            IS_DELETED = 0
            AND PAID_DATE = @Today
    
        UNION ALL
    
        -- This week's expenses
        SELECT 
            'This Week' AS Time_Frame,
           CASE WHEN SUM(PAID_AMOUNT) > 0 THEN SUM(PAID_AMOUNT) ELSE 0 END AS TOTAL_FEE_PAID
        FROM 
            SLN_FEE
        WHERE 
            IS_DELETED = 0
            AND PAID_DATE BETWEEN @ThisWeekStart AND @Today
    
        UNION ALL
    
        -- This month's expenses
        SELECT 
            'This Month' AS Time_Frame,
			CASE WHEN SUM(PAID_AMOUNT) > 0 THEN SUM(PAID_AMOUNT) ELSE 0 END AS TOTAL_FEE_PAID
        FROM 
            SLN_FEE
        WHERE 
            IS_DELETED = 0
            AND PAID_DATE BETWEEN @ThisMonthStart AND @Today
    
        UNION ALL
    
        -- This year's expenses
        SELECT 
            'This Year' AS Time_Frame,
			CASE WHEN SUM(PAID_AMOUNT) > 0 THEN SUM(PAID_AMOUNT) ELSE 0 END AS TOTAL_FEE_PAID
           
        FROM 
            SLN_FEE
        WHERE 
            IS_DELETED = 0
            AND PAID_DATE BETWEEN @ThisYearStart AND @Today
    )
    
    SELECT *
    FROM ExpenseSummary
    ORDER BY 
        CASE 
            WHEN Time_Frame = 'Today' THEN 1
            WHEN Time_Frame = 'This Week' THEN 2
            WHEN Time_Frame = 'This Month' THEN 3
            WHEN Time_Frame = 'This Year' THEN 4
            ELSE 5 -- For any unexpected value, put it last
        END        
END;
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYSTUDENTDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSUMMARYSTUDENTDETAILS] 
AS
BEGIN
    SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
    
    ;WITH Summary AS (
        SELECT 
            SUM(CASE WHEN CLASS IN ('LKG', 'UKG') THEN 1 ELSE 0 END) AS KinderGartenCount,
            SUM(CASE WHEN CLASS IN ('1', '2', '3', '4', '5') THEN 1 ELSE 0 END) AS PrimaryCount,
			SUM(CASE WHEN CLASS IN ('6', '7', '8', '9', '10') THEN 1 ELSE 0 END) AS HigherCount,
			SUM(CASE WHEN GENDER ='M' THEN 1 ELSE 0 END) AS MaleCount,
			SUM(CASE WHEN GENDER ='F' THEN 1 ELSE 0 END) AS FemaleCount
        FROM SLN_ADMISIONS
    )
    SELECT 
        KinderGartenCount AS Kinder_Garten,
        PrimaryCount AS Primary_Count,
		HigherCount AS Higher_Count,
		MaleCount AS Male_Count,
		FemaleCount As Female_Count
    FROM Summary;
END;
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATECOLLECTION]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLNSP_INSERTORUPDATECOLLECTION]
	@CollectionId INT =0,
    @CollectionType VARCHAR(255),
    @Description VARCHAR(255),
    @CollectionAmount INT,
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
					ENTRY_DATE = @EntryDate,
					IS_DELETED = @IsDeleted,
					CORRECTED_AMOUNT = @CorrectedAmount,
					LST_UPDATED_TMSP=GetDATE(),
					LST_UPATED_ID='Admin'
		  WHERE COLLECTION_ID = @CollectionId
			END
	ELSE
		BEGIN
			 INSERT INTO SLN_COLLECTION (COLLECTION_TYPE, DESCRIPTION, COLLECTION_AMOUNT, ENTRY_DATE, IS_DELETED, CORRECTED_AMOUNT,LST_UPDATED_TMSP,LST_UPATED_ID)
			VALUES (@CollectionType, @Description, @CollectionAmount, @EntryDate, @IsDeleted, @CorrectedAmount,GetDATE(),'Admin')
		
		END

END

/*
INSERT INTO SLN_COLLECTION (COLLECTION_TYPE, DESCRIPTION, COLLECTION_AMOUNT, ENTRY_DATE, IS_DELETED, CORRECTED_AMOUNT)
        VALUES ('Primary', 'Daily Collection', 20000, getdate(), 0, 0)

		select * from SLN_COLLECTION
		*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATEEXPENSE]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLNSP_INSERTORUPDATEEXPENSE]
					  @EXPENSE_ID INT =0 ,
					  @EXPENSE_TYPE VARCHAR(255),
					  @DESCRIPTION VARCHAR(255),
					  @EXPENSE_AMOUNT INT,
					  @ENTRY_DATE DATETIME,
					  @IS_DELETED BIT,
					  @EXP_CORRECTED_AMOUNT INT
AS
BEGIN
    --SET NOCOUNT ON;
	IF @EXPENSE_ID>0
		BEGIN
		UPDATE SLN_EXPENSE
				SET [DESCRIPTION] = @DESCRIPTION,
					EXPENSE_TYPE =@EXPENSE_TYPE,
					EXPENSE_AMOUNT = @EXPENSE_AMOUNT,
					ENTRY_DATE = @ENTRY_DATE,
					IS_DELETED = @IS_DELETED,
					EXP_CORRECTED_AMOUNT = @EXP_CORRECTED_AMOUNT,
					LST_UPDATED_TMSP=GetDATE(),
					LST_UPATED_ID ='Admin'
		  WHERE EXPENSE_ID = @EXPENSE_ID
			END
	ELSE
		BEGIN
			 INSERT INTO SLN_EXPENSE (EXPENSE_TYPE, DESCRIPTION, EXPENSE_AMOUNT, ENTRY_DATE, IS_DELETED, EXP_CORRECTED_AMOUNT,LST_UPDATED_TMSP,LST_UPATED_ID)
			VALUES (@EXPENSE_TYPE, @Description, @EXPENSE_AMOUNT, @ENTRY_DATE, @IS_DELETED, @EXP_CORRECTED_AMOUNT,GETDATE(),'Admin')
		
		END

END

/*
INSERT INTO SLN_EXPENSE (COLLECTION_TYPE, DESCRIPTION, COLLECTION_AMOUNT, ENTRY_DATE, IS_DELETED, CORRECTED_AMOUNT)
        VALUES ('Primary', 'Daily Collection', 20000, getdate(), 0, 0)

		select * from SLN_EXPENSE
		*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATEFEEPAYMENT]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SLNSP_INSERTORUPDATEFEEPAYMENT]
					  @FEE_ID INT =0 ,
					  @FEE_TYPE VARCHAR(50),
					  @STUDENT_NAME VARCHAR(50),
					  @FATHER_NAME VARCHAR(50),
					  @CLASS VARCHAR(10),
					  @PAID_AMOUNT INT,						  
					  @PAID_DATE DATETIME,
					  @VILLAGE_NAME VARCHAR(150),
					  @ACADEMIC_YEAR VARCHAR(10),
					  @MOBILE_NUM VARCHAR(10),
					  @GENDER VARCHAR(10),
					  @IS_DELETED BIT,					  
					  @DESCRIPTION VARCHAR(255),					  
					  @CORRECTED_AMOUNT INT,
					  @ADMISSION_ID INT
AS
BEGIN
    --SET NOCOUNT ON;
	IF @FEE_ID>0
		BEGIN
		UPDATE SLN_FEE
				SET FEE_TYPE		=	@FEE_TYPE ,
					STUDENT_NAME	=	@STUDENT_NAME ,
					FATHER_NAME		=	@FATHER_NAME ,
					CLASS			=	@CLASS ,
					PAID_AMOUNT		=	@PAID_AMOUNT ,					
					VILLAGE_NAME	=	@VILLAGE_NAME ,
					PAID_DATE		=	@PAID_DATE , 
					ACADEMIC_YEAR	=	@ACADEMIC_YEAR ,
					MOBILE_NUM		=	@MOBILE_NUM ,
					GENDER			=	@GENDER ,
					[DESCRIPTION]	=	@DESCRIPTION ,
					IS_DELETED		=	@IS_DELETED ,
					CORRECTED_AMOUNT	=	@CORRECTED_AMOUNT ,
					ADMISSION_ID	=	@ADMISSION_ID ,
					LST_UPDATED_TMSP	=	GETDATE(),
					LST_UPATED_ID	=	'Admin'
		  WHERE FEE_ID = @FEE_ID
			END
	ELSE
		BEGIN
			 INSERT INTO SLN_FEE (   FEE_TYPE
									,STUDENT_NAME
									,FATHER_NAME
									,CLASS
									,PAID_AMOUNT
									,VILLAGE_NAME
									,PAID_DATE
									,ACADEMIC_YEAR
									,MOBILE_NUM
									,GENDER
									,[DESCRIPTION]
									,IS_DELETED
									,CORRECTED_AMOUNT
									,ADMISSION_ID
									,LST_UPDATED_TMSP
									,LST_UPATED_ID)
			VALUES (@FEE_TYPE ,
					@STUDENT_NAME ,
					@FATHER_NAME ,
					@CLASS ,
					@PAID_AMOUNT ,					
					@VILLAGE_NAME ,
					@PAID_DATE , 
					@ACADEMIC_YEAR ,
					@MOBILE_NUM ,
					@GENDER ,
					@DESCRIPTION ,
					@IS_DELETED ,
					@CORRECTED_AMOUNT ,
					@ADMISSION_ID 
					,GETDATE(),
					'Admin')
		
		END

END

/*
INSERT INTO SLN_EXPENSE (COLLECTION_TYPE, DESCRIPTION, COLLECTION_AMOUNT, ENTRY_DATE, IS_DELETED, CORRECTED_AMOUNT)
        VALUES ('Primary', 'Daily Collection', 20000, getdate(), 0, 0)

		select * from SLN_EXPENSE
		*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_LOADSTUDENTDETAILS]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[SLNSP_LOADSTUDENTDETAILS]
		@FilePath NVARCHAR(255) ='C:\Users\hp\Documents\SQL Server Management Studio\BulkInsert_2023_New.CSV',
		@Delimiter CHAR(1) = ','
	AS
	BEGIN
	SET NOCOUNT ON;
		 DECLARE @SqlCmd NVARCHAR(MAX);
		 truncate table SLN_ADMISIONS_STG
		SET @SqlCmd = '
			BULK INSERT SLN_ADMISIONS_STG
			FROM ''' + @FilePath + '''
			WITH (
				FIELDTERMINATOR = ''' + @Delimiter + ''',
				ROWTERMINATOR = ''\n'',
				FIRSTROW = 2 -- Skip header row if present
			)';

		EXEC sp_executesql @SqlCmd;

		Update SLN_ADMISIONS_STG
		SET LST_UPDATED_TMSP=GETDATE();
		/*
		Select * from SLN_ADMISIONS_STG
		*/

END;
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_SLN_ADMISIONS_LOAD]    Script Date: 27-Jul-24 10:13:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[SLNSP_SLN_ADMISIONS_LOAD]
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
	INSERT INTO SLN_ADMISIONS
	SELECT  FIRST_NAME ,
			LAST_NAME ,
			CLASS   ,
			ACADEMIC_YEAR ,
			VILLAGE_NAME ,	
			MOBILE_NUM   ,	
			GENDER ,
			AADHAR_NUM ,
			FATHER_NAME ,
			MOTHER_NAME ,	
			SECTION ,
			CASTE,
			GETDATE(),
			LST_UPATED_ID
	FROM 
		SLN_ADMISIONS_STG
		
END;


/*
	select * from SLN_ADMISIONS
*/
GO
