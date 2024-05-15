using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldCupWPF.UserControls
{
    public partial class PlayerVisualisation : UserControl
    {
        private const string RESOURCES_PATH = "../../../../Resources/img";

        private Player player;
        private Match match;

        public PlayerVisualisation(Player p, Match m)
        {
            InitializeComponent();
            this.MouseDown += OnClick;

            this.player = p;
            this.match = m;

            this.lblPlayerName.Text = $"{p.Name.Split()[ p.Name.Split().Length-1 ] } ({p.ShirtNumber})";

            if (p.getOwnPicture() != null)
            {
                try
                {
                    var img = new BitmapImage();
                    img.BeginInit();
                    img.StreamSource = new MemoryStream(File.ReadAllBytes(p.getOwnPicture()));
                    img.EndInit();

                    this.imgPlayerImage.ImageSource = img;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void OnClick(Object sender, MouseEventArgs ev)
        {
            new PlayerInformation(this.player,this.match).ShowDialog();


        }
    }
}
