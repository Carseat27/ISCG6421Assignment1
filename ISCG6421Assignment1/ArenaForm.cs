using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    public partial class ArenaForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private Button[] controls;
        public ArenaForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            controls = new Button[] { btnNext, btnPrevious, btnAddArena, btnUpdateArena, btnDeleteArena, btnReturn };
        }

        /// <summary>
        /// this method binds the arena maintenance controls
        /// </summary>
        private void BindControls()
        {
            txtArenaID.DataBindings.Add("Text", DM.dsNZESL, "Arena.ArenaID");
            txtArenaName.DataBindings.Add("Text", DM.dsNZESL, "Arena.ArenaName");
            txtArenaAddress.DataBindings.Add("Text", DM.dsNZESL, "Arena.StreetAddress");
            txtArenaSuburb.DataBindings.Add("Text", DM.dsNZESL, "Arena.Suburb");
            txtArenaCity.DataBindings.Add("Text", DM.dsNZESL, "Arena.City");
            txtArenaPhone.DataBindings.Add("Text", DM.dsNZESL, "Arena.PhoneNumber");
            lstArenas.DataSource = DM.dsNZESL;
            lstArenas.DisplayMember = "Arena.ArenaName";
            lstArenas.ValueMember = "Arena.ArenaID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Arena"];
        }

        /// <summary>
        /// this region holds the code for the basic controls
        /// </summary>
        #region basicPageControls
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currencyManager.Position < currencyManager.Count - 1)
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
        /// this region holds the code for adding a new arena
        /// </summary>
        #region AddArena
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //hide panel for adding arena
            pnlAdd.Visible = false;
            pnlUpdate.Visible = false;

            //enable needed items
            Utilities.ButtonsMagic(controls, true);
        }

        private void btnAddArena_Click(object sender, EventArgs e)
        {
            //show panel for adding arena
            pnlAdd.Visible = true;
            pnlUpdate.Visible = false;

            //disable items not needed
            Utilities.ButtonsMagic(controls, false);

            //ensure text boxes are empty
            txtArenaNameAdd.Text = "";
            txtArenaAddressAdd.Text = "";
            txtArenaSuburbAdd.Text = "";
            txtArenaCityAdd.Text = "";
            txtArenaPhoneAdd.Text = "";
        }


        private void btnArenaSave_Click(object sender, EventArgs e)
        {
            txtArenaID.Text = "";
            DataRow newArenaRow = DM.dtArena.NewRow();

            if ((txtArenaNameAdd.Text == "") || (txtArenaAddressAdd.Text == "") || (txtArenaSuburbAdd.Text == "") || (txtArenaCityAdd.Text == "") || (txtArenaPhoneAdd.Text == ""))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            else
            {
                newArenaRow["ArenaName"] = txtArenaNameAdd.Text;
                newArenaRow["StreetAddress"] = txtArenaAddressAdd.Text;
                newArenaRow["Suburb"] = txtArenaSuburbAdd.Text;
                newArenaRow["City"] = txtArenaCityAdd.Text;
                newArenaRow["PhoneNumber"] = txtArenaPhoneAdd.Text;
                MessageBox.Show("Arena added successfully", "Success");
                try
                {
                    DM.dtArena.Rows.Add(newArenaRow);
                    DM.UpdateArena();
                    MessageBox.Show("Arena added successfully", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an unexpected error.\n\nPlease check that you are using 'NZESL.mdb' as provided.", "Error");
                }
                //hide panel
                pnlAdd.Visible = false;
                //enable buttons
                Utilities.ButtonsMagic(controls, true);
            }
        }
        #endregion

        /// <summary>
        /// this region holds the code for updating an arena
        /// </summary>
        #region UpdateArena
        private void btnUpdateArena_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            pnlUpdate.Visible = true;

            //disable items not needed
            Utilities.ButtonsMagic(controls, false);

            //enable text boxes
            txtArenaName.Enabled = true;
            txtArenaAddress.Enabled = true;
            txtArenaSuburb.Enabled = true;
            txtArenaCity.Enabled = true;
            txtArenaPhone.Enabled = true;
        }

        private void btnArenaUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateArenaRow = DM.dtArena.Rows[currencyManager.Position];
            if ((txtArenaName.Text == "") || (txtArenaAddress.Text == "") || (txtArenaSuburb.Text == "") || (txtArenaCity.Text == "") || (txtArenaPhone.Text == ""))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            else
            {
                updateArenaRow["ArenaName"] = txtArenaName.Text;
                updateArenaRow["StreetAddress"] = txtArenaAddress.Text;
                updateArenaRow["Suburb"] = txtArenaSuburb.Text;
                updateArenaRow["City"] = txtArenaCity.Text;
                updateArenaRow["PhoneNumber"] = txtArenaPhone.Text;
                currencyManager.EndCurrentEdit();
                try
                {
                    DM.UpdateArena();
                    MessageBox.Show("Arena updated successfully", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an unexpected error.\n\nPlease check that you are using 'NZESL.mdb' as provided.", "Error");
                }
                //hide panel
                pnlUpdate.Visible = false;

                //enable needed items
                Utilities.ButtonsMagic(controls, true);

                //disable text boxes
                txtArenaName.Enabled = false;
                txtArenaAddress.Enabled = false;
                txtArenaSuburb.Enabled = false;
                txtArenaCity.Enabled = false;
                txtArenaPhone.Enabled = false;
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;

            //enable needed items
            Utilities.ButtonsMagic(controls, true);

            //disable text boxes
            txtArenaName.Enabled = false;
            txtArenaAddress.Enabled = false;
            txtArenaSuburb.Enabled = false;
            txtArenaCity.Enabled = false;
            txtArenaPhone.Enabled = false;
        }
        #endregion

        /// <summary>
        /// this section defines the EventActions for deleting an arena
        /// </summary>
        #region DeleteArena
        private void btnDeleteArena_Click(object sender, EventArgs e)
        {
            DataRow deleteArenaRow = DM.dtArena.Rows[currencyManager.Position];
            DataRow[] EventRow = DM.dtEvent.Select("ArenaID = " + txtArenaID.Text);
            if (EventRow.Length != 0)
            {
                MessageBox.Show("You may only delete arenas that are not assigned to Events", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete the selected record?\n\nIt is currently: " + txtArenaName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        deleteArenaRow.Delete();
                        DM.UpdateArena();
                        MessageBox.Show("Arena updated successfully", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There has been an unexpected error.\n\nPlease check that you are using 'NZESL.mdb' as provided.", "Error");
                    }
                }
            }
        }
        #endregion
    }
}
