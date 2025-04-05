
namespace SLN_FEE_MANAGEMENT
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            addStudentDetailsMenuItem = new ToolStripMenuItem();
            collectionEntryStripMenuItem = new ToolStripMenuItem();
            generateCollectionReportsToolStripMenuItem = new ToolStripMenuItem();
            addCollectionEntryToolStripMenuItem = new ToolStripMenuItem();
            monthlyCollectionSummaryReportToolStripMenuItem = new ToolStripMenuItem();
            bankTransactionsEntryToolStripMenuItem = new ToolStripMenuItem();
            expensesEntryToolStripMenuItem = new ToolStripMenuItem();
            generateExpenseReportsToolStripMenuItem = new ToolStripMenuItem();
            addExpenseEntryToolStripMenuItem = new ToolStripMenuItem();
            monthlyExpenseSummaryReportToolStripMenuItem = new ToolStripMenuItem();
            feeReportsToolStripMenuItem = new ToolStripMenuItem();
            genereateFeeReportsToolStripMenuItem = new ToolStripMenuItem();
            aDDFEEToolStripMenuItem = new ToolStripMenuItem();
            monthlyFToolStripMenuItem = new ToolStripMenuItem();
            classWiseMonthlySummaryReportToolStripMenuItem = new ToolStripMenuItem();
            studentReportsToolStripMenuItem = new ToolStripMenuItem();
            generateFeeReportsToolStripMenuItem = new ToolStripMenuItem();
            classWiseFeeReportsToolStripMenuItem = new ToolStripMenuItem();
            feeCollectionPercentageReportsToolStripMenuItem = new ToolStripMenuItem();
            feeDueReportToolStripMenuItem = new ToolStripMenuItem();
            busFeeDetailsToolStripMenuItem = new ToolStripMenuItem();
            busDueListToolStripMenuItem = new ToolStripMenuItem();
            nOTIFICATIONSToolStripMenuItem = new ToolStripMenuItem();
            eMAILNOTIFICATIONSToolStripMenuItem = new ToolStripMenuItem();
            vERIFICATIONSToolStripMenuItem = new ToolStripMenuItem();
            verifyCollectionToFeeToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            ClassComboBox = new ComboBox();
            AcademicYearComboBox = new ComboBox();
            label10 = new Label();
            summaryDataGridView = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            SectionComboBox = new ComboBox();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            dataGridView3 = new DataGridView();
            discountEntryFormToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(778, 100);
            button1.Name = "button1";
            button1.Size = new Size(95, 32);
            button1.TabIndex = 0;
            button1.Text = "Get Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1271, 394);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSeaGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { addStudentDetailsMenuItem, collectionEntryStripMenuItem, expensesEntryToolStripMenuItem, feeReportsToolStripMenuItem, studentReportsToolStripMenuItem, busFeeDetailsToolStripMenuItem, nOTIFICATIONSToolStripMenuItem, vERIFICATIONSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1346, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // addStudentDetailsMenuItem
            // 
            addStudentDetailsMenuItem.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addStudentDetailsMenuItem.ForeColor = Color.Red;
            addStudentDetailsMenuItem.Name = "addStudentDetailsMenuItem";
            addStudentDetailsMenuItem.Size = new Size(214, 27);
            addStudentDetailsMenuItem.Text = "ADD STUDENT DETAILS";
            addStudentDetailsMenuItem.ToolTipText = "To Bulk Insert Student Details From Excel";
            addStudentDetailsMenuItem.Click += addStudentDetailsMenuItem_Click;
            // 
            // collectionEntryStripMenuItem
            // 
            collectionEntryStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateCollectionReportsToolStripMenuItem, addCollectionEntryToolStripMenuItem, monthlyCollectionSummaryReportToolStripMenuItem, bankTransactionsEntryToolStripMenuItem });
            collectionEntryStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            collectionEntryStripMenuItem.ForeColor = Color.Red;
            collectionEntryStripMenuItem.Name = "collectionEntryStripMenuItem";
            collectionEntryStripMenuItem.Size = new Size(171, 27);
            collectionEntryStripMenuItem.Text = "COLLECTION ENTRY";
            collectionEntryStripMenuItem.ToolTipText = "To Add Collection Details";
            collectionEntryStripMenuItem.Click += collectionEntryStripMenuItem_Click;
            // 
            // generateCollectionReportsToolStripMenuItem
            // 
            generateCollectionReportsToolStripMenuItem.Name = "generateCollectionReportsToolStripMenuItem";
            generateCollectionReportsToolStripMenuItem.Size = new Size(350, 26);
            generateCollectionReportsToolStripMenuItem.Text = "Generate Collection Reports";
            generateCollectionReportsToolStripMenuItem.Click += generateCollectionReportsToolStripMenuItem_Click;
            // 
            // addCollectionEntryToolStripMenuItem
            // 
            addCollectionEntryToolStripMenuItem.Name = "addCollectionEntryToolStripMenuItem";
            addCollectionEntryToolStripMenuItem.Size = new Size(350, 26);
            addCollectionEntryToolStripMenuItem.Text = "Add Collection Entry";
            addCollectionEntryToolStripMenuItem.Click += addCollectionEntryToolStripMenuItem_Click;
            // 
            // monthlyCollectionSummaryReportToolStripMenuItem
            // 
            monthlyCollectionSummaryReportToolStripMenuItem.Name = "monthlyCollectionSummaryReportToolStripMenuItem";
            monthlyCollectionSummaryReportToolStripMenuItem.Size = new Size(350, 26);
            monthlyCollectionSummaryReportToolStripMenuItem.Text = "Monthly Collection Summary Report";
            monthlyCollectionSummaryReportToolStripMenuItem.Click += monthlyCollectionSummaryReportToolStripMenuItem_Click;
            // 
            // bankTransactionsEntryToolStripMenuItem
            // 
            bankTransactionsEntryToolStripMenuItem.Name = "bankTransactionsEntryToolStripMenuItem";
            bankTransactionsEntryToolStripMenuItem.Size = new Size(350, 26);
            bankTransactionsEntryToolStripMenuItem.Text = "Bank Transactions Entry";
            bankTransactionsEntryToolStripMenuItem.Click += bankTransactionsEntryToolStripMenuItem_Click;
            // 
            // expensesEntryToolStripMenuItem
            // 
            expensesEntryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateExpenseReportsToolStripMenuItem, addExpenseEntryToolStripMenuItem, monthlyExpenseSummaryReportToolStripMenuItem });
            expensesEntryToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            expensesEntryToolStripMenuItem.ForeColor = Color.Red;
            expensesEntryToolStripMenuItem.Name = "expensesEntryToolStripMenuItem";
            expensesEntryToolStripMenuItem.Size = new Size(160, 27);
            expensesEntryToolStripMenuItem.Text = "EXPENSESS ENTRY";
            expensesEntryToolStripMenuItem.ToolTipText = "To Add Expenses Details";
            expensesEntryToolStripMenuItem.Click += expensesEntryToolStripMenuItem_Click;
            // 
            // generateExpenseReportsToolStripMenuItem
            // 
            generateExpenseReportsToolStripMenuItem.Name = "generateExpenseReportsToolStripMenuItem";
            generateExpenseReportsToolStripMenuItem.Size = new Size(335, 26);
            generateExpenseReportsToolStripMenuItem.Text = "Generate Expense Reports";
            generateExpenseReportsToolStripMenuItem.Click += generateExpenseReportsToolStripMenuItem_Click;
            // 
            // addExpenseEntryToolStripMenuItem
            // 
            addExpenseEntryToolStripMenuItem.Name = "addExpenseEntryToolStripMenuItem";
            addExpenseEntryToolStripMenuItem.Size = new Size(335, 26);
            addExpenseEntryToolStripMenuItem.Text = "Add Expense Entry";
            addExpenseEntryToolStripMenuItem.Click += addExpenseEntryToolStripMenuItem_Click;
            // 
            // monthlyExpenseSummaryReportToolStripMenuItem
            // 
            monthlyExpenseSummaryReportToolStripMenuItem.Name = "monthlyExpenseSummaryReportToolStripMenuItem";
            monthlyExpenseSummaryReportToolStripMenuItem.Size = new Size(335, 26);
            monthlyExpenseSummaryReportToolStripMenuItem.Text = "Monthly Expense Summary Report";
            monthlyExpenseSummaryReportToolStripMenuItem.Click += monthlyExpenseSummaryReportToolStripMenuItem_Click;
            // 
            // feeReportsToolStripMenuItem
            // 
            feeReportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { genereateFeeReportsToolStripMenuItem, aDDFEEToolStripMenuItem, monthlyFToolStripMenuItem, classWiseMonthlySummaryReportToolStripMenuItem, discountEntryFormToolStripMenuItem });
            feeReportsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            feeReportsToolStripMenuItem.ForeColor = Color.Red;
            feeReportsToolStripMenuItem.Name = "feeReportsToolStripMenuItem";
            feeReportsToolStripMenuItem.Size = new Size(118, 27);
            feeReportsToolStripMenuItem.Text = "FEE REPORTS";
            feeReportsToolStripMenuItem.ToolTipText = "To Get Various Fee Details";
            feeReportsToolStripMenuItem.Click += feeReportsToolStripMenuItem_Click;
            // 
            // genereateFeeReportsToolStripMenuItem
            // 
            genereateFeeReportsToolStripMenuItem.Name = "genereateFeeReportsToolStripMenuItem";
            genereateFeeReportsToolStripMenuItem.Size = new Size(350, 26);
            genereateFeeReportsToolStripMenuItem.Text = "Genereate Fee Reports";
            genereateFeeReportsToolStripMenuItem.Click += genereateFeeReportsToolStripMenuItem_Click;
            // 
            // aDDFEEToolStripMenuItem
            // 
            aDDFEEToolStripMenuItem.Name = "aDDFEEToolStripMenuItem";
            aDDFEEToolStripMenuItem.Size = new Size(350, 26);
            aDDFEEToolStripMenuItem.Text = "Add Fee Entry";
            aDDFEEToolStripMenuItem.Click += aDDFEEToolStripMenuItem_Click;
            // 
            // monthlyFToolStripMenuItem
            // 
            monthlyFToolStripMenuItem.Name = "monthlyFToolStripMenuItem";
            monthlyFToolStripMenuItem.Size = new Size(350, 26);
            monthlyFToolStripMenuItem.Text = "Monthly Fee Summary Report";
            monthlyFToolStripMenuItem.Click += monthlyFToolStripMenuItem_Click;
            // 
            // classWiseMonthlySummaryReportToolStripMenuItem
            // 
            classWiseMonthlySummaryReportToolStripMenuItem.Name = "classWiseMonthlySummaryReportToolStripMenuItem";
            classWiseMonthlySummaryReportToolStripMenuItem.Size = new Size(350, 26);
            classWiseMonthlySummaryReportToolStripMenuItem.Text = "ClassWise Monthly Summary Report";
            classWiseMonthlySummaryReportToolStripMenuItem.Click += classWiseMonthlySummaryReportToolStripMenuItem_Click;
            // 
            // studentReportsToolStripMenuItem
            // 
            studentReportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateFeeReportsToolStripMenuItem, classWiseFeeReportsToolStripMenuItem, feeCollectionPercentageReportsToolStripMenuItem, feeDueReportToolStripMenuItem });
            studentReportsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            studentReportsToolStripMenuItem.ForeColor = Color.Red;
            studentReportsToolStripMenuItem.Name = "studentReportsToolStripMenuItem";
            studentReportsToolStripMenuItem.Size = new Size(166, 27);
            studentReportsToolStripMenuItem.Text = "STUDENT REPORTS";
            studentReportsToolStripMenuItem.ToolTipText = "To View Added Student Details ";
            studentReportsToolStripMenuItem.Click += studentReportsToolStripMenuItem_Click;
            // 
            // generateFeeReportsToolStripMenuItem
            // 
            generateFeeReportsToolStripMenuItem.Name = "generateFeeReportsToolStripMenuItem";
            generateFeeReportsToolStripMenuItem.Size = new Size(326, 26);
            generateFeeReportsToolStripMenuItem.Text = "Generate Fee Reports";
            generateFeeReportsToolStripMenuItem.Click += generateFeeReportsToolStripMenuItem_Click;
            // 
            // classWiseFeeReportsToolStripMenuItem
            // 
            classWiseFeeReportsToolStripMenuItem.Name = "classWiseFeeReportsToolStripMenuItem";
            classWiseFeeReportsToolStripMenuItem.Size = new Size(326, 26);
            classWiseFeeReportsToolStripMenuItem.Text = "Class Wise Fee Reports";
            classWiseFeeReportsToolStripMenuItem.Click += classWiseFeeReportsToolStripMenuItem_Click;
            // 
            // feeCollectionPercentageReportsToolStripMenuItem
            // 
            feeCollectionPercentageReportsToolStripMenuItem.Name = "feeCollectionPercentageReportsToolStripMenuItem";
            feeCollectionPercentageReportsToolStripMenuItem.Size = new Size(326, 26);
            feeCollectionPercentageReportsToolStripMenuItem.Text = "Fee Collection Percentage Reports";
            feeCollectionPercentageReportsToolStripMenuItem.Click += feeCollectionPercentageReportsToolStripMenuItem_Click;
            // 
            // feeDueReportToolStripMenuItem
            // 
            feeDueReportToolStripMenuItem.Name = "feeDueReportToolStripMenuItem";
            feeDueReportToolStripMenuItem.Size = new Size(326, 26);
            feeDueReportToolStripMenuItem.Text = "Fee Due Report";
            feeDueReportToolStripMenuItem.Click += feeDueReportToolStripMenuItem_Click;
            // 
            // busFeeDetailsToolStripMenuItem
            // 
            busFeeDetailsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { busDueListToolStripMenuItem });
            busFeeDetailsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            busFeeDetailsToolStripMenuItem.ForeColor = Color.Red;
            busFeeDetailsToolStripMenuItem.Name = "busFeeDetailsToolStripMenuItem";
            busFeeDetailsToolStripMenuItem.Size = new Size(147, 27);
            busFeeDetailsToolStripMenuItem.Text = "BUS FEE DETAILS";
            busFeeDetailsToolStripMenuItem.ToolTipText = "To View Bus Fee Details";
            // 
            // busDueListToolStripMenuItem
            // 
            busDueListToolStripMenuItem.Name = "busDueListToolStripMenuItem";
            busDueListToolStripMenuItem.Size = new Size(171, 26);
            busDueListToolStripMenuItem.Text = "Bus Due List";
            busDueListToolStripMenuItem.Click += busDueListToolStripMenuItem_Click;
            // 
            // nOTIFICATIONSToolStripMenuItem
            // 
            nOTIFICATIONSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eMAILNOTIFICATIONSToolStripMenuItem });
            nOTIFICATIONSToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            nOTIFICATIONSToolStripMenuItem.ForeColor = Color.Red;
            nOTIFICATIONSToolStripMenuItem.Name = "nOTIFICATIONSToolStripMenuItem";
            nOTIFICATIONSToolStripMenuItem.Size = new Size(143, 27);
            nOTIFICATIONSToolStripMenuItem.Text = "NOTIFICATIONS";
            // 
            // eMAILNOTIFICATIONSToolStripMenuItem
            // 
            eMAILNOTIFICATIONSToolStripMenuItem.ForeColor = Color.Red;
            eMAILNOTIFICATIONSToolStripMenuItem.Name = "eMAILNOTIFICATIONSToolStripMenuItem";
            eMAILNOTIFICATIONSToolStripMenuItem.Size = new Size(251, 26);
            eMAILNOTIFICATIONSToolStripMenuItem.Text = "EMAIL NOTIFICATIONS";
            eMAILNOTIFICATIONSToolStripMenuItem.Click += eMAILNOTIFICATIONSToolStripMenuItem_Click;
            // 
            // vERIFICATIONSToolStripMenuItem
            // 
            vERIFICATIONSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verifyCollectionToFeeToolStripMenuItem });
            vERIFICATIONSToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            vERIFICATIONSToolStripMenuItem.ForeColor = Color.Red;
            vERIFICATIONSToolStripMenuItem.Name = "vERIFICATIONSToolStripMenuItem";
            vERIFICATIONSToolStripMenuItem.Size = new Size(138, 27);
            vERIFICATIONSToolStripMenuItem.Text = "VERIFICATIONS";
            // 
            // verifyCollectionToFeeToolStripMenuItem
            // 
            verifyCollectionToFeeToolStripMenuItem.ForeColor = Color.Red;
            verifyCollectionToFeeToolStripMenuItem.Name = "verifyCollectionToFeeToolStripMenuItem";
            verifyCollectionToFeeToolStripMenuItem.Size = new Size(253, 26);
            verifyCollectionToFeeToolStripMenuItem.Text = "Verify Collection To Fee";
            verifyCollectionToFeeToolStripMenuItem.Click += verifyCollectionToFeeToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(46, 102);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 4;
            label2.Text = "Select Class :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(285, 103);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 5;
            label3.Text = "Academic Year :";
            // 
            // ClassComboBox
            // 
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(150, 103);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(129, 25);
            ClassComboBox.TabIndex = 6;
            ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
            ClassComboBox.Leave += ClassComboBox_Leave;
            // 
            // AcademicYearComboBox
            // 
            AcademicYearComboBox.FormattingEnabled = true;
            AcademicYearComboBox.Location = new Point(407, 103);
            AcademicYearComboBox.Name = "AcademicYearComboBox";
            AcademicYearComboBox.Size = new Size(148, 25);
            AcademicYearComboBox.TabIndex = 7;
            AcademicYearComboBox.SelectedIndexChanged += AcademicYearComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(124, 44);
            label10.Name = "label10";
            label10.Size = new Size(648, 32);
            label10.TabIndex = 70;
            label10.Text = "Student Details View By Class and Academic Year";
            // 
            // summaryDataGridView
            // 
            summaryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            summaryDataGridView.BackgroundColor = Color.BurlyWood;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Red;
            summaryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            summaryDataGridView.ColumnHeadersHeight = 25;
            summaryDataGridView.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            summaryDataGridView.Location = new Point(920, 70);
            summaryDataGridView.Name = "summaryDataGridView";
            summaryDataGridView.ReadOnly = true;
            summaryDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Blue;
            summaryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            summaryDataGridView.Size = new Size(410, 62);
            summaryDataGridView.TabIndex = 71;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(977, 39);
            label1.Name = "label1";
            label1.Size = new Size(277, 28);
            label1.TabIndex = 72;
            label1.Text = "Student Summary Details";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(561, 104);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 73;
            label4.Text = "Section :";
            // 
            // SectionComboBox
            // 
            SectionComboBox.FormattingEnabled = true;
            SectionComboBox.Location = new Point(632, 104);
            SectionComboBox.Name = "SectionComboBox";
            SectionComboBox.Size = new Size(140, 25);
            SectionComboBox.TabIndex = 74;
            SectionComboBox.SelectedIndexChanged += SectionComboBox_SelectedIndexChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.BurlyWood;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Red;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeight = 25;
            dataGridView2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridView2.Location = new Point(424, 546);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(906, 152);
            dataGridView2.TabIndex = 75;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(29, 568);
            label5.Name = "label5";
            label5.Size = new Size(389, 28);
            label5.TabIndex = 76;
            label5.Text = "Fee Paid Summary For This Class";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.BurlyWood;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Red;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView3.ColumnHeadersHeight = 25;
            dataGridView3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridView3.Location = new Point(12, 615);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView3.RowTemplate.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(406, 83);
            dataGridView3.TabIndex = 77;
            // 
            // discountEntryFormToolStripMenuItem
            // 
            discountEntryFormToolStripMenuItem.Name = "discountEntryFormToolStripMenuItem";
            discountEntryFormToolStripMenuItem.Size = new Size(350, 26);
            discountEntryFormToolStripMenuItem.Text = "Discount Entry Form";
            discountEntryFormToolStripMenuItem.Click += discountEntryFormToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1346, 734);
            Controls.Add(dataGridView3);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(SectionComboBox);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(summaryDataGridView);
            Controls.Add(label10);
            Controls.Add(AcademicYearComboBox);
            Controls.Add(ClassComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SLN FEE MANAGEMENT SOFTWARE";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addStudentDetailsMenuItem;
        private ToolStripMenuItem collectionEntryStripMenuItem;
        private ToolStripMenuItem expensesEntryToolStripMenuItem;
        private ToolStripMenuItem feeReportsToolStripMenuItem;
        private ToolStripMenuItem studentReportsToolStripMenuItem;
        private ToolStripMenuItem busFeeDetailsToolStripMenuItem;
        private Label label2;
        private Label label3;
        private ComboBox ClassComboBox;
        private ComboBox AcademicYearComboBox;
        private Label label10;
        private DataGridView summaryDataGridView;
        private Label label1;
        private ToolStripMenuItem genereateFeeReportsToolStripMenuItem;
        private ToolStripMenuItem aDDFEEToolStripMenuItem;
        private ToolStripMenuItem generateCollectionReportsToolStripMenuItem;
        private ToolStripMenuItem addCollectionEntryToolStripMenuItem;
        private ToolStripMenuItem generateExpenseReportsToolStripMenuItem;
        private ToolStripMenuItem addExpenseEntryToolStripMenuItem;
        private ToolStripMenuItem generateFeeReportsToolStripMenuItem;
        private ToolStripMenuItem classWiseFeeReportsToolStripMenuItem;
        private Label label4;
        private ComboBox SectionComboBox;
        private ToolStripMenuItem nOTIFICATIONSToolStripMenuItem;
        private ToolStripMenuItem eMAILNOTIFICATIONSToolStripMenuItem;
        private ToolStripMenuItem monthlyCollectionSummaryReportToolStripMenuItem;
        private ToolStripMenuItem monthlyExpenseSummaryReportToolStripMenuItem;
        private ToolStripMenuItem monthlyFToolStripMenuItem;
        private ToolStripMenuItem classWiseMonthlySummaryReportToolStripMenuItem;
        private ToolStripMenuItem bankTransactionsEntryToolStripMenuItem;
        private DataGridView dataGridView2;
        private Label label5;
        private DataGridView dataGridView3;
        private ToolStripMenuItem feeCollectionPercentageReportsToolStripMenuItem;
        private ToolStripMenuItem feeDueReportToolStripMenuItem;
        private ToolStripMenuItem vERIFICATIONSToolStripMenuItem;
        private ToolStripMenuItem verifyCollectionToFeeToolStripMenuItem;
        private ToolStripMenuItem busDueListToolStripMenuItem;
        private ToolStripMenuItem discountEntryFormToolStripMenuItem;
    }
}
