namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class BulkInsertStudentDetails
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
            label1 = new Label();
            BrowseButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            FilePathTextBox = new TextBox();
            LoadButton = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            SaveButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(31, 63);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose File Path :";
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = Color.DeepSkyBlue;
            BrowseButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrowseButton.Location = new Point(546, 55);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(115, 37);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Location = new Point(185, 63);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.Size = new Size(355, 23);
            FilePathTextBox.TabIndex = 2;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = Color.DeepSkyBlue;
            LoadButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadButton.Location = new Point(682, 55);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(117, 37);
            LoadButton.TabIndex = 3;
            LoadButton.Text = "Load Data";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-192, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1231, 419);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(31, 122);
            label2.Name = "label2";
            label2.Size = new Size(492, 20);
            label2.TabIndex = 5;
            label2.Text = "Please Validated The Loaded Data And Click Save to Commit the Data";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DeepSkyBlue;
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(546, 113);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(117, 37);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save Data";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(698, 118);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(101, 28);
            CloseButton.TabIndex = 39;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // BulkInsertStudentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1041, 574);
            Controls.Add(CloseButton);
            Controls.Add(SaveButton);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(LoadButton);
            Controls.Add(FilePathTextBox);
            Controls.Add(BrowseButton);
            Controls.Add(label1);
            Name = "BulkInsertStudentDetails";
            Text = "BulkInsertStudentDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BrowseButton;
        private OpenFileDialog openFileDialog1;
        private TextBox FilePathTextBox;
        private Button LoadButton;
        private DataGridView dataGridView1;
        private Label label2;
        private Button SaveButton;
        private Button CloseButton;
    }
}