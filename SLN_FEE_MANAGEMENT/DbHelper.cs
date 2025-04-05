using SLN_FEE_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SLN_FEE_MANAGEMENT
{
    public class DbHelper
    {
        private SLN_FEE_MANAGEMENT.Utility UtilityInstance;
        private List<SqlParameter> ParamList;
        public DbHelper() 
        {
            UtilityInstance = new Utility();
        
        }

        public DataSet GetStudentDetailsByClass(string procedureName, string className, string academicYear, string section)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                new SqlParameter("@CLASSNAME", className),
                new SqlParameter("@ACADEMIC_YEAR", academicYear),
                new SqlParameter("@SECTION", section)
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetDistinctClass(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetDistinctAcademicYears(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet PerformBulkInsert(string procedureName, string filePath)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                new SqlParameter("@FilePath", filePath),
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetBulkInsertedData(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public int LoadDataToTargetTable(string procedureName)
        {
            SqlParameter[] parameters = {};
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }

        public int SaveCollectionDataModel(string procedureName,CollectionModel collectionModel)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@CollectionId", collectionModel.CollectionId),
                new SqlParameter("@CollectionType", collectionModel.CollectionType),
                new SqlParameter("@Description", collectionModel.Description),
                new SqlParameter("@CollectionAmount", collectionModel.CollectionAmount),
                new SqlParameter("@BankDepositAmount", collectionModel.BankDepositAmount),
                new SqlParameter("@InCash", collectionModel.Incash),
                new SqlParameter("@EntryDate", collectionModel.EntryDate),
                new SqlParameter("@IsDeleted", collectionModel.IsDeleted),
                new SqlParameter("@CorrectedAmount", collectionModel.CorrectedAmount)
            };
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }

      
        public int SaveBankingDataModel(string procedureName, BankingModel transaction)
        {
            SqlParameter[] parameters = {
                     new SqlParameter("@TRANSACTION_ID", transaction.TransactionId ?? (object)DBNull.Value),  // Handle nullable int
                     new SqlParameter("@TRANSACTION_FROM", transaction.TransactionFrom),
                     new SqlParameter("@TRANSACTION_TO", transaction.TransactionTo),
                     new SqlParameter("@TRANSACTION_AMOUNT", transaction.TransactionAmount),
                     new SqlParameter("@TRANSACTION_DATE", transaction.TransactionDate),
                     new SqlParameter("@DESCRIPTION", transaction.Description ?? (object)DBNull.Value),  // Handle nullable string
                     new SqlParameter("@DEPOSITED_BY", transaction.DepositedBy ?? (object)DBNull.Value)  // Handle nullable string
             };
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }


        public DataSet GetCollectionDetails(string procedureName,bool fetchAllData)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                 new SqlParameter("@FETCHALL", fetchAllData)
                
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetCollectionSummaryDetails(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }


        public DataSet GetExpenseSummaryDetails(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetFeeSummaryDetails(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetStudnetDetailsSummaryDetails(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public int SaveExpenseDataModel(string procedureName, ExpenseModel expenseModel)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EXPENSE_ID", expenseModel.ExpenseId),
                new SqlParameter("@EXPENSE_TYPE", expenseModel.ExpenseType),
                new SqlParameter("@Description", expenseModel.Description),
                new SqlParameter("@EXPENSE_AMOUNT", expenseModel.ExpenseAmount),
                new SqlParameter("@ENTRY_DATE", expenseModel.EntryDate),
                new SqlParameter("@IS_DELETED", expenseModel.IsDeleted),
                new SqlParameter("@EXP_CORRECTED_AMOUNT", expenseModel.ExpCorrectedAmount)
            };
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }
        public DataSet GetExpenseDetails(string procedureName, bool fetchAllData)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                 new SqlParameter("@FETCHALL", fetchAllData)

                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public int DeleteExpenseDetails(string procedureName, int expese_id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Expense_Id", expese_id)
            };
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }
        public int DeleteCollectionDetails(string procedureName, int collection_id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Collection_Id", collection_id)
            };
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }

        public int DeleteBankDetails(string procedureName, int transaction_id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@TRANSACTION_ID", transaction_id)
            };
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }

        public int SaveFeeDataModel(string procedureName, FeeModel feeModel)
        {            
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FEE_ID",  feeModel.FEE_ID ),
            new SqlParameter("@FEE_TYPE",feeModel.FEE_TYPE ),
            new SqlParameter("@STUDENT_NAME", feeModel.STUDENT_NAME ),
            new SqlParameter("@FATHER_NAME", feeModel.FATHER_NAME ),
            new SqlParameter("@CLASS", feeModel.CLASS ),
            new SqlParameter("@PAID_AMOUNT",  feeModel.PAID_AMOUNT ),
            new SqlParameter("@VILLAGE_NAME", feeModel.VILLAGE_NAME ),
            new SqlParameter("@PAID_DATE",  feeModel.PAID_DATE ),
            new SqlParameter("@ACADEMIC_YEAR", feeModel.ACADEMIC_YEAR ),
            new SqlParameter("@MOBILE_NUM", feeModel.MOBILE_NUM ),
            new SqlParameter("@GENDER", feeModel.GENDER ),
            new SqlParameter("@IS_DELETED",  feeModel.IS_DELETED ),
             new SqlParameter("@DESCRIPTION",  feeModel.DESCRIPTION ),
            new SqlParameter("@CORRECTED_AMOUNT",  feeModel.CORRECTED_AMOUNT ),
            new SqlParameter("@ADMISSION_ID",  feeModel.ADMISSION_ID ),
            new SqlParameter("@SECTION",  feeModel.SECTION ),
            new SqlParameter("@BILL_NUMBER",  feeModel.BILL_NUMBER )
            };
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }

        public DataSet GetStudentFeeDetailsByFilters(string procedureName, string StudentName,string FatherName, string Class,string AcademicYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@STUDENT_NAME", StudentName),
                 new SqlParameter("@FATHER_NAME", FatherName),                 
                 new SqlParameter("@CLASS", Class),
                 new SqlParameter("@ACADEMIC_YEAR", AcademicYear)

                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetFeeType(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetStudentName(string procedureName, string className, string section)
        {
            SqlParameter[] parameters = {
                //new SqlParameter("@STUDENT_NAME", StudentName),
                 new SqlParameter("@CLASS", className),
                 new SqlParameter("@SECTION", section),
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }
        public DataSet GetFatherName(string procedureName, string StudentName, string className)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@STUDENT_NAME", StudentName),
                 new SqlParameter("@CLASS", className)

                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetSectionDetails(string procedureName,  string className)
        {
            SqlParameter[] parameters = {               
                 new SqlParameter("@CLASS", className)

                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetAllSavedFeeDetails(string procedureName)
        {
            // Assuming you have a stored procedure that filters students based on these parameters

            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public int DeleteFeeDetails(string procedureName, int fee_Id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Fee_Id", fee_Id)
            };
            return UtilityInstance.ExecuteNonQuery(procedureName, parameters);
        }

        public DataSet GenerateFeeTypeReport(string procedureName, string Class, string AcademicYear,string FeeType,DateTime FromDate, DateTime ToDate)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@CLASS", Class),
                new SqlParameter("@ACADEMIC_YEAR", AcademicYear),
                 new SqlParameter("@FEE_TYPE", FeeType),
                 new SqlParameter("@FROM_DATE", FromDate),
                 new SqlParameter("@TO_DATE", ToDate)
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GenerateCollectionTypeReport(string procedureName, string CollectionType, DateTime FromDate, DateTime ToDate)
        {
            SqlParameter[] parameters = {                
                 new SqlParameter("@COLLECTION_TYPE", CollectionType),
                 new SqlParameter("@FROM_DATE", FromDate),
                 new SqlParameter("@TO_DATE", ToDate)
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GenerateExpenseTypeReport(string procedureName, string ExpenseType, DateTime FromDate, DateTime ToDate)
        {
            SqlParameter[] parameters = {
                 new SqlParameter("@EXPENSE_TYPE", ExpenseType),
                 new SqlParameter("@FROM_DATE", FromDate),
                 new SqlParameter("@TO_DATE", ToDate)
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GenerateStudentFeeReport(string procedureName, string Class, string AcademicYear, string section, string studendName)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@CLASS", Class),
                new SqlParameter("@ACADEMIC_YEAR", AcademicYear),
                 new SqlParameter("@SECTION", section),
                 new SqlParameter("@STUDENT_NAME", studendName)
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GenerateClassWiseFeeReport(string procedureName, string Class, string AcademicYear, string section)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@CLASS", Class),
                new SqlParameter("@ACADEMIC_YEAR", AcademicYear),
                 new SqlParameter("@SECTION", section)
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }

        public DataSet GetAmountsForEmailSummary(string procedureName)
        {
            SqlParameter[] parameters = {
                };
            return UtilityInstance.GetDataSet(procedureName, parameters);
        }
    }
}

