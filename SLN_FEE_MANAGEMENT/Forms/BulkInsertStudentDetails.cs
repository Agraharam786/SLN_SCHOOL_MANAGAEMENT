using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLN_FEE_MANAGEMENT.Forms
{
    public partial class BulkInsertStudentDetails : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string filePath = String.Empty;
        public BulkInsertStudentDetails()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties for OpenFileDialog
            openFileDialog.Title = "Select a CSV File";
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog.FileName;

                // Do something with the selected file path, e.g., display it in a TextBox
                FilePathTextBox.Text = selectedFilePath;
                filePath = FilePathTextBox.Text.Trim();
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            dbHelper.PerformBulkInsert(Common.BulkInsertProcedure, filePath);
            GetInsertedData();
        }

        public void GetInsertedData()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetBulkInsertedData(Common.GetBulkInsertDataProcedure);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("No Data Loaded From CSV File ", "SLN VALIDATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Submit The Loaded Data ?", "SLN CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Process the result
                if (result == DialogResult.Yes)
                {
                    int rowInserted = dbHelper.LoadDataToTargetTable(Common.TargetTableLoadProcedure);
                    // User clicked Yes
                    MessageBox.Show(" Row(s) Inserted Sucessfully. ", "SLN INFORMATION ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Perform your action here
                }
                else
                {
                    // User clicked No
                    MessageBox.Show("User clicked No. Canceling action...", "SLN INFORMATION ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Perform your action or handle cancellation here
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SLN ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
