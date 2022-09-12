﻿using System;
using System.Data;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    public partial class CompetitorForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private Button[] controls;
        private int step;
        public CompetitorForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            controls = new Button[] { btnPrevious, btnNext, btnAddCompetitor, btnUpdateCompetitor, btnDeleteCompetitor, btnReturn };
            step = 0;
        }
        /// <summary>
        /// this method binds the competitor maintenance controls
        /// </summary>
        private void BindControls()
        {
            txtCompetitorID.DataBindings.Add("Text", DM.dsNZESL, "Competitor.CompetitorID");
            txtCompetitorUsername.DataBindings.Add("Text", DM.dsNZESL, "Competitor.UserName");
            txtCompetitorFName.DataBindings.Add("Text", DM.dsNZESL, "Competitor.FirstName");
            txtCompetitorLName.DataBindings.Add("Text", DM.dsNZESL, "Competitor.LastName");
            txtCompetitorGender.DataBindings.Add("Text", DM.dsNZESL, "Competitor.Gender");
            txtCompetitorDoB.DataBindings.Add("Text", DM.dsNZESL, "Competitor.DateOfBirth");
            txtCompetitorEmail.DataBindings.Add("Text", DM.dsNZESL, "Competitor.EmailAddress");
            lstCompetitors.DataSource = DM.dsNZESL;
            lstCompetitors.DisplayMember = "Competitor.UserName";
            lstCompetitors.ValueMember = "Competitor.CompetitorID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Competitor"];
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
        /// this region holds the code for adding a new competitor
        /// </summary>
        #region AddCompetitor
        private void btnAddCompetitor_Click(object sender, EventArgs e)
        {
            //show correct panel
            pnlAdd.Visible = true;
            //disable items not needed
            Utilities.ButtonsMagic(controls, false);
            //ensure boxes are emtpy
            txtCompetitorUsernameAdd.Text = "";
            txtCompetitorFNameAdd.Text = "";
            txtCompetitorLNameAdd.Text = "";
            txtCompetitorEmailAdd.Text = "";
            //configure datepicker
            DoBPickerAdd.MaxDate = DateTime.Now;
            DoBPickerAdd.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
        }
        private void btnCompetitorSave_Click(object sender, EventArgs e)
        {
            txtCompetitorID.Text = "";
            DataRow newCompetitorRow = DM.dtCompetitor.NewRow();

            //empty boxes validation
            if ( (txtCompetitorUsernameAdd.Text == "") || (txtCompetitorFNameAdd.Text == "") || (txtCompetitorLNameAdd.Text == "") || (txtCompetitorEmailAdd.Text == ""))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            //gender validation
            else if ( (radCompetitorFemaleAdd.Checked == false) && (radCompetitorMaleAdd.Checked == false) && (radCompetitorOtherAdd.Checked == false))
            {
                MessageBox.Show("You must select a gender!", "Error!");
            }
            //email validation
            else if (!Utilities.EmailCheck(txtCompetitorEmailAdd.Text))
            {
                MessageBox.Show("Invalid email address!", "Error!");
            }
            else
            {
                newCompetitorRow["UserName"] = txtCompetitorUsernameAdd.Text;
                newCompetitorRow["FirstName"] = txtCompetitorFNameAdd.Text;
                newCompetitorRow["LastName"] = txtCompetitorLNameAdd.Text;
                if (radCompetitorFemaleAdd.Checked == true)
                {
                    newCompetitorRow["Gender"] = "Female";
                }
                else if (radCompetitorMaleAdd.Checked == true)
                {
                    newCompetitorRow["Gender"] = "Male";
                }
                else if (radCompetitorOtherAdd.Checked == true)
                {
                    newCompetitorRow["Gender"] = "Other";
                }
                newCompetitorRow["DateOfBirth"] = DoBPickerAdd.Value;
                newCompetitorRow["EmailAddress"] = txtCompetitorEmailAdd.Text;
                try
                {
                    DM.dtCompetitor.Rows.Add(newCompetitorRow);
                    DM.UpdateCompetitor();
                    MessageBox.Show("Competitor Added Successfully", "Success");
                }
                catch (Exception ex)
                {
                    Utilities.DBExceptionError();
                }

                pnlAdd.Visible = false;
                //enable butttons
                Utilities.ButtonsMagic(controls, true);
            }
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //hide panel and enable controls
            pnlAdd.Visible = false;
            //enable buttons
            Utilities.ButtonsMagic(controls, true);
        }
        #endregion

        /// <summary>
        /// this region holds the code for updating a competitor
        /// </summary>
        #region UpdateCompetitors
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //hide panel and enable controls
            pnlUpdate.Visible = false;
            //enable buttons
            Utilities.ButtonsMagic(controls, true);
        }

        private void btnUpdateCompetitor_Click(object sender, EventArgs e)
        {
            //show correct panel
            pnlUpdate.Visible = true;
            //disable buttons
            Utilities.ButtonsMagic(controls, false);
            //ensure fields are filled out correctly for selected competitor
            txtCompetitorUsernameUpdate.Text = txtCompetitorUsername.Text;
            txtCompetitorFNameUpdate.Text = txtCompetitorFName.Text;
            txtCompetitorLNameUpdate.Text = txtCompetitorLName.Text;
            if(txtCompetitorGender.Text == "Female") { radCompetitorFemaleUpdate.Checked = true; }
            else if (txtCompetitorGender.Text == "Male") { radCompetitorMaleUpdate.Checked = true; }
            else if (txtCompetitorGender.Text == "Other") { radCompetitorOtherUpdate.Checked = true; }
            DoBPickerUpdate.Text = txtCompetitorDoB.Text;
            txtCompetitorEmailUpdate.Text = txtCompetitorEmail.Text;
            //configure datepicker
            DoBPickerAdd.MaxDate = DateTime.Now;
        }

        private void btnCompetitorUpdate_Click(object sender, EventArgs e)
        {
            DataRow UpdateCompetitorRow = DM.dtCompetitor.Rows[currencyManager.Position];

            //empty boxes validation
            if ((txtCompetitorUsernameUpdate.Text == "") || (txtCompetitorFNameUpdate.Text == "") || (txtCompetitorLNameUpdate.Text == "") || (txtCompetitorEmailUpdate.Text == ""))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            //gender validation
            else if ((radCompetitorFemaleUpdate.Checked == false) && (radCompetitorMaleUpdate.Checked == false) && (radCompetitorOtherUpdate.Checked == false))
            {
                MessageBox.Show("You must select a gender!", "Error!");
            }
            //email validation
            else if (!Utilities.EmailCheck(txtCompetitorEmailUpdate.Text))
            {
                MessageBox.Show("Invalid email address!", "Error!");
            }
            else
            {
                UpdateCompetitorRow["UserName"] = txtCompetitorUsernameUpdate.Text;
                UpdateCompetitorRow["FirstName"] = txtCompetitorFNameUpdate.Text;
                UpdateCompetitorRow["LastName"] = txtCompetitorLNameUpdate.Text;
                if (radCompetitorFemaleUpdate.Checked == true)
                {
                    UpdateCompetitorRow["Gender"] = "Female";
                }
                else if (radCompetitorMaleUpdate.Checked == true)
                {
                    UpdateCompetitorRow["Gender"] = "Male";
                }
                else if (radCompetitorOtherUpdate.Checked == true)
                {
                    UpdateCompetitorRow["Gender"] = "Other";
                }
                UpdateCompetitorRow["DateOfBirth"] = DoBPickerUpdate.Value;
                UpdateCompetitorRow["EmailAddress"] = txtCompetitorEmailUpdate.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateCompetitor();
                MessageBox.Show("Competitor Updated Successfully", "Success");

                pnlUpdate.Visible = false;
                //enable buttons
                Utilities.ButtonsMagic(controls, true);
            }
        }
        #endregion 

        /// <summary>
        /// this region holds the code for deleting a competitor
        /// </summary>
        #region DeleteCompetitor
        private void btnDeleteCompetitor_Click(object sender, EventArgs e)
        {
            DataRow deleteCompetitorRow = DM.dtCompetitor.Rows[currencyManager.Position];
            DataRow[] EntryRow = DM.dtEntry.Select("CompetitorID = " + txtCompetitorID.Text);
            if (EntryRow.Length != 0)
            {
                MessageBox.Show("You may only delete competitors that have no entries", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete the selected record?\n\nIt is currently: " + txtCompetitorFName.Text + " " + txtCompetitorLName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteCompetitorRow.Delete();
                    DM.UpdateCompetitor();
                    MessageBox.Show("Competitor deleted successfully", "Success");
                }
            }
        }
        #endregion
    }
}
