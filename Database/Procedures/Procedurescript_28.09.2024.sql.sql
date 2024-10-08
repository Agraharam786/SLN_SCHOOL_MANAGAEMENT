/****** Object:  StoredProcedure [dbo].[SLNSP_COLLECTIONTYPEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_COLLECTIONTYPEDETAILS]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 

  SELECT COLLECTION_TYPE
		FROM (
			SELECT 'ALL' AS COLLECTION_TYPE, 0 AS SortOrder
			UNION ALL
			SELECT DISTINCT COLLECTION_TYPE, 1 AS SortOrder
			FROM SLN_COLLECTION_TYPE_LKP
		) AS COLLECTION_TYPEData
		ORDER BY SortOrder, COLLECTION_TYPE DESC
			
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETECOLLECTIONDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETEEXPENSEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_DELETEFEEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_EXPENSETYPEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_EXPENSETYPEDETAILS]
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 
 SELECT EXPENSE_TYPE
		FROM (
			SELECT 'ALL' AS EXPENSE_TYPE, 0 AS SortOrder
			UNION ALL
			SELECT DISTINCT EXPENSE_TYPE, 1 AS SortOrder
			FROM SLN_EXPENSE_TYPE_LKP
		) AS EXPENSETYPEData
		ORDER BY SortOrder, EXPENSE_TYPE DESC

	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_FEETYPEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETBULKINSERTDATA]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETCLASSFEEREPORTS]    Script Date: 28-Sep-24 11:59:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETCLASSFEEREPORTS]	
	@CLASS Varchar(10),
	@ACADEMIC_YEAR Varchar(10),
	@SECTION  Varchar(10)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT  FEE_ID
				,FEE_TYPE
				,STUDENT_NAME
				,FATHER_NAME
				,GENDER
				,CLASS
				,SECTION
				,BILL_NUMBER
				,PAID_AMOUNT
				,[DESCRIPTION]
				,ACADEMIC_YEAR				
				,PAID_DATE	
				,VILLAGE_NAME
				,ADMISSION_ID
		FROM SLN_FEE
		where CLASS=@CLASS and ACADEMIC_YEAR= @ACADEMIC_YEAR
		AND SECTION=@SECTION
		AND  IS_DELETED=0
		order by FEE_ID Desc
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETCOLLECTIONDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETCOLLECTIONREPORT]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
 	
	IF(@COLLECTION_TYPE <>'ALL')
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETDISTINCTACADEMICYEARS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETDISTINCTCLASSNAME]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEREPORT]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
 	
	IF(@EXPENSE_TYPE <>'ALL')
		BEGIN
			SELECT 
					EXPENSE_TYPE,				
					SUM(EXPENSE_AMOUNT) EXPENSE_AMOUNT
				
			FROM SLN_EXPENSE
			where EXPENSE_TYPE = @EXPENSE_TYPE  AND 
			ENTRY_DATE BETWEEN @FROM_DATE AND @TO_DATE
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETEXPENSEREPORT_BYFEETYPE]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFATHERNAME]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFEEREPORT_BYFEETYPE]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETFEEREPORTDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSAVEDFEEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
				,SECTION
				,PAID_AMOUNT
				,BILL_NUMBER
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSECTIONDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSECTIONDETAILS]	
	@CLASS Varchar(10)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
	

		SELECT DISTINCT SECTION
		FROM SLN_ADMISIONS
		where CLASS=@CLASS 

	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTFEEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
				,SECTION
				,PAID_AMOUNT
				,BILL_NUMBER
				,[DESCRIPTION]
				,ACADEMIC_YEAR				
				,PAID_DATE	
				,VILLAGE_NAME
				,ADMISSION_ID
		FROM SLN_FEE
		where  STUDENT_NAME =@STUDENT_NAME AND FATHER_NAME=@FATHER_NAME
		AND CLASS=@CLASS and ACADEMIC_YEAR= @ACADEMIC_YEAR
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTFEEDETAILSBYFILTERS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
 			
		SELECT   FEE_ID
				,FEE_TYPE
				,STUDENT_NAME
				,FATHER_NAME
				,CLASS
				,SECTION
				,PAID_AMOUNT
				,BILL_NUMBER
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTFEEREPORTS]    Script Date: 28-Sep-24 11:59:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SLNSP_GETSTUDENTFEEREPORTS]	
	@CLASS Varchar(10),
	@ACADEMIC_YEAR Varchar(10),
	@SECTION  Varchar(10),
	@STUDENT_NAME Varchar(50)
   
AS
BEGIN
 SET NOCOUNT ON; -- Helps to reduce network traffic and improve performance
 			
		SELECT  FEE_ID
				,FEE_TYPE
				,STUDENT_NAME
				,FATHER_NAME
				,GENDER
				,CLASS
				,SECTION
				,BILL_NUMBER
				,PAID_AMOUNT
				,[DESCRIPTION]
				,ACADEMIC_YEAR				
				,PAID_DATE	
				,VILLAGE_NAME
				,ADMISSION_ID
		FROM SLN_FEE
		where  STUDENT_NAME =@STUDENT_NAME 
		AND CLASS=@CLASS and ACADEMIC_YEAR= @ACADEMIC_YEAR
		AND SECTION=@SECTION
		AND  IS_DELETED=0
		order by FEE_ID Desc
	
END;

GO
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTNAME]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSTUDENTSBYCLASSANDYEAR]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYCOLLECTIONDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYCOLLECTIONEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYEXPENSEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYFEEDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_GETSUMMARYSTUDENTDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATECOLLECTION]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATEEXPENSE]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_INSERTORUPDATEFEEPAYMENT]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
					  @ADMISSION_ID INT,
					  @SECTION VARCHAR(10),
					  @BILL_NUMBER VARCHAR(50)
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
					LST_UPATED_ID	=	'Admin',
					SECTION			=	@SECTION,
					BILL_NUMBER		=	@BILL_NUMBER
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
									,LST_UPATED_ID,
									SECTION,
									BILL_NUMBER)
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
					'Admin',
					@SECTION,
					@BILL_NUMBER)
		
		END

END

/*
INSERT INTO SLN_EXPENSE (COLLECTION_TYPE, DESCRIPTION, COLLECTION_AMOUNT, ENTRY_DATE, IS_DELETED, CORRECTED_AMOUNT)
        VALUES ('Primary', 'Daily Collection', 20000, getdate(), 0, 0)

		select * from SLN_EXPENSE
		*/
GO
/****** Object:  StoredProcedure [dbo].[SLNSP_LOADSTUDENTDETAILS]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SLNSP_SLN_ADMISIONS_LOAD]    Script Date: 28-Sep-24 11:59:32 AM ******/
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
