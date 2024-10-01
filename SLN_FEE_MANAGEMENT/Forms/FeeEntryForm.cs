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
    public partial class FeeEntryForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private int UnEditedAmount = 0;
        private int FeeId = 0;
        private int AdmissionId = 0;
        private string? ClassName = string.Empty;
        private string? AcdameicYear = string.Empty;
        private string? FeeType = string.Empty;
        private string? StudentName = string.Empty;
        private string? FatherName = string.Empty;
        private string? Village = string.Empty;
        private string? Gender = string.Empty;
        private string? Mobile_Number = string.Empty;
        private string? Section = string.Empty;
        public FeeEntryForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetAcademicYearDetailsForComboBox();
            GetClassDetailsForComboBox();
            GetFeeTypeComboBox();
            GetAllSavedFeeDetails();
            LoadFeeSummaryDetails();
            this.SaveButton.Enabled = false;
            this.DeleteButton.Enabled = false;
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

        private void GetSectionTypeComboBox()
        {
            DataSet dsSectionType = new DataSet();
            dsSectionType = dbHelper.GetSectionDetails(Common.GetSectionDetails, this.ClassName);
            if (dsSectionType.Tables[0].Rows.Count > 0)
            {
                sectionComboBox.DataSource = dsSectionType.Tables[0].DefaultView;
                sectionComboBox.DisplayMember = dsSectionType.Tables[0].Columns["SECTION"].ToString();
                sectionComboBox.ValueMember = dsSectionType.Tables[0].Columns["SECTION"].ToString();
            }
        }

        private void ClearAllFileds()
        {
            this.FeeId = 0;
            this.ClassComboBox.SelectedValue = string.Empty;
            this.AcademicYearComboBox.SelectedValue = string.Empty;
            this.FeeTypeComboBox.SelectedValue = string.Empty;
            this.sectionComboBox.SelectedValue = string.Empty;
            this.DescriptionTextBox.Text = string.Empty;
            this.AmountTextBox.Text = string.Empty;
            this.dateTimePicker1.Value = DateTime.Now;
            this.StudentNameComboBox.Text = string.Empty;
            this.FatherNameTextBox.Text = string.Empty;
            this.VillageNameTextBox.Text = string.Empty;
            this.BillNoTextBox.Text = string.Empty;
            this.UnEditedAmount = 0;
            this.SaveButton.Enabled = false;
            this.DeleteButton.Enabled = false;
            this.Section = string.Empty;
            LoadFeeSummaryDetails();
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


        private void StudentNameComboBox_TextChanged(object sender, EventArgs e)
        {
            this.StudentName = StudentNameComboBox.Text.ToString().Trim();
            //if (StudentName.Length > 2 && (!string.IsNullOrEmpty(this.ClassName)))
            //{
            //    GetStudentNameComboBox(this.StudentName, this.ClassName);
            //}

        }
        private void GetStudentNameComboBox(string className, string section)
        {
            DataSet dsStudentType = new DataSet();

            dsStudentType = dbHelper.GetStudentName(Common.GetStudentNameProcedure, this.ClassName, this.Section);
            if (dsStudentType.Tables[0].Rows.Count > 0)
            {
                StudentNameComboBox.DataSource = dsStudentType.Tables[0].DefaultView;
                StudentNameComboBox.DisplayMember = dsStudentType.Tables[0].Columns["FIRST_NAME"].ToString();
                StudentNameComboBox.ValueMember = dsStudentType.Tables[0].Columns["FIRST_NAME"].ToString();
            }

        }
        private void LoadFeeSummaryDetails()
        {
            DataSet dataSet = new DataSet();
            dataSet = dbHelper.GetCollectionSummaryDetails(Common.SummaryFeeProcedure);
            if (dataSet.Tables.Count > 0)
            {
                summaryDataGridView.DataSource = dataSet.Tables[0].DefaultView;
            }

        }


        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sectionComboBox.SelectedValue != null)
            {
                this.Section = sectionComboBox.SelectedValue.ToString();
            }

        }

        private void StudentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.StudentNameComboBox.SelectedValue != null)
            {
                this.StudentName = StudentNameComboBox.SelectedValue.ToString();
            }
        }

        private void GetFatherName(string studentName, string className)
        {
            DataSet dsFatherName = new DataSet();
            dsFatherName = dbHelper.GetFatherName(Common.GetFatherNameProcedure, studentName, className);
            if (dsFatherName.Tables[0].Rows.Count > 0)
            {
                this.FatherName = dsFatherName.Tables[0].Rows[0]["FATHER_NAME"].ToString().Trim();
                this.Village = dsFatherName.Tables[0].Rows[0]["VILLAGE_NAME"].ToString().Trim();//FATHER_NAME, A.VILLAGE_NAME
                this.FatherNameTextBox.Text = this.FatherName;
                this.VillageNameTextBox.Text = Village;
                this.Gender = dsFatherName.Tables[0].Rows[0]["GENDER"].ToString().Trim();
                this.Mobile_Number = dsFatherName.Tables[0].Rows[0]["MOBILE_NUM"].ToString().Trim();//A.GENDER,A.MOBILE_NUM
                this.AdmissionId = Convert.ToInt32(dsFatherName.Tables[0].Rows[0]["ADMISION_ID"].ToString());
            }

        }

        private void StudentNameComboBox_Leave(object sender, EventArgs e)
        {
            if (this.StudentNameComboBox.SelectedValue != null && (!string.IsNullOrEmpty(ClassName)))
            {
                this.StudentName = StudentNameComboBox.SelectedValue.ToString();
                GetFatherName(StudentName, this.ClassName);
            }
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            int returnValue = 0;
            bool isUpdate = false;
            try
            {
                FeeModel feeModel = new FeeModel();
                if (this.FeeId > 0)
                    isUpdate = true;

                int feePaidAmount = Convert.ToInt32(this.AmountTextBox.Text.Trim());
                if (feePaidAmount > 0 && (!string.IsNullOrEmpty(this.StudentName) && (!string.IsNullOrEmpty(this.FatherName)) && (!string.IsNullOrEmpty(this.ClassName))))
                {
                    if (isUpdate)
                    {
                        feeModel.CORRECTED_AMOUNT = UnEditedAmount;
                        feeModel.FEE_ID = this.FeeId;
                    }
                    feeModel.CLASS = this.ClassName;
                    feeModel.ACADEMIC_YEAR = this.AcdameicYear;
                    feeModel.FEE_TYPE = this.FeeType;
                    feeModel.STUDENT_NAME = this.StudentName;
                    feeModel.FATHER_NAME = this.FatherName;
                    feeModel.VILLAGE_NAME = this.VillageNameTextBox.Text.Trim();
                    feeModel.GENDER = Gender;
                    feeModel.MOBILE_NUM = this.Mobile_Number;
                    feeModel.PAID_AMOUNT = feePaidAmount;
                    feeModel.BILL_NUMBER = BillNoTextBox.Text.ToString().Trim();
                    feeModel.SECTION = this.Section;
                    feeModel.DESCRIPTION = this.DescriptionTextBox.Text.Trim();
                    feeModel.PAID_DATE = DateTime.ParseExact(dateTimePicker1.Value.ToString("yyyyMMdd"), "yyyyMMdd", CultureInfo.InvariantCulture);
                    feeModel.IS_DELETED = false;
                    feeModel.ADMISSION_ID = AdmissionId;
                    feeModel.CORRECTED_AMOUNT = UnEditedAmount;
                    returnValue = dbHelper.SaveFeeDataModel(Common.InsertandUpdateFeeProcedure, feeModel);
                    if (returnValue == 1)
                        MessageBox.Show("Collection Amount Saved Sucessfully ", "SLN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetFeeDetailsByFilters(StudentName, FatherName, ClassName, AcdameicYear);
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

        private void GetFeeDetailsByFilters(string studentName, string fatherName, string Class, string academicYear)
        {
            DataSet dsFeePaymentDetails = new DataSet();
            dsFeePaymentDetails = dbHelper.GetStudentFeeDetailsByFilters(Common.GetStudentFeeDetailsByFiltersProcedure, studentName, fatherName, Class, academicYear);
            if (dsFeePaymentDetails.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dsFeePaymentDetails.Tables[0].DefaultView;
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    dsFeePaymentDetails.Tables[0].Rows.Add();
                }
                dataGridView1.DataSource = dsFeePaymentDetails.Tables[0].DefaultView;
                // MessageBox.Show("No Data Available for the Selection", "SLN VALIDATIONS", MessageBoxButtons.OK);
            }

        }

        private void GetAllSavedFeeDetails()
        {
            DataSet dsFeePaymentDetails = new DataSet();
            dsFeePaymentDetails = dbHelper.GetAllSavedFeeDetails(Common.GetSavedFeeDetailsProcedure);
            if (dsFeePaymentDetails.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dsFeePaymentDetails.Tables[0].DefaultView;
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    dsFeePaymentDetails.Tables[0].Rows.Add();
                }
                dataGridView1.DataSource = dsFeePaymentDetails.Tables[0].DefaultView;
                // MessageBox.Show("No Data Available for the Selection", "SLN VALIDATIONS", MessageBoxButtons.OK);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.FeeId > 0)
            {
                int returnValue = dbHelper.DeleteFeeDetails(Common.DeleteFeeProcedure, FeeId);
                if (returnValue == 1)
                    MessageBox.Show("Expense Amount Deleted Sucessfully ", "SLN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GetAllSavedFeeDetails();
                ClearAllFileds();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFileds();
            GetAllSavedFeeDetails();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            ClearAllFileds();
            GetAllSavedFeeDetails();
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            if (row != null && (!string.IsNullOrEmpty(row.Cells[0].Value.ToString())))
            {

                FeeId = Convert.ToInt32(row.Cells[0].Value);  //FEE_ID

                this.FeeType = row.Cells[1].Value.ToString();  //FEE_TYPE
                FeeTypeComboBox.SelectedValue = this.FeeType;
                StudentNameComboBox.SelectedText = "";
                StudentName = row.Cells[2].Value.ToString();    //STUDENT_NAME
                StudentNameComboBox.SelectedText = StudentName.ToString();
                StudentNameComboBox.SelectedValue = StudentName.ToString();
                this.FatherName = row.Cells[3].Value.ToString(); //FATHER_NAME
                FatherNameTextBox.Text = this.FatherName;
                this.ClassName = row.Cells[8].Value.ToString(); //CLASS
                ClassComboBox.SelectedValue = this.ClassName;
                this.AcdameicYear = row.Cells[10].Value.ToString();      //ACADEMIC_YEAR
                AcademicYearComboBox.SelectedValue = this.AcdameicYear;
                GetSectionTypeComboBox();
                this.Section= row.Cells[9].Value.ToString().Trim();
                this.sectionComboBox.SelectedValue = this.Section;  //SECTION
                //SectionComboBox.SelectedText = this.Section;
                this.UnEditedAmount = Convert.ToInt32(row.Cells[5].Value.ToString());   //PAID_AMOUNT
                AmountTextBox.Text = row.Cells[5].Value.ToString();     //PAID_AMOUNT
                this.BillNoTextBox.Text = row.Cells[6].Value.ToString();    //BILL_NUMBER
                this.DescriptionTextBox.Text= row.Cells[7].Value.ToString();    //DESCRIPTION
                
                dateTimePicker1.Value = DateTime.Parse(row.Cells[4].Value.ToString());  //PAID_DATE
                this.Village = row.Cells[11].Value.ToString();       //VILLAGE_NAME
                VillageNameTextBox.Text = this.Village;
                AdmissionId = Convert.ToInt32(row.Cells[12].Value.ToString());  //ADMISSION_ID
                this.DeleteButton.Enabled = true;
                this.SaveButton.Enabled = true;
            }
            else
                DeleteButton.Enabled = false;
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.AmountTextBox.Text))
            {
                int FeePaidAmount = Convert.ToInt32(this.AmountTextBox.Text);
                if (FeePaidAmount > 0 && (!string.IsNullOrEmpty(this.StudentName) && (!string.IsNullOrEmpty(this.FatherName)) && (!string.IsNullOrEmpty(this.ClassName))))
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
        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit and not a control key, ignore the input
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClassComboBox_Leave(object sender, EventArgs e)
        {
            this.ClassName = ClassComboBox.SelectedValue.ToString();
            if (this.ClassComboBox.SelectedValue != null && (!string.IsNullOrEmpty(ClassName)))
            {
                GetSectionTypeComboBox();
            }
        }

        private void StudentNameComboBox_Click(object sender, EventArgs e)
        {
            this.ClassName = ClassComboBox.SelectedValue.ToString();
            this.Section = sectionComboBox.SelectedValue.ToString();
            if (this.sectionComboBox.SelectedValue != null && (!string.IsNullOrEmpty(ClassName)))
            {
                GetStudentNameComboBox(this.ClassName, this.Section);
            }
        }
    }
}
