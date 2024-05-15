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
    public partial class SettingsForm : Form
    {
        private Settings settings = Settings.load();

        public SettingsForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();

            this.MinimizeBox= false;
            this.MaximizeBox= false;

            this.cbGender.SelectedIndex = (int)settings.gender;
            this.cbDataAccessMode.SelectedIndex = (int)settings.dataAccessMode;
            this.cbLanguage.SelectedIndex = (int)settings.language;

            setLblTxt();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel);

            if(dr == DialogResult.Cancel)
            {
                return;
            }


            settings.gender = (Gender) cbGender.SelectedIndex;
            settings.dataAccessMode = (DataAccessMode)cbDataAccessMode.SelectedIndex;
            settings.language = (Language)cbLanguage.SelectedIndex;

            settings.save();

            this.DialogResult= DialogResult.OK;
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

            this.lblGender.Text = Properties.strings.Gender;
            this.lblDataAccessMode.Text = Properties.strings.DataAccessMode;
            this.lblLanguage.Text = Properties.strings.Language;
            this.cbGender.Items[0] = Properties.strings.MEN;
            this.cbGender.Items[1] = Properties.strings.WOMEN;


        }

    }
}
