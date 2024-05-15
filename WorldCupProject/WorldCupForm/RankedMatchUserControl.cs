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
    public partial class RankedMatchUserControl : UserControl
    {
        private readonly Settings settings;

        public RankedMatchUserControl(Match m)
        {
            InitializeComponent();

            this.settings = Settings.load();

            setLblTxt();

            this.lblVenue.Text = m.Venue;
            this.lblHomeName.Text = m.HomeTeam.Country;
            this.lblAwayName.Text = m.AwayTeam.Country;
            this.lblVisitors.Text = m.Attendance.ToString();
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

            this.lblAwayTxt.Text = Properties.strings.Away_;
            this.lblHomeTxt.Text = Properties.strings.Home_;
            this.lblVisitorsTxt.Text = Properties.strings.Visitors_;


        }
    }
}
