﻿using System;
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
    public partial class ClassWiseFeeReportForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        private string? ClassName = string.Empty;
        private string? AcdameicYear = string.Empty;
        private string? Section = string.Empty;
        public ClassWiseFeeReportForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
            GetAcademicYearDetailsForComboBox();
            GetClassDetailsForComboBox();
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFileds();
        }

        private void ClearAllFileds()
        {
            this.ClassComboBox.SelectedValue = string.Empty;
            this.AcademicYearComboBox.SelectedValue = string.Empty;
            this.SectionComboBox.SelectedValue = string.Empty;
            this.SectionComboBox.SelectedText = string.Empty;
            this.SectionComboBox.SelectedValue = string.Empty;
            this.Section = string.Empty;
        }

        private void ClassComboBox_Leave(object sender, EventArgs e)
        {
            this.ClassName = ClassComboBox.SelectedValue.ToString();
            if (this.ClassComboBox.SelectedValue != null && (!string.IsNullOrEmpty(ClassName)))
            {
                GetSectionTypeComboBox();
            }
        }

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SectionComboBox.SelectedValue != null)
            {
                this.Section = SectionComboBox.SelectedValue.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            GetGridData();
        }
        private void GetGridData()
        {
            DataSet dsFeeDatils = new DataSet();
            dsFeeDatils = dbHelper.GenerateClassWiseFeeReport(Common.GenerateClassFeeReportProcedure, ClassName, AcdameicYear, Section);
            if (dsFeeDatils.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dsFeeDatils.Tables[0].DefaultView;
            }
            else
            {

                for (int i = 1; i <= 18; i++)
                {
                    dsFeeDatils.Tables[0].Rows.Add();
                }
                dataGridView1.DataSource = dsFeeDatils.Tables[0].DefaultView;
                // MessageBox.Show("No Data Available for the Selection", "SLN VALIDATIONS", MessageBoxButtons.OK);
            }

        }

    }
}