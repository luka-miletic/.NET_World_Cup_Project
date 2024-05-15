using DataAccessLayer.Models;
using DataAccessLayer.Settings;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WorldCupWPF
{
    public partial class PlayerInformation : Window
    {

        private Settings settings = Settings.load();
        public PlayerInformation(Player p, Match m)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            setLblTxt();

            this.txtName.Content = p.Name;
            this.txtNumber.Content = p.ShirtNumber.ToString();
            this.txtPosition.Content = p.Position.ToString();
            
            if(p.Captain.HasValue && p.Captain.Value)
            {
                this.txtCaptain.Content = "Yes";
            } 
            else
            {
                this.txtCaptain.Content = "No";
            }

            this.txtGoals.Content = getGoalsInMatch(p, m);
            this.txtYellowCards.Content = getYellowCardsInMatch(p, m);

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private int getGoalsInMatch(Player p, Match m)
        {
            int goals = 0;

            foreach (TeamEvent e in m.HomeTeamEvents)
            {
                if(e.Player == p.Name && ( e.TypeOfEvent == TypeOfEvent.Goal || e.TypeOfEvent == TypeOfEvent.GoalPenalty))
                {
                    goals++;
                }
            }

            foreach (TeamEvent e in m.AwayTeamEvents)
            {
                if (e.Player == p.Name && (e.TypeOfEvent == TypeOfEvent.Goal || e.TypeOfEvent == TypeOfEvent.GoalPenalty))
                {
                    goals++;
                }
            }

            return goals;
        }

        private int getYellowCardsInMatch(Player p, Match m)
        {
            int yellows = 0;

            foreach (TeamEvent e in m.HomeTeamEvents)
            {
                if (e.Player == p.Name && e.TypeOfEvent == TypeOfEvent.YellowCard)
                {
                    yellows++;
                }
            }

            foreach (TeamEvent e in m.AwayTeamEvents)
            {
                if (e.Player == p.Name && e.TypeOfEvent == TypeOfEvent.YellowCard)
                {
                    yellows++;
                }
            }

            return yellows;
        }

        private void setLblTxt()
        {
            if (this.settings.language == DataAccessLayer.Settings.Language.CRO)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("hr-HR");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            }

            this.lblName.Content = Properties.strings.Name_;
            this.lblNumber.Content = Properties.strings.Number_;
            this.lblCaptain.Content = Properties.strings.Captain_;
            this.lblPosition.Content = Properties.strings.Position_;
            this.lblGoals.Content = Properties.strings.Goals_;
            this.lblYellowCards.Content = Properties.strings.YellowCards_;


        }
    }
}
