using SLN_FEE_MANAGEMENT.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SLN_FEE_MANAGEMENT
{
    public partial class MainForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string className = String.Empty;
        private string academicYear = String.Empty;
        public MainForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetClassDetailsForComboBox();
            GetAcademicYearDetailsForComboBox();
            GetGridData();
            LoadStudentDetailsSummary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetGridData();
        }
        private void LoadStudentDetailsSummary()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetStudnetDetailsSummaryDetails(Common.SummaryStudentProcedure);
            if (dataSet.Tables.Count > 0)
            {
                summaryDataGridView.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

        private void GetGridData()
        {
            DataSet dsEmployee = new DataSet();
            dsEmployee = dbHelper.GetStudentDetailsByClass(Common.GetStudentDetailsProcedure, className, academicYear);
            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dsEmployee.Tables[0].DefaultView;
            }
            else
            {

                for (int i = 1; i <= 18; i++)
                {
                    dsEmployee.Tables[0].Rows.Add();
                }
                dataGridView1.DataSource = dsEmployee.Tables[0].DefaultView;
                // MessageBox.Show("No Data Available for the Selection", "SLN VALIDATIONS", MessageBoxButtons.OK);
            }

        }

        private void GetClassDetailsForComboBox()
        {
            DataSet dsDistinctClass = new DataSet();
            dsDistinctClass = dbHelper.GetDistinctClass(Common.ClassNamesProcedure);
            if (dsDistinctClass.Tables[0].Rows.Count > 0)
            {

                ClassComboBox.DataSource = dsDistinctClass.Tables[0].DefaultView;
                ClassComboBox.DisplayMember = dsDistinctClass.Tables[0].Columns["CLASS"].ToString();
                ClassComboBox.ValueMember = dsDistinctClass.Tables[0].Columns["CLASS"].ToString();
            }
        }
        private void GetAcademicYearDetailsForComboBox()
        {
            DataSet dsAcadmicYear = new DataSet();
            dsAcadmicYear = dbHelper.GetDistinctClass(Common.AcademicYearProcedure);
            if (dsAcadmicYear.Tables[0].Rows.Count > 0)
            {
                AcademicYearComboBox.DataSource = dsAcadmicYear.Tables[0].DefaultView;
                AcademicYearComboBox.DisplayMember = dsAcadmicYear.Tables[0].Columns["ACADEMIC_YEAR"].ToString();
                AcademicYearComboBox.ValueMember = dsAcadmicYear.Tables[0].Columns["ACADEMIC_YEAR"].ToString();
            }
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.className = ClassComboBox.SelectedValue.ToString();
        }

        private void AcademicYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.academicYear = AcademicYearComboBox.SelectedValue.ToString();
        }

        private void addStudentDetailsMenuItem_Click(object sender, EventArgs e)
        {
            BulkInsertStudentDetails bulkInsertStudentDetails = new BulkInsertStudentDetails();
            bulkInsertStudentDetails.Show();
        }

        private void collectionEntryStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expensesEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void feeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void genereateFeeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeReportsForm feeReportsForm = new FeeReportsForm();
            feeReportsForm.Show();

        }

        private void aDDFEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeEntryForm feeEntryForm = new FeeEntryForm();
            feeEntryForm.Show();
        }

        private void addCollectionEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CollectionEntryForm collectionForm = new CollectionEntryForm();
            collectionForm.Show();
        }

        private void generateCollectionReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CollectionReportsForm collectionReportsForm = new CollectionReportsForm();
            collectionReportsForm.Show();   
        }

        private void addExpenseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseEntryForm expenseEntryForm = new ExpenseEntryForm();
            expenseEntryForm.Show();
        }

        private void generateExpenseReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseReportsForm expenseReportsForm = new ExpenseReportsForm();
            expenseReportsForm.Show();
        }
    }
}
