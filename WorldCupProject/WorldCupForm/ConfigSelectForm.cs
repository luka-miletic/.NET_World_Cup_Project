using System.Configuration;

namespace WorldCupForm
{
    public partial class ConfigSelectForm : Form
    {
        public ConfigSelectForm()
        {
            InitializeComponent();

            if(Properties.Settings.Default.GenderSetting == "men")
            {
                menRadioButton.Checked = true;
            }
            else
            {
                womenRadioButton.Checked = true;
            }

            if (Properties.Settings.Default.CultureSetting == "en-gb")
            {
                ENGRadioButton.Checked = true;
            }
            else
            {
                CRORadioButton.Checked = true;
            }

            if (Properties.Settings.Default.DataModeSetting == "API")
            {
                APIRadioButton.Checked = true;
            }
            else
            {
                FILERadioButton.Checked = true;
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private static void SetSetting(string key, string value)
        {
            Properties.Settings.Default[key] = value;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "My Application", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            SetSetting("GenderSetting", menRadioButton.Checked ? "men" : "women");
            SetSetting("CultureSetting", ENGRadioButton.Checked ? "en-gb" : "hr-HR");
            SetSetting("DataModeSetting", APIRadioButton.Checked ? "API" : "FILE");

            Properties.Settings.Default.FirstStartup = false;
            
            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}