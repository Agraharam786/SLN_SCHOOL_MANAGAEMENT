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
    public partial class FeeReportsForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string? ClassName = string.Empty;
        private string? AcdameicYear = string.Empty;
        private string? FeeType = string.Empty;
        public FeeReportsForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetAcademicYearDetailsForComboBox();
            GetClassDetailsForComboBox();
            GetFeeTypeComboBox();
        }
        private void GetAcademicYearDetailsForComboBox()
        {
            DataSet dsAcadmicYear = new DataSet();
            dsAcadmicYear = dbHelper.GetDistinctAcademicYears(Common.AcademicYearProcedure);
            if (dsAcadmicYear.Tables[0].Rows.Count > 0)
            {
                AcademicYearComboBox.DataSource = dsAcadmicYear.Tables[0].DefaultView;
                AcademicYearComboBox.DisplayMember = dsAcadmicYear.Tables[0].Columns["ACADEMIC_YEAR"].ToString();
                AcademicYearComboBox.ValueMember = dsAcadmicYear.Tables[0].Columns["ACADEMIC_YEAR"].ToString();
            }
        }

        private void GetFeeTypeComboBox()
        {
            DataSet dsFeeType = new DataSet();
            dsFeeType = dbHelper.GetFeeType(Common.FeeTypeProcedure);
            if (dsFeeType.Tables[0].Rows.Count > 0)
            {
                FeeTypeComboBox.DataSource = dsFeeType.Tables[0].DefaultView;
                FeeTypeComboBox.DisplayMember = dsFeeType.Tables[0].Columns["FEE_TYPE"].ToString();
                FeeTypeComboBox.ValueMember = dsFeeType.Tables[0].Columns["FEE_TYPE"].ToString();
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

        private void LoadFeeReportDetails()
        {
            DataSet dataSet = new DataSet();
            DateTime FromDate = this.FromdateTimePicker.Value.Date;
            DateTime ToDate = this.TodateTimePicker.Value.Date;
            if (!String.IsNullOrEmpty(ClassName) && (!string.IsNullOrEmpty(AcdameicYear)) && (!string.IsNullOrEmpty(FeeType)))
            {
                dataSet = dbHelper.GenerateFeeTypeReport(Common.GenerateFeeTypeReportProcedure, this.ClassName, this.AcdameicYear, this.FeeType, FromDate, ToDate);
                if (dataSet.Tables.Count > 0)
                {
                    dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                }
            }
            else
            {
                MessageBox.Show("Please Provide All Inputs to Generate Report ", "SLN Data Validations", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ClearAllFileds()
        {
            this.FeeTypeComboBox.SelectedValue = string.Empty;
            this.ClassComboBox.SelectedValue = string.Empty;
            this.AcademicYearComboBox.SelectedValue = string.Empty;
            this.FromdateTimePicker.Value = DateTime.Now;
            this.TodateTimePicker.Value = DateTime.Now;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFileds();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            LoadFeeReportDetails();
        }


        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ClassComboBox.SelectedValue != null)
            {
                this.ClassName = ClassComboBox.SelectedValue.ToString();
            }
        }

        private void AcademicYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.AcademicYearComboBox.SelectedValue != null)
            {
                this.AcdameicYear = AcademicYearComboBox.SelectedValue.ToString();
            }
        }

        private void FeeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FeeTypeComboBox.SelectedValue != null)
            {
                this.FeeType = FeeTypeComboBox.SelectedValue.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
