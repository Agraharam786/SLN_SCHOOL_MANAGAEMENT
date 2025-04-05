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
    public partial class FeeCollectionPercentageForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        public FeeCollectionPercentageForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            LoadReportDetails();
        }
        private void LoadReportDetails()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetCollectionSummaryDetails(Common.AllClassFeePredictedAndActualDetails);
            if (dataSet.Tables.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

       

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reloadbutton_Click_1(object sender, EventArgs e)
        {
            LoadReportDetails();
        }
    }
}
