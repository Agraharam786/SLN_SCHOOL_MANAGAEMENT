namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class ClassWiseFeeReportForm
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            SectionComboBox = new ComboBox();
            label11 = new Label();
            label2 = new Label();
            label3 = new Label();
            ClassComboBox = new ComboBox();
            AcademicYearComboBox = new ComboBox();
            label10 = new Label();
            ClearButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(355, 99);
            button1.Name = "button1";
            button1.Size = new Size(95, 32);
            button1.TabIndex = 92;
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
            dataGridView1.Location = new Point(45, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1055, 367);
            dataGridView1.TabIndex = 91;
            // 
            // SectionComboBox
            // 
            SectionComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SectionComboBox.FormattingEnabled = true;
            SectionComboBox.Location = new Point(813, 45);
            SectionComboBox.Name = "SectionComboBox";
            SectionComboBox.Size = new Size(142, 24);
            SectionComboBox.TabIndex = 86;
            SectionComboBox.SelectedIndexChanged += SectionComboBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(730, 45);
            label11.Name = "label11";
            label11.Size = new Size(77, 28);
            label11.TabIndex = 90;
            label11.Text = "Section :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(45, 45);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 89;
            label2.Text = "Select Class:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(346, 45);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 88;
            label3.Text = "Academic Year:";
            // 
            // ClassComboBox
            // 
            ClassComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(162, 45);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(141, 24);
            ClassComboBox.TabIndex = 84;
            ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
            ClassComboBox.Leave += ClassComboBox_Leave;
            // 
            // AcademicYearComboBox
            // 
            AcademicYearComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AcademicYearComboBox.FormattingEnabled = true;
            AcademicYearComboBox.Location = new Point(508, 45);
            AcademicYearComboBox.Name = "AcademicYearComboBox";
            AcademicYearComboBox.Size = new Size(150, 24);
            AcademicYearComboBox.TabIndex = 85;
            AcademicYearComboBox.SelectedIndexChanged += AcademicYearComboBox_SelectedIndexChanged;
            AcademicYearComboBox.SystemColorsChanged += AcademicYearComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(293, 5);
            label10.Name = "label10";
            label10.Size = new Size(318, 32);
            label10.TabIndex = 87;
            label10.Text = "Student Fee Report Details ";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(516, 103);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(95, 28);
            ClearButton.TabIndex = 93;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(683, 103);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(101, 28);
            CloseButton.TabIndex = 94;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ClassWiseFeeReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1144, 517);
            Controls.Add(ClearButton);
            Controls.Add(CloseButton);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(SectionComboBox);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(ClassComboBox);
            Controls.Add(AcademicYearComboBox);
            Controls.Add(label10);
            Name = "ClassWiseFeeReportForm";
            Text = "ClassWiseFeeReportForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox SectionComboBox;
        private Label label11;
        private Label label2;
        private Label label3;
        private ComboBox ClassComboBox;
        private ComboBox AcademicYearComboBox;
        private Label label10;
        private Button ClearButton;
        private Button CloseButton;
    }
}