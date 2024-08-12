namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class CollectionReportsForm
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
            FromdateTimePicker = new DateTimePicker();
            label1 = new Label();
            TodateTimePicker = new DateTimePicker();
            label6 = new Label();
            ClearButton = new Button();
            CloseButton = new Button();
            GetButton = new Button();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            CollectionTypeComboBox = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FromdateTimePicker
            // 
            FromdateTimePicker.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FromdateTimePicker.Location = new Point(174, 157);
            FromdateTimePicker.Name = "FromdateTimePicker";
            FromdateTimePicker.Size = new Size(221, 21);
            FromdateTimePicker.TabIndex = 89;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(26, 157);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 99;
            label1.Text = "From Date :";
            // 
            // TodateTimePicker
            // 
            TodateTimePicker.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodateTimePicker.Location = new Point(174, 219);
            TodateTimePicker.Name = "TodateTimePicker";
            TodateTimePicker.Size = new Size(221, 21);
            TodateTimePicker.TabIndex = 90;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(26, 219);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 98;
            label6.Text = "To Date :";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(190, 276);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(95, 28);
            ClearButton.TabIndex = 92;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.LightCoral;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(306, 276);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(101, 28);
            CloseButton.TabIndex = 93;
            CloseButton.Text = "Close Form";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // GetButton
            // 
            GetButton.BackColor = Color.DeepSkyBlue;
            GetButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetButton.Location = new Point(37, 276);
            GetButton.Name = "GetButton";
            GetButton.Size = new Size(119, 28);
            GetButton.TabIndex = 91;
            GetButton.Text = "Get All Data";
            GetButton.UseVisualStyleBackColor = false;
            GetButton.Click += GetButton_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.ColumnHeadersHeight = 25;
            dataGridView1.Location = new Point(432, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(362, 212);
            dataGridView1.TabIndex = 95;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(51, 38);
            label10.Name = "label10";
            label10.Size = new Size(356, 28);
            label10.TabIndex = 94;
            label10.Text = "Collection Report Generation Form";
            // 
            // CollectionTypeComboBox
            // 
            CollectionTypeComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CollectionTypeComboBox.FormattingEnabled = true;
            CollectionTypeComboBox.Location = new Point(174, 90);
            CollectionTypeComboBox.Name = "CollectionTypeComboBox";
            CollectionTypeComboBox.Size = new Size(221, 24);
            CollectionTypeComboBox.TabIndex = 88;
            CollectionTypeComboBox.SelectedIndexChanged += CollectionTypeComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(26, 90);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 100;
            label4.Text = "Collection Type:";
            // 
            // CollectionReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(805, 327);
            Controls.Add(CollectionTypeComboBox);
            Controls.Add(label4);
            Controls.Add(FromdateTimePicker);
            Controls.Add(label1);
            Controls.Add(TodateTimePicker);
            Controls.Add(label6);
            Controls.Add(ClearButton);
            Controls.Add(CloseButton);
            Controls.Add(GetButton);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "CollectionReportsForm";
            Text = "CollectionReportsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker FromdateTimePicker;
        private Label label1;
        private DateTimePicker TodateTimePicker;
        private Label label6;
        private Button ClearButton;
        private Button CloseButton;
        private Button GetButton;
        private DataGridView dataGridView1;
        private Label label10;
        private ComboBox CollectionTypeComboBox;
        private Label label4;
    }
}