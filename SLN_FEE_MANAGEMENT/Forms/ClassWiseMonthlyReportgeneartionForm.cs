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
    public partial class ClassWiseMonthlyReportgeneartionForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        public ClassWiseMonthlyReportgeneartionForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            LoadClassWiseMonthlyFeeReportDetails();
        }

        private void LoadClassWiseMonthlyFeeReportDetails()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetCollectionSummaryDetails(Common.ClassandMonthlyFeeSummaryProcedure);
            if (dataSet.Tables.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            LoadClassWiseMonthlyFeeReportDetails();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
