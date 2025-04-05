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
    public partial class MonthlyExpenseSummaryReportForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        public MonthlyExpenseSummaryReportForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            LoadExpenseReportDetails();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadCollectionReportDetails();
        }

        private void LoadExpenseReportDetails()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetCollectionSummaryDetails(Common.MonthlyExpenseSummaryProcedure);
            if (dataSet.Tables.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            LoadExpenseReportDetails();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
