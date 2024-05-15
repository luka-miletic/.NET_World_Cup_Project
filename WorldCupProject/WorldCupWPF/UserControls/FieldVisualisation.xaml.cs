using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class FieldVisualisation : UserControl
    {
        IRepository repo = RepositoryFactory.GetRepository();

        public FieldVisualisation(Match m, Team team1, Team team2)
        {
            InitializeComponent();

            if(m.HomeTeam.FifaCode == team1.FifaCode)
            {
                foreach (Player player in m.HomeTeamStatistics.StartingEleven)
                {
                    PlayerVisualisation vis = new PlayerVisualisation(player,m);

                    switch (player.Position)
                    {
                        case Position.Goalie:
                            this.team1Column1.Children.Add(vis);
                            break;
                        case Position.Defender:
                            this.team1Column2.Children.Add(vis);
                            break;
                        case Position.Midfield:
                            this.team1Column3.Children.Add(vis);
                            break;
                        case Position.Forward:
                            this.team1Column4.Children.Add(vis);
                            break;
                    }
                }

                foreach (Player player in m.AwayTeamStatistics.StartingEleven)
                {
                    PlayerVisualisation vis = new PlayerVisualisation(player, m);

                    switch (player.Position)
                    {
                        case Position.Goalie:
                            this.team2Column1.Children.Add(vis);
                            break;
                        case Position.Defender:
                            this.team2Column2.Children.Add(vis);
                            break;
                        case Position.Midfield:
                            this.team2Column3.Children.Add(vis);
                            break;
                        case Position.Forward:
                            this.team2Column4.Children.Add(vis);
                            break;
                    }
                }
            }
            else
            {
                foreach (Player player in m.HomeTeamStatistics.StartingEleven)
                {
                    PlayerVisualisation vis = new PlayerVisualisation(player, m);

                    switch (player.Position)
                    {
                        case Position.Goalie:
                            this.team2Column1.Children.Add(vis);
                            break;
                        case Position.Defender:
                            this.team2Column2.Children.Add(vis);
                            break;
                        case Position.Midfield:
                            this.team2Column3.Children.Add(vis);
                            break;
                        case Position.Forward:
                            this.team2Column4.Children.Add(vis);
                            break;
                    }
                }

                foreach (Player player in m.AwayTeamStatistics.StartingEleven)
                {
                    PlayerVisualisation vis = new PlayerVisualisation(player, m);

                    switch (player.Position)
                    {
                        case Position.Goalie:
                            this.team1Column1.Children.Add(vis);
                            break;
                        case Position.Defender:
                            this.team1Column2.Children.Add(vis);
                            break;
                        case Position.Midfield:
                            this.team1Column3.Children.Add(vis);
                            break;
                        case Position.Forward:
                            this.team1Column4.Children.Add(vis);
                            break;
                    }
                }
            }
        }
    }
}
