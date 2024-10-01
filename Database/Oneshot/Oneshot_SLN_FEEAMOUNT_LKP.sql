
-- Insert fee records from LKG to 10th class
DECLARE @AcademicYear VARCHAR(10) = '2024-2025';
DECLARE @FeeType VARCHAR(50) = 'School Fee'; -- Example fee type
DECLARE @UpdatedID VARCHAR(50) = 'Admin';     -- Example user ID

-- Insert records for each class
INSERT INTO dbo.SLN_FEEAMOUNT_LKP (FEE_TYPE, CLASS, ACADEMIC_YEAR, [DESCRIPTION],AMOUNT, LST_UPDATED_TMSP, LST_UPDATED_ID)
VALUES 
	(@FeeType, 'Nursery', @AcademicYear, 'Nursery Tuition Fee', 10000,GETDATE(), @UpdatedID),
    (@FeeType, 'LKG', @AcademicYear, 'LKG Tuition Fee',14000 ,GETDATE(), @UpdatedID),
    (@FeeType, 'UKG', @AcademicYear, 'UKG Tuition Fee',14000 ,GETDATE(), @UpdatedID),
    (@FeeType, '1', @AcademicYear, '1st Class Tuition Fee', 15000,GETDATE(), @UpdatedID),
    (@FeeType, '2', @AcademicYear, '2nd Class Tuition Fee', 15000,GETDATE(), @UpdatedID),
    (@FeeType, '3', @AcademicYear, '3rd Class Tuition Fee', 16500,GETDATE(), @UpdatedID),
    (@FeeType, '4', @AcademicYear, '4th Class Tuition Fee',17500 ,GETDATE(), @UpdatedID),
    (@FeeType, '5', @AcademicYear, '5th Class Tuition Fee', 18000,GETDATE(), @UpdatedID),
    (@FeeType, '6', @AcademicYear, '6th Class Tuition Fee',19000 ,GETDATE(), @UpdatedID),
    (@FeeType, '7', @AcademicYear, '7th Class Tuition Fee',20000 ,GETDATE(), @UpdatedID),
    (@FeeType, '8', @AcademicYear, '8th Class Tuition Fee',21000 ,GETDATE(), @UpdatedID),
    (@FeeType, '9', @AcademicYear, '9th Class Tuition Fee',22000 ,GETDATE(), @UpdatedID),
    (@FeeType, '10', @AcademicYear, '10th Class Tuition Fee',26000 ,GETDATE(), @UpdatedID),
	 (@FeeType, 'Jr Inter', @AcademicYear, 'Jr Inter Tuition Fee',20000 ,GETDATE(), @UpdatedID),
	 (@FeeType, 'Sr Inter', @AcademicYear, '9th Class Tuition Fee',22000 ,GETDATE(), @UpdatedID);
GO
