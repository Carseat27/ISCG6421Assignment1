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

/// <summary>
/// this class runs the main form.
/// From here, the user can choose from many maintenance or report options
/// Author: Carson Loveday
/// Date Finished: 22/09/2022
/// </summary>
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
        private CompetitiorChallengeForm frmCompetitorChallenge;
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

        /// <summary>
        /// button to open arena maintenance form
        /// </summary>
        private void btnArenaMaintenance_Click(object sender, EventArgs e)
        {
            if(frmArena == null)
            {
                frmArena = new ArenaForm(DM, this);
            }
            DM.refeshMainDS();          // <-- refresh main dataset
            frmArena.ShowDialog();
        }

        /// <summary>
        /// button to open the event maintenance form
        /// </summary>
        private void btnEventMaintenance_Click(object sender, EventArgs e)
        {
            if(frmEvent == null)
            {
                frmEvent = new EventForm(DM, this);
            }
            DM.refeshMainDS();          // <-- refresh main dataset;
            frmEvent.ShowDialog();
        }

        /// <summary>
        /// button to open the challenge maintenance form
        /// </summary>
        private void btnChallengeMaintenance_Click(object sender, EventArgs e)
        {
            if(frmChallenge == null)
            {
                frmChallenge = new ChallengeForm(DM, this);
            }
            DM.refeshMainDS();          // <-- refresh main dataset
            frmChallenge.ShowDialog();
        }

        /// <summary>
        /// button to open the competitor maintenance form
        /// </summary>
        private void btnCompetitorMaintence_Click(object sender, EventArgs e)
        {
            if(frmCompetitor == null)
            {
                frmCompetitor = new CompetitorForm(DM, this);
            }
            DM.refeshMainDS();          // <-- refresh main dataset
            frmCompetitor.ShowDialog();
        }
        /// <summary>
        /// button to open the entry maintenance form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntryMaintenance_Click(object sender, EventArgs e)
        {
            if(frmEntry == null)
            {
                frmEntry = new EntryForm(DM, this);
            }
            DM.refeshMainDS();          // <-- refresh main dataset
            frmEntry.ShowDialog();
        }

        /// <summary>
        /// button to open the entry maintenance form
        /// </summary>
        private void btnEnterCompetitorChallenge_Click(object sender, EventArgs e)
        {
            if(frmCompetitorChallenge == null)
            {
                frmCompetitorChallenge = new CompetitiorChallengeForm(DM, this);
            }
            DM.refeshMainDS();          // <-- refresh main dataset
            frmCompetitorChallenge.ShowDialog();
        }

        /// <summary>
        /// button to open the events report form
        /// </summary>
        private void btnEventsReport_Click(object sender, EventArgs e)
        {
            if(frmEventsReport == null)
            {
                frmEventsReport = new EventsReportForm(DM, this);
            }
            DM.refeshMainDS();          // <-- refresh main dataset
            DM.refreshEventReportDS();  // <-- refresh dataset for report
            frmEventsReport.ShowDialog();
        }

        /// <summary>
        /// button to open the competitor reports form
        /// </summary>
        private void btnCompetitorReport_Click(object sender, EventArgs e)
        {
            if(frmCompetitorReport == null)
            {
                frmCompetitorReport = new CompetitorReportForm(DM, this);
            }
            DM.refeshMainDS();          // <-- refresh main dataset
            DM.refreshCompReportDS();   // <-- refresh dataset for report
            frmCompetitorReport.ShowDialog();
        }

        /// <summary>
        /// button to allow user to select location of database file
        /// </summary>
        private void btbDbConnect_Click(object sender, EventArgs e)
        {
            Utilities.selectDBFile();
        }

        /// <summary>
        /// button to exit the program
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
