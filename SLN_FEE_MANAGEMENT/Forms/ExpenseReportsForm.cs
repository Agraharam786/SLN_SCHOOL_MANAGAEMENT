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
    public partial class ExpenseReportsForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string? ExpenseType = string.Empty;
        public ExpenseReportsForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetExpenseTypeComboBox();
        }

        private void LoadExpenseReportDetails()
        {
            DataSet dataSet = new DataSet();
            DateTime FromDate = this.FromdateTimePicker.Value.Date;
            DateTime ToDate = this.TodateTimePicker.Value.Date;

            dataSet = dbHelper.GenerateExpenseTypeReport(Common.GenerateExpenseReportProcedure, this.ExpenseType, FromDate, ToDate);
            if (dataSet.Tables.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                dataGridView1.Columns[0].Width = 150; // Adjust the width as needed for the first column
                dataGridView1.Columns[1].Width = 200;
            }

        }
        private void GetExpenseTypeComboBox()
        {
            DataSet dsFeeType = new DataSet();
            dsFeeType = dbHelper.GetFeeType(Common.ExpenseTypeProcedure);
            if (dsFeeType.Tables[0].Rows.Count > 0)
            {
                ExpenseTypeComboBox.DataSource = dsFeeType.Tables[0].DefaultView;
                ExpenseTypeComboBox.DisplayMember = dsFeeType.Tables[0].Columns["EXPENSE_TYPE"].ToString();
                ExpenseTypeComboBox.ValueMember = dsFeeType.Tables[0].Columns["EXPENSE_TYPE"].ToString();
            }
        }

        private void ClearAllFileds()
        {
            this.ExpenseType = string.Empty;
            this.ExpenseTypeComboBox.SelectedValue = string.Empty;
            this.FromdateTimePicker.Value = DateTime.Now;
            this.TodateTimePicker.Value = DateTime.Now;

        }
        private void ExpenseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ExpenseTypeComboBox.SelectedValue != null)
            {
                this.ExpenseType = ExpenseTypeComboBox.SelectedValue.ToString();
            }
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            LoadExpenseReportDetails();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFileds();   
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
