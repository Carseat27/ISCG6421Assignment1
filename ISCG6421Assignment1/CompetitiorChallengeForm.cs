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
/// this class runs the add a competitor to a challenge form.
/// From here, the user can make an entry by adding a competitor to a challenge,
/// or they can remove an entry by removing a competitor from a challenge.
/// Author: Carson Loveday
/// Date Finished: 22/09/2022
/// </summary>
namespace ISCG6421Assignment1
{
    public partial class CompetitiorChallengeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmCompetitor;
        private CurrencyManager cmChallenge;
        private CurrencyManager cmEntry;
        private CurrencyManager cmCE;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;
        public CompetitiorChallengeForm(DataModule dm, MainForm mnu)
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
        /// <summary>
        /// this method binds the add/remove competitor to challenge controls
        /// </summary>
        private void BindControls()
        {
            dgvCompetitor.DataSource = DM.dsNZESL;
            dgvCompetitor.DataMember = "Competitor";
            dgvCompetitor.AllowUserToAddRows = false;

            dgvChallenge.DataSource = DM.dsNZESL;
            dgvChallenge.DataMember = "Challenge";
            dgvChallenge.AllowUserToAddRows = false;

            dgvEntry.DataSource = DM.dsNZESL;
            dgvEntry.DataMember = "Challenge.Challenge_Entry";

            txtEventName.DataBindings.Add("Text", DM.dsNZESL, "Challenge.EventName");
            txtEventStatus.DataBindings.Add("Text", DM.dsNZESL, "Challenge.EventStatus");

            //auto resize columns
            //noticed that it sometimes caused an error, hence the try-catch
            try
            {
                dgvCompetitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvChallenge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading the form. Please try again.");
                Close();
            }
        }

        /// <summary>
        /// the region holds the code for the basic controls
        /// </summary>
        #region basicPageControls

        /// <summary>
        /// close the form
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        /// <summary>
        /// this region holds the code for assigning a comeptitor to a challenge
        /// </summary>
        #region AssignCompetitorToChallenge
        
        /// <summary>
        /// add an entry
        /// </summary>
        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            //check if challenge is scheduled
            if (DM.dtChallenge.Rows[cmChallenge.Position]["Status"].ToString() == "Scheduled")
            {
                DataRow newEntryRow = DM.dtEntry.NewRow();

                //assign values to add row
                newEntryRow["ChallengeID"] = dgvChallenge["ChallengeID", cmChallenge.Position].Value;
                newEntryRow["CompetitorID"] = dgvCompetitor["CompetitorID", cmCompetitor.Position].Value;
                newEntryRow["Status"] = "Pending";

                //add entry
                try
                {
                    DM.dsNZESL.Tables["Entry"].Rows.Add(newEntryRow);
                    DM.UpdateEntry();
                    MessageBox.Show("Entry added successfully", "Success");
                }
                catch (Exception)
                {
                    Utilities.DBExceptionError();
                }
            }
            else
            {
                MessageBox.Show("Competitors can only be entered into scheduled challenges", "Error");
            }
        }
        #endregion

        /// <summary>
        /// this region holds the code for removing an entry
        /// </summary>
        #region RemoveCompetitorFromChallenge

        /// <summary>
        /// remove an entry
        /// </summary>
        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            int competitorID = Convert.ToInt32(dgvEntry["CompetitorID", cmCE.Position].Value);
            int challengeID = Convert.ToInt32(dgvEntry["ChallengeID", cmCE.Position].Value);

            //check if challenge is scheduled, not completed or finished
            if (DM.dtChallenge.Rows[cmChallenge.Position]["Status"].ToString() == "Scheduled")
            {
                try
                {
                    DataRow deleteEntryRow = DM.dtEntry.Select("CompetitorID = " + competitorID + " AND ChallengeID = " + challengeID)[0];
                    //check with user
                    if (MessageBox.Show("Are you sure to delete the selected record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        //delete entry
                        try
                        {
                            deleteEntryRow.Delete();
                            DM.UpdateEntry();
                            MessageBox.Show("Entry deleted successfully", "Success");
                        }
                        catch (Exception)
                        {
                            Utilities.DBExceptionError();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unexpected Error\n\nTry Again", "Error");
                }
            }
            else
            {
                MessageBox.Show("Competitors can only be removed from scheduled challenges", "Error");
            }
            
            
        }
        #endregion
    }
}
