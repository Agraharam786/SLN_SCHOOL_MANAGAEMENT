using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN_FEE_MANAGEMENT
{
    public static class Common
    {

        public const string GetStudentDetailsProcedure = "SLNSP_GETSTUDENTSBYCLASSANDYEAR";
        public const string ClassNamesProcedure = "SLNSP_GETDISTINCTCLASSNAME";
        public const string AcademicYearProcedure = "SLNSP_GETDISTINCTACADEMICYEARS";
        public const string BulkInsertProcedure = "SLNSP_LOADSTUDENTDETAILS";
        public const string GetBulkInsertDataProcedure = "SLNSP_GETBULKINSERTDATA";
        public const string TargetTableLoadProcedure = "SLNSP_SLN_ADMISIONS_LOAD";
        public const string CollectionTypeProcedure = "SLNSP_COLLECTIONTYPEDETAILS";
        public const string InsertandUpdateCollectionProcedure = "SLNSP_INSERTORUPDATECOLLECTION";
        public const string GetCollectionDetailsProcedure = "SLNSP_GETCOLLECTIONDETAILS";
        public const string ExpenseTypeProcedure = "SLNSP_EXPENSETYPEDETAILS";
        public const string GetExpensenDetailsProcedure = "SLNSP_GETEXPENSEDETAILS";
        public const string InsertandUpdateExpenseProcedure = "SLNSP_INSERTORUPDATEEXPENSE";
        public const string DeleteCollectionProcedure = "SLNSP_DELETECOLLECTIONDETAILS";
        public const string DeleteExpenseProcedure = "SLNSP_DELETEEXPENSEDETAILS";
        public const string FeeTypeProcedure = "SLNSP_FEETYPEDETAILS";
        public const string GetStudentNameProcedure = "SLNSP_GETSTUDENTNAME";
        public const string GetFatherNameProcedure = "SLNSP_GETFATHERNAME";
        public const string GetStudentFeeDetailsByFiltersProcedure = "SLNSP_GETSTUDENTFEEDETAILSBYFILTERS";
        public const string InsertandUpdateFeeProcedure = "SLNSP_INSERTORUPDATEFEEPAYMENT";
        public const string GetSavedFeeDetailsProcedure = "SLNSP_GETSAVEDFEEDETAILS";
        public const string DeleteFeeProcedure = "SLNSP_DELETEFEEDETAILS";
        public const string GetSectionDetails = "SLNSP_GETSECTIONDETAILS";

        public const string SummaryFeeProcedure = "SLNSP_GETSUMMARYFEEDETAILS";
        public const string SummaryCollectionProcedure = "SLNSP_GETSUMMARYCOLLECTIONDETAILS";
        public const string SummaryExpenseProcedure = "SLNSP_GETSUMMARYEXPENSEDETAILS";
        public const string SummaryStudentProcedure = "SLNSP_GETSUMMARYSTUDENTDETAILS";

        public const string GenerateFeeTypeReportProcedure = "SLNSP_GETFEEREPORT_BYFEETYPE";
        public const string GenerateCollectioneReportProcedure = "SLNSP_GETCOLLECTIONREPORT";
        public const string GenerateExpenseReportProcedure = "SLNSP_GETEXPENSEREPORT";

        public const string GenerateStudentFeeReportProcedure = "SLNSP_GETSTUDENTFEEREPORTS";
        public const string GenerateClassFeeReportProcedure = "SLNSP_GETCLASSFEEREPORTS";

        public const string EmailSummaryProcedure = "SLNSP_GETEMAIL_FIANACIALSUMMARY"; 



















    }
}
