﻿using System;
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
        public ArenaForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

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
            pnlAdd.Visible = false;
            Close();
        }

        /// <summary>
        /// this section contains functions to hide and show the control buttons
        /// </summary>
        private void disableButtons()
        {
            //disable items not needed
            btnUpdateArena.Enabled = false;
            btnDeleteArena.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnAddArena.Enabled = false;
            btnReturn.Enabled = false;
        }
        private void enableButtons()
        {
            //enable needed items
            btnUpdateArena.Enabled = true;
            btnDeleteArena.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddArena.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// this section defines the ActionEvents for adding an arena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //hide panel for adding arena
            pnlAdd.Visible = false;
            pnlUpdate.Visible = false;


            //enable needed items
            enableButtons();
        }

        private void btnAddArena_Click(object sender, EventArgs e)
        {
            //show panel for adding arena
            pnlAdd.Visible = true;
            pnlUpdate.Visible = false;

            //disable items not needed
            disableButtons();

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
                DM.dtArena.Rows.Add(newArenaRow);
                MessageBox.Show("Arena added successfully", "Success");
                DM.UpdateArena();
                pnlAdd.Visible = false;
            }
        }

        /// <summary>
        /// this next section defines the EventActions for updating the arena details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                DM.UpdateArena();
                MessageBox.Show("Treatment Updated Successfully", "Success!");

                pnlUpdate.Visible = false;
                pnlAdd.Visible = false;

                //enable needed items
                enableButtons();

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
            pnlAdd.Visible = false;

            //enable needed items
            enableButtons();

            //disable text boxes
            txtArenaName.Enabled = false;
            txtArenaAddress.Enabled = false;
            txtArenaSuburb.Enabled = false;
            txtArenaCity.Enabled = false;
            txtArenaPhone.Enabled = false;

        }

        private void btnUpdateArena_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            pnlUpdate.Visible = true;

            //disable items not needed
            disableButtons();

            //enable text boxes
            txtArenaName.Enabled = true;
            txtArenaAddress.Enabled = true;
            txtArenaSuburb.Enabled = true;
            txtArenaCity.Enabled = true;
            txtArenaPhone.Enabled = true;
        }

        /// <summary>
        /// this section defines the EventActions for deleting an arena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (MessageBox.Show("Are you sure you want to delete the selected record?\nIt is currently: " + txtArenaName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteArenaRow.Delete();
                    DM.UpdateArena();
                }
            }
        }
    }
}