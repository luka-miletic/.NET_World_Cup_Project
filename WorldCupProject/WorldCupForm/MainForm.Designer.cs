namespace WorldCupForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.cbChooseTeam = new System.Windows.Forms.ComboBox();
            this.lblFavTeam = new System.Windows.Forms.Label();
            this.flPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flPlayers2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenuButton
            // 
            this.tsmMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSettingsButton,
            this.tsmExitButton});
            this.tsmMenuButton.Name = "tsmMenuButton";
            this.tsmMenuButton.Size = new System.Drawing.Size(50, 20);
            this.tsmMenuButton.Text = "Menu";
            // 
            // tsmSettingsButton
            // 
            this.tsmSettingsButton.Name = "tsmSettingsButton";
            this.tsmSettingsButton.Size = new System.Drawing.Size(116, 22);
            this.tsmSettingsButton.Text = "Settings";
            this.tsmSettingsButton.Click += new System.EventHandler(this.tsmSettingsButton_Click);
            // 
            // tsmExitButton
            // 
            this.tsmExitButton.Name = "tsmExitButton";
            this.tsmExitButton.Size = new System.Drawing.Size(116, 22);
            this.tsmExitButton.Text = "Exit";
            this.tsmExitButton.Click += new System.EventHandler(this.tsmExitButton_Click);
            // 
            // cbChooseTeam
            // 
            this.cbChooseTeam.FormattingEnabled = true;
            this.cbChooseTeam.Location = new System.Drawing.Point(118, 27);
            this.cbChooseTeam.Name = "cbChooseTeam";
            this.cbChooseTeam.Size = new System.Drawing.Size(190, 23);
            this.cbChooseTeam.TabIndex = 1;
            this.cbChooseTeam.SelectedIndexChanged += new System.EventHandler(this.cbChooseTeam_SelectedIndexChanged);
            // 
            // lblFavTeam
            // 
            this.lblFavTeam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFavTeam.Location = new System.Drawing.Point(12, 27);
            this.lblFavTeam.Name = "lblFavTeam";
            this.lblFavTeam.Size = new System.Drawing.Size(100, 23);
            this.lblFavTeam.TabIndex = 2;
            this.lblFavTeam.Text = "Favourite Team";
            this.lblFavTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flPlayers
            // 
            this.flPlayers.AllowDrop = true;
            this.flPlayers.AutoScroll = true;
            this.flPlayers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flPlayers.Location = new System.Drawing.Point(12, 67);
            this.flPlayers.Name = "flPlayers";
            this.flPlayers.Size = new System.Drawing.Size(390, 380);
            this.flPlayers.TabIndex = 3;
            this.flPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flPlayers_DragDrop);
            this.flPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flPlayers_DragEnter);
            // 
            // flPlayers2
            // 
            this.flPlayers2.AllowDrop = true;
            this.flPlayers2.AutoScroll = true;
            this.flPlayers2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flPlayers2.Location = new System.Drawing.Point(408, 67);
            this.flPlayers2.Name = "flPlayers2";
            this.flPlayers2.Size = new System.Drawing.Size(390, 380);
            this.flPlayers2.TabIndex = 4;
            this.flPlayers2.DragDrop += new System.Windows.Forms.DragEventHandler(this.flPlayers_DragDrop);
            this.flPlayers2.DragEnter += new System.Windows.Forms.DragEventHandler(this.flPlayers_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.Controls.Add(this.flPlayers2);
            this.Controls.Add(this.flPlayers);
            this.Controls.Add(this.lblFavTeam);
            this.Controls.Add(this.cbChooseTeam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Select Favourites";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmMenuButton;
        private ToolStripMenuItem tsmSettingsButton;
        private ToolStripMenuItem tsmExitButton;
        private ComboBox cbChooseTeam;
        private Label lblFavTeam;
        private FlowLayoutPanel flPlayers;
        private FlowLayoutPanel flPlayers2;
    }
}