namespace WorldCupForm
{
    partial class RankedPlayerUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankedPlayerUserControl));
            this.pbPlayerPicture = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblGoalsTxt = new System.Windows.Forms.Label();
            this.lblYellowCardsTxt = new System.Windows.Forms.Label();
            this.lblAppearancesTxt = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            this.lblYellowCards = new System.Windows.Forms.Label();
            this.lblAppearances = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerPicture
            // 
            this.pbPlayerPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerPicture.Image")));
            this.pbPlayerPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPlayerPicture.InitialImage")));
            this.pbPlayerPicture.Location = new System.Drawing.Point(0, 0);
            this.pbPlayerPicture.Name = "pbPlayerPicture";
            this.pbPlayerPicture.Size = new System.Drawing.Size(50, 50);
            this.pbPlayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerPicture.TabIndex = 1;
            this.pbPlayerPicture.TabStop = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerName.Location = new System.Drawing.Point(56, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(100, 50);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "(Name)";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoalsTxt
            // 
            this.lblGoalsTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGoalsTxt.Location = new System.Drawing.Point(162, 0);
            this.lblGoalsTxt.Name = "lblGoalsTxt";
            this.lblGoalsTxt.Size = new System.Drawing.Size(78, 16);
            this.lblGoalsTxt.TabIndex = 3;
            this.lblGoalsTxt.Text = "Goals:";
            this.lblGoalsTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYellowCardsTxt
            // 
            this.lblYellowCardsTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYellowCardsTxt.Location = new System.Drawing.Point(162, 17);
            this.lblYellowCardsTxt.Name = "lblYellowCardsTxt";
            this.lblYellowCardsTxt.Size = new System.Drawing.Size(78, 16);
            this.lblYellowCardsTxt.TabIndex = 4;
            this.lblYellowCardsTxt.Text = "Yellow Cards:";
            this.lblYellowCardsTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppearancesTxt
            // 
            this.lblAppearancesTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppearancesTxt.Location = new System.Drawing.Point(162, 34);
            this.lblAppearancesTxt.Name = "lblAppearancesTxt";
            this.lblAppearancesTxt.Size = new System.Drawing.Size(78, 16);
            this.lblAppearancesTxt.TabIndex = 5;
            this.lblAppearancesTxt.Text = "Appearances:";
            this.lblAppearancesTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoals
            // 
            this.lblGoals.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGoals.Location = new System.Drawing.Point(246, 0);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(27, 16);
            this.lblGoals.TabIndex = 6;
            this.lblGoals.Text = "0";
            this.lblGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYellowCards
            // 
            this.lblYellowCards.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYellowCards.Location = new System.Drawing.Point(246, 16);
            this.lblYellowCards.Name = "lblYellowCards";
            this.lblYellowCards.Size = new System.Drawing.Size(27, 17);
            this.lblYellowCards.TabIndex = 7;
            this.lblYellowCards.Text = "0";
            this.lblYellowCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppearances
            // 
            this.lblAppearances.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppearances.Location = new System.Drawing.Point(246, 34);
            this.lblAppearances.Name = "lblAppearances";
            this.lblAppearances.Size = new System.Drawing.Size(27, 16);
            this.lblAppearances.TabIndex = 8;
            this.lblAppearances.Text = "0";
            this.lblAppearances.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RankedPlayerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.lblAppearances);
            this.Controls.Add(this.lblYellowCards);
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.lblAppearancesTxt);
            this.Controls.Add(this.lblYellowCardsTxt);
            this.Controls.Add(this.lblGoalsTxt);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbPlayerPicture);
            this.Name = "RankedPlayerUserControl";
            this.Size = new System.Drawing.Size(273, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pbPlayerPicture;
        private Label lblPlayerName;
        private Label lblGoalsTxt;
        private Label lblYellowCardsTxt;
        private Label lblAppearancesTxt;
        private Label lblGoals;
        private Label lblYellowCards;
        private Label lblAppearances;
    }
}
