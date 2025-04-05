namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class BusDueListForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            CloseButton = new Button();
            Reloadbutton = new Button();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            SectionComboBox = new ComboBox();
            label4 = new Label();
            AcademicYearComboBox = new ComboBox();
            ClassComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(647, 517);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(101, 32);
            CloseButton.TabIndex = 106;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // Reloadbutton
            // 
            Reloadbutton.BackColor = Color.DeepSkyBlue;
            Reloadbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reloadbutton.Location = new Point(344, 517);
            Reloadbutton.Name = "Reloadbutton";
            Reloadbutton.Size = new Size(160, 32);
            Reloadbutton.TabIndex = 105;
            Reloadbutton.Text = "Get Complete Due List ";
            Reloadbutton.UseVisualStyleBackColor = false;
            Reloadbutton.Click += Reloadbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 25;
            dataGridView1.Location = new Point(44, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(954, 406);
            dataGridView1.TabIndex = 104;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(413, 9);
            label10.Name = "label10";
            label10.Size = new Size(228, 28);
            label10.TabIndex = 103;
            label10.Text = "Bus Due List Report";
            // 
            // SectionComboBox
            // 
            SectionComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SectionComboBox.FormattingEnabled = true;
            SectionComboBox.Location = new Point(728, 49);
            SectionComboBox.Name = "SectionComboBox";
            SectionComboBox.Size = new Size(140, 25);
            SectionComboBox.TabIndex = 113;
            SectionComboBox.SelectedIndexChanged += SectionComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(631, 48);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 112;
            label4.Text = "Section :";
            // 
            // AcademicYearComboBox
            // 
            AcademicYearComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AcademicYearComboBox.FormattingEnabled = true;
            AcademicYearComboBox.Location = new Point(460, 50);
            AcademicYearComboBox.Name = "AcademicYearComboBox";
            AcademicYearComboBox.Size = new Size(148, 25);
            AcademicYearComboBox.TabIndex = 111;
            AcademicYearComboBox.SelectedIndexChanged += AcademicYearComboBox_SelectedIndexChanged;
            // 
            // ClassComboBox
            // 
            ClassComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(148, 50);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(129, 25);
            ClassComboBox.TabIndex = 110;
            ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
            ClassComboBox.Leave += ClassComboBox_Leave;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(308, 48);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 109;
            label3.Text = "Academic Year :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(44, 49);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 108;
            label2.Text = "Select Class :";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(903, 44);
            button1.Name = "button1";
            button1.Size = new Size(95, 32);
            button1.TabIndex = 107;
            button1.Text = "Get Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BusDueListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1052, 567);
            Controls.Add(SectionComboBox);
            Controls.Add(label4);
            Controls.Add(AcademicYearComboBox);
            Controls.Add(ClassComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(CloseButton);
            Controls.Add(Reloadbutton);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Name = "BusDueListForm";
            Text = "BusDueListForm";
            Leave += ClassComboBox_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private Button Reloadbutton;
        private DataGridView dataGridView1;
        private Label label10;
        private ComboBox SectionComboBox;
        private Label label4;
        private ComboBox AcademicYearComboBox;
        private ComboBox ClassComboBox;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}