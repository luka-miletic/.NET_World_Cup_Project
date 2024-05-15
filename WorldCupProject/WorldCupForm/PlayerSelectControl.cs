using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccessLayer.Models;

namespace WorldCupForm
{
    public partial class PlayerSelectControl : UserControl
    {
        public Player mPlayer;

        public void setImg()
        {
            if (Properties.Settings.Default.FavPlayers.Contains(this.mPlayer.Name))
            {
                this.imgFavourite.Visible = true;
            }
            else
            {
                this.imgFavourite.Visible = false;
            }
        }

        public PlayerSelectControl(Player player)
        {
            InitializeComponent();

            this.mPlayer = player;

            this.lblPlayerName.Text = player.Name;
            this.lblCaptain.Visible = player.Captain;
            this.lblPosition.Text = player.Position.ToString();
            this.lblShirtNumber.Text = player.ShirtNumber.ToString();

            foreach (Control c in this.Controls)
            {
                c.MouseDown += PlayerSelectControl_MouseDown;
            }

            setImg();

        }

        private void PlayerSelectControl_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this, DragDropEffects.Move);
        }
    }
}
