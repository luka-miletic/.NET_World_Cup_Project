namespace WorldCupForm
{
    partial class RankingsForm
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
            this.flpPlayersRanking = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMatchRanking = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlayersRanking = new System.Windows.Forms.Label();
            this.lblMatchRanking = new System.Windows.Forms.Label();
            this.btnPrintMatches = new System.Windows.Forms.Button();
            this.btnPrintPlayers = new System.Windows.Forms.Button();
            this.lblSelectedTeamName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpPlayersRanking
            // 
            this.flpPlayersRanking.AllowDrop = true;
            this.flpPlayersRanking.AutoScroll = true;
            this.flpPlayersRanking.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpPlayersRanking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpPlayersRanking.Location = new System.Drawing.Point(9, 61);
            this.flpPlayersRanking.Name = "flpPlayersRanking";
            this.flpPlayersRanking.Size = new System.Drawing.Size(300, 354);
            this.flpPlayersRanking.TabIndex = 6;
            // 
            // flpMatchRanking
            // 
            this.flpMatchRanking.AllowDrop = true;
            this.flpMatchRanking.AutoScroll = true;
            this.flpMatchRanking.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpMatchRanking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpMatchRanking.Location = new System.Drawing.Point(315, 61);
            this.flpMatchRanking.Name = "flpMatchRanking";
            this.flpMatchRanking.Size = new System.Drawing.Size(300, 354);
            this.flpMatchRanking.TabIndex = 5;
            // 
            // lblPlayersRanking
            // 
            this.lblPlayersRanking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayersRanking.Location = new System.Drawing.Point(9, 35);
            this.lblPlayersRanking.Name = "lblPlayersRanking";
            this.lblPlayersRanking.Size = new System.Drawing.Size(300, 23);
            this.lblPlayersRanking.TabIndex = 0;
            this.lblPlayersRanking.Text = "Players Ranking";
            this.lblPlayersRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatchRanking
            // 
            this.lblMatchRanking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatchRanking.Location = new System.Drawing.Point(315, 35);
            this.lblMatchRanking.Name = "lblMatchRanking";
            this.lblMatchRanking.Size = new System.Drawing.Size(300, 23);
            this.lblMatchRanking.TabIndex = 7;
            this.lblMatchRanking.Text = "Matches Ranking";
            this.lblMatchRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrintMatches
            // 
            this.btnPrintMatches.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrintMatches.Location = new System.Drawing.Point(315, 421);
            this.btnPrintMatches.Name = "btnPrintMatches";
            this.btnPrintMatches.Size = new System.Drawing.Size(300, 36);
            this.btnPrintMatches.TabIndex = 8;
            this.btnPrintMatches.Text = "Print Matches";
            this.btnPrintMatches.UseVisualStyleBackColor = true;
            this.btnPrintMatches.Click += new System.EventHandler(this.btnPrintMatches_Click);
            // 
            // btnPrintPlayers
            // 
            this.btnPrintPlayers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrintPlayers.Location = new System.Drawing.Point(12, 421);
            this.btnPrintPlayers.Name = "btnPrintPlayers";
            this.btnPrintPlayers.Size = new System.Drawing.Size(298, 36);
            this.btnPrintPlayers.TabIndex = 9;
            this.btnPrintPlayers.Text = "Print Players";
            this.btnPrintPlayers.UseVisualStyleBackColor = true;
            this.btnPrintPlayers.Click += new System.EventHandler(this.btnPrintPlayers_Click);
            // 
            // lblSelectedTeamName
            // 
            this.lblSelectedTeamName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedTeamName.Location = new System.Drawing.Point(12, 9);
            this.lblSelectedTeamName.Name = "lblSelectedTeamName";
            this.lblSelectedTeamName.Size = new System.Drawing.Size(599, 26);
            this.lblSelectedTeamName.TabIndex = 10;
            this.lblSelectedTeamName.Text = "team";
            this.lblSelectedTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RankingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 465);
            this.Controls.Add(this.lblSelectedTeamName);
            this.Controls.Add(this.btnPrintPlayers);
            this.Controls.Add(this.btnPrintMatches);
            this.Controls.Add(this.lblMatchRanking);
            this.Controls.Add(this.lblPlayersRanking);
            this.Controls.Add(this.flpPlayersRanking);
            this.Controls.Add(this.flpMatchRanking);
            this.Name = "RankingsForm";
            this.Text = "RankingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpPlayersRanking;
        private FlowLayoutPanel flpMatchRanking;
        private Label lblPlayersRanking;
        private Label lblMatchRanking;
        private Button btnPrintMatches;
        private Button btnPrintPlayers;
        private Label lblSelectedTeamName;
    }
}