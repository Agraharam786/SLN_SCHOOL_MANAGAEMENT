using SLN_FEE_MANAGEMENT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLN_FEE_MANAGEMENT.Forms
{
    public partial class ExpenseEntryForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string ExpenseType = String.Empty;
        private string ExpenseFrom = String.Empty;
        private int ExpenseId = 0;
        private int UnEditedAmount = 0;
        public ExpenseEntryForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetExpenseTypeComboBox();
            GetExpenseDetails(false);
            LoadExpenseSummaryDetails();
            this.SaveButton.Enabled = false;
            this.DeleteButton.Enabled = false;
        }

        private void GetExpenseTypeComboBox()
        {
            DataSet dsDistinctClass = new DataSet();
            dsDistinctClass = dbHelper.GetDistinctClass(Common.ExpenseTypeProcedure);
            if (dsDistinctClass.Tables[0].Rows.Count > 0)
            {
                ExpenseTypeComboBox.DataSource = dsDistinctClass.Tables[0].DefaultView;
                ExpenseTypeComboBox.DisplayMember = dsDistinctClass.Tables[0].Columns["EXPENSE_TYPE"].ToString();
                ExpenseTypeComboBox.ValueMember = dsDistinctClass.Tables[0].Columns["EXPENSE_TYPE"].ToString();
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int returnValue = 0;
            bool isUpdate = false;
            try
            {
                ExpenseModel expeseModel = new ExpenseModel();
                if (this.ExpenseId > 0)
                    isUpdate = true;

                int ExpenseAmount = Convert.ToInt32(this.AmountTextBox.Text.Trim());
                if (this.ExpenseTypeComboBox.SelectedValue != null && ExpenseAmount > 0)
                {
                    if (isUpdate)
                    {
                        expeseModel.ExpCorrectedAmount = UnEditedAmount;
                        expeseModel.ExpenseId = this.ExpenseId;
                    }
                    expeseModel.ExpenseType = this.ExpenseTypeComboBox.SelectedValue.ToString();
                    expeseModel.ExpenseFrom = this.ExpenseFromComboBox.SelectedItem.ToString();
                    expeseModel.Description = this.DescTextBox.Text.Trim();
                    expeseModel.ExpenseAmount = ExpenseAmount;
                    expeseModel.EntryDate = DateTime.ParseExact(dateTimePicker1.Value.ToString("yyyyMMdd"), "yyyyMMdd", CultureInfo.InvariantCulture);
                    expeseModel.IsDeleted = false;

                    returnValue = dbHelper.SaveExpenseDataModel(Common.InsertandUpdateExpenseProcedure, expeseModel);
                    if (returnValue == 1)
                        MessageBox.Show("Expense Amount Saved Sucessfully ", "SLN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetExpenseDetails(false);
                    ClearAllFileds();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Data ", "SLN Data Validations", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured while Saving the Data", "SLN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFileds();
        }

        private void ClearAllFileds()
        {
            this.ExpenseTypeComboBox.SelectedValue = string.Empty;
            this.ExpenseFromComboBox.SelectedValue = string.Empty;
            this.DescTextBox.Text = string.Empty;
            this.AmountTextBox.Text = string.Empty;
            this.dateTimePicker1.Value = DateTime.Now;
            this.UnEditedAmount = 0;
            this.ExpenseId = 0;
            this.SaveButton.Enabled = false;
            this.DeleteButton.Enabled = false;
            LoadExpenseSummaryDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllFileds();
        }

        private void GetExpenseDetails(bool fetchAllData)
        {
            DataSet dsCollectionDetails = new DataSet();
            dsCollectionDetails = dbHelper.GetExpenseDetails(Common.GetExpensenDetailsProcedure, fetchAllData);
            if (dsCollectionDetails.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dsCollectionDetails.Tables[0].DefaultView;
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    dsCollectionDetails.Tables[0].Rows.Add();
                }
                dataGridView1.DataSource = dsCollectionDetails.Tables[0].DefaultView;
                // MessageBox.Show("No Data Available for the Selection", "SLN VALIDATIONS", MessageBoxButtons.OK);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            if (row != null && (!string.IsNullOrEmpty(row.Cells[0].Value.ToString())))
            {
                ExpenseId = Convert.ToInt32(row.Cells[0].Value);
                ExpenseFromComboBox.SelectedValue = row.Cells[1].Value;
                ExpenseTypeComboBox.SelectedValue = row.Cells[2].Value;
                DescTextBox.Text = row.Cells[3].Value.ToString();
                UnEditedAmount = Convert.ToInt32(row.Cells[4].Value.ToString());
                dateTimePicker1.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                AmountTextBox.Text = UnEditedAmount.ToString();
                DeleteButton.Enabled = true;
            }
            else
                DeleteButton.Enabled = false;
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.AmountTextBox.Text))
            {
                int collectionAmount = Convert.ToInt32(this.AmountTextBox.Text);
                if (collectionAmount > 0 && this.ExpenseTypeComboBox.SelectedValue != null)
                {
                    this.SaveButton.Enabled = true;
                    this.DeleteButton.Enabled = true;
                }
            }
            else
            {
                this.SaveButton.Enabled = false;
                this.DeleteButton.Enabled = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetExpenseDetails(true);
        }

        private void ExpenseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ExpenseTypeComboBox.SelectedValue != null)
            {
                this.SaveButton.Enabled = true;
                this.ExpenseType = ExpenseTypeComboBox.SelectedValue.ToString();
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.ExpenseId > 0)
            {
                int returnValue = dbHelper.DeleteExpenseDetails(Common.DeleteExpenseProcedure, ExpenseId);
                if (returnValue == 1)
                    MessageBox.Show("Expense Amount Deleted Sucessfully ", "SLN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GetExpenseDetails(false);
                ClearAllFileds();
            }
        }

        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit and not a control key, ignore the input
                e.Handled = true;
            }
        }

        private void LoadExpenseSummaryDetails()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetExpenseSummaryDetails(Common.SummaryExpenseProcedure);
            if (dataSet.Tables.Count > 0)
            {
                summaryDataGridView.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExpenseFromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ExpenseFromComboBox.SelectedItem != null)
            {
                this.ExpenseFrom = ExpenseFromComboBox.SelectedItem.ToString();
            }
        }

        private void ExpenseEntryForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
