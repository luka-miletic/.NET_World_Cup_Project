using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using DataAccessLayer.Settings;
using System.Drawing.Printing;
using System.Globalization;

namespace WorldCupForm
{
    public partial class RankingsForm : Form
    {

        private Team selectedTeam;

        private List<Player> rankedPlayerList;
        private List<Match> rankedMatchList;

        private IRepository repo;
        private Settings settings;


        public RankingsForm(Team team)
        {
            InitializeComponent();

            this.settings = Settings.load();

            this.repo = RepositoryFactory.GetRepository();

            this.setLblTxt();

            this.selectedTeam = team;

            this.lblSelectedTeamName.Text = this.selectedTeam.ToString();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.CenterToScreen();

            this.MinimizeBox = false;
            this.MaximizeBox = false;


            this.rankedPlayerList = repo.GetRankedPlayersForCountry(this.selectedTeam.FifaCode).ToList();
            this.rankedMatchList = repo.GetRankedMatchesForCountry(this.selectedTeam.FifaCode);


            LoadFlowPanels();

        }

        private void LoadFlowPanels()
        {
            this.flpPlayersRanking.Controls.Clear();
            this.flpMatchRanking.Controls.Clear();

            List<RankedPlayerUserControl> rankedPlayerUserControls = new();
            List<RankedMatchUserControl> rankedMatchUserControls = new();


            foreach (Player p in this.rankedPlayerList)
            {

                rankedPlayerUserControls.Add(new RankedPlayerUserControl(p));
            }

            foreach (Match m in this.rankedMatchList)
            {
                rankedMatchUserControls.Add(new RankedMatchUserControl(m));
            }

            this.flpPlayersRanking.Controls.AddRange(rankedPlayerUserControls.ToArray());
            this.flpMatchRanking.Controls.AddRange(rankedMatchUserControls.ToArray());
        }

        private void btnPrintPlayers_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPlayers;


            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog();
        }

        private void PrintPlayers(object sender, PrintPageEventArgs e)
        {
            Graphics? graphics = e.Graphics;

            if (graphics == null)
            {
                return;
            }

            graphics.DrawString("PLAYER RANKING", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(Height/2,30));

            int yPos = 100;
            Font font = new Font("Arial", 10, FontStyle.Bold);

            graphics.DrawLine(new Pen(Color.FromArgb(50, 0, 0, 0)), new Point(0, yPos - 5), new Point(1000, yPos - 5));

            foreach (Player p in this.rankedPlayerList)
            {
                graphics.DrawString($"{p.Name} ({p.ShirtNumber})",font, Brushes.Black, new PointF(10, yPos));
                graphics.DrawString($"Goals: {p.Goals}", font, Brushes.Black, new PointF(250,yPos));
                graphics.DrawString($"Yellow Cards: {p.YellowCards}",font,Brushes.Black, new PointF(325,yPos));
                graphics.DrawString($"Appearances: {p.noAppearances}", font, Brushes.Black, new PointF(450, yPos));

                graphics.DrawLine(new Pen(Color.FromArgb(50,0,0,0)), new Point(0, yPos+20), new Point(1000, yPos+20));

                yPos += 30;
            }

        }

        private void btnPrintMatches_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintMatches;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog();
        }

        private void PrintMatches(object sender, PrintPageEventArgs e)
        {
            Graphics? graphics = e.Graphics;

            if (graphics == null)
            {
                return;
            }

            graphics.DrawString("MATCH RANKING", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(Height / 2, 30));

            int yPos = 100;
            Font font = new Font("Arial", 10, FontStyle.Bold);

            graphics.DrawLine(new Pen(Color.FromArgb(50, 0, 0, 0)), new Point(0, yPos - 5), new Point(1000, yPos - 5));

            foreach (Match m in this.rankedMatchList)
            {
                graphics.DrawString($"{m.Venue}", font, Brushes.Black, new PointF(10, yPos));
                graphics.DrawString($"Home Team: {m.HomeTeam}", font, Brushes.Red, new PointF(150, yPos));
                graphics.DrawString($"Away Team: {m.AwayTeam}", font, Brushes.Blue, new PointF(400, yPos));
                graphics.DrawString($"Visitors: {m.Attendance}", font, Brushes.Black, new PointF(650, yPos));

                graphics.DrawLine(new Pen(Color.FromArgb(50, 0, 0, 0)), new Point(0, yPos + 20), new Point(1000, yPos + 20));

                yPos += 30;
            }

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

            this.lblPlayersRanking.Text = Properties.strings.PlayersRanking;
            this.lblMatchRanking.Text = Properties.strings.MatchesRanking;

            this.btnPrintPlayers.Text = Properties.strings.PrintPlayers;
            this.btnPrintMatches.Text = Properties.strings.PrintMatches;

        }

    }
}
