namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class FeeEntryForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            AddNewButton = new Button();
            ClearButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            BillNoTextBox = new TextBox();
            label7 = new Label();
            AmountTextBox = new TextBox();
            label4 = new Label();
            FeeTypeComboBox = new ComboBox();
            label1 = new Label();
            AcademicYearComboBox = new ComboBox();
            ClassComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            VillageNameTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            StudentNameComboBox = new ComboBox();
            FatherNameTextBox = new TextBox();
            summaryDataGridView = new DataGridView();
            CloseButton = new Button();
            label11 = new Label();
            DescriptionTextBox = new TextBox();
            label12 = new Label();
            sectionComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(399, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(696, 367);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // AddNewButton
            // 
            AddNewButton.BackColor = Color.DeepSkyBlue;
            AddNewButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewButton.Location = new Point(38, 497);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(94, 28);
            AddNewButton.TabIndex = 10;
            AddNewButton.Text = "Add New";
            AddNewButton.UseVisualStyleBackColor = false;
            AddNewButton.Click += AddNewButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(222, 560);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(95, 28);
            ClearButton.TabIndex = 14;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.LightCoral;
            DeleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(38, 560);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 28);
            DeleteButton.TabIndex = 12;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DeepSkyBlue;
            SaveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(222, 497);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(95, 28);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(148, 450);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 21);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(12, 450);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 51;
            label6.Text = "Entry Date :";
            // 
            // BillNoTextBox
            // 
            BillNoTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BillNoTextBox.Location = new Point(148, 406);
            BillNoTextBox.Name = "BillNoTextBox";
            BillNoTextBox.Size = new Size(211, 22);
            BillNoTextBox.TabIndex = 8;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(12, 406);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 53;
            label7.Text = "Bill Number :";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            AmountTextBox.Location = new Point(148, 330);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(211, 22);
            AmountTextBox.TabIndex = 7;
            AmountTextBox.TextChanged += AmountTextBox_TextChanged;
            AmountTextBox.KeyPress += AmountTextBox_KeyPress;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(12, 330);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 57;
            label4.Text = "Amount :";
            // 
            // FeeTypeComboBox
            // 
            FeeTypeComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeeTypeComboBox.FormattingEnabled = true;
            FeeTypeComboBox.Location = new Point(148, 134);
            FeeTypeComboBox.Name = "FeeTypeComboBox";
            FeeTypeComboBox.Size = new Size(211, 24);
            FeeTypeComboBox.TabIndex = 3;
            FeeTypeComboBox.SelectedIndexChanged += FeeTypeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(10, 134);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 55;
            label1.Text = "Fee Type:";
            // 
            // AcademicYearComboBox
            // 
            AcademicYearComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AcademicYearComboBox.FormattingEnabled = true;
            AcademicYearComboBox.Location = new Point(148, 95);
            AcademicYearComboBox.Name = "AcademicYearComboBox";
            AcademicYearComboBox.Size = new Size(211, 24);
            AcademicYearComboBox.TabIndex = 2;
            AcademicYearComboBox.SelectedIndexChanged += AcademicYearComboBox_SelectedIndexChanged;
            // 
            // ClassComboBox
            // 
            ClassComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(150, 52);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(211, 24);
            ClassComboBox.TabIndex = 1;
            ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
            ClassComboBox.Leave += ClassComboBox_Leave;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(10, 91);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 61;
            label3.Text = "Academic Year:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 62;
            label2.Text = "Select Class:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(12, 212);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 63;
            label5.Text = "Student Name :";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(12, 249);
            label8.Name = "label8";
            label8.Size = new Size(120, 28);
            label8.TabIndex = 65;
            label8.Text = "Father Name :";
            // 
            // VillageNameTextBox
            // 
            VillageNameTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            VillageNameTextBox.Location = new Point(148, 288);
            VillageNameTextBox.Name = "VillageNameTextBox";
            VillageNameTextBox.Size = new Size(211, 22);
            VillageNameTextBox.TabIndex = 6;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(12, 288);
            label9.Name = "label9";
            label9.Size = new Size(120, 28);
            label9.TabIndex = 67;
            label9.Text = "Village Name :";
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(89, 9);
            label10.Name = "label10";
            label10.Size = new Size(196, 28);
            label10.TabIndex = 69;
            label10.Text = "Fee Entry Form";
            // 
            // StudentNameComboBox
            // 
            StudentNameComboBox.AllowDrop = true;
            StudentNameComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            StudentNameComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentNameComboBox.FormattingEnabled = true;
            StudentNameComboBox.Location = new Point(148, 212);
            StudentNameComboBox.Name = "StudentNameComboBox";
            StudentNameComboBox.Size = new Size(211, 24);
            StudentNameComboBox.TabIndex = 4;
            StudentNameComboBox.SelectedIndexChanged += StudentNameComboBox_SelectedIndexChanged;
            StudentNameComboBox.TextChanged += StudentNameComboBox_TextChanged;
            StudentNameComboBox.Click += StudentNameComboBox_Click;
            StudentNameComboBox.Leave += StudentNameComboBox_Leave;
            // 
            // FatherNameTextBox
            // 
            FatherNameTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            FatherNameTextBox.Location = new Point(150, 249);
            FatherNameTextBox.Name = "FatherNameTextBox";
            FatherNameTextBox.Size = new Size(211, 22);
            FatherNameTextBox.TabIndex = 5;
            // 
            // summaryDataGridView
            // 
            summaryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            summaryDataGridView.BackgroundColor = Color.BurlyWood;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Red;
            summaryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            summaryDataGridView.ColumnHeadersHeight = 25;
            summaryDataGridView.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            summaryDataGridView.Location = new Point(512, 450);
            summaryDataGridView.Name = "summaryDataGridView";
            summaryDataGridView.ReadOnly = true;
            summaryDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Blue;
            summaryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            summaryDataGridView.Size = new Size(354, 153);
            summaryDataGridView.TabIndex = 70;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(953, 497);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(101, 28);
            CloseButton.TabIndex = 71;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(12, 174);
            label11.Name = "label11";
            label11.Size = new Size(120, 28);
            label11.TabIndex = 73;
            label11.Text = "Section:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            DescriptionTextBox.Location = new Point(148, 367);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(211, 22);
            DescriptionTextBox.TabIndex = 74;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.RoyalBlue;
            label12.Location = new Point(12, 367);
            label12.Name = "label12";
            label12.Size = new Size(120, 28);
            label12.TabIndex = 75;
            label12.Text = "Description :";
            // 
            // sectionComboBox
            // 
            sectionComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sectionComboBox.FormattingEnabled = true;
            sectionComboBox.Location = new Point(150, 174);
            sectionComboBox.Name = "sectionComboBox";
            sectionComboBox.Size = new Size(211, 24);
            sectionComboBox.TabIndex = 76;
            sectionComboBox.SelectedIndexChanged += SectionComboBox_SelectedIndexChanged;
            // 
            // FeeEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1119, 615);
            Controls.Add(sectionComboBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(CloseButton);
            Controls.Add(summaryDataGridView);
            Controls.Add(FatherNameTextBox);
            Controls.Add(StudentNameComboBox);
            Controls.Add(label10);
            Controls.Add(VillageNameTextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(ClassComboBox);
            Controls.Add(AcademicYearComboBox);
            Controls.Add(AmountTextBox);
            Controls.Add(label4);
            Controls.Add(FeeTypeComboBox);
            Controls.Add(label1);
            Controls.Add(BillNoTextBox);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(AddNewButton);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(dataGridView1);
            Name = "FeeEntryForm";
            Text = "FeeEntryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button AddNewButton;
        private Button ClearButton;
        private Button DeleteButton;
        private Button SaveButton;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox BillNoTextBox;
        private Label label7;
        private TextBox AmountTextBox;
        private Label label4;
        private ComboBox FeeTypeComboBox;
        private Label label1;
        private ComboBox AcademicYearComboBox;
        private ComboBox ClassComboBox;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label8;
        private TextBox VillageNameTextBox;
        private Label label9;
        private Label label10;
        private ComboBox StudentNameComboBox;
        private TextBox FatherNameTextBox;
        private DataGridView summaryDataGridView;
        private Button CloseButton;
        private Label label11;
        private TextBox DescriptionTextBox;
        private Label label12;
        private ComboBox sectionComboBox;
    }
}