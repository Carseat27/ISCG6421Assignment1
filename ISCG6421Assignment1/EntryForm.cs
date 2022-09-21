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
    public partial class EntryForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmChallenge;
        private CurrencyManager cmCompetitor;
        private CurrencyManager cmEntry;
        public EntryForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        private void BindControls()
        {
            lstChallenges.DataSource = DM.dsNZESL;
            lstChallenges.DisplayMember = "Challenge.ChallengeID" + " " + "Challenge.ChallengeName";
            lstChallenges.ValueMember = "Challenge.ChallengeID";
            cmChallenge = (CurrencyManager)lstChallenges.BindingContext[DM.dsNZESL, "Challenge"];
            txtChallengeName.DataBindings.Add("Text", DM.dsNZESL, "Challenge.ChallengeName");

            lstEntries.DataSource = DM.dsNZESL;
            lstEntries.DisplayMember = "Challenge.Challenge_Entry.Username";
            lstEntries.ValueMember = "Challenge.Challenge_Entry.CompetitorID";
            cmCompetitor = (CurrencyManager)lstEntries.BindingContext[DM.dsNZESL, "Challenge.Challenge_Entry"];

            txtCompetitorFName.DataBindings.Add("Text", DM.dsNZESL, "Challenge.Challenge_Entry.FirstName");
            txtCompetitorLName.DataBindings.Add("Text", DM.dsNZESL, "Challenge.Challenge_Entry.LastName");

            txtEntryStatus.DataBindings.Add("Text", DM.dsNZESL, "Challenge.Challenge_Entry.Status");

            cmEntry = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Entry"];
        }

        #region basicPageControls
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreviousChallenge_Click(object sender, EventArgs e)
        {
            if (cmChallenge.Position > 0)
            {
                --cmChallenge.Position;
            }
        }

        private void btnNextChallenge_Click(object sender, EventArgs e)
        {
            if (cmChallenge.Position < cmChallenge.Count - 1)
            {
                ++cmChallenge.Position;
            }
        }

        private void btnPreviousCompetitor_Click(object sender, EventArgs e)
        {
            if (cmCompetitor.Position > 0)
            {
                --cmCompetitor.Position;
            }
        }

        private void btnNextCompetitor_Click(object sender, EventArgs e)
        {
            if (cmCompetitor.Position < cmCompetitor.Count - 1)
            {
                ++cmCompetitor.Position;
            }
        }
        #endregion

        private void btnEntryConfirm_Click(object sender, EventArgs e)
        {
            //get the correct row for the selection
            int competitorID = Convert.ToInt32(lstEntries.SelectedValue);
            int challengeID = Convert.ToInt32(lstChallenges.SelectedValue);
            DataRow changeEntryStatusRow = DM.dtEntry.Select("CompetitorID = " + competitorID + " AND ChallengeID = " + challengeID)[0];

            if (changeEntryStatusRow["Status"].Equals("Confirmed"))
            {
                MessageBox.Show("Entry is already confirmed", "Error");
            }
            else
            {
                //assign values
                changeEntryStatusRow["Status"] = "Confirmed";
                //cmEntry.EndCurrentEdit();
                //update row
                try
                {
                    DM.UpdateEntry();
                    MessageBox.Show("Entry successfully set to 'Confirmed'", "Success");
                }
                catch (Exception)
                {
                    Utilities.DBExceptionError();
                }
            }
        }

        private void btnMarkDSQ_Click(object sender, EventArgs e)
        {
            //get the correct row for the selection
            int competitorID = Convert.ToInt32(lstEntries.SelectedValue);
            int challengeID = Convert.ToInt32(lstChallenges.SelectedValue);
            DataRow changeEntryStatusRow = DM.dtEntry.Select("CompetitorID = " + competitorID + " AND ChallengeID = " + challengeID)[0];

            if (changeEntryStatusRow["Status"].Equals("Disqualified"))
            {
                MessageBox.Show("Entry is already disqualified", "Error");
            }
            else
            {
                //assign values
                changeEntryStatusRow["Status"] = "Disqualified";
                cmEntry.EndCurrentEdit();
                //update row
                try
                {
                    DM.UpdateEntry();
                    MessageBox.Show("Entry successfully set to 'Confirmed'", "Success");
                }
                catch (Exception)
                {
                    Utilities.DBExceptionError();
                }
            }
        }
    }
}
