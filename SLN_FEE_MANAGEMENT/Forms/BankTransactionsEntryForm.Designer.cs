namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class BankTransactionsEntryForm
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
            bankDepositTextBox = new TextBox();
            label7 = new Label();
            label3 = new Label();
            AddNewButton = new Button();
            ClearButton = new Button();
            DeleteButton = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            DescTextBox = new TextBox();
            label5 = new Label();
            CollectionFromComboBox = new ComboBox();
            label1 = new Label();
            SaveButton = new Button();
            label2 = new Label();
            SendToComboBox = new ComboBox();
            senderTextBox = new TextBox();
            label4 = new Label();
            summaryDataGridView = new DataGridView();
            CloseButton = new Button();
            button1 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // bankDepositTextBox
            // 
            bankDepositTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            bankDepositTextBox.Location = new Point(197, 141);
            bankDepositTextBox.Name = "bankDepositTextBox";
            bankDepositTextBox.Size = new Size(242, 22);
            bankDepositTextBox.TabIndex = 56;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(12, 141);
            label7.Name = "label7";
            label7.Size = new Size(179, 28);
            label7.TabIndex = 55;
            label7.Text = "Bank Deposit Amount :";
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(623, 12);
            label3.Name = "label3";
            label3.Size = new Size(338, 28);
            label3.TabIndex = 54;
            label3.Text = "Saved Bank Transaction Details";
            // 
            // AddNewButton
            // 
            AddNewButton.BackColor = Color.DeepSkyBlue;
            AddNewButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewButton.Location = new Point(73, 331);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(94, 28);
            AddNewButton.TabIndex = 53;
            AddNewButton.Text = "Add New";
            AddNewButton.UseVisualStyleBackColor = false;
            AddNewButton.Click += AddNewButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(268, 386);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(95, 28);
            ClearButton.TabIndex = 52;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.LightCoral;
            DeleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(73, 386);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 28);
            DeleteButton.TabIndex = 51;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
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
            dataGridView1.Location = new Point(477, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(705, 379);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(197, 276);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 21);
            dateTimePicker1.TabIndex = 49;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(12, 276);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 48;
            label6.Text = "Entry Date :";
            // 
            // DescTextBox
            // 
            DescTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            DescTextBox.Location = new Point(197, 231);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(242, 22);
            DescTextBox.TabIndex = 47;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 46;
            label5.Text = "Description :";
            // 
            // CollectionFromComboBox
            // 
            CollectionFromComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CollectionFromComboBox.FormattingEnabled = true;
            CollectionFromComboBox.Items.AddRange(new object[] { "Old Campus", "New Campus", "PCG", "Others" });
            CollectionFromComboBox.Location = new Point(197, 56);
            CollectionFromComboBox.Name = "CollectionFromComboBox";
            CollectionFromComboBox.Size = new Size(242, 24);
            CollectionFromComboBox.TabIndex = 43;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 42;
            label1.Text = "Amount Sending From:";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DeepSkyBlue;
            SaveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(268, 331);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(95, 28);
            SaveButton.TabIndex = 41;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(179, 28);
            label2.TabIndex = 57;
            label2.Text = "Amount Send To:";
            // 
            // SendToComboBox
            // 
            SendToComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendToComboBox.FormattingEnabled = true;
            SendToComboBox.Items.AddRange(new object[] { "Indian Bank Society Account", "Indian Bank Primary Account", "Andhra Bank", "Bank Of Baroda" });
            SendToComboBox.Location = new Point(197, 103);
            SendToComboBox.Name = "SendToComboBox";
            SendToComboBox.Size = new Size(242, 24);
            SendToComboBox.TabIndex = 58;
            // 
            // senderTextBox
            // 
            senderTextBox.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            senderTextBox.Location = new Point(197, 185);
            senderTextBox.Name = "senderTextBox";
            senderTextBox.Size = new Size(242, 22);
            senderTextBox.TabIndex = 60;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 59;
            label4.Text = "Sender Name:";
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
            summaryDataGridView.Location = new Point(12, 477);
            summaryDataGridView.Name = "summaryDataGridView";
            summaryDataGridView.ReadOnly = true;
            summaryDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Blue;
            summaryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            summaryDataGridView.Size = new Size(965, 153);
            summaryDataGridView.TabIndex = 61;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(1018, 590);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(119, 28);
            CloseButton.TabIndex = 63;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1018, 477);
            button1.Name = "button1";
            button1.Size = new Size(119, 28);
            button1.TabIndex = 62;
            button1.Text = "Get All Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(73, 446);
            label8.Name = "label8";
            label8.Size = new Size(453, 28);
            label8.TabIndex = 64;
            label8.Text = "Monthly Bank Transaction Summary Details";
            // 
            // BankTransactionsEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1214, 642);
            Controls.Add(label8);
            Controls.Add(CloseButton);
            Controls.Add(button1);
            Controls.Add(summaryDataGridView);
            Controls.Add(senderTextBox);
            Controls.Add(label4);
            Controls.Add(SendToComboBox);
            Controls.Add(label2);
            Controls.Add(bankDepositTextBox);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(AddNewButton);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(DescTextBox);
            Controls.Add(label5);
            Controls.Add(CollectionFromComboBox);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Name = "BankTransactionsEntryForm";
            Text = "Bank Transactions Entry Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)summaryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bankDepositTextBox;
        private Label label7;
        private Label label3;
        private Button AddNewButton;
        private Button ClearButton;
        private Button DeleteButton;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox DescTextBox;
        private Label label5;
        private ComboBox CollectionFromComboBox;
        private Label label1;
        private Button SaveButton;
        private Label label2;
        private ComboBox SendToComboBox;
        private TextBox senderTextBox;
        private Label label4;
        private DataGridView summaryDataGridView;
        private Button CloseButton;
        private Button button1;
        private Label label8;
    }
}