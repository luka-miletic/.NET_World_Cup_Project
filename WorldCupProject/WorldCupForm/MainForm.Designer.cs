namespace WorldCupForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblLoadingProgress = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpFavPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblFavouriteTeams = new System.Windows.Forms.Label();
            this.btnSetFavTeam = new System.Windows.Forms.Button();
            this.lblFavTeamConfirm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoadingProgress
            // 
            this.lblLoadingProgress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoadingProgress.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLoadingProgress.Location = new System.Drawing.Point(12, 381);
            this.lblLoadingProgress.Name = "lblLoadingProgress";
            this.lblLoadingProgress.Size = new System.Drawing.Size(198, 20);
            this.lblLoadingProgress.TabIndex = 0;
            this.lblLoadingProgress.Text = "Loading Data...";
            this.lblLoadingProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.rankingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.rankingToolStripMenuItem.Text = "Ranking Lists";
            this.rankingToolStripMenuItem.Click += new System.EventHandler(this.rankingToolStripMenuItem_Click);
            // 
            // flpFavPlayers
            // 
            this.flpFavPlayers.AllowDrop = true;
            this.flpFavPlayers.AutoScroll = true;
            this.flpFavPlayers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpFavPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpFavPlayers.Location = new System.Drawing.Point(522, 53);
            this.flpFavPlayers.Name = "flpFavPlayers";
            this.flpFavPlayers.Size = new System.Drawing.Size(300, 399);
            this.flpFavPlayers.TabIndex = 3;
            this.flpFavPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavPlayers_DragDrop);
            this.flpFavPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavPlayers_DragEnter);
            // 
            // cbTeams
            // 
            this.cbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(12, 53);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(198, 23);
            this.cbTeams.TabIndex = 0;
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            this.cbTeams.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.cbTeams_MouseWheel);
            // 
            // lblTeams
            // 
            this.lblTeams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTeams.Location = new System.Drawing.Point(12, 27);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(198, 23);
            this.lblTeams.TabIndex = 4;
            this.lblTeams.Text = "Select Team";
            this.lblTeams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpPlayers
            // 
            this.flpPlayers.AllowDrop = true;
            this.flpPlayers.AutoScroll = true;
            this.flpPlayers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpPlayers.Location = new System.Drawing.Point(216, 53);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(300, 399);
            this.flpPlayers.TabIndex = 4;
            this.flpPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpPlayers_DragDrop);
            this.flpPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpPlayers_DragEnter);
            // 
            // lblPlayers
            // 
            this.lblPlayers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayers.Location = new System.Drawing.Point(216, 27);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(300, 23);
            this.lblPlayers.TabIndex = 4;
            this.lblPlayers.Text = "Players";
            this.lblPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFavouriteTeams
            // 
            this.lblFavouriteTeams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFavouriteTeams.Location = new System.Drawing.Point(522, 27);
            this.lblFavouriteTeams.Name = "lblFavouriteTeams";
            this.lblFavouriteTeams.Size = new System.Drawing.Size(300, 23);
            this.lblFavouriteTeams.TabIndex = 5;
            this.lblFavouriteTeams.Text = "Favourite Players";
            this.lblFavouriteTeams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetFavTeam
            // 
            this.btnSetFavTeam.Location = new System.Drawing.Point(12, 404);
            this.btnSetFavTeam.Name = "btnSetFavTeam";
            this.btnSetFavTeam.Size = new System.Drawing.Size(198, 45);
            this.btnSetFavTeam.TabIndex = 6;
            this.btnSetFavTeam.Text = "Set team as favourite";
            this.btnSetFavTeam.UseVisualStyleBackColor = true;
            this.btnSetFavTeam.Click += new System.EventHandler(this.btnSetFavTeam_Click);
            // 
            // lblFavTeamConfirm
            // 
            this.lblFavTeamConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFavTeamConfirm.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFavTeamConfirm.Location = new System.Drawing.Point(12, 79);
            this.lblFavTeamConfirm.Name = "lblFavTeamConfirm";
            this.lblFavTeamConfirm.Size = new System.Drawing.Size(198, 23);
            this.lblFavTeamConfirm.TabIndex = 7;
            this.lblFavTeamConfirm.Text = "Favourite Team";
            this.lblFavTeamConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFavTeamConfirm.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lblFavTeamConfirm);
            this.Controls.Add(this.btnSetFavTeam);
            this.Controls.Add(this.lblFavouriteTeams);
            this.Controls.Add(this.flpPlayers);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.flpFavPlayers);
            this.Controls.Add(this.lblLoadingProgress);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLoadingProgress;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private FlowLayoutPanel flpFavPlayers;
        private ComboBox cbTeams;
        private Label lblTeams;
        private FlowLayoutPanel flpPlayers;
        private Label lblPlayers;
        private Label lblFavouriteTeams;
        private Button btnSetFavTeam;
        private Label lblFavTeamConfirm;
        private ToolStripMenuItem rankingToolStripMenuItem;
    }
}