using DataAccessLayer.Models;
using DataAccessLayer.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupForm
{
    public partial class RankedPlayerUserControl : UserControl
    {
        public readonly Player player;
        private readonly Settings settings;
        private const string RESOURCES_PATH = "../../../../Resources/img";

        public int shirtNumber { get; set; }

        public RankedPlayerUserControl(Player player)
        {
            InitializeComponent();

            this.player = player;
            this.settings = Settings.load();

            this.Name = player.Name;

            this.setLblTxt();

            this.lblPlayerName.Text = player.Name;
            this.lblGoals.Text = player.Goals.ToString();
            this.lblYellowCards.Text = player.YellowCards.ToString();
            this.lblAppearances.Text = player.noAppearances.ToString();

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

        private void setLblTxt()
        {
            if (this.settings.language == Language.CRO)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("hr-HR");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            }

            this.lblGoalsTxt.Text = Properties.strings.Goals_;
            this.lblYellowCardsTxt.Text = Properties.strings.YellowCards_;
            this.lblAppearancesTxt.Text = Properties.strings.Appearances_;

        }
    }
}
