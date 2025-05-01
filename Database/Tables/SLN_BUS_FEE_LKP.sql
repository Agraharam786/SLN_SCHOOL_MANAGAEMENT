/****** Object:  Table [dbo].[SLN_BUS_FEE_LKP]    Script Date: 01-May-25 1:29:40 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SLN_BUS_FEE_LKP]') AND type in (N'U'))
DROP TABLE [dbo].[SLN_BUS_FEE_LKP]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SLN_BUS_FEE_LKP](
	[VILLAGE_ID] [int] IDENTITY(1,1) NOT NULL,
	[VILLAGE_NAME] [varchar](200) NULL,
	[BUS_FEE] int,
	[LST_UPDATED_TMSP] [datetime] NULL,
	[LST_UPATED_ID] [varchar](50) NULL
) ON [PRIMARY]
GO