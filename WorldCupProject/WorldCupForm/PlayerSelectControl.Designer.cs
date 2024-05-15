namespace WorldCupForm
{
    partial class PlayerSelectControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSelectControl));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.imgPlayerImage = new System.Windows.Forms.PictureBox();
            this.lblShirtNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.imgFavourite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFavourite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerName.Location = new System.Drawing.Point(54, 3);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(86, 44);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgPlayerImage
            // 
            this.imgPlayerImage.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayerImage.Image")));
            this.imgPlayerImage.Location = new System.Drawing.Point(3, 3);
            this.imgPlayerImage.Name = "imgPlayerImage";
            this.imgPlayerImage.Size = new System.Drawing.Size(45, 45);
            this.imgPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerImage.TabIndex = 1;
            this.imgPlayerImage.TabStop = false;
            // 
            // lblShirtNumber
            // 
            this.lblShirtNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShirtNumber.Location = new System.Drawing.Point(146, 3);
            this.lblShirtNumber.Name = "lblShirtNumber";
            this.lblShirtNumber.Size = new System.Drawing.Size(37, 44);
            this.lblShirtNumber.TabIndex = 2;
            this.lblShirtNumber.Text = "0";
            this.lblShirtNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(189, 3);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(88, 44);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptain
            // 
            this.lblCaptain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaptain.Location = new System.Drawing.Point(283, 3);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(64, 16);
            this.lblCaptain.TabIndex = 4;
            this.lblCaptain.Text = "Captain";
            this.lblCaptain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFavourite
            // 
            this.imgFavourite.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgFavourite.ErrorImage")));
            this.imgFavourite.Image = ((System.Drawing.Image)(resources.GetObject("imgFavourite.Image")));
            this.imgFavourite.ImageLocation = "";
            this.imgFavourite.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgFavourite.InitialImage")));
            this.imgFavourite.Location = new System.Drawing.Point(322, 22);
            this.imgFavourite.Name = "imgFavourite";
            this.imgFavourite.Size = new System.Drawing.Size(25, 25);
            this.imgFavourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFavourite.TabIndex = 5;
            this.imgFavourite.TabStop = false;
            this.imgFavourite.Visible = false;
            // 
            // PlayerSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.imgFavourite);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblShirtNumber);
            this.Controls.Add(this.imgPlayerImage);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "PlayerSelectControl";
            this.Size = new System.Drawing.Size(350, 50);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerSelectControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFavourite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblPlayerName;
        private PictureBox imgPlayerImage;
        private Label lblShirtNumber;
        private Label lblPosition;
        private Label lblCaptain;
        private PictureBox imgFavourite;
    }
}
