using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using DataAccessLayer.Settings;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WorldCupWPF.UserControls;

namespace WorldCupWPF
{
    public partial class MainWindow : Window
    {
        Settings settings;
        IRepository repo = RepositoryFactory.GetRepository();

        private Team team1;
        private Team team2;

        private Match match;

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;

            InitialiseSettings();

            this.cbTeam2.IsEnabled = false;
            this.scoreGrid.Visibility = Visibility.Hidden;

            setWindowMode();
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await InitialiseRepo();
            loadComboBox();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            settings.save();
            SettingsWindow sf = new SettingsWindow();
            sf.ShowDialog();

            InitialiseSettings();

            await InitialiseRepo();

            loadComboBox();
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

            this.btnSettings.Content = Properties.strings.Settings;


        }

        private void InitialiseSettings()
        {
            this.settings = Settings.load();
            if (Settings.FirstRun()) { new SettingsWindow().ShowDialog(); }

            setLblTxt();
            setWindowMode();
        }

        private async Task InitialiseRepo()
        {
            this.lblDataLoading.Content = Properties.strings.DataLoading;
            this.lblDataLoading.Foreground = new SolidColorBrush(Colors.Red);

            await repo.LoadData(settings.dataAccessMode, settings.gender);

            this.lblDataLoading.Content = Properties.strings.DataLoaded;
            this.lblDataLoading.Foreground = new SolidColorBrush(Colors.Green);

        }

        private void loadComboBox()
        {
            this.cbTeam1.Items.Clear();
            this.cbTeam2.Items.Clear();
            foreach(Team t in repo.GetAllTeams())
            {
                cbTeam1.Items.Add(t);
            }

            this.scoreGrid.Visibility = Visibility.Hidden;

        }

        private void cbTeam1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(cbTeam1.SelectedIndex == -1) 
            {
                this.cbTeam2.IsEnabled= false;
                return; 
            }

            this.team1 = (Team)cbTeam1.SelectedItem;

            this.cbTeam2.Items.Clear();
            foreach(Team t in repo.GetTeamsVsCountry(this.team1.FifaCode))
            {
                this.cbTeam2.Items.Add(t);
            }

            this.cbTeam2.IsEnabled = true;
        }

        private void btnInfo1_Click(object sender, RoutedEventArgs e)
        {
            if(this.cbTeam1.SelectedIndex == -1) { return; }
            new TeamInformationWindow(this.team1).ShowDialog();
        }

        private void btnInfo2_Click(object sender, RoutedEventArgs e)
        {
            if (this.cbTeam2.SelectedIndex == -1) { return; }
            new TeamInformationWindow(this.team2).ShowDialog();
        }

        private void cbTeam2_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            if (cbTeam2.SelectedIndex == -1)
            {
                this.scoreGrid.Visibility = Visibility.Hidden;
                this.fieldVisualisationUserControl.Content = null;
                return;
            }

            this.team2 = (Team)cbTeam2.SelectedItem;

            this.match = repo.GetMatchBetweenTeams(this.team1.FifaCode, this.team2.FifaCode);

            this.scoreGrid.Visibility = Visibility.Visible;

            if (this.team1.FifaCode == this.match.HomeTeam.FifaCode)
            {
                this.lblTeam1Score.Content = this.match.HomeTeam.Goals;
                this.lblTeam2Score.Content = this.match.AwayTeam.Goals;
            }
            else
            {
                this.lblTeam2Score.Content = this.match.HomeTeam.Goals;
                this.lblTeam1Score.Content = this.match.AwayTeam.Goals;
            }

            this.fieldVisualisationUserControl.Content = new FieldVisualisation(this.match,this.team1,this.team2);
        }

        private void setWindowMode()
        {
            if(settings.windowMode == WindowMode.FULLSCREEN)
            {
                this.Visibility = Visibility.Collapsed;
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None;
                this.ResizeMode = ResizeMode.NoResize;
                this.Visibility = Visibility.Visible;
            }
            else if (settings.windowMode == WindowMode.FULLSCREEN_WINDOWED)
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                this.ResizeMode = ResizeMode.CanResize;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                this.ResizeMode = ResizeMode.CanResize;
            }
        }

    }
}
