using SLN_FEE_MANAGEMENT.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SLN_FEE_MANAGEMENT
{
    public partial class MainForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string className = String.Empty;
        private string academicYear = String.Empty;
        private string? Section = string.Empty;
        private string? ClassName = string.Empty;
        DataSet dsEmployee = new DataSet();
        DataSet dsClassSummary = new DataSet();
        DataSet dsPaidPercentageSummary = new DataSet();
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int index = e.RowIndex;
        //    DataGridViewRow row = dataGridView1.Rows[index];
        //    if (row != null && (!string.IsNullOrEmpty(row.Cells[0].Value.ToString())))
        //    {
        //        ExpenseId = Convert.ToInt32(row.Cells[0].Value);
        //        UnEditedAmount = Convert.ToInt32(row.Cells[3].Value.ToString());
        //        ExpenseTypeComboBox.SelectedValue = row.Cells[1].Value;
        //        DescTextBox.Text = row.Cells[2].Value.ToString();
        //        AmountTextBox.Text = UnEditedAmount.ToString();
        //        dateTimePicker1.Value = DateTime.Parse(row.Cells[4].Value.ToString());
        //        DeleteButton.Enabled = true;
        //    }
        //    else
        //        DeleteButton.Enabled = false;
        //}
        private void GetGridData()
        {
            dsEmployee = dbHelper.GetStudentDetailsByClass(Common.GetStudentDetailsProcedure, className, academicYear, Section);
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

            dsClassSummary = dbHelper.GetStudentDetailsByClass(Common.ClassWiseLast5MonthsFeePaidSummary, className, academicYear, Section);
            if (dsClassSummary.Tables[0].Rows.Count > 0)
            {
                dataGridView2.DataSource = dsClassSummary.Tables[0].DefaultView;
            }
            else
            {

                for (int i = 1; i <= 2; i++)
                {
                    dsClassSummary.Tables[0].Rows.Add();
                }
                dataGridView2.DataSource = dsClassSummary.Tables[0].DefaultView;
            }

            dsPaidPercentageSummary = dbHelper.GetStudentDetailsByClass(Common.ClassWiseFeePredictedAndActualDetails, className, academicYear, Section);
            if (dsPaidPercentageSummary.Tables[0].Rows.Count > 0)
            {
                dataGridView3.DataSource = dsPaidPercentageSummary.Tables[0].DefaultView;
            }
            else
            {

                for (int i = 1; i <= 1; i++)
                {
                    dsPaidPercentageSummary.Tables[0].Rows.Add();
                }
                dataGridView3.DataSource = dsPaidPercentageSummary.Tables[0].DefaultView;
            }
        }

        //private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{            
        //    if (dsEmployee.Tables[0].Rows.Count > 0)
        //    {
        //        // Assuming "TOTAL_PAID_AMOUNT" is the name of the column in your DataGridView
        //        var grid = sender as DataGridView;

        //        // Get the value of the TOTAL_PAID_AMOUNT from the current row
        //        var totalPaidAmountValue = grid.Rows[e.RowIndex].Cells["FEE_PAID_PERCENTAGE"].Value;

        //        // Ensure that the value is not null and is a number
        //        if (totalPaidAmountValue != null && decimal.TryParse(totalPaidAmountValue.ToString(), out decimal totalPaidAmount))
        //        {
        //            // Apply color based on the amount
        //            if (totalPaidAmount == 0)
        //            {
        //                // Set row background color to red for unpaid students
        //                grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
        //            }
        //            else if (totalPaidAmount < 30)
        //            {
        //                // Set row background color to orange for amounts less than 5000
        //                grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        //            }
        //            else if (totalPaidAmount >= 5000 && totalPaidAmount <= 10000)
        //            {
        //                // Set row background color to yellow for amounts between 5000 and 10000
        //                grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
        //            }
        //            else
        //            {
        //                // Set default color for amounts greater than 10000
        //                grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
        //            }
        //        }
        //    }
        //}

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dsEmployee.Tables[0].Rows.Count > 0)
            {
                var grid = sender as DataGridView;

                // Get the value of the FEE_PAID_PERCENTAGE from the current row
                var feePaidPercentageValue = grid.Rows[e.RowIndex].Cells["FEE_PAID_PERCENTAGE"].Value;

                // Ensure that the value is not null and is a number
                if (feePaidPercentageValue != null && decimal.TryParse(feePaidPercentageValue.ToString(), out decimal feePaidPercentage))
                {
                    // Apply color based on the fee paid percentage
                    if (feePaidPercentage < 30)
                    {
                        // Set row background color to light red for very low payment
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed; // Light red
                    }
                    else if (feePaidPercentage >= 30 && feePaidPercentage < 50)
                    {
                        // Set row background color to yellow for low payment
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange; // Yellow
                    }
                    else if (feePaidPercentage >= 50 && feePaidPercentage < 80)
                    {
                        // Set row background color to orange for average payment
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue; // Orange
                    }
                    else if (feePaidPercentage >= 80 && feePaidPercentage < 100)
                    {
                        // Set row background color to light green for good payment
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; // Light green
                    }
                    else if (feePaidPercentage == 100)
                    {
                        // Normal payment; keep the default color (no change needed)
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Default color (white)
                    }
                    else
                    {
                        // Handle cases where there is no data (optional)
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray; // Gray for no data
                    }
                }
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

        private void GetSectionTypeComboBox()
        {
            DataSet dsSectionType = new DataSet();
            dsSectionType = dbHelper.GetSectionDetails(Common.GetSectionDetails, this.ClassName);
            if (dsSectionType.Tables[0].Rows.Count > 0)
            {
                SectionComboBox.DataSource = dsSectionType.Tables[0].DefaultView;
                SectionComboBox.DisplayMember = dsSectionType.Tables[0].Columns["SECTION"].ToString();
                SectionComboBox.ValueMember = dsSectionType.Tables[0].Columns["SECTION"].ToString();
            }
        }
        private void ClassComboBox_Leave(object sender, EventArgs e)
        {
            this.ClassName = ClassComboBox.SelectedValue.ToString();
            if (this.ClassComboBox.SelectedValue != null && (!string.IsNullOrEmpty(ClassName)))
            {
                GetSectionTypeComboBox();
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

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SectionComboBox.SelectedValue != null)
            {
                this.Section = SectionComboBox.SelectedValue.ToString();
            }

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

        private void generateFeeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateStudendFeeReportForm generateStudendFeeReportForm = new GenerateStudendFeeReportForm();
            generateStudendFeeReportForm.Show();
        }

        private void classWiseFeeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassWiseFeeReportForm classWiseFeeReportForm = new ClassWiseFeeReportForm();
            classWiseFeeReportForm.Show();
        }

        private void eMAILNOTIFICATIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailForm email = new EmailForm();
            email.Show();
        }

        private void monthlyCollectionSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyCollectionReportForm monthlyCollectionReportForm = new MonthlyCollectionReportForm();
            monthlyCollectionReportForm.Show();

        }

        private void monthlyExpenseSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyExpenseSummaryReportForm monthlyExpenseSummaryReport = new MonthlyExpenseSummaryReportForm();
            monthlyExpenseSummaryReport.Show();
        }

        private void monthlyFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyFeeSummaryReportForm monthlyFeeSummaryReportForm = new MonthlyFeeSummaryReportForm();
            monthlyFeeSummaryReportForm.Show();
        }

        private void classWiseMonthlySummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassWiseMonthlyReportgeneartionForm classWiseMonthlyReportgeneartionForm = new ClassWiseMonthlyReportgeneartionForm();
            classWiseMonthlyReportgeneartionForm.Show();
        }

        private void bankTransactionsEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankTransactionsEntryForm bankTransactionsEntryForm = new BankTransactionsEntryForm();
            bankTransactionsEntryForm.Show();
        }

        private void studentReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void feeCollectionPercentageReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeCollectionPercentageForm feeCollectionPercentageForm = new FeeCollectionPercentageForm();
            feeCollectionPercentageForm.Show();
        }

        private void feeDueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeDueList feeDueList = new FeeDueList();
            feeDueList.Show();
        }

        private void verifyCollectionToFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Collection_Fee_VerificationForm verificationForm = new Collection_Fee_VerificationForm();
            verificationForm.Show();
        }

        private void busDueListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusDueListForm busDueListForm = new BusDueListForm();
            busDueListForm.Show();
        }

        private void discountEntryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountForm discountForm = new DiscountForm();
            discountForm.Show();
        }
    }
}
