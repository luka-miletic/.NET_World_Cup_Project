namespace WorldCupForm
{
    partial class RankedMatchUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblHomeName = new System.Windows.Forms.Label();
            this.lblAwayName = new System.Windows.Forms.Label();
            this.lblHomeTxt = new System.Windows.Forms.Label();
            this.lblAwayTxt = new System.Windows.Forms.Label();
            this.lblVisitorsTxt = new System.Windows.Forms.Label();
            this.lblVisitors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVenue
            // 
            this.lblVenue.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVenue.Location = new System.Drawing.Point(0, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(75, 50);
            this.lblVenue.TabIndex = 2;
            this.lblVenue.Text = "(Name)";
            this.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHomeName
            // 
            this.lblHomeName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHomeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHomeName.Location = new System.Drawing.Point(132, 0);
            this.lblHomeName.Name = "lblHomeName";
            this.lblHomeName.Size = new System.Drawing.Size(70, 23);
            this.lblHomeName.TabIndex = 3;
            this.lblHomeName.Text = "(Name)";
            this.lblHomeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAwayName
            // 
            this.lblAwayName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAwayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAwayName.Location = new System.Drawing.Point(132, 28);
            this.lblAwayName.Name = "lblAwayName";
            this.lblAwayName.Size = new System.Drawing.Size(70, 23);
            this.lblAwayName.TabIndex = 4;
            this.lblAwayName.Text = "(Name)";
            this.lblAwayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHomeTxt
            // 
            this.lblHomeTxt.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHomeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHomeTxt.Location = new System.Drawing.Point(81, 0);
            this.lblHomeTxt.Name = "lblHomeTxt";
            this.lblHomeTxt.Size = new System.Drawing.Size(45, 23);
            this.lblHomeTxt.TabIndex = 5;
            this.lblHomeTxt.Text = "Home:";
            this.lblHomeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAwayTxt
            // 
            this.lblAwayTxt.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAwayTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAwayTxt.Location = new System.Drawing.Point(81, 28);
            this.lblAwayTxt.Name = "lblAwayTxt";
            this.lblAwayTxt.Size = new System.Drawing.Size(45, 23);
            this.lblAwayTxt.TabIndex = 6;
            this.lblAwayTxt.Text = "Away:";
            this.lblAwayTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVisitorsTxt
            // 
            this.lblVisitorsTxt.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVisitorsTxt.Location = new System.Drawing.Point(208, 0);
            this.lblVisitorsTxt.Name = "lblVisitorsTxt";
            this.lblVisitorsTxt.Size = new System.Drawing.Size(65, 23);
            this.lblVisitorsTxt.TabIndex = 7;
            this.lblVisitorsTxt.Text = "Visitors";
            this.lblVisitorsTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisitors
            // 
            this.lblVisitors.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVisitors.Location = new System.Drawing.Point(208, 28);
            this.lblVisitors.Name = "lblVisitors";
            this.lblVisitors.Size = new System.Drawing.Size(65, 23);
            this.lblVisitors.TabIndex = 8;
            this.lblVisitors.Text = "(Visitors)";
            this.lblVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RankedMatchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.lblVisitors);
            this.Controls.Add(this.lblVisitorsTxt);
            this.Controls.Add(this.lblAwayTxt);
            this.Controls.Add(this.lblHomeTxt);
            this.Controls.Add(this.lblAwayName);
            this.Controls.Add(this.lblHomeName);
            this.Controls.Add(this.lblVenue);
            this.Name = "RankedMatchUserControl";
            this.Size = new System.Drawing.Size(273, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblVenue;
        private Label lblHomeName;
        private Label lblAwayName;
        private Label lblHomeTxt;
        private Label lblAwayTxt;
        private Label lblVisitorsTxt;
        private Label lblVisitors;
    }
}
