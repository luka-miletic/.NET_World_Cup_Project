using DataAccessLayer.Models;
using System.Windows.Forms;

namespace WorldCupForm
{
    public partial class PlayerUserControl : UserControl
    {
        public readonly Player player;
        private const string RESOURCES_PATH = "../../../../Resources/img";

        public int shirtNumber { get; set; }

        public PlayerUserControl(Player player, bool favourite)
        {
            InitializeComponent();

            this.player = player;

            this.Name = player.Name;

            this.lblPlayerName.Text = player.Name;
            this.lblPosition.Text = player.Position.ToString();
            this.lblShirtNumber.Text = player.ShirtNumber.ToString();
            this.shirtNumber = (int?)player.ShirtNumber ?? 0;

            this.lblCaptain.Visible = player.Captain ?? false;
            this.pbFavourite.Visible = favourite;

            if (player.getOwnPicture() != null)
            {
                try
                {
                    this.pbPlayerPicture.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(player.getOwnPicture())));
                }
                catch
                {
                    MessageBox.Show("File Error!");
                    return;
                }
            }
         }

        private void menuItemAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = "c:\\";
                fileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;*";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fileDialog.FileName;

                    File.Copy(filePath, RESOURCES_PATH + "/" + this.player.getNewFileName() + ".jpg", true);
                    
                }
            }

            if (player.getOwnPicture() != null)
            {
                try
                {
                    this.pbPlayerPicture.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(player.getOwnPicture())));
                }catch
                {
                    MessageBox.Show("File Error!");
                    return;
                }
                
            }
        }

        private void pbPlayerPicture_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left) { return; }

            this.cmsImageContextMenu.Show((Control)sender, me.Location);
        }

        private void PlayerUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if(me.Button == MouseButtons.Right) { return; }

            DoDragDrop(this.player, DragDropEffects.Copy | DragDropEffects.Move);

        }

        public override bool Equals(object? obj)
        {
            return obj is PlayerUserControl control &&
                   EqualityComparer<Player>.Default.Equals(player, control.player);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(player);
        }

        private void deleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (player.getOwnPicture() != null)
            {
                File.Delete(this.player.getOwnPicture());

                this.pbPlayerPicture.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(RESOURCES_PATH + "/avatar.png")));
            }
        }
    }
}
