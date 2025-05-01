/****** Object:  Table [dbo].[SLN_ADMISIONS_STG]    Script Date: 01-May-25 1:29:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_ADMISIONS_STG]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_ADMISIONS_STG]
GO

/****** Object:  Table [dbo].[SLN_ADMISIONS_STG]    Script Date: 01-May-25 1:29:40 PM ******/
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
	[DISCOUNT_AMOUNT]	[varchar] (15) NULL,
	[IS_HALF_FEE]	[varchar] (10)NULL,
	[IS_FREE_STUDENT]	[varchar] (10)NULL,
	[IS_FEE_CLEAR]	[varchar] (10)NULL,
	[DISCOUNT_DESCRIPTION]	[varchar](500) NULL,	
	[LST_UPATED_ID] [varchar](50) NULL
) ON [PRIMARY]
GO