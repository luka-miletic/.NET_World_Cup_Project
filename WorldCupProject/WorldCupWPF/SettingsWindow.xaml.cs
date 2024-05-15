using DataAccessLayer.Settings;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace WorldCupWPF
{
    public partial class SettingsWindow : Window
    {
        Settings settings;
        public SettingsWindow()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.settings = Settings.load();

            this.cbGender.SelectedIndex = (int)settings.gender;
            this.cbDataAccessMode.SelectedIndex = (int)settings.dataAccessMode;
            this.cbLanguage.SelectedIndex = (int)settings.language;
            this.cbWindowMode.SelectedIndex= (int)settings.windowMode;

            setLblTxt();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            settings.gender = (Gender)cbGender.SelectedIndex;
            settings.dataAccessMode = (DataAccessMode)cbDataAccessMode.SelectedIndex;
            settings.language = (Language)cbLanguage.SelectedIndex;
            settings.windowMode = (WindowMode)cbWindowMode.SelectedIndex;

            settings.save();

            this.Close();
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

            this.lblGender.Content = Properties.strings.Gender;
            this.lblLanguage.Content = Properties.strings.Language;
            this.lblDataAccessMode.Content = Properties.strings.DataAccessMode;
            this.lblWindowMode.Content = Properties.strings.WindowMode;


        }
    }
}
