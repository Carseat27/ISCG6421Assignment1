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


        private void btnArenaSave_Click(object sender, EventArgs e)
        {
            txtArenaID.Text = "";
            DataRow newArenaRow = DM.dtArena.NewRow();

            if ((txtArenaName.Text == "") || (txtArenaAddress.Text == "") || (txtArenaSuburb.Text == "") || (txtArenaCity.Text == "") || (txtArenaPhone.Text == ""))
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //hide panel for adding arena
            pnlAdd.Visible = false;


            //enable needed items
            btnUpdateArena.Enabled = true;
            btnDeleteArena.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
        }

        private void btnArenaSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddArena_Click(object sender, EventArgs e)
        {
            //show panel for adding arena
            pnlAdd.Visible = true;

            //disable items not needed
            btnUpdateArena.Enabled = false;
            btnDeleteArena.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            //ensure text boxes are empty
            txtArenaNameAdd.Text = "";
            txtArenaAddressAdd.Text = "";
            txtArenaSuburbAdd.Text = "";
            txtArenaCityAdd.Text = "";
            txtArenaPhoneAdd.Text = "";
        }
    }
}
