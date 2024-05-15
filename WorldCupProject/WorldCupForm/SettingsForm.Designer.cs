namespace WorldCupForm
{
    partial class SettingsForm
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
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbDataAccessMode = new System.Windows.Forms.ComboBox();
            this.lblDataAccessMode = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGender
            // 
            this.lblGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGender.Location = new System.Drawing.Point(12, 10);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(136, 23);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGender.Items.AddRange(new object[] {
            "MEN",
            "WOMEN"});
            this.cbGender.Location = new System.Drawing.Point(154, 10);
            this.cbGender.MaxDropDownItems = 2;
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(98, 23);
            this.cbGender.TabIndex = 1;
            // 
            // cbDataAccessMode
            // 
            this.cbDataAccessMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataAccessMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDataAccessMode.Items.AddRange(new object[] {
            "API",
            "FILE"});
            this.cbDataAccessMode.Location = new System.Drawing.Point(154, 39);
            this.cbDataAccessMode.MaxDropDownItems = 2;
            this.cbDataAccessMode.Name = "cbDataAccessMode";
            this.cbDataAccessMode.Size = new System.Drawing.Size(98, 23);
            this.cbDataAccessMode.TabIndex = 3;
            // 
            // lblDataAccessMode
            // 
            this.lblDataAccessMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataAccessMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataAccessMode.Location = new System.Drawing.Point(12, 39);
            this.lblDataAccessMode.Name = "lblDataAccessMode";
            this.lblDataAccessMode.Size = new System.Drawing.Size(136, 23);
            this.lblDataAccessMode.TabIndex = 2;
            this.lblDataAccessMode.Text = "Data Selection Mode";
            this.lblDataAccessMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLanguage.Items.AddRange(new object[] {
            "en-US",
            "hr-HR"});
            this.cbLanguage.Location = new System.Drawing.Point(154, 68);
            this.cbLanguage.MaxDropDownItems = 2;
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(98, 23);
            this.cbLanguage.TabIndex = 5;
            // 
            // lblLanguage
            // 
            this.lblLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLanguage.Location = new System.Drawing.Point(12, 68);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(136, 23);
            this.lblLanguage.TabIndex = 4;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 108);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(240, 44);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 162);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbDataAccessMode);
            this.Controls.Add(this.lblDataAccessMode);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblGender);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblGender;
        private ComboBox cbGender;
        private ComboBox cbDataAccessMode;
        private Label lblDataAccessMode;
        private ComboBox cbLanguage;
        private Label lblLanguage;
        private Button btnAccept;
    }
}