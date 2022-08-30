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
    public partial class ChallengeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public ChallengeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }
        private void BindControls()
        {
            txtChallengeID.DataBindings.Add("Text", DM.dsNZESL, "Challenge.ChallengeID");
            txtChallengeName.DataBindings.Add("Text", DM.dsNZESL, "Challenge.ChallengeName");
            txtEventID.DataBindings.Add("Text", DM.dsNZESL, "Challenge.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsNZESL, "Challenge.EventName");
            txtStartTime.DataBindings.Add("Text", DM.dsNZESL, "Challenge.StartTime");
            txtStatus.DataBindings.Add("Text", DM.dsNZESL, "Challenge.Status");
            txtCapacity.DataBindings.Add("Text", DM.dsNZESL, "Challenge.Capacity");
            lstChallenges.DataSource = DM.dsNZESL;
            lstChallenges.DisplayMember = "Challenge.ChallengeID";
            lstChallenges.ValueMember = "Challenge.ChallengeID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Challenge"];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnDeleteChallenge_Click(object sender, EventArgs e)
        {
            DataRow deleteChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            DataRow[] entryRow = DM.dtEntry.Select("EntryID = " + txtChallengeID.Text);
            if (entryRow.Length != 0)
            {
                MessageBox.Show("You may only delete challenges that have no entries", "Error!");
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete the selected record?\nIt is currently: " + txtChallengeName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteChallengeRow.Delete();
                    DM.UpdateChallenge();
                }
            }
        }

        private void btnUpdateChallenge_Click(object sender, EventArgs e)
        {

        }

        private void btnAddChallenge_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;

            //diable buttons
            disableButtons();

            //ensure items are empty
            txtChallengeNameAdd.Text = "";
            timePicker.Text = "";
            numCapacity.Value = 0;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnMarkFinished_Click(object sender, EventArgs e)
        {
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            if (txtStatus.Text == "Scheduled")
            {
                updateChallengeRow["Status"] = "Finished";
                currencyManager.EndCurrentEdit();
                MessageBox.Show("Challenge status set to 'Finished'", "Success");
                DM.UpdateChallenge();
            }
            else
            {
                MessageBox.Show("Only scheduled challenges can be marked as finished!", "Error!");
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            if (txtStatus.Text == "Finished")
            {
                updateChallengeRow["Status"] = "Completed";
                currencyManager.EndCurrentEdit();
                MessageBox.Show("Challenge status set to 'Completed'", "Success");
                DM.UpdateChallenge();
            }
            else
            {
                MessageBox.Show("Only finished challenges can be marked as completed!", "Error!");
            }
        }
        /// <summary>
        /// this section contains functions to hide and show the control buttons
        /// </summary>
        private void disableButtons()
        {
            //disable not needed items
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddChallenge.Enabled = false;
            btnUpdateChallenge.Enabled = false;
            btnDeleteChallenge.Enabled = false;
            btnMarkFinished.Enabled = false;
            btnMarkCompleted.Enabled = false;
            btnReturn.Enabled = false;
        }
        private void enableButtons()
        {
            //enable needed items
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddChallenge.Enabled = true;
            btnUpdateChallenge.Enabled = true;
            btnDeleteChallenge.Enabled = true;
            btnMarkFinished.Enabled = true;
            btnMarkCompleted.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //hide panel
            pnlAdd.Visible = false;

            //enable buttons
            enableButtons();
        }

        private void btnChallengeSave_Click(object sender, EventArgs e)
        {
            txtChallengeID.Text = "";
            DataRow newChallengeRow = DM.dtChallenge.NewRow();

            if  ( (txtChallengeNameAdd.Text == "") || (cmbEventID.Text == "") || (timePicker.Text == "") || (numCapacity.Value == 0) )
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            else
            {
                newChallengeRow["ChallengeName"] = txtChallengeNameAdd.Text;
                newChallengeRow["EventID"] = cmbEventID.Text;
                newChallengeRow["StartTime"] = timePicker.Text;
                newChallengeRow["Status"] = "Scheduled";
                newChallengeRow["Capacity"] = numCapacity.Value;
                DM.dtChallenge.Rows.Add(newChallengeRow);
                MessageBox.Show("Challenge added successfully", "Success");
                DM.UpdateChallenge();
                pnlAdd.Visible = false;
            }
        }
    }
}
