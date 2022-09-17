using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    public partial class MainForm : Form
    {
        //form references
        private DataModule DM;
        private ArenaForm frmArena;
        private EventForm frmEvent;
        private ChallengeForm frmChallenge;
        private CompetitorForm frmCompetitor;
        private EntryForm frmEntry;
        private EventsReportForm frmEventsReport;
        private CompetitorReportForm frmCompetitorReport;

        public MainForm()
        {
            InitializeComponent();
            Utilities.frmMenu = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); // <-- create data module and load dataset
        }

        private void btnArenaMaintenance_Click(object sender, EventArgs e)
        {
            if(frmArena == null)
            {
                frmArena = new ArenaForm(DM, this);
            }
            frmArena.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEventMaintenance_Click(object sender, EventArgs e)
        {
            if(frmEvent == null)
            {
                frmEvent = new EventForm(DM, this);
            }
            frmEvent.ShowDialog();
        }

        private void btnChallengeMaintenance_Click(object sender, EventArgs e)
        {
            if(frmChallenge == null)
            {
                frmChallenge = new ChallengeForm(DM, this);
            }
            frmChallenge.ShowDialog();
        }

        private void btnCompetitorMaintence_Click(object sender, EventArgs e)
        {
            if(frmCompetitor == null)
            {
                frmCompetitor = new CompetitorForm(DM, this);
            }
            frmCompetitor.ShowDialog();
        }

        private void btnEnterCompetitorChallenge_Click(object sender, EventArgs e)
        {
            if(frmEntry == null)
            {
                frmEntry = new EntryForm(DM, this);
            }
            frmEntry.ShowDialog();
        }

        private void btnEventsReport_Click(object sender, EventArgs e)
        {
            if(frmEventsReport == null)
            {
                frmEventsReport = new EventsReportForm(DM, this);
            }
            frmEventsReport.ShowDialog();
        }

        private void btnCompetitorReport_Click(object sender, EventArgs e)
        {
            if(frmCompetitorReport == null)
            {
                frmCompetitorReport = new CompetitorReportForm(DM, this);
            }
            frmCompetitorReport.ShowDialog();
        }

        private void btbDbConnect_Click(object sender, EventArgs e)
        {
            Utilities.selectDBFile();
        }
    }
}
