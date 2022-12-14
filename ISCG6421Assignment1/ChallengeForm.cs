using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
/// <summary>
/// this class runs the challenge maintenance form.
/// From here, the user can view challenges, or choose to add, update, or delete them
/// Author: Carson Loveday
/// Date Finished: 22/09/2022
/// </summary>
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
            controls = new Button[] { btnPrevious, btnNext, btnMarkCompleted, btnMarkFinished, btnAddChallenge, btnUpdateChallenge, btnDeleteChallenge, btnReturn };    // <-- add controls to button array for passing to Utilities.ButtonsMagic
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

        /// <summary>
        /// move the cm position back one
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// move the cm position forward one
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// close the form
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        /// <summary>
        /// this region holds the code for adding a new challenge
        /// </summary>
        #region AddChallenges

        /// <summary>
        /// when user clicks add challenge button
        /// </summary>
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

        /// <summary>
        /// this fills the event combo boxes on the add challenge screen and 
        /// binds them to ensure that the values correlate
        /// </summary>
        private void fillCmb()
        {
            cmbEventID.DataSource = DM.dsNZESL;
            cmbEventID.DisplayMember = "EVENT.EventID";
            cmbEventID.ValueMember = "EVENT.EventID";

            cmbEventName.DataSource = DM.dsNZESL;
            cmbEventName.ValueMember = "EVENT.EventID";
            cmbEventName.DisplayMember = "EVENT.EventName";
        }

        /// <summary>
        /// add a challenge
        /// </summary>
        private void btnChallengeSave_Click(object sender, EventArgs e)
        {
            txtChallengeID.Text = "";   // <-- set challengeID to blank
            DataRow newChallengeRow = DM.dtChallenge.NewRow();

            //check that all fields are filled
            if ((txtChallengeNameAdd.Text == "") || (cmbEventID.Text == "select") || (timePicker.Text == "") || (numCapacity.Value == 0))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            else
            {
                //assign values to new datarow
                newChallengeRow["ChallengeName"] = txtChallengeNameAdd.Text;
                newChallengeRow["EventID"] = cmbEventID.Text;
                newChallengeRow["StartTime"] = timePicker.Text;
                newChallengeRow["Status"] = cmbStatusAdd.Text;
                newChallengeRow["Capacity"] = numCapacity.Value;
                newChallengeRow["EventName"] = cmbEventName.Text;
                //add row
                try
                {
                    DM.dtChallenge.Rows.Add(newChallengeRow);
                    DM.UpdateChallenge();
                    MessageBox.Show("Challenge added successfully", "Success");
                }
                catch (Exception)
                {
                    Utilities.DBExceptionError();
                }
                //hide panel
                pnlAdd.Visible = false;
                //enable buttons
                Utilities.ButtonsMagic(controls, true);
            }
        }

        /// <summary>
        /// user cancels add
        /// </summary>
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

        /// <summary>
        /// user clicks on update challenge
        /// </summary>
        private void btnUpdateChallenge_Click(object sender, EventArgs e)
        {
            //show panel
            pnlUpdate.Visible = true;

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

        /// <summary>
        /// update the selected challenge
        /// </summary>
        private void btnChallengeUpdate_Click(object sender, EventArgs e)
        {
            DataRow UpdateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            //check fields are filled
            if ((txtChallengeNameUpdate.Text == "") || (timePickerUpdate.Text == "") || (numCapacityUpdate.Value == 0))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            else
            {
                //assign values to update row
                UpdateChallengeRow["ChallengeName"] = txtChallengeNameUpdate.Text;
                UpdateChallengeRow["StartTime"] = timePickerUpdate.Text;
                UpdateChallengeRow["Capacity"] = numCapacityUpdate.Value;
                UpdateChallengeRow["Status"] = cmbStatusUpdate.Text;
                UpdateChallengeRow["EventName"] = txtEventNameUpdate.Text;
                currencyManager.EndCurrentEdit();
                //update row
                try
                {
                    DM.UpdateChallenge();
                    MessageBox.Show("Challenge updated successfully", "Success");
                }
                catch (Exception)
                {
                    Utilities.DBExceptionError();
                }
                //hide panel
                pnlUpdate.Visible = false;
                //enable buttons
                Utilities.ButtonsMagic(controls, true);
            }
        }

        /// <summary>
        /// user cancels add
        /// </summary>
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

        /// <summary>
        /// user clicks on delete challenge
        /// </summary>
        private void btnDeleteChallenge_Click(object sender, EventArgs e)
        {
            DataRow deleteChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            DataRow[] entryRow = DM.dtEntry.Select("ChallengeID = " + txtChallengeID.Text);
            //ensure that challenge has no entries
            if (entryRow.Length != 0)
            {
                MessageBox.Show("You may only delete challenges that have no entries", "Error!");
            }
            else
            {
                //check with user
                if (MessageBox.Show("Are you sure to delete the selected record?\n\nIt is currently: " + txtChallengeName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //delete row
                    try
                    {
                        deleteChallengeRow.Delete();
                        DM.UpdateChallenge();
                        MessageBox.Show("Challenge deleted successfully", "Success");
                    }
                    catch (Exception)
                    {
                        Utilities.DBExceptionError();
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// this region holds the code for changing the status of a challenge
        /// </summary>
        #region changeStatus

        /// <summary>
        /// user clicks mark as finished
        /// </summary>
        private void btnMarkFinished_Click(object sender, EventArgs e)
        {
            //sets the selected challenge to "Finished" provided that the condidtions are met
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            //check current status
            if (txtStatus.Text == "Scheduled")
            {
                updateChallengeRow["Status"] = "Finished";
                currencyManager.EndCurrentEdit();
                //update status
                try
                {
                    DM.UpdateChallenge();
                    MessageBox.Show("Challenge status set to 'Finished'", "Success");
                }
                catch (Exception)
                {
                    Utilities.DBExceptionError();
                }
            }
            else
            {
                MessageBox.Show("Only scheduled challenges can be marked as finished!", "Error!");
            }
        }

        /// <summary>
        /// user clicks mark as completed
        /// </summary>
        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            //sets the selected challenge to "Completed" provided that the condidtions are met
            DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            //check current status
            if (txtStatus.Text == "Finished")
            {
                updateChallengeRow["Status"] = "Completed";
                currencyManager.EndCurrentEdit();
                //update status
                try
                {
                    DM.UpdateChallenge();
                    MessageBox.Show("Challenge status set to 'Completed'", "Success");
                }
                catch (Exception)
                {
                    Utilities.DBExceptionError();
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