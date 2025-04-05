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
    public partial class CollectionEntryForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string CollectionType = String.Empty;
        private int CollectionId = 0;
        private int UnEditedAmount = 0;
        public CollectionEntryForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetCollectionTypeComboBox();
            GetCollectionDetails(false);
            LoadCollectionSummaryDetails();
            this.SaveButton.Enabled = false;
            this.DeleteButton.Enabled = false;
        }

        private void GetCollectionTypeComboBox()
        {
            DataSet dsDistinctClass = new DataSet();
            dsDistinctClass = dbHelper.GetDistinctClass(Common.CollectionTypeProcedure);
            if (dsDistinctClass.Tables[0].Rows.Count > 0)
            {
                CollectionTypeComboBox.DataSource = dsDistinctClass.Tables[0].DefaultView;
                CollectionTypeComboBox.DisplayMember = dsDistinctClass.Tables[0].Columns["COLLECTION_TYPE"].ToString();
                CollectionTypeComboBox.ValueMember = dsDistinctClass.Tables[0].Columns["COLLECTION_TYPE"].ToString();
            }
        }

        private void CollectionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CollectionTypeComboBox.SelectedValue != null)
            {
                this.DeleteButton.Enabled = true;
                this.CollectionType = CollectionTypeComboBox.SelectedValue.ToString();
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
                CollectionModel collectionModel = new CollectionModel();
                if (this.CollectionId > 0)
                    isUpdate = true;

                int CollectionAmount = Convert.ToInt32(this.AmountTextBox.Text.Trim());
                if (this.CollectionTypeComboBox.SelectedValue != null && CollectionAmount > 0)
                {
                    if (isUpdate)
                    {
                        collectionModel.CorrectedAmount = UnEditedAmount;
                        collectionModel.CollectionId = this.CollectionId;
                    }
                    collectionModel.CollectionType = this.CollectionTypeComboBox.SelectedValue.ToString();
                    collectionModel.Description = this.DescTextBox.Text.Trim();
                    collectionModel.CollectionAmount = CollectionAmount;
                    collectionModel.BankDepositAmount = string.IsNullOrEmpty(this.bankDepositTextBox.Text) ? 0 : Convert.ToInt32(this.bankDepositTextBox.Text);  //Convert.ToInt32(this.bankDepositTextBox.Text.Trim());
                    //collectionModel.Incash = Convert.ToInt32(this.InCashTextBox.Text.Trim());
                    collectionModel.Incash = string.IsNullOrEmpty(this.bankDepositTextBox.Text) || this.bankDepositTextBox.Text == "0"? CollectionAmount : Convert.ToInt32(this.InCashTextBox.Text.Trim());
                    collectionModel.EntryDate = DateTime.ParseExact(dateTimePicker1.Value.ToString("yyyyMMdd"), "yyyyMMdd", CultureInfo.InvariantCulture);
                    collectionModel.IsDeleted = false;

                    returnValue = dbHelper.SaveCollectionDataModel(Common.InsertandUpdateCollectionProcedure, collectionModel);
                    if (returnValue == 1)
                        MessageBox.Show("Collection Amount Saved Sucessfully ", "SLN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetCollectionDetails(false);
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
            this.CollectionTypeComboBox.SelectedValue = string.Empty; ;
            this.DescTextBox.Text = string.Empty;
            this.AmountTextBox.Text = string.Empty;
            this.dateTimePicker1.Value = DateTime.Now;
            this.UnEditedAmount = 0;
            this.CollectionId = 0;
            this.SaveButton.Enabled = false;
            this.DeleteButton.Enabled = false;
            this.bankDepositTextBox.Text = "0";
            this.InCashTextBox.Text = string.Empty;
            LoadCollectionSummaryDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllFileds();
        }

        private void GetCollectionDetails(bool fetchAllData)
        {
            DataSet dsCollectionDetails = new DataSet();
            dsCollectionDetails = dbHelper.GetCollectionDetails(Common.GetCollectionDetailsProcedure, fetchAllData);
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
                CollectionId = Convert.ToInt32(row.Cells[0].Value);
                CollectionTypeComboBox.SelectedValue = row.Cells[1].Value;
                UnEditedAmount = Convert.ToInt32(row.Cells[2].Value.ToString());
                this.bankDepositTextBox.Text= row.Cells[3].Value.ToString();
                this.InCashTextBox.Text = row.Cells[4].Value.ToString();
                DescTextBox.Text = row.Cells[5].Value.ToString();
                AmountTextBox.Text = UnEditedAmount.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[6].Value.ToString());
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
                if (collectionAmount > 0 && this.CollectionTypeComboBox.SelectedValue != null)
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
            GetCollectionDetails(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.CollectionId > 0)
            {
                int returnValue = dbHelper.DeleteCollectionDetails(Common.DeleteCollectionProcedure, CollectionId);
                if (returnValue == 1)
                    MessageBox.Show("Collection Amount Deleted Sucessfully !!!", "SLN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GetCollectionDetails(false);
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

        private void LoadCollectionSummaryDetails()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetCollectionSummaryDetails(Common.SummaryCollectionProcedure);
            if (dataSet.Tables.Count > 0)
            {
                summaryDataGridView.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bankDepositTextBox_Leave(object sender, EventArgs e)
        {
            int collectionAmount = (Convert.ToInt32(this.AmountTextBox.Text));

            if (!string.IsNullOrEmpty(this.AmountTextBox.Text) && (Convert.ToInt32(this.AmountTextBox.Text) > 0))
            {
                int bankDepositedAmount = string.IsNullOrEmpty(this.bankDepositTextBox.Text) ? 0 : Convert.ToInt32(this.bankDepositTextBox.Text); 
                
                if(bankDepositedAmount>collectionAmount)
                    MessageBox.Show("Deposit Amount is greater than Collection Amount ", "Validation Message", MessageBoxButtons.OK);
                else
                    this.InCashTextBox.Text = ((collectionAmount) - (bankDepositedAmount)).ToString();
            }
            else
            {
                MessageBox.Show("Enter valid collection amount before you submit to bank! ", "Validation Message", MessageBoxButtons.OK);
            }
        }
    }
}
