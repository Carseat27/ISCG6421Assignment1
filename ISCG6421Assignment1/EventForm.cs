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
            controls = new Button[] { btnNext, btnPrevious, btnAddEvent, btnUpdateEvent, btnDeleteEvent, btnReturn };
            step = 0;
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
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

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
        #endregion

        /// <summary>
        /// this region holds the code for adding a new event
        /// </summary>
        #region AddEvents
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

        private void btnEventSave_Click(object sender, EventArgs e)
        {
            txtEventID.Text = "";
            DataRow newEventRow = DM.dtEvent.NewRow();

            //validation of empty boxes
            if ((txtEventNameAdd.Text == "") || (cmbArenaID.Text == ""))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error");
            }
            //check capacity
            else if ( (numEventCapacityAdd.Value == 0) || (numEventCapacityAdd.Value == null) )
            {
                MessageBox.Show("Capacity cannot be 0 or null", "Error");
            }
            else
            {
                newEventRow["EventName"] = txtEventNameAdd.Text;
                newEventRow["ArenaID"] = cmbArenaID.Text;
                newEventRow["Status"] = cmbEventStatusAdd.Text;
                newEventRow["Capacity"] = numEventCapacityAdd.Value;
                newEventRow["EventDate"] = DatePickerAdd.Value;
                newEventRow["ArenaName"] = cmbArenaName.Text;
                try
                {
                    DM.dtEvent.Rows.Add(newEventRow);
                    DM.UpdateEvent();
                    MessageBox.Show("Event added successfully", "Success");
                }
                catch (Exception ex)
                {
                    Utilities.DBExceptionError();
                }
                pnlAdd.Visible = false;
                //enable buttons
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

        //this fills the arena combo boxes on the add challenge screen and
        //ensures that they match.
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

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //hide panel
            pnlUpdate.Visible = false;
            //enable buttons
            Utilities.ButtonsMagic(controls, true);
        }

        private void btnEventUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];

            //validation of empty boxes
            if ((txtEventNameUpdate.Text == "") )
            {
                MessageBox.Show("You must fill out ALL fields!", "Error");
            }
            //check capacity
            else if ((numEventCapacityUpdate.Value == 0) || (numEventCapacityUpdate.Value == null))
            {
                MessageBox.Show("Capacity cannot be 0 or null", "Error");
            }
            else
            {
                updateEventRow["EventName"] = txtEventNameUpdate.Text;
                updateEventRow["ArenaID"] = txtArenaIDUpdate.Text;
                updateEventRow["Status"] = cmbEventStatusUpdate.Text;
                updateEventRow["Capacity"] = numEventCapacityUpdate.Value;
                updateEventRow["EventDate"] = DatePickerUpdate.Value;
                updateEventRow["ArenaName"] = txtArenaNameUpdate.Text;
                currencyManager.EndCurrentEdit();
                try
                {
                    DM.UpdateEvent();
                    MessageBox.Show("Event Updated Successfully", "Success");
                }
                catch (Exception ex)
                {
                    Utilities.DBExceptionError();
                }
                //hide panel
                pnlUpdate.Visible = false;
                //enable buttons
                Utilities.ButtonsMagic(controls, true);
            }

        }
        #endregion

        /// <summary>
        /// this region holds the code for deleting an event
        /// </summary>
        #region DeleteEvent
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];
            DataRow[] ChallengeRow = DM.dtChallenge.Select("EventID = " + txtEventID.Text);
            if(ChallengeRow.Length != 0)
            {
                MessageBox.Show("You may only delete events that have no challenges", "Error!");
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to delete the selected record?\n\nIt is currently: " + txtEventName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        deleteEventRow.Delete();
                        DM.UpdateEvent();
                        MessageBox.Show("Event deleted successfully", "Success");
                    }
                    catch (Exception ex)
                    {
                        Utilities.DBExceptionError();
                    }
                }
            }
        }
        #endregion
    }
}