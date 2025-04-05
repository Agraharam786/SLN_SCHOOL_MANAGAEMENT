namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class EmailForm
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
            senEmailButton = new Button();
            EmailFromComboBox = new ComboBox();
            label1 = new Label();
            ReoprtTypeComboBox = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // senEmailButton
            // 
            senEmailButton.BackColor = Color.DeepSkyBlue;
            senEmailButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            senEmailButton.Location = new Point(315, 197);
            senEmailButton.Name = "senEmailButton";
            senEmailButton.Size = new Size(95, 32);
            senEmailButton.TabIndex = 93;
            senEmailButton.Text = "Send Email";
            senEmailButton.UseVisualStyleBackColor = false;
            senEmailButton.Click += senEmailButton_Click;
            // 
            // EmailFromComboBox
            // 
            EmailFromComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailFromComboBox.FormattingEnabled = true;
            EmailFromComboBox.Items.AddRange(new object[] { "Old Campus", "New Campus", "PCG", "Others" });
            EmailFromComboBox.Location = new Point(235, 36);
            EmailFromComboBox.Name = "EmailFromComboBox";
            EmailFromComboBox.Size = new Size(242, 24);
            EmailFromComboBox.TabIndex = 95;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(50, 36);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 94;
            label1.Text = "Email Sending From:";
            // 
            // ReoprtTypeComboBox
            // 
            ReoprtTypeComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReoprtTypeComboBox.FormattingEnabled = true;
            ReoprtTypeComboBox.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            ReoprtTypeComboBox.Location = new Point(235, 96);
            ReoprtTypeComboBox.Name = "ReoprtTypeComboBox";
            ReoprtTypeComboBox.Size = new Size(242, 24);
            ReoprtTypeComboBox.TabIndex = 97;
            ReoprtTypeComboBox.Text = "Daily";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(179, 28);
            label2.TabIndex = 96;
            label2.Text = "Sending Report Type:";
            // 
            // EmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(ReoprtTypeComboBox);
            Controls.Add(label2);
            Controls.Add(EmailFromComboBox);
            Controls.Add(label1);
            Controls.Add(senEmailButton);
            Name = "EmailForm";
            Text = "EmailForm";
            ResumeLayout(false);
        }

        #endregion

        private Button senEmailButton;
        private ComboBox EmailFromComboBox;
        private Label label1;
        private ComboBox ReoprtTypeComboBox;
        private Label label2;
    }
}