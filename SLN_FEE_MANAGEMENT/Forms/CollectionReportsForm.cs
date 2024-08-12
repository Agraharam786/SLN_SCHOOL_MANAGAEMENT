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
    
    public partial class CollectionReportsForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string? CollectionType = string.Empty;
        public CollectionReportsForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetCollectionTypeComboBox();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            LoadCollectionReportDetails();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFileds();
        }

        private void ClearAllFileds()
        {
            this.CollectionType = string.Empty;
            this.CollectionTypeComboBox.SelectedValue = string.Empty; 
            this.FromdateTimePicker.Value= DateTime.Now;
            this.TodateTimePicker.Value = DateTime.Now;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCollectionReportDetails()
        {
            DataSet dataSet = new DataSet();
            DateTime FromDate = this.FromdateTimePicker.Value.Date;
            DateTime ToDate = this.TodateTimePicker.Value.Date;
            
                dataSet = dbHelper.GenerateCollectionTypeReport(Common.GenerateCollectioneReportProcedure, this.CollectionType, FromDate, ToDate);
                if (dataSet.Tables.Count > 0)
                {
                    dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                    dataGridView1.Columns[0].Width = 150; // Adjust the width as needed for the first column
                    dataGridView1.Columns[1].Width = 200;
                }

        }
        private void GetCollectionTypeComboBox()
        {
            DataSet dsFeeType = new DataSet();
            dsFeeType = dbHelper.GetFeeType(Common.CollectionTypeProcedure);
            if (dsFeeType.Tables[0].Rows.Count > 0)
            {
                CollectionTypeComboBox.DataSource = dsFeeType.Tables[0].DefaultView;
                CollectionTypeComboBox.DisplayMember = dsFeeType.Tables[0].Columns["COLLECTION_TYPE"].ToString();
                CollectionTypeComboBox.ValueMember = dsFeeType.Tables[0].Columns["COLLECTION_TYPE"].ToString();
            }
        }


        private void CollectionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CollectionTypeComboBox.SelectedValue != null)
            {
                this.CollectionType = CollectionTypeComboBox.SelectedValue.ToString();
            }
        }
    }
}
