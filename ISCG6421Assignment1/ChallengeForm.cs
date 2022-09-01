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
                if (MessageBox.Show("Are you sure to delete the selected record?\nIt is currently: " + txtChallengeName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteChallengeRow.Delete();
                    DM.UpdateChallenge();
                }
            }
        }

        private void btnUpdateChallenge_Click(object sender, EventArgs e)
        {
            //show correct panel
            pnlUpdate.Visible = true;
            pnlAdd.Visible = false;

            //disable not needed items
            disableButtons();

            //enable text boxes and set text
            txtChallengeNameUpdate.Text = txtChallengeName.Text;
            txtEventNameUpdate.Text = txtEventName.Text;
            timePickerUpdate.Text = txtStartTime.Text;
            int.TryParse(txtCapacity.Text, out int result);
            numCapacityUpdate.Value = result;
            cmbStatusUpdate.Text = txtStatus.Text;
        }

        private void btnAddChallenge_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlUpdate.Visible = false;

            //diable buttons
            disableButtons();

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

            if ((txtChallengeNameAdd.Text == "") || (cmbEventID.Text == "select") || (timePicker.Text == "") || (numCapacity.Value == 0))
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
                enableButtons();
            }
        }

        private void btnChallengeUpdate_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
            pnlAdd.Visible = false;

            //enable needed items
            enableButtons();
        }

        private void fillCmb()
        {
            //OleDbCommand cmd = new OleDbCommand("SELECT EventID, EventName FROM EVENT", DM.ctnNZESL);
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    cmbEventID.Items.Add(row["EventID"]);
            //}
            //cmbEventID.Text = "select";
            cmbEventID.DataSource = DM.dsNZESL;
            cmbEventID.DisplayMember = "EVENT.EventID";
            cmbEventID.ValueMember = "EVENT.EventID";

            cmbEventName.DataSource = DM.dsNZESL;
            cmbEventName.ValueMember = "EVENT.EventID";
            cmbEventName.DisplayMember = "EVENT.EventName";
        }

        private void cmbEventID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEventName.SelectedValue = cmbEventID.SelectedValue;
        }
    }
}
