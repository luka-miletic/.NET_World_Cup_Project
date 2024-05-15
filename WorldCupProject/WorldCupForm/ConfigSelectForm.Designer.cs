namespace WorldCupForm
{
    partial class ConfigSelectForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.genderSelectLabel = new System.Windows.Forms.Label();
            this.menRadioButton = new System.Windows.Forms.RadioButton();
            this.womenRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.languageSelectLabel = new System.Windows.Forms.Label();
            this.CRORadioButton = new System.Windows.Forms.RadioButton();
            this.ENGRadioButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataModeLabel = new System.Windows.Forms.Label();
            this.FILERadioButton = new System.Windows.Forms.RadioButton();
            this.APIRadioButton = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // genderSelectLabel
            // 
            this.genderSelectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderSelectLabel.Location = new System.Drawing.Point(25, 13);
            this.genderSelectLabel.Name = "genderSelectLabel";
            this.genderSelectLabel.Size = new System.Drawing.Size(92, 26);
            this.genderSelectLabel.TabIndex = 1;
            this.genderSelectLabel.Text = "Gender";
            this.genderSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menRadioButton
            // 
            this.menRadioButton.AutoSize = true;
            this.menRadioButton.Checked = true;
            this.menRadioButton.Location = new System.Drawing.Point(139, 19);
            this.menRadioButton.Name = "menRadioButton";
            this.menRadioButton.Size = new System.Drawing.Size(49, 19);
            this.menRadioButton.TabIndex = 5;
            this.menRadioButton.TabStop = true;
            this.menRadioButton.Text = "Men";
            this.menRadioButton.UseVisualStyleBackColor = true;
            // 
            // womenRadioButton
            // 
            this.womenRadioButton.AutoSize = true;
            this.womenRadioButton.Location = new System.Drawing.Point(228, 19);
            this.womenRadioButton.Name = "womenRadioButton";
            this.womenRadioButton.Size = new System.Drawing.Size(67, 19);
            this.womenRadioButton.TabIndex = 6;
            this.womenRadioButton.Text = "Women";
            this.womenRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.genderSelectLabel);
            this.panel1.Controls.Add(this.womenRadioButton);
            this.panel1.Controls.Add(this.menRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 53);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.languageSelectLabel);
            this.panel2.Controls.Add(this.CRORadioButton);
            this.panel2.Controls.Add(this.ENGRadioButton);
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 53);
            this.panel2.TabIndex = 8;
            // 
            // languageSelectLabel
            // 
            this.languageSelectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.languageSelectLabel.Location = new System.Drawing.Point(25, 15);
            this.languageSelectLabel.Name = "languageSelectLabel";
            this.languageSelectLabel.Size = new System.Drawing.Size(92, 23);
            this.languageSelectLabel.TabIndex = 1;
            this.languageSelectLabel.Text = "Language";
            this.languageSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CRORadioButton
            // 
            this.CRORadioButton.AutoSize = true;
            this.CRORadioButton.Location = new System.Drawing.Point(228, 19);
            this.CRORadioButton.Name = "CRORadioButton";
            this.CRORadioButton.Size = new System.Drawing.Size(49, 19);
            this.CRORadioButton.TabIndex = 6;
            this.CRORadioButton.Text = "CRO";
            this.CRORadioButton.UseVisualStyleBackColor = true;
            // 
            // ENGRadioButton
            // 
            this.ENGRadioButton.AutoSize = true;
            this.ENGRadioButton.Checked = true;
            this.ENGRadioButton.Location = new System.Drawing.Point(139, 19);
            this.ENGRadioButton.Name = "ENGRadioButton";
            this.ENGRadioButton.Size = new System.Drawing.Size(48, 19);
            this.ENGRadioButton.TabIndex = 5;
            this.ENGRadioButton.TabStop = true;
            this.ENGRadioButton.Text = "ENG";
            this.ENGRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataModeLabel);
            this.panel3.Controls.Add(this.FILERadioButton);
            this.panel3.Controls.Add(this.APIRadioButton);
            this.panel3.Location = new System.Drawing.Point(12, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 53);
            this.panel3.TabIndex = 9;
            // 
            // DataModeLabel
            // 
            this.DataModeLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataModeLabel.Location = new System.Drawing.Point(25, 13);
            this.DataModeLabel.Name = "DataModeLabel";
            this.DataModeLabel.Size = new System.Drawing.Size(92, 30);
            this.DataModeLabel.TabIndex = 1;
            this.DataModeLabel.Text = "Data Retrieval Mode";
            this.DataModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FILERadioButton
            // 
            this.FILERadioButton.AutoSize = true;
            this.FILERadioButton.Location = new System.Drawing.Point(228, 19);
            this.FILERadioButton.Name = "FILERadioButton";
            this.FILERadioButton.Size = new System.Drawing.Size(46, 19);
            this.FILERadioButton.TabIndex = 6;
            this.FILERadioButton.Text = "FILE";
            this.FILERadioButton.UseVisualStyleBackColor = true;
            // 
            // APIRadioButton
            // 
            this.APIRadioButton.AutoSize = true;
            this.APIRadioButton.Checked = true;
            this.APIRadioButton.Location = new System.Drawing.Point(139, 19);
            this.APIRadioButton.Name = "APIRadioButton";
            this.APIRadioButton.Size = new System.Drawing.Size(43, 19);
            this.APIRadioButton.TabIndex = 5;
            this.APIRadioButton.TabStop = true;
            this.APIRadioButton.Text = "API";
            this.APIRadioButton.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(338, 43);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ConfigSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(362, 255);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConfigSelectForm";
            this.Text = "WorldCupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label genderSelectLabel;
        private RadioButton menRadioButton;
        private RadioButton womenRadioButton;
        private Panel panel1;
        private Panel panel2;
        private Label languageSelectLabel;
        private RadioButton CRORadioButton;
        private RadioButton ENGRadioButton;
        private Panel panel3;
        private Label DataModeLabel;
        private RadioButton FILERadioButton;
        private RadioButton APIRadioButton;
        private Button btnSubmit;
    }
}