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
            // EmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(senEmailButton);
            Name = "EmailForm";
            Text = "EmailForm";
            ResumeLayout(false);
        }

        #endregion

        private Button senEmailButton;
    }
}