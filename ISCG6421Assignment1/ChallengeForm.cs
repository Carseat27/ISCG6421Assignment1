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
        private DateTime currentTimeUpdate;
        private int step;
        private Button[] controls;
        public ChallengeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            controls = new Button[] { btnPrevious, btnNext, btnMarkCompleted, btnMarkFinished, btnAddChallenge, btnUpdateChallenge, btnDeleteChallenge, btnReturn };
            step = 0;
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

            cmbEventName.DataBindings.Add("Text", DM.dsNZESL, "Event.EventName");

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

            //get time
            currentTimeUpdate = timePickerUpdate.Value;
        }

        private void btnAddChallenge_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlUpdate.Visible = false;

            //disable buttons
            Utilities.ButtonsMagic(controls, false);

            //ensure items are empty
            txtChallengeNameAdd.Text = "";
            timePicker.Text = "00:00";
            numCapacity.Value = 0;

            //fill combo box
            fillCmb();
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

        //sets the selected challenge to "Finished" provided that the condidtions are met
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

        //sets the selected challenge to "Completed" provided that the condidtions are met
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

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //hide panel
            pnlAdd.Visible = false;

            //enable buttons
            Utilities.ButtonsMagic(controls, true);
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
                DM.dtChallenge.Rows.Add(newChallengeRow);
                try
                {
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
                DM.UpdateChallenge();
                MessageBox.Show("Challenge Updated Successfully", "Success");
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

        //this fills the event combo boxes on the add challenge screen and
        //ensures that they match.
        private void fillCmb()
        {
            cmbEventID.DataSource = DM.dsNZESL;
            cmbEventID.DisplayMember = "EVENT.EventID";
            cmbEventID.ValueMember = "EVENT.EventID";

            cmbEventName.DataSource = DM.dsNZESL;
            cmbEventName.ValueMember = "EVENT.EventID";
            cmbEventName.DisplayMember = "EVENT.EventName";
        }

        private void timePickerUpdate_ValueChanged(object sender, EventArgs e)
        {
            //haven't been able to get this to work properly
            //but it is there if you want to fix it

            //Console.WriteLine(e.GetType());
            //PropertyValueChangedEventArgs args = (PropertyValueChangedEventArgs)e;


            //if ((DateTime)args.OldValue > timePickerUpdate.Value)
            //{
            //    timePickerUpdate.Value.AddMinutes(15);
            //}
            //else {
            //    timePickerUpdate.Value.AddMinutes(-15);
            //}
            
            //if ((currentTimeUpdate.Minute < timePickerUpdate.Value.Minute))
            //{
            //    timePickerUpdate.Value = currentTimeUpdate.AddMinutes(15);
            //    currentTimeUpdate = timePickerUpdate.Value;
            //}
            //else if ((currentTimeUpdate.Minute == 45))
            //{
            //    timePickerUpdate.Value = currentTimeUpdate.AddMinutes(15);
            //    currentTimeUpdate = timePickerUpdate.Value;
            //}
            //else if ((currentTimeUpdate.Minute > timePickerUpdate.Value.Minute))
            //{
            //    timePickerUpdate.Value = currentTimeUpdate.AddMinutes(-15);
            //    //Console.WriteLine("False"); 
            //    currentTimeUpdate = timePickerUpdate.Value;
            //}
            //else { currentTimeUpdate = timePickerUpdate.Value; }
        }

        /// <summary>
        /// this method ensures that the child form (Arena) will make the parent form (MainForm) move with it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChallengeForm_Move(object sender, EventArgs e)
        {
            step = Utilities.Movement(step, sender, e);
        }
    }
}
