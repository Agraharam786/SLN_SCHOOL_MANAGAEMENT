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
    public partial class BankTransactionsEntryForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private int TransactionId = 0;
        public BankTransactionsEntryForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetTransactionDetails(false);
            LoadBankSummaryDetails();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            LoadBankSummaryDetails();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int returnValue = 0;
            bool isUpdate = false;
            try
            {
                BankingModel bankingModel = new BankingModel();
                if (this.TransactionId > 0)
                    isUpdate = true;

                int TransactionAmount = Convert.ToInt32(this.bankDepositTextBox.Text.Trim());
                if (this.CollectionFromComboBox.SelectedItem != null && TransactionAmount > 0 && this.SendToComboBox.SelectedItem != null)
                {
                    if (isUpdate)
                    {
                        bankingModel.TransactionId = this.TransactionId;
                    }
                    bankingModel.TransactionFrom = this.CollectionFromComboBox.SelectedItem.ToString();
                    bankingModel.TransactionTo = this.SendToComboBox.SelectedItem.ToString();
                    bankingModel.TransactionAmount = TransactionAmount;
                    bankingModel.DepositedBy = this.senderTextBox.Text.Trim();
                    bankingModel.Description = this.DescTextBox.Text.Trim();
                    bankingModel.TransactionDate = DateTime.ParseExact(dateTimePicker1.Value.ToString("yyyyMMdd"), "yyyyMMdd", CultureInfo.InvariantCulture);
                    returnValue = dbHelper.SaveBankingDataModel(Common.InsertandUpdateBankDetails, bankingModel);
                    if (returnValue == 1)
                        MessageBox.Show("Bank Transaction Amount Saved Sucessfully ", "SLN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTransactionDetails(false);
                    ClearAllFields();
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.TransactionId > 0)
            {
                int returnValue = dbHelper.DeleteBankDetails(Common.DeleteBankDetails, TransactionId);
                if (returnValue == 1)
                    MessageBox.Show("Bank Transaction Amount Deleted Sucessfully !!!", "SLN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GetTransactionDetails(false);
                ClearAllFields();
                LoadBankSummaryDetails();
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();            
            GetTransactionDetails(false);
            LoadBankSummaryDetails();
        }

        private void LoadBankSummaryDetails()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetCollectionSummaryDetails(Common.MonthlyTransactionSummary);
            if (dataSet.Tables.Count > 0)
            {
                summaryDataGridView.DataSource = dataSet.Tables[0].DefaultView;
            }
            else
            {

                summaryDataGridView.DataSource = null;
            }

        }

        private void ClearAllFields()
        {
            // Clear combo boxes
            this.CollectionFromComboBox.SelectedIndex = -1; // Reset selection
            this.SendToComboBox.SelectedIndex = -1; // Reset selection

            // Clear text fields
            this.senderTextBox.Text = string.Empty;
            this.DescTextBox.Text = string.Empty;

            // Reset transaction amount (assuming it's a numeric field)
            this.bankDepositTextBox.Text = string.Empty;

            // Reset date picker to current date
            this.dateTimePicker1.Value = DateTime.Now;
            LoadBankSummaryDetails();
        }

        private void GetTransactionDetails(bool fetchAllData)
        {
            DataSet dsCollectionDetails = new DataSet();
            dsCollectionDetails = dbHelper.GetCollectionDetails(Common.GetBankDetails, fetchAllData);
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
                TransactionId = Convert.ToInt32(row.Cells[0].Value);
                CollectionFromComboBox.SelectedItem = row.Cells[1].Value;
                SendToComboBox.SelectedItem = row.Cells[2].Value;
                this.bankDepositTextBox.Text = row.Cells[3].Value.ToString();
                this.DescTextBox.Text = row.Cells[5].Value.ToString();
                this.senderTextBox.Text = row.Cells[6].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                DeleteButton.Enabled = true;
            }
            else
                DeleteButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTransactionDetails(true);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
