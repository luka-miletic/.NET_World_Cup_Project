namespace WorldCupForm
{
    partial class PlayerUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerUserControl));
            this.pbPlayerPicture = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblShirtNumber = new System.Windows.Forms.Label();
            this.pbFavourite = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.cmsImageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourite)).BeginInit();
            this.cmsImageContextMenu.SuspendLayout();
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
            this.pbPlayerPicture.TabIndex = 0;
            this.pbPlayerPicture.TabStop = false;
            this.pbPlayerPicture.Click += new System.EventHandler(this.pbPlayerPicture_Click);
            this.pbPlayerPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerName.Location = new System.Drawing.Point(56, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(100, 50);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "(Name)";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayerName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            // 
            // lblShirtNumber
            // 
            this.lblShirtNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShirtNumber.Location = new System.Drawing.Point(250, 24);
            this.lblShirtNumber.Name = "lblShirtNumber";
            this.lblShirtNumber.Size = new System.Drawing.Size(23, 25);
            this.lblShirtNumber.TabIndex = 2;
            this.lblShirtNumber.Text = "12";
            this.lblShirtNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShirtNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            // 
            // pbFavourite
            // 
            this.pbFavourite.Image = ((System.Drawing.Image)(resources.GetObject("pbFavourite.Image")));
            this.pbFavourite.Location = new System.Drawing.Point(250, 0);
            this.pbFavourite.Name = "pbFavourite";
            this.pbFavourite.Size = new System.Drawing.Size(23, 22);
            this.pbFavourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFavourite.TabIndex = 3;
            this.pbFavourite.TabStop = false;
            this.pbFavourite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(162, 22);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(82, 28);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "(Position)";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            // 
            // lblCaptain
            // 
            this.lblCaptain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaptain.ForeColor = System.Drawing.Color.Red;
            this.lblCaptain.Location = new System.Drawing.Point(162, 0);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(82, 22);
            this.lblCaptain.TabIndex = 6;
            this.lblCaptain.Text = "Captain";
            this.lblCaptain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCaptain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            // 
            // cmsImageContextMenu
            // 
            this.cmsImageContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddImage,
            this.deleteImageToolStripMenuItem});
            this.cmsImageContextMenu.Name = "cmsImageContextMenu";
            this.cmsImageContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // menuItemAddImage
            // 
            this.menuItemAddImage.Name = "menuItemAddImage";
            this.menuItemAddImage.Size = new System.Drawing.Size(180, 22);
            this.menuItemAddImage.Text = "Add Image";
            this.menuItemAddImage.Click += new System.EventHandler(this.menuItemAddImage_Click);
            // 
            // deleteImageToolStripMenuItem
            // 
            this.deleteImageToolStripMenuItem.Name = "deleteImageToolStripMenuItem";
            this.deleteImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteImageToolStripMenuItem.Text = "Delete Image";
            this.deleteImageToolStripMenuItem.Click += new System.EventHandler(this.deleteImageToolStripMenuItem_Click);
            // 
            // PlayerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.pbFavourite);
            this.Controls.Add(this.lblShirtNumber);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbPlayerPicture);
            this.Name = "PlayerUserControl";
            this.Size = new System.Drawing.Size(273, 50);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourite)).EndInit();
            this.cmsImageContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbPlayerPicture;
        private Label lblPlayerName;
        private Label lblShirtNumber;
        private PictureBox pbFavourite;
        private Label lblPosition;
        private Label lblCaptain;
        private ContextMenuStrip cmsImageContextMenu;
        private ToolStripMenuItem menuItemAddImage;
        private ToolStripMenuItem deleteImageToolStripMenuItem;
    }
}
