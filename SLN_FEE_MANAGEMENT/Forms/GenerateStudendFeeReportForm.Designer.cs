namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class GenerateStudendFeeReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label10 = new Label();
            SectionComboBox = new ComboBox();
            label11 = new Label();
            StudentNameComboBox = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            ClassComboBox = new ComboBox();
            AcademicYearComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ClearButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(318, 9);
            label10.Name = "label10";
            label10.Size = new Size(318, 32);
            label10.TabIndex = 71;
            label10.Text = "Student Fee Report Details ";
            // 
            // SectionComboBox
            // 
            SectionComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SectionComboBox.FormattingEnabled = true;
            SectionComboBox.Location = new Point(595, 58);
            SectionComboBox.Name = "SectionComboBox";
            SectionComboBox.Size = new Size(133, 24);
            SectionComboBox.TabIndex = 3;
            SectionComboBox.SelectedIndexChanged += SectionComboBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(520, 60);
            label11.Name = "label11";
            label11.Size = new Size(77, 28);
            label11.TabIndex = 81;
            label11.Text = "Section :";
            // 
            // StudentNameComboBox
            // 
            StudentNameComboBox.AllowDrop = true;
            StudentNameComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            StudentNameComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentNameComboBox.FormattingEnabled = true;
            StudentNameComboBox.Location = new Point(856, 60);
            StudentNameComboBox.Name = "StudentNameComboBox";
            StudentNameComboBox.Size = new Size(211, 24);
            StudentNameComboBox.TabIndex = 4;
            StudentNameComboBox.SelectedIndexChanged += StudentNameComboBox_SelectedIndexChanged;
            StudentNameComboBox.TextChanged += StudentNameComboBox_TextChanged;
            StudentNameComboBox.Click += StudentNameComboBox_Click;
            StudentNameComboBox.Leave += StudentNameComboBox_Leave;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(732, 60);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 79;
            label5.Text = "Student Name :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 78;
            label2.Text = "Select Class:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(247, 58);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 77;
            label3.Text = "Academic Year:";
            // 
            // ClassComboBox
            // 
            ClassComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(103, 60);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(141, 24);
            ClassComboBox.TabIndex = 1;
            ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
            ClassComboBox.Leave += ClassComboBox_Leave;
            // 
            // AcademicYearComboBox
            // 
            AcademicYearComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AcademicYearComboBox.FormattingEnabled = true;
            AcademicYearComboBox.Location = new Point(354, 60);
            AcademicYearComboBox.Name = "AcademicYearComboBox";
            AcademicYearComboBox.Size = new Size(170, 24);
            AcademicYearComboBox.TabIndex = 2;
            AcademicYearComboBox.SelectedIndexChanged += AcademicYearComboBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1055, 367);
            dataGridView1.TabIndex = 82;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(330, 108);
            button1.Name = "button1";
            button1.Size = new Size(95, 32);
            button1.TabIndex = 83;
            button1.Text = "Get Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(483, 108);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(95, 28);
            ClearButton.TabIndex = 84;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(640, 108);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(101, 28);
            CloseButton.TabIndex = 85;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // GenerateStudendFeeReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1093, 548);
            Controls.Add(ClearButton);
            Controls.Add(CloseButton);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(SectionComboBox);
            Controls.Add(label11);
            Controls.Add(StudentNameComboBox);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(ClassComboBox);
            Controls.Add(AcademicYearComboBox);
            Controls.Add(label10);
            Name = "GenerateStudendFeeReportForm";
            Text = "GenerateStudendFeeReportForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label10;
        private ComboBox SectionComboBox;
        private Label label11;
        private ComboBox StudentNameComboBox;
        private Label label5;
        private Label label2;
        private Label label3;
        private ComboBox ClassComboBox;
        private ComboBox AcademicYearComboBox;
        private DataGridView dataGridView1;
        private Button button1;
        private Button ClearButton;
        private Button CloseButton;
    }
}