
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            addStudentDetailsMenuItem = new ToolStripMenuItem();
            collectionEntryStripMenuItem = new ToolStripMenuItem();
            generateCollectionReportsToolStripMenuItem = new ToolStripMenuItem();
            addCollectionEntryToolStripMenuItem = new ToolStripMenuItem();
            expensesEntryToolStripMenuItem = new ToolStripMenuItem();
            generateExpenseReportsToolStripMenuItem = new ToolStripMenuItem();
            addExpenseEntryToolStripMenuItem = new ToolStripMenuItem();
            feeReportsToolStripMenuItem = new ToolStripMenuItem();
            genereateFeeReportsToolStripMenuItem = new ToolStripMenuItem();
            aDDFEEToolStripMenuItem = new ToolStripMenuItem();
            studentReportsToolStripMenuItem = new ToolStripMenuItem();
            busFeeDetailsToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            ClassComboBox = new ComboBox();
            AcademicYearComboBox = new ComboBox();
            label10 = new Label();
            summaryDataGridView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(774, 109);
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
            dataGridView1.Location = new Point(21, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1240, 451);
            dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSeaGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { addStudentDetailsMenuItem, collectionEntryStripMenuItem, expensesEntryToolStripMenuItem, feeReportsToolStripMenuItem, studentReportsToolStripMenuItem, busFeeDetailsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1267, 31);
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
            collectionEntryStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateCollectionReportsToolStripMenuItem, addCollectionEntryToolStripMenuItem });
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
            generateCollectionReportsToolStripMenuItem.Size = new Size(283, 26);
            generateCollectionReportsToolStripMenuItem.Text = "Generate Collection Reports";
            generateCollectionReportsToolStripMenuItem.Click += generateCollectionReportsToolStripMenuItem_Click;
            // 
            // addCollectionEntryToolStripMenuItem
            // 
            addCollectionEntryToolStripMenuItem.Name = "addCollectionEntryToolStripMenuItem";
            addCollectionEntryToolStripMenuItem.Size = new Size(283, 26);
            addCollectionEntryToolStripMenuItem.Text = "Add Collection Entry";
            addCollectionEntryToolStripMenuItem.Click += addCollectionEntryToolStripMenuItem_Click;
            // 
            // expensesEntryToolStripMenuItem
            // 
            expensesEntryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateExpenseReportsToolStripMenuItem, addExpenseEntryToolStripMenuItem });
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
            generateExpenseReportsToolStripMenuItem.Size = new Size(268, 26);
            generateExpenseReportsToolStripMenuItem.Text = "Generate Expense Reports";
            generateExpenseReportsToolStripMenuItem.Click += generateExpenseReportsToolStripMenuItem_Click;
            // 
            // addExpenseEntryToolStripMenuItem
            // 
            addExpenseEntryToolStripMenuItem.Name = "addExpenseEntryToolStripMenuItem";
            addExpenseEntryToolStripMenuItem.Size = new Size(268, 26);
            addExpenseEntryToolStripMenuItem.Text = "Add Expense Entry";
            addExpenseEntryToolStripMenuItem.Click += addExpenseEntryToolStripMenuItem_Click;
            // 
            // feeReportsToolStripMenuItem
            // 
            feeReportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { genereateFeeReportsToolStripMenuItem, aDDFEEToolStripMenuItem });
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
            genereateFeeReportsToolStripMenuItem.Size = new Size(241, 26);
            genereateFeeReportsToolStripMenuItem.Text = "Genereate Fee Reports";
            genereateFeeReportsToolStripMenuItem.Click += genereateFeeReportsToolStripMenuItem_Click;
            // 
            // aDDFEEToolStripMenuItem
            // 
            aDDFEEToolStripMenuItem.Name = "aDDFEEToolStripMenuItem";
            aDDFEEToolStripMenuItem.Size = new Size(241, 26);
            aDDFEEToolStripMenuItem.Text = "Add Fee Entry";
            aDDFEEToolStripMenuItem.Click += aDDFEEToolStripMenuItem_Click;
            // 
            // studentReportsToolStripMenuItem
            // 
            studentReportsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            studentReportsToolStripMenuItem.ForeColor = Color.Red;
            studentReportsToolStripMenuItem.Name = "studentReportsToolStripMenuItem";
            studentReportsToolStripMenuItem.Size = new Size(166, 27);
            studentReportsToolStripMenuItem.Text = "STUDENT REPORTS";
            studentReportsToolStripMenuItem.ToolTipText = "To View Added Student Details ";
            // 
            // busFeeDetailsToolStripMenuItem
            // 
            busFeeDetailsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            busFeeDetailsToolStripMenuItem.ForeColor = Color.Red;
            busFeeDetailsToolStripMenuItem.Name = "busFeeDetailsToolStripMenuItem";
            busFeeDetailsToolStripMenuItem.Size = new Size(147, 27);
            busFeeDetailsToolStripMenuItem.Text = "BUS FEE DETAILS";
            busFeeDetailsToolStripMenuItem.ToolTipText = "To View Bus Fee Details";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(30, 113);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 4;
            label2.Text = "Select Class :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(390, 113);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 5;
            label3.Text = "Academic Year :";
            // 
            // ClassComboBox
            // 
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(151, 113);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(221, 25);
            ClassComboBox.TabIndex = 6;
            ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
            // 
            // AcademicYearComboBox
            // 
            AcademicYearComboBox.FormattingEnabled = true;
            AcademicYearComboBox.Location = new Point(534, 114);
            AcademicYearComboBox.Name = "AcademicYearComboBox";
            AcademicYearComboBox.Size = new Size(221, 25);
            AcademicYearComboBox.TabIndex = 7;
            AcademicYearComboBox.SelectedIndexChanged += AcademicYearComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(119, 46);
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
            summaryDataGridView.Location = new Point(875, 79);
            summaryDataGridView.Name = "summaryDataGridView";
            summaryDataGridView.ReadOnly = true;
            summaryDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Blue;
            summaryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            summaryDataGridView.Size = new Size(386, 62);
            summaryDataGridView.TabIndex = 71;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(962, 46);
            label1.Name = "label1";
            label1.Size = new Size(277, 28);
            label1.TabIndex = 72;
            label1.Text = "Student Summary Details";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1267, 605);
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
    }
}
