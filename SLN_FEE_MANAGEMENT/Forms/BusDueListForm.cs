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
    public partial class BusDueListForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string? AcademicYear = string.Empty;
        private string? Section = string.Empty;
        private string? ClassName = string.Empty;
        public BusDueListForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetClassDetailsForComboBox();
            GetAcademicYearDetailsForComboBox();
            GetSectionTypeComboBox();
            LoadDefaultView();

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
        private void GetAcademicYearDetailsForComboBox()
        {
            DataSet dsAcadmicYear = new DataSet();
            dsAcadmicYear = dbHelper.GetDistinctClass(Common.AcademicYearProcedure);
            if (dsAcadmicYear.Tables[0].Rows.Count > 0)
            {
                AcademicYearComboBox.DataSource = dsAcadmicYear.Tables[0].DefaultView;
                AcademicYearComboBox.DisplayMember = dsAcadmicYear.Tables[0].Columns["ACADEMIC_YEAR"].ToString();
                AcademicYearComboBox.ValueMember = dsAcadmicYear.Tables[0].Columns["ACADEMIC_YEAR"].ToString();
            }
        }

        private void GetSectionTypeComboBox()
        {
            DataSet dsSectionType = new DataSet();
            dsSectionType = dbHelper.GetSectionDetails(Common.GetSectionDetails, this.ClassName);
            if (dsSectionType.Tables[0].Rows.Count > 0)
            {
                SectionComboBox.DataSource = dsSectionType.Tables[0].DefaultView;
                SectionComboBox.DisplayMember = dsSectionType.Tables[0].Columns["SECTION"].ToString();
                SectionComboBox.ValueMember = dsSectionType.Tables[0].Columns["SECTION"].ToString();
            }
        }
        private void ClassComboBox_Leave(object sender, EventArgs e)
        {
            this.ClassName = ClassComboBox.SelectedValue.ToString();
            if (this.ClassComboBox.SelectedValue != null && (!string.IsNullOrEmpty(ClassName)))
            {
                GetSectionTypeComboBox();
            }
        }
        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClassName = ClassComboBox.SelectedValue.ToString();
        }

        private void AcademicYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.AcademicYear = AcademicYearComboBox.SelectedValue.ToString();
        }

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SectionComboBox.SelectedValue != null)
            {
                this.Section = SectionComboBox.SelectedValue.ToString();
            }

        }
        private void LoadReportDetails()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetCollectionSummaryDetails(Common.GetBusFeeDetails);//GetDefaultBusFeeDetails
            if (dataSet.Tables.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                MessageBox.Show("Bus Due List Reloaded for all Classes !","Data Load",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                for (int i = 1; i <= 18; i++)
                {
                    dataSet.Tables[0].Rows.Add();
                }
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

        private void LoadDefaultView()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetCollectionSummaryDetails(Common.GetDefaultBusFeeDetails);
            if (dataSet.Tables.Count > 1)
            {
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }
            else
            {

                for (int i = 1; i <= 18; i++)
                {
                    dataSet.Tables[0].Rows.Add();
                }
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

        private void LoadClassView()
        {
            DataSet dataSet = new DataSet();
            this.ClassName = this.ClassComboBox.SelectedValue.ToString();
            this.AcademicYear=this.AcademicYearComboBox.SelectedValue.ToString();
            this.Section = this.SectionComboBox.SelectedValue.ToString();
            dataSet = dbHelper.GetStudentDetailsByClass(Common.GetBusFeeDetails, ClassName, AcademicYear, Section);
            if (dataSet.Tables.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }
            else
            {

                for (int i = 1; i <= 18; i++)
                {
                    dataSet.Tables[0].Rows.Add();
                }
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }

        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            LoadReportDetails();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadClassView();
        }
    }
}
