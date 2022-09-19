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
/// this class runs the event maintenance form.
/// From here, the user can view events, or choose to add, update, or delete them
/// Author: Carson Loveday
/// Date Finished: 22/09/2022
/// </summary>
namespace ISCG6421Assignment1
{
    public partial class EventForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private Button[] controls;
        public EventForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            controls = new Button[] { btnNext, btnPrevious, btnAddEvent, btnUpdateEvent, btnDeleteEvent, btnReturn };   // <-- add controls to button array for passing to Utilities.ButtonsMagic
        }
        /// <summary>
        /// this method binds the event maintenance controls
        /// </summary>
        private void BindControls()
        {
            txtEventID.DataBindings.Add("Text", DM.dsNZESL, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsNZESL, "Event.EventName");
            txtArenaID.DataBindings.Add("Text", DM.dsNZESL, "Event.ArenaID");
            txtArenaName.DataBindings.Add("Text", DM.dsNZESL, "Event.ArenaName");
            txtEventStatus.DataBindings.Add("Text", DM.dsNZESL, "Event.Status");
            txtEventCapacity.DataBindings.Add("Text", DM.dsNZESL, "Event.Capacity");
            txtEventDate.DataBindings.Add("Text", DM.dsNZESL, "Event.EventDate");
            lstEvents.DataSource = DM.dsNZESL;
            lstEvents.DisplayMember = "Event.EventName";
            lstEvents.ValueMember = "Event.EventID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Event"];
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
        #endregion

        /// <summary>
        /// this region holds the code for adding a new event
        /// </summary>
        #region AddEvents

        /// <summary>
        /// user clicks on add event
        /// </summary>
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            //show panel
            pnlAdd.Visible = true;

            //disable buttons
            Utilities.ButtonsMagic(controls, false);

            //set inputs to defaults
            txtEventNameAdd.Text = "";
            numEventCapacityAdd.Value = 0;
            cmbEventStatusAdd.SelectedIndex = 0;

            //fill arena info
            fillArenaInfo();

            //configure datepicker
            DatePickerAdd.MaxDate = DateTime.Now.AddYears(5);
            DatePickerAdd.MinDate = DateTime.Now;
            DatePickerAdd.Value = DateTime.Now;
        }

        /// <summary>
        /// add an event
        /// </summary>
        private void btnEventSave_Click(object sender, EventArgs e)
        {
            txtEventID.Text = "";   // <-- set eventID to blank
            DataRow newEventRow = DM.dtEvent.NewRow();

            //check fields are filled
            if ((txtEventNameAdd.Text == "") || (cmbArenaID.Text == ""))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error");
            }
            //check capacity is valid
            else if (numEventCapacityAdd.Value == 0)
            {
                MessageBox.Show("Capacity cannot be 0", "Error");
            }
            else
            {
                //assign values to new datarow
                newEventRow["EventName"] = txtEventNameAdd.Text;
                newEventRow["ArenaID"] = cmbArenaID.Text;
                newEventRow["Status"] = cmbEventStatusAdd.Text;
                newEventRow["Capacity"] = numEventCapacityAdd.Value;
                newEventRow["EventDate"] = DatePickerAdd.Value;
                newEventRow["ArenaName"] = cmbArenaName.Text;
                //add row
                try
                {
                    DM.dtEvent.Rows.Add(newEventRow);
                    DM.UpdateEvent();
                    MessageBox.Show("Event added successfully", "Success");
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
        /// user cancels the add
        /// </summary>
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //hide panel
            pnlAdd.Visible = false;
            //enable buttons
            Utilities.ButtonsMagic(controls, true);
        }

        /// <summary>
        /// this fills the arena combo boxes on the add challenge screen and
        /// ensures that they match.
        /// </summary>
        private void fillArenaInfo()
        {
            cmbArenaID.DataSource = DM.dsNZESL;
            cmbArenaID.DisplayMember = "Arena.ArenaID";
            cmbArenaID.ValueMember = "Arena.ArenaID";

            cmbArenaName.DataSource = DM.dsNZESL;
            cmbArenaName.DisplayMember = "Arena.ArenaName";
            cmbArenaName.ValueMember = "Arena.ArenaID";
        }
        #endregion

        /// <summary>
        /// this region holds the code for updating an event
        /// </summary>
        #region UpdateEvents

        /// <summary>
        /// user clicks on update event
        /// </summary>
        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            //show panel
            pnlUpdate.Visible = true;

            //disable buttons
            Utilities.ButtonsMagic(controls, false);

            //fill boxes
            txtEventIDUpdate.Text = txtEventID.Text;
            txtEventNameUpdate.Text = txtEventName.Text;
            txtArenaIDUpdate.Text = txtArenaID.Text;
            txtArenaNameUpdate.Text = txtArenaName.Text;
            cmbEventStatusUpdate.Text = txtEventStatus.Text;
            int.TryParse(txtEventCapacity.Text, out int result);
            numEventCapacityUpdate.Value = result;

            //set minimum date to be 1 year prior to the selected event's date
            DatePickerUpdate.MinDate = (DateTime.Parse(txtEventDate.Text).AddYears(-1));
            DatePickerUpdate.Text = txtEventDate.Text;
        }

        /// <summary>
        /// update the selected event
        /// </summary>
        private void btnEventUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];

            //check fields are filled
            if ((txtEventNameUpdate.Text == "") )
            {
                MessageBox.Show("You must fill out ALL fields!", "Error");
            }
            //check capacity is valid
            else if (numEventCapacityUpdate.Value == 0)
            {
                MessageBox.Show("Capacity cannot be 0 or null", "Error");
            }
            else
            {
                //assign values to update row
                updateEventRow["EventName"] = txtEventNameUpdate.Text;
                updateEventRow["ArenaID"] = txtArenaIDUpdate.Text;
                updateEventRow["Status"] = cmbEventStatusUpdate.Text;
                updateEventRow["Capacity"] = numEventCapacityUpdate.Value;
                updateEventRow["EventDate"] = DatePickerUpdate.Value;
                updateEventRow["ArenaName"] = txtArenaNameUpdate.Text;
                currencyManager.EndCurrentEdit();
                //update row
                try
                {
                    DM.UpdateEvent();
                    MessageBox.Show("Event Updated Successfully", "Success");
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
        /// user cancels the update
        /// </summary>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //hide panel
            pnlUpdate.Visible = false;
            //enable buttons
            Utilities.ButtonsMagic(controls, true);
        }
        #endregion

        /// <summary>
        /// this region holds the code for deleting an event
        /// </summary>
        #region DeleteEvent

        /// <summary>
        /// user clicks on delete event
        /// </summary>
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];
            DataRow[] ChallengeRow = DM.dtChallenge.Select("EventID = " + txtEventID.Text);
            //ensure event has no challenges
            if(ChallengeRow.Length != 0)
            {
                MessageBox.Show("You may only delete events that have no challenges", "Error!");
            }
            else
            {
                //check with user
                if(MessageBox.Show("Are you sure you want to delete the selected record?\n\nIt is currently: " + txtEventName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //delete row
                    try
                    {
                        deleteEventRow.Delete();
                        DM.UpdateEvent();
                        MessageBox.Show("Event deleted successfully", "Success");
                    }
                    catch (Exception)
                    {
                        Utilities.DBExceptionError();
                    }
                }
            }
        }
        #endregion
    }
}