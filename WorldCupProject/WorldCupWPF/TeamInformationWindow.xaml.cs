using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using DataAccessLayer.Settings;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    public partial class TeamInformationWindow : Window
    {
        IRepository repo = RepositoryFactory.GetRepository();

        Settings settings = Settings.load();

        public TeamInformationWindow(Team team)
        {
            InitializeComponent();

            Result r = repo.GetResultForCountry(team.FifaCode);

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.txtNationalTeamName.Text = team.Country;
            this.txtFifaCode.Text = team.FifaCode;
            this.txtGames.Text = r.GamesPlayed.ToString();
            this.txtWins.Text = r.Wins.ToString();
            this.txtLosses.Text = r.Losses.ToString();
            this.txtDraws.Text = r.Draws.ToString();
            this.txtGoalsScored.Text = r.GoalsFor.ToString();
            this.txtGoalsRecieved.Text = r.GoalsAgainst.ToString();
            this.txtGoalDifference.Text = r.GoalDifferential.ToString();

            setLblTxt();

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

            this.lblTeamName.Content = Properties.strings.NationalTeamName_;
            this.lblFifaCode.Content = Properties.strings.FIFACode_;
            this.lblGames.Content = Properties.strings.Games_;
            this.lblWins.Content = Properties.strings.Wins_;
            this.lblLosses.Content = Properties.strings.Losses_;
            this.lblDraws.Content = Properties.strings.Draws_;
            this.lblGoals.Content = Properties.strings.GoalsScored_;
            this.lblGoalsAgainst.Content = Properties.strings.GoalsRecieved_;
            this.lblGoalDiff.Content = Properties.strings.GoalDifference_;
        }
    }
}
