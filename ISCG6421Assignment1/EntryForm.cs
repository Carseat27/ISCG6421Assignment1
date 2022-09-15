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
    public partial class EntryForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmCompetitor;
        private CurrencyManager cmChallenge;
        private CurrencyManager cmEntry;
        private CurrencyManager cmCE;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;
        public EntryForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmCompetitor = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Competitor"];
            cmChallenge = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Challenge"];
            cmEntry = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Entry"];
            cmCE = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Challenge.Challenge_Entry"];
            cmDt = (CurrencyManager)this.BindingContext[dt];

            BindControls();
        }
        /// <summary>
        /// this method binds the add/remove competitor to challenge controls
        /// </summary>
        private void BindControls()
        {
            dgvCompetitor.DataSource = DM.dsNZESL;
            dgvCompetitor.DataMember = "Competitor";
            dgvCompetitor.AllowUserToAddRows = false;

            dgvChallenge.DataSource = DM.dsNZESL;
            dgvChallenge.DataMember = "Challenge";
            dgvChallenge.AllowUserToAddRows = false;

            dgvEntry.DataSource = DM.dsNZESL;
            dgvEntry.DataMember = "Challenge.Challenge_Entry";

            txtEventName.DataBindings.Add("Text", DM.dsNZESL, "Challenge.EventName");

            cmbEntryStatus.DataBindings.Add("Text", DM.dsNZESL, "Entry.Status");

            //auto resize columns
            //noticed that it sometimes caused an error, hence the try-catch
            try
            {
                dgvCompetitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvChallenge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the form. Please try again.");
            }
        }

        /// <summary>
        /// the region holds the code for the basic controls
        /// </summary>
        #region basicPageControls

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        /// <summary>
        /// this region holds the code for assigning a comeptitor to a challenge
        /// </summary>
        #region AssignCompetitorToChallenge
        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            if (DM.dtChallenge.Rows[cmChallenge.Position]["Status"].ToString() == "Scheduled")
            {
                DataRow newEntryRow = DM.dtEntry.NewRow();
                newEntryRow["ChallengeID"] = dgvChallenge["ChallengeID", cmChallenge.Position].Value;
                newEntryRow["CompetitorID"] = dgvCompetitor["CompetitorID", cmCompetitor.Position].Value;
                newEntryRow["Status"] = "Confirmed";
                
                try
                {
                    DM.UpdateEntry();
                    MessageBox.Show("Entry added successfully", "Success");
                }
                catch (Exception ex)
                {
                    Utilities.DBExceptionError();
                }
            }
            else
            {
                MessageBox.Show("Competitors can only be entered into scheduled challenges", "Error");
            }
        }
        #endregion

        /// <summary>
        /// this region holds the code for removing an entry
        /// </summary>
        #region RemoveCompetitorFromChallenge
        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            DataRow deleteEntryRow = DM.dtEntry.Rows[cmCE.Position];
            if (MessageBox.Show("Are you sure to delete the selected record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    deleteEntryRow.Delete();
                    DM.UpdateEntry();
                    MessageBox.Show("Entry deleted successfully", "Success");
                }
                catch(Exception ex)
                {
                    Utilities.DBExceptionError();
                }
            }
        }
        #endregion

        /// <summary>
        /// this region holds the code for updating the status of an entry
        /// </summary>
        #region UpdateEntryStatus
        private void cmbEntryStatus_SelectedValueChanged(object sender, EventArgs e) // <-- each time the combo box selection changes
        {
            DataRow UpdateEntryRow = DM.dtEntry.Rows[cmCE.Position];
            UpdateEntryRow["Status"] = cmbEntryStatus.Text; // <-- update the status
            cmCE.EndCurrentEdit();
            try
            {
                DM.UpdateEntry();
            }
            catch (Exception)
            {
                Utilities.DBExceptionError();
            }
        }
        //link the combo box value to the entry DGV
        private void dgvEntry_SelectionChanged(object sender, EventArgs e)
        {
            cmbEntryStatus.Text = dgvEntry.Rows[cmCE.Position].Cells["Status"].Value.ToString(); // <-- change the EntryStatus combo box to match that selected.
        }
        #endregion
    }
}
