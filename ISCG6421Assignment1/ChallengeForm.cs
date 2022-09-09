using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    public partial class ChallengeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private Button[] controls;
        public ChallengeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            controls = new Button[] { btnPrevious, btnNext, btnMarkCompleted, btnMarkFinished, btnAddChallenge, btnUpdateChallenge, btnDeleteChallenge, btnReturn };
        }
        /// <summary>
        /// this method binds the challenge maintenance controls
        /// </summary>
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
            cmbEventName.DataBindings.Add("Text", DM.dsNZESL, "Event.EventName");
        }

        /// <summary>
        /// this region holds the code for the basic controls
        /// </summary>
        #region basicPageControls
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        /// <summary>
        /// this region holds the code for adding a new challenge
        /// </summary>
        #region AddChallenges
        private void btnAddChallenge_Click(object sender, EventArgs e)
        {
            //show panel
            pnlAdd.Visible = true;

            //disable buttons
            Utilities.ButtonsMagic(controls, false);

            //ensure items are empty
            txtChallengeNameAdd.Text = "";
            timePicker.Text = "00:00";
            numCapacity.Value = 0;

            //fill combo box
            fillCmb();
        }

        private void fillCmb()
        {
            //this fills the event combo boxes on the add challenge screen and
            //binds them to ensure that the values correlate
            cmbEventID.DataSource = DM.dsNZESL;
            cmbEventID.DisplayMember = "EVENT.EventID";
            cmbEventID.ValueMember = "EVENT.EventID";

            cmbEventName.DataSource = DM.dsNZESL;
            cmbEventName.ValueMember = "EVENT.EventID";
            cmbEventName.DisplayMember = "EVENT.EventName";
        }

        private void btnChallengeSave_Click(object sender, EventArgs e)
        {
            //ensures that no options are left blank and adds the challenge with a new id
            txtChallengeID.Text = "";
            DataRow newChallengeRow = DM.dtChallenge.NewRow();

            if ((txtChallengeNameAdd.Text == "") || (cmbEventID.Text == "select") || (timePicker.Text == "") || (numCapacity.Value == 0))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            else
            {
                newChallengeRow["ChallengeName"] = txtChallengeNameAdd.Text;
                newChallengeRow["EventID"] = cmbEventID.Text;
                newChallengeRow["StartTime"] = timePicker.Text;
                newChallengeRow["Status"] = cmbStatusAdd.Text;
                newChallengeRow["Capacity"] = numCapacity.Value;
                try
                {
                    DM.dtChallenge.Rows.Add(newChallengeRow);
                    DM.UpdateChallenge();
                    MessageBox.Show("Challenge added successfully", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an unexpected error.\n\nPlease check that you are using 'NZESL.mdb' as provided.", "Error");
                }
                pnlAdd.Visible = false;
                Utilities.ButtonsMagic(controls, true);
            }
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //hide panel
            pnlAdd.Visible = false;

            //enable buttons
            Utilities.ButtonsMagic(controls, true);
        }
        #endregion

        /// <summary>
        /// this region holds the cold for updating a challenge
        /// </summary>
        #region UpdateChallenge
        private void btnUpdateChallenge_Click(object sender, EventArgs e)
        {
            //show correct panel
            pnlUpdate.Visible = true;
            pnlAdd.Visible = false;

            //disable not needed items
            Utilities.ButtonsMagic(controls, false);

            //enable text boxes and set text
            txtChallengeNameUpdate.Text = txtChallengeName.Text;
            txtEventNameUpdate.Text = txtEventName.Text;
            timePickerUpdate.Text = txtStartTime.Text;
            int.TryParse(txtCapacity.Text, out int result);
            numCapacityUpdate.Value = result;
            cmbStatusUpdate.Text = txtStatus.Text;
        }

        private void btnChallengeUpdate_Click(object sender, EventArgs e)
        {
            //ensures that no options are left blank and updates the relevant challenge
            DataRow UpdateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            if ((txtChallengeNameUpdate.Text == "") || (timePickerUpdate.Text == "") || (numCapacityUpdate.Value == 0))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            else
            {
                UpdateChallengeRow["ChallengeName"] = txtChallengeNameUpdate.Text;
                UpdateChallengeRow["StartTime"] = timePickerUpdate.Text;
                UpdateChallengeRow["Capacity"] = numCapacityUpdate.Value;
                UpdateChallengeRow["Status"] = cmbStatusUpdate.Text;
                currencyManager.EndCurrentEdit();
                try
                {
                    DM.UpdateChallenge();
                    MessageBox.Show("Challenge updated successfully", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an unexpected error.\n\nPlease check that you are using 'NZESL.mdb' as provided.", "Error");
                }
                //hide panel
                pnlUpdate.Visible = false;
                //enable buttons
                Utilities.ButtonsMagic(controls, true);
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //ensure extra panels are not visible
            pnlUpdate.Visible = false;
            pnlAdd.Visible = false;

            //enable needed items
            Utilities.ButtonsMagic(controls, true);
        }
        #endregion

        /// <summary>
        /// this region holds the code for deleting a challenge
        /// </summary>
        #region DeleteChallenge
        private void btnDeleteChallenge_Click(object sender, EventArgs e)
        {
            DataRow deleteChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            DataRow[] entryRow = DM.dtEntry.Select("ChallengeID = " + txtChallengeID.Text);
            if (entryRow.Length != 0)
            {
                MessageBox.Show("You may only delete challenges that have no entries", "Error!");
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete the selected record?\n\nIt is currently: " + txtChallengeName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteChallengeRow.Delete();
                    DM.UpdateChallenge();

                    MessageBox.Show("Challenge deleted successfully", "Success");
                }
            }
        }
        #endregion

        /// <summary>
        /// this region holds the code for changing the status of a challenge
        /// </summary>
        #region changeStatus
        private void btnMarkFinished_Click(object sender, EventArgs e)
        {
            //sets the selected challenge to "Finished" provided that the condidtions are met
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            if (txtStatus.Text == "Scheduled")
            {
                updateChallengeRow["Status"] = "Finished";
                currencyManager.EndCurrentEdit();
                try
                {
                    DM.UpdateChallenge();
                    MessageBox.Show("Challenge status set to 'Finished'", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an unexpected error.\n\nPlease check that you are using 'NZESL.mdb' as provided.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Only scheduled challenges can be marked as finished!", "Error!");
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            //sets the selected challenge to "Completed" provided that the condidtions are met
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            if (txtStatus.Text == "Finished")
            {
                updateChallengeRow["Status"] = "Completed";
                currencyManager.EndCurrentEdit();
                try
                {
                    DM.UpdateChallenge();
                    MessageBox.Show("Challenge status set to 'Completed'", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an unexpected error.\n\nPlease check that you are using 'NZESL.mdb' as provided.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Only finished challenges can be marked as completed!", "Error!");
            }
        }
        #endregion

    }
}