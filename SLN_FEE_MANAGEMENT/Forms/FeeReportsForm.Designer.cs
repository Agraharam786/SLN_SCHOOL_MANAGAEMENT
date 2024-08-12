namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class FeeReportsForm
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            label10 = new Label();
            AcademicYearComboBox = new ComboBox();
            ClassComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            CloseButton = new Button();
            GetButton = new Button();
            ClearButton = new Button();
            TodateTimePicker = new DateTimePicker();
            label6 = new Label();
            FromdateTimePicker = new DateTimePicker();
            label1 = new Label();
            FeeTypeComboBox = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(34, 22);
            label10.Name = "label10";
            label10.Size = new Size(356, 28);
            label10.TabIndex = 70;
            label10.Text = "Fee Report Generation Form";
            label10.Click += label10_Click;
            // 
            // AcademicYearComboBox
            // 
            AcademicYearComboBox.FormattingEnabled = true;
            AcademicYearComboBox.Location = new Point(157, 134);
            AcademicYearComboBox.Name = "AcademicYearComboBox";
            AcademicYearComboBox.Size = new Size(221, 23);
            AcademicYearComboBox.TabIndex = 2;
            AcademicYearComboBox.SelectedIndexChanged += AcademicYearComboBox_SelectedIndexChanged;
            // 
            // ClassComboBox
            // 
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(157, 77);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(221, 23);
            ClassComboBox.TabIndex = 1;
            ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(9, 133);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 74;
            label3.Text = "Academic Year :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(9, 76);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 73;
            label2.Text = "Select Class :";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(415, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(751, 400);
            dataGridView1.TabIndex = 72;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(289, 405);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(101, 28);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // GetButton
            // 
            GetButton.BackColor = Color.DeepSkyBlue;
            GetButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetButton.Location = new Point(27, 405);
            GetButton.Name = "GetButton";
            GetButton.Size = new Size(119, 28);
            GetButton.TabIndex = 6;
            GetButton.Text = "Get All Data";
            GetButton.UseVisualStyleBackColor = false;
            GetButton.Click += GetButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(174, 405);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(95, 28);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // TodateTimePicker
            // 
            TodateTimePicker.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodateTimePicker.Location = new Point(157, 326);
            TodateTimePicker.Name = "TodateTimePicker";
            TodateTimePicker.Size = new Size(221, 21);
            TodateTimePicker.TabIndex = 5;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(19, 326);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 80;
            label6.Text = "To Date :";
            // 
            // FromdateTimePicker
            // 
            FromdateTimePicker.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FromdateTimePicker.Location = new Point(157, 264);
            FromdateTimePicker.Name = "FromdateTimePicker";
            FromdateTimePicker.Size = new Size(221, 21);
            FromdateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(19, 264);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 82;
            label1.Text = "From Date :";
            // 
            // FeeTypeComboBox
            // 
            FeeTypeComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeeTypeComboBox.FormattingEnabled = true;
            FeeTypeComboBox.Location = new Point(157, 197);
            FeeTypeComboBox.Name = "FeeTypeComboBox";
            FeeTypeComboBox.Size = new Size(221, 24);
            FeeTypeComboBox.TabIndex = 3;
            FeeTypeComboBox.SelectedIndexChanged += FeeTypeComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(9, 197);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 85;
            label4.Text = "Fee Type:";
            // 
            // FeeReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1183, 489);
            Controls.Add(FeeTypeComboBox);
            Controls.Add(label4);
            Controls.Add(FromdateTimePicker);
            Controls.Add(label1);
            Controls.Add(TodateTimePicker);
            Controls.Add(label6);
            Controls.Add(ClearButton);
            Controls.Add(CloseButton);
            Controls.Add(GetButton);
            Controls.Add(AcademicYearComboBox);
            Controls.Add(ClassComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Name = "FeeReportsForm";
            Text = "FeeReportsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label10;
        private ComboBox AcademicYearComboBox;
        private ComboBox ClassComboBox;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button CloseButton;
        private Button GetButton;
        private Button ClearButton;
        private DateTimePicker TodateTimePicker;
        private Label label6;
        private DateTimePicker FromdateTimePicker;
        private Label label1;
        private ComboBox FeeTypeComboBox;
        private Label label4;
    }
}