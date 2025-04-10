﻿namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class CollectionEntryForm
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
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            DescTextBox = new TextBox();
            label5 = new Label();
            AmountTextBox = new TextBox();
            label4 = new Label();
            CollectionTypeComboBox = new ComboBox();
            label1 = new Label();
            SaveButton = new Button();
            dataGridView1 = new DataGridView();
            DeleteButton = new Button();
            ClearButton = new Button();
            AddNewButton = new Button();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            summaryDataGridView = new DataGridView();
            CloseButton = new Button();
            bankDepositTextBox = new TextBox();
            label7 = new Label();
            InCashTextBox = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(152, 289);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 21);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(12, 289);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 28;
            label6.Text = "Entry Date :";
            // 
            // DescTextBox
            // 
            DescTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            DescTextBox.Location = new Point(152, 244);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(235, 22);
            DescTextBox.TabIndex = 27;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(12, 244);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 26;
            label5.Text = "Description :";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            AmountTextBox.Location = new Point(187, 112);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(200, 22);
            AmountTextBox.TabIndex = 25;
            AmountTextBox.TextChanged += AmountTextBox_TextChanged;
            AmountTextBox.KeyPress += AmountTextBox_KeyPress;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 24;
            label4.Text = "Amount :";
            // 
            // CollectionTypeComboBox
            // 
            CollectionTypeComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CollectionTypeComboBox.FormattingEnabled = true;
            CollectionTypeComboBox.Location = new Point(187, 73);
            CollectionTypeComboBox.Name = "CollectionTypeComboBox";
            CollectionTypeComboBox.Size = new Size(200, 24);
            CollectionTypeComboBox.TabIndex = 23;
            CollectionTypeComboBox.SelectedIndexChanged += CollectionTypeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 22;
            label1.Text = "Collection Type:";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DeepSkyBlue;
            SaveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(258, 344);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(95, 28);
            SaveButton.TabIndex = 17;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 25;
            dataGridView1.Location = new Point(399, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(705, 379);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.LightCoral;
            DeleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(63, 399);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 28);
            DeleteButton.TabIndex = 31;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(258, 399);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(95, 28);
            ClearButton.TabIndex = 32;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddNewButton
            // 
            AddNewButton.BackColor = Color.DeepSkyBlue;
            AddNewButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewButton.Location = new Point(63, 344);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(94, 28);
            AddNewButton.TabIndex = 33;
            AddNewButton.Text = "Add New";
            AddNewButton.UseVisualStyleBackColor = false;
            AddNewButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(338, 28);
            label2.TabIndex = 34;
            label2.Text = "Daily Collection Entry Form";
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(539, 18);
            label3.Name = "label3";
            label3.Size = new Size(338, 28);
            label3.TabIndex = 35;
            label3.Text = "Saved Collection Details";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(563, 533);
            button1.Name = "button1";
            button1.Size = new Size(119, 28);
            button1.TabIndex = 36;
            button1.Text = "Get All Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // summaryDataGridView
            // 
            summaryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            summaryDataGridView.BackgroundColor = Color.BurlyWood;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Red;
            summaryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            summaryDataGridView.ColumnHeadersHeight = 25;
            summaryDataGridView.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            summaryDataGridView.Location = new Point(12, 465);
            summaryDataGridView.Name = "summaryDataGridView";
            summaryDataGridView.ReadOnly = true;
            summaryDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Blue;
            summaryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            summaryDataGridView.Size = new Size(362, 153);
            summaryDataGridView.TabIndex = 37;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(847, 533);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(101, 28);
            CloseButton.TabIndex = 38;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += button2_Click;
            // 
            // bankDepositTextBox
            // 
            bankDepositTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            bankDepositTextBox.Location = new Point(187, 154);
            bankDepositTextBox.Name = "bankDepositTextBox";
            bankDepositTextBox.Size = new Size(200, 22);
            bankDepositTextBox.TabIndex = 40;
            bankDepositTextBox.Text = "0";
            bankDepositTextBox.Leave += bankDepositTextBox_Leave;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(12, 154);
            label7.Name = "label7";
            label7.Size = new Size(179, 28);
            label7.TabIndex = 39;
            label7.Text = "Bank Deposit Amount :";
            // 
            // InCashTextBox
            // 
            InCashTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            InCashTextBox.Location = new Point(187, 200);
            InCashTextBox.Name = "InCashTextBox";
            InCashTextBox.Size = new Size(200, 22);
            InCashTextBox.TabIndex = 42;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(12, 200);
            label8.Name = "label8";
            label8.Size = new Size(135, 28);
            label8.TabIndex = 41;
            label8.Text = "Amount In Cash:";
            // 
            // CollectionEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1136, 641);
            Controls.Add(InCashTextBox);
            Controls.Add(label8);
            Controls.Add(bankDepositTextBox);
            Controls.Add(label7);
            Controls.Add(CloseButton);
            Controls.Add(summaryDataGridView);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AddNewButton);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(DescTextBox);
            Controls.Add(label5);
            Controls.Add(AmountTextBox);
            Controls.Add(label4);
            Controls.Add(CollectionTypeComboBox);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Name = "CollectionEntryForm";
            Text = "CollectionEntryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox DescTextBox;
        private Label label5;
        private TextBox AmountTextBox;
        private Label label4;
        private ComboBox CollectionTypeComboBox;
        private Label label1;
        private Button SaveButton;
        private DataGridView dataGridView1;
        private Button DeleteButton;
        private Button ClearButton;
        private Button AddNewButton;
        private Label label2;
        private Label label3;
        private Button button1;
        private DataGridView summaryDataGridView;
        private Button CloseButton;
        private TextBox bankDepositTextBox;
        private Label label7;
        private TextBox InCashTextBox;
        private Label label8;
    }
}