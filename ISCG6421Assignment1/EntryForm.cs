using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// this class runs the entry maintenance form.
/// From here, the user can filter the entrys by challenges, and change the status of an entry
/// Author: Carson Loveday
/// Date Finished: 22/09/2022
/// 
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

        /// <summary>
        /// this method binds the entry maintenance controls
        /// </summary>
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

        /// <summary>
        /// this region holds the code for the basic controls
        /// </summary>
        #region basicPageControls

        /// <summary>
        /// close the form
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// move the cm position back one
        /// </summary>
        private void btnPreviousChallenge_Click(object sender, EventArgs e)
        {
            if (cmChallenge.Position > 0)
            {
                --cmChallenge.Position;
            }
        }

        /// <summary>
        /// move the cm position forward one
        /// </summary>
        private void btnNextChallenge_Click(object sender, EventArgs e)
        {
            if (cmChallenge.Position < cmChallenge.Count - 1)
            {
                ++cmChallenge.Position;
            }
        }

        /// <summary>
        /// move the cm position back one
        /// </summary>
        private void btnPreviousCompetitor_Click(object sender, EventArgs e)
        {
            if (cmCompetitor.Position > 0)
            {
                --cmCompetitor.Position;
            }
        }

        /// <summary>
        /// move the cm position forward one
        /// </summary>
        private void btnNextCompetitor_Click(object sender, EventArgs e)
        {
            if (cmCompetitor.Position < cmCompetitor.Count - 1)
            {
                ++cmCompetitor.Position;
            }
        }
        #endregion

        /// <summary>
        /// mark an entry as confirmed
        /// </summary>
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

        /// <summary>
        /// mark an entry as disqualified
        /// </summary>
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
