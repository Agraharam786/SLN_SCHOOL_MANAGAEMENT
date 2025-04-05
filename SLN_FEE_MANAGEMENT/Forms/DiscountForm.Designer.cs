namespace SLN_FEE_MANAGEMENT.Forms
{
    partial class DiscountForm
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
            SectionComboBox = new ComboBox();
            label4 = new Label();
            AcademicYearComboBox = new ComboBox();
            ClassComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FreeCheckBox = new CheckBox();
            HalffreeCheckBox = new CheckBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // SectionComboBox
            // 
            SectionComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SectionComboBox.FormattingEnabled = true;
            SectionComboBox.Location = new Point(183, 166);
            SectionComboBox.Name = "SectionComboBox";
            SectionComboBox.Size = new Size(148, 25);
            SectionComboBox.TabIndex = 80;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(34, 165);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 79;
            label4.Text = "Section :";
            // 
            // AcademicYearComboBox
            // 
            AcademicYearComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AcademicYearComboBox.FormattingEnabled = true;
            AcademicYearComboBox.Location = new Point(183, 122);
            AcademicYearComboBox.Name = "AcademicYearComboBox";
            AcademicYearComboBox.Size = new Size(148, 25);
            AcademicYearComboBox.TabIndex = 78;
            // 
            // ClassComboBox
            // 
            ClassComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(183, 68);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(148, 25);
            ClassComboBox.TabIndex = 77;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(34, 121);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 76;
            label3.Text = "Academic Year :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(34, 68);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 75;
            label2.Text = "Select Class :";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(34, 209);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 81;
            label1.Text = "Is_Free_Student :";
            // 
            // FreeCheckBox
            // 
            FreeCheckBox.AutoSize = true;
            FreeCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FreeCheckBox.Location = new Point(183, 212);
            FreeCheckBox.Name = "FreeCheckBox";
            FreeCheckBox.Size = new Size(61, 25);
            FreeCheckBox.TabIndex = 83;
            FreeCheckBox.TabStop = false;
            FreeCheckBox.Text = "Free";
            FreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // HalffreeCheckBox
            // 
            HalffreeCheckBox.AutoSize = true;
            HalffreeCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HalffreeCheckBox.Location = new Point(183, 250);
            HalffreeCheckBox.Name = "HalffreeCheckBox";
            HalffreeCheckBox.Size = new Size(97, 25);
            HalffreeCheckBox.TabIndex = 85;
            HalffreeCheckBox.TabStop = false;
            HalffreeCheckBox.Text = "Half Free";
            HalffreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(34, 250);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 84;
            label5.Text = "Is_Half_Free :";
            // 
            // DiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(HalffreeCheckBox);
            Controls.Add(label5);
            Controls.Add(FreeCheckBox);
            Controls.Add(label1);
            Controls.Add(SectionComboBox);
            Controls.Add(label4);
            Controls.Add(AcademicYearComboBox);
            Controls.Add(ClassComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "DiscountForm";
            Text = "DiscountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SectionComboBox;
        private Label label4;
        private ComboBox AcademicYearComboBox;
        private ComboBox ClassComboBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox FreeCheckBox;
        private CheckBox HalffreeCheckBox;
        private Label label5;
    }
}