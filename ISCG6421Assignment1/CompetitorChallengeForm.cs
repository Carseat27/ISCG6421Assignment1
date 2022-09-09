using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    public partial class CompetitorChallengeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmCompetitor;
        private CurrencyManager cmChallenge;
        private CurrencyManager cmEntry;
        private CurrencyManager cmCE;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;
        public CompetitorChallengeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmCompetitor = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Competitor"];
            cmChallenge = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Challenge"];
            cmEntry = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Entry"];
            cmCE = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Challenge.Challenge_Entry"];
            cmDt = (CurrencyManager)this.BindingContext[dt];

            BindControls();
        }
        private void BindControls()
        {
            dgvCompetitor.DataSource = DM.dsNZESL;
            dgvCompetitor.DataMember = "Competitor";
            dgvCompetitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompetitor.AllowUserToAddRows = false;

            dgvChallenge.DataSource = DM.dsNZESL;
            dgvChallenge.DataMember = "Challenge";
            dgvChallenge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChallenge.AllowUserToAddRows = false;

            dgvEntry.DataSource = DM.dsNZESL;
            dgvEntry.DataMember = "Challenge.Challenge_Entry";
            dgvEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtEventName.DataBindings.Add("Text", DM.dsNZESL, "Challenge.EventName");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            if (DM.dtChallenge.Rows[cmChallenge.Position]["Status"].ToString() == "Scheduled")
            {
                DataRow newEntryRow = DM.dtEntry.NewRow();
                newEntryRow["ChallengeID"] = dgvChallenge["ChallengeID", cmChallenge.Position].Value;
                newEntryRow["CompetitorID"] = dgvCompetitor["CompetitorID", cmCompetitor.Position].Value;
                newEntryRow["Status"] = "Confirmed";
                
                try
                {
                    DM.UpdateEntry();
                    MessageBox.Show("Entry added successfully", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an unexpected error - Please check that you are using 'NZESL.mdb' as provided.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Competitors can only be entered into scheduled challenges", "Error");
            }
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            DataRow deleteEntryRow = DM.dtEntry.Rows[cmCE.Position];
            if (MessageBox.Show("Are you sure to delete the selected record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    deleteEntryRow.Delete();
                    DM.UpdateEntry();
                    MessageBox.Show("Entry deleted successfully", "Success");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("There has been an unexpected error - Please check that you are using 'NZESL.mdb' as provided.", "Error");
                }
            }
        }
    }
}
