using DataAccessLayer.Repository;
using DataAccessLayer.Models;
using DataAccessLayer.Settings;
using System.Threading;
using System.Globalization;

namespace WorldCupForm
{
    public partial class MainForm : Form
    {
        private IRepository repo = RepositoryFactory.GetRepository();
        private Settings settings = Settings.load();

        private Team selectedTeam = new Team();

        private HashSet<Player> currentTeamPlayers = new();
        private HashSet<Player> favPlayers = new();

        public MainForm()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.CenterToScreen();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            InitialiseSettings();

            await InitialiseRepo();

            LoadComboBox();

            this.cbTeams.SelectedItem = this.settings.favouriteTeam;

        }

        private async Task InitialiseRepo()
        {
            this.lblLoadingProgress.Text = Properties.strings.LoadingData;
            this.lblLoadingProgress.ForeColor = Color.OrangeRed;
            this.cbTeams.Enabled = false;

            await repo.LoadData(settings.dataAccessMode,settings.gender);

            this.lblLoadingProgress.Text = Properties.strings.DataLoaded;
            this.lblLoadingProgress.ForeColor = Color.Green;
            this.cbTeams.Enabled = true;
        }

        private void LoadComboBox()
        {
            this.cbTeams.Items.Clear();
            this.cbTeams.Items.AddRange(repo.GetAllTeams().ToArray());
        }

        private void InitialiseSettings()
        {
            this.settings = Settings.load();
            if (Settings.FirstRun()) { new SettingsForm().ShowDialog(); }

            setLblTxt();
        }

        private async void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.save();
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();

            if (sf.DialogResult== DialogResult.Cancel) { return; }

            InitialiseSettings();

            await InitialiseRepo();

            LoadComboBox();
            this.cbTeams.SelectedIndex = -1;

            this.lblFavTeamConfirm.Visible = false;

            this.flpPlayers.Controls.Clear();
            this.flpFavPlayers.Controls.Clear();

            this.cbTeams.SelectedItem = this.settings.favouriteTeam;

            if(this.cbTeams.SelectedItem != null ) 
            {
                LoadPlayerLists();
                LoadFlowPanels();
            }
        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedTeam = (Team)cbTeams.SelectedItem;

            if(this.cbTeams.SelectedIndex == -1) 
            {
                lblFavTeamConfirm.Visible = false;
                return; 
            }

            lblFavTeamConfirm.Visible = this.selectedTeam.Equals(this.settings.favouriteTeam);

             LoadPlayerLists();
             LoadFlowPanels();
        }

        void cbTeams_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void btnSetFavTeam_Click(object sender, EventArgs e)
        {
            if (this.cbTeams.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a team first");
            }

            this.settings.favouriteTeam = this.selectedTeam;
            this.lblFavTeamConfirm.Visible = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.settings.save();
        }

        private void LoadPlayerLists()
        {
            this.currentTeamPlayers.Clear();
            this.favPlayers.Clear();
                
            this.currentTeamPlayers = repo.GetPlayersForCountry(this.selectedTeam.FifaCode);

            foreach (Player p in this.settings.favouritePlayers)
            {
                if (this.currentTeamPlayers.Contains(p))
                {
                    this.favPlayers.Add(p);
                }
            }
        }

        private void LoadFlowPanels()
        {
            this.flpPlayers.Controls.Clear();
            this.flpFavPlayers.Controls.Clear();

            List<PlayerUserControl> playerUserControls = new();
            List<PlayerUserControl> favPlayerUserControls= new();

            foreach (Player p in this.currentTeamPlayers)
            {
                if(!this.favPlayers.Contains(p))
                {
                    playerUserControls.Add(new PlayerUserControl(p,false));
                }
            }

            foreach (Player p in this.favPlayers)
            {
                favPlayerUserControls.Add(new PlayerUserControl(p,true));
            }

            playerUserControls.Sort((x,y) => x.shirtNumber.CompareTo(y.shirtNumber));
            favPlayerUserControls.Sort((x, y) => x.shirtNumber.CompareTo(y.shirtNumber));

            this.flpPlayers.Controls.AddRange(playerUserControls.ToArray());
            this.flpFavPlayers.Controls.AddRange(favPlayerUserControls.ToArray());
        }


        //DRAG-DROP
        private void flpFavPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void flpFavPlayers_DragDrop(object sender, DragEventArgs e)
        {
            Player p = (Player)e.Data.GetData(typeof(Player));

            if (this.flpFavPlayers.Controls.Count >= 3)
            {
                MessageBox.Show("Only 3 favourite players allowed per team!");
                return;
            }

            if (((FlowLayoutPanel)sender).Controls.ContainsKey(p.Name))
            {
                return;
            }

            this.settings.favouritePlayers.Add(p);

            LoadPlayerLists();
            LoadFlowPanels();
        }

        private void flpPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void flpPlayers_DragDrop(object sender, DragEventArgs e)
        {
            Player p = (Player)e.Data.GetData(typeof(Player));

            if ( ((FlowLayoutPanel)sender).Controls.ContainsKey(p.Name) )
            {
                return;
            }

            settings.favouritePlayers.Remove(p);

            LoadPlayerLists();
            LoadFlowPanels();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( this.cbTeams.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a team first");
                return;
            }

            new RankingsForm((Team)this.selectedTeam).ShowDialog();


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

            this.lblTeams.Text = Properties.strings.SelectTeam;
            this.lblFavTeamConfirm.Text = Properties.strings.FavouriteTeam;
            this.lblLoadingProgress.Text = Properties.strings.LoadingData;
            this.btnSetFavTeam.Text = Properties.strings.SetTeamAsFav;
            this.lblPlayers.Text = Properties.strings.Players;
            this.lblFavouriteTeams.Text = Properties.strings.FavouritePlayers;

            this.editToolStripMenuItem.Text = Properties.strings.Edit;
            this.settingsToolStripMenuItem.Text = Properties.strings.Settings;

            this.rankingToolStripMenuItem.Text = Properties.strings.RankingLists;
        }
    }
}
