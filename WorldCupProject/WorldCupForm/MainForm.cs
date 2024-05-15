using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static DataAccessLayer.Repositories.TeamRepository;
using static DataAccessLayer.Repositories.MatchRepository;

using DataAccessLayer.Models;

namespace WorldCupForm
{
    public partial class MainForm : Form
    {
        Form cfgForm = new ConfigSelectForm();

        private async Task InitTeamsList()
        {
            if (Properties.Settings.Default.DataModeSetting.Equals("API"))
            {
                await initTeamListFromAPI(Properties.Settings.Default.GenderSetting);
            }
            else
            {
                await initTeamListFromFile(Properties.Settings.Default.GenderSetting);
            }

            foreach (Team t in teamList)
            {
                cbChooseTeam.Items.Add(t);
            }


            cbChooseTeam.SelectedIndex = Properties.Settings.Default.FavTeam;
        }

        private async Task InitMatchList()
        {
            await initMatchListFromAPI(Properties.Settings.Default.GenderSetting, teamList[Properties.Settings.Default.FavTeam]);
        }

        private async Task InitPlayerList()
        {
            await InitMatchList();

            initPlayerList(teamList[Properties.Settings.Default.FavTeam]);

            foreach (Player p in playerList)
            {
                PlayerSelectControl pc = new PlayerSelectControl(p);
                flPlayers.Controls.Add(pc);
            }
        }

        private void tsmSettingsButton_Click(object sender, EventArgs e)
        {
            cfgForm.ShowDialog();
            MainForm_Load(null, EventArgs.Empty);
            Properties.Settings.Default.FavTeam = 0;
        }

        private void tsmExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.FirstStartup)
            {
                cfgForm.ShowDialog();
            }

            cbChooseTeam.Items.Clear();

            await InitTeamsList();

        }

        private async void cbChooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FavTeam = cbChooseTeam.SelectedIndex;

            Properties.Settings.Default.Save();

            flPlayers.Controls.Clear();

            await InitPlayerList();

            populateFl();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "My Application", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void flPlayers_DragDrop(object sender, DragEventArgs e)
        {
            
            if (((Control)sender).Name.Equals("flPlayers2") && ((Control)sender).Controls.Count >= 3)
            {
                return;
            }

            ((Control)sender).Controls.Add((PlayerSelectControl)e.Data.GetData(typeof(PlayerSelectControl)));

            if (((Control)sender).Name.Equals("flPlayers2"))
            {
                addFavPlayer(((PlayerSelectControl)e.Data.GetData(typeof(PlayerSelectControl))).mPlayer);
            }

            if (((Control)sender).Name.Equals("flPlayers"))
            {
                removeFavPlayer(((PlayerSelectControl)e.Data.GetData(typeof(PlayerSelectControl))).mPlayer);
            }

            ((PlayerSelectControl)e.Data.GetData(typeof(PlayerSelectControl))).setImg();
            
        }
        
        private void addFavPlayer(Player player)
        {
            Properties.Settings.Default.FavPlayers = Properties.Settings.Default.FavPlayers + $"{player.Name};";
            Properties.Settings.Default.Save();
        }

        private void removeFavPlayer(Player player)
        {
            int i = Properties.Settings.Default.FavPlayers.IndexOf(player.Name);
            int len = player.Name.Length + 1;

            try
            {
                Properties.Settings.Default.FavPlayers = Properties.Settings.Default.FavPlayers.Remove(i, len);
                Properties.Settings.Default.Save();
            }
            catch { MessageBox.Show("Player Already in layout!"); }
        }

        private void populateFl()
        {
            flPlayers2.Controls.Clear();

            foreach(Player player in playerList)
            {
                if (Properties.Settings.Default.FavPlayers.Contains(player.Name))
                {
                    PlayerSelectControl pc = new PlayerSelectControl(player);
                    flPlayers2.Controls.Add(pc);
                    flPlayers.Controls.Remove(pc);
                }
            }
        }

        private void flPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
