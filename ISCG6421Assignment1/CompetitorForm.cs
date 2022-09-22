using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
/// <summary>
/// this class runs the competitor maintenance form.
/// From here, the user can view competitors, or choose to add, update, or delete them
/// Author: Carson Loveday
/// Date Finished: 22/09/2022
/// </summary>
namespace ISCG6421Assignment1
{
    public partial class CompetitorForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private Button[] controls;
        public CompetitorForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            controls = new Button[] { btnPrevious, btnNext, btnAddCompetitor, btnUpdateCompetitor, btnDeleteCompetitor, btnReturn };    // <-- add controls to button array for passing to Utilities.ButtonsMagic
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
        /// this region holds the code for adding a new competitor
        /// </summary>
        #region AddCompetitor

        /// <summary>
        /// when user clicks add competitor button
        /// </summary>
        private void btnAddCompetitor_Click(object sender, EventArgs e)
        {
            //show panel
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

        /// <summary>
        /// add a competitor
        /// </summary>
        private void btnCompetitorSave_Click(object sender, EventArgs e)
        {
            string Gender = "";

            txtCompetitorID.Text = "";  // <-- set competitorID to blank
            DataRow newCompetitorRow = DM.dtCompetitor.NewRow();

            //check all fields are filled
            if ( (txtCompetitorUsernameAdd.Text == "") || (txtCompetitorFNameAdd.Text == "") || (txtCompetitorLNameAdd.Text == ""))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            //check gender has been selected
            else if ( (radCompetitorFemaleAdd.Checked == false) && (radCompetitorMaleAdd.Checked == false) && (radCompetitorOtherAdd.Checked == false))
            {
                MessageBox.Show("You must select a gender!", "Error!");
            }
            else
            {
                //assign values to new datarow
                newCompetitorRow["UserName"] = txtCompetitorUsernameAdd.Text;
                newCompetitorRow["FirstName"] = txtCompetitorFNameAdd.Text;
                newCompetitorRow["LastName"] = txtCompetitorLNameAdd.Text;
                if (radCompetitorFemaleAdd.Checked == true)
                {
                    newCompetitorRow["Gender"] = "Female";
                    Gender = "Female";
                }
                else if (radCompetitorMaleAdd.Checked == true)
                {
                    newCompetitorRow["Gender"] = "Male";
                    Gender = "Male";
                }
                else if (radCompetitorOtherAdd.Checked == true)
                {
                    newCompetitorRow["Gender"] = "Other";
                    Gender = "Other";
                }
                newCompetitorRow["DateOfBirth"] = DoBPickerAdd.Value;
                newCompetitorRow["EmailAddress"] = txtCompetitorEmailAdd.Text;
                //add row
                try
                {
                    DM.dtCompetitor.Rows.Add(newCompetitorRow);
                    DM.UpdateCompetitor();

                    //send email confirmation of new competitor
                    if (txtCompetitorEmailAdd.Text != "")
                    {
                        try
                        {
                            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;       // <-- enable TSL1.2

                            MailAddress from = new MailAddress("noreply-nzesportsleague@gmail.com", "NZESports League");            // <-- sending from
                            MailAddress to = new MailAddress(txtCompetitorEmailAdd.Text, txtCompetitorFNameAdd.Text + " " + txtCompetitorLNameAdd.Text);    // <-- sending to

                            //make message
                            MailMessage message = new MailMessage(from, to);
                            message.Subject = "New Registration for NZESL";     // <-- email subject

                            message.Body = "Hello " + txtCompetitorFNameAdd.Text + " " + txtCompetitorLNameAdd.Text +
                                "\n\nThis is an automated email from an application designed for a University Assignment. Please do not be alarmed if you receive it. " +
                                "\nIf the recipient has any questions, please contact carsonloveday@gmail.com. Thank you." +
                                "\n\nThank you for you registration with the New Zealand E-Sports League!" +
                                "\n\nHere is a summary of the details you entered with us:" +
                                "\nUsername: " + txtCompetitorUsernameAdd.Text +
                                "\nFirst Name: " + txtCompetitorFNameAdd.Text +
                                "\nLast Name: " + txtCompetitorLNameAdd.Text +
                                "\nGender: " + Gender +
                                "\nDate of Birth: " + DoBPickerAdd.Value.ToString().Split(' ')[0] +
                                "\nEmail: " + txtCompetitorEmailAdd.Text +
                                "\n\n\nWe wish you the best of luck at future events!";     // <--email body

                            message.Priority = MailPriority.Normal;     // <-- email priority
                            message.IsBodyHtml = false;     // <-- not html body

                            SmtpClient MailClient = new SmtpClient("smtp.gmail.com");   // <-- google smtp

                            MailClient.Credentials = new System.Net.NetworkCredential   // <-- login credentials
                            {
                                UserName = "nzesportsleague@gmail.com",
                                Password = "rllrbpidzsygzmvz"       // <-- app only password lol
                            };

                            MailClient.EnableSsl = true;            // <-- SSL for security
                            MailClient.Port = 587;                  // <-- mail port

                            MailClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                            MailClient.Send(message);   // <-- send
                        }
                        catch (Exception)
                        {
                        }
                    }

                    MessageBox.Show("Competitor Added Successfully", "Success");
                }
                catch (Exception)
                {
                    Utilities.DBExceptionError();
                }
                //hide panel
                pnlAdd.Visible = false;
                //enable butttons
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
        /// this region holds the code for updating a competitor
        /// </summary>
        #region UpdateCompetitors

        /// <summary>
        /// when user clicks update arena button
        /// </summary>
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
            if(txtCompetitorGender.Text == "Female"){ radCompetitorFemaleUpdate.Checked = true; }
            else if (txtCompetitorGender.Text == "Male") { radCompetitorMaleUpdate.Checked = true; }
            else if (txtCompetitorGender.Text == "Other") { radCompetitorOtherUpdate.Checked = true; }
            DoBPickerUpdate.Text = txtCompetitorDoB.Text;
            txtCompetitorEmailUpdate.Text = txtCompetitorEmail.Text;

            //configure datepicker
            DoBPickerAdd.MaxDate = DateTime.Now;
        }

        /// <summary>
        /// update competitor
        /// </summary>
        private void btnCompetitorUpdate_Click(object sender, EventArgs e)
        {
            string Gender = "";
            DataRow UpdateCompetitorRow = DM.dtCompetitor.Rows[currencyManager.Position];

            //check fields are filled
            if ((txtCompetitorUsernameUpdate.Text == "") || (txtCompetitorFNameUpdate.Text == "") || (txtCompetitorLNameUpdate.Text == ""))
            {
                MessageBox.Show("You must fill out ALL fields!", "Error!");
            }
            //check gender is selected
            else if ((radCompetitorFemaleUpdate.Checked == false) && (radCompetitorMaleUpdate.Checked == false) && (radCompetitorOtherUpdate.Checked == false))
            {
                MessageBox.Show("You must select a gender!", "Error!");
            }
            else
            {
                //assign values to update row
                UpdateCompetitorRow["UserName"] = txtCompetitorUsernameUpdate.Text;
                UpdateCompetitorRow["FirstName"] = txtCompetitorFNameUpdate.Text;
                UpdateCompetitorRow["LastName"] = txtCompetitorLNameUpdate.Text;
                if (radCompetitorFemaleUpdate.Checked == true)
                {
                    UpdateCompetitorRow["Gender"] = "Female";
                    Gender = "Female";
                }
                else if (radCompetitorMaleUpdate.Checked == true)
                {
                    UpdateCompetitorRow["Gender"] = "Male";
                    Gender = "Male";
                }
                else if (radCompetitorOtherUpdate.Checked == true)
                {
                    UpdateCompetitorRow["Gender"] = "Other";
                    Gender = "Other";
                }
                UpdateCompetitorRow["DateOfBirth"] = DoBPickerUpdate.Value;
                UpdateCompetitorRow["EmailAddress"] = txtCompetitorEmailUpdate.Text;
                currencyManager.EndCurrentEdit();
                //update row
                try
                {

                    DM.UpdateCompetitor();

                    //send email confirmation of new competitor
                    if (txtCompetitorEmailAdd.Text != "")
                    {
                        try
                        {
                            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;       // <-- enable TSL1.2

                            MailAddress from = new MailAddress("noreply-nzesportsleague@gmail.com", "NZESports League");            // <-- sending from
                            MailAddress to = new MailAddress(txtCompetitorEmailUpdate.Text, txtCompetitorFNameUpdate.Text + " " + txtCompetitorLNameUpdate.Text);    // <-- sending to

                            //make message
                            MailMessage message = new MailMessage(from, to);
                            message.Subject = "Updated Registration for NZESL";     // <-- email subject

                            message.Body = "Hello " + txtCompetitorFNameUpdate.Text + " " + txtCompetitorLNameUpdate.Text +
                                "\n\nThis is an automated email from an application designed for a University Assignment. Please do not be alarmed if you receive it. " +
                                "\nIf the recipient has any questions, please contact carsonloveday@gmail.com. Thank you." +
                                "\n\nThank you for your updating your details with the New Zealand E-Sports League!" +
                                "\n\nHere is a summary of the details you have updated with us:" +
                                "\nUsername: " + txtCompetitorUsernameUpdate.Text +
                                "\nFirst Name: " + txtCompetitorFNameUpdate.Text +
                                "\nLast Name: " + txtCompetitorLNameUpdate.Text +
                                "\nGender: " + Gender +
                                "\nDate of Birth: " + DoBPickerUpdate.Value.ToString().Split(' ')[0] +
                                "\nEmail: " + txtCompetitorEmailUpdate.Text +
                                "\n\n\nWe wish you the best of luck at future events!";     // <--email body

                            message.Priority = MailPriority.Normal;     // <-- email priority
                            message.IsBodyHtml = false;     // <-- not html body

                            SmtpClient MailClient = new SmtpClient("smtp.gmail.com");   // <-- google smtp

                            MailClient.Credentials = new System.Net.NetworkCredential   // <-- login credentials
                            {
                                UserName = "nzesportsleague@gmail.com",
                                Password = "rllrbpidzsygzmvz"       // <-- app only password lol
                            };

                            MailClient.EnableSsl = true;            // <-- SSL for security
                            MailClient.Port = 587;                  // <-- mail port

                            MailClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                            MailClient.Send(message);   // <-- send
                        }
                        catch (Exception)
                        {
                        }
                    }

                    MessageBox.Show("Competitor Updated Successfully", "Success");
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
        /// user cancels update
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
        /// this region holds the code for deleting a competitor
        /// </summary>
        #region DeleteCompetitor

        /// <summary>
        /// when user clicks delete challenge
        /// </summary>
        private void btnDeleteCompetitor_Click(object sender, EventArgs e)
        {
            DataRow deleteCompetitorRow = DM.dtCompetitor.Rows[currencyManager.Position];
            DataRow[] EntryRow = DM.dtEntry.Select("CompetitorID = " + txtCompetitorID.Text);
            //ensure competitor has no entries
            if (EntryRow.Length != 0)
            {
                MessageBox.Show("You may only delete competitors that have no entries", "Error");
            }
            else
            {
                //check with user
                if (MessageBox.Show("Are you sure you want to delete the selected record?\n\nIt is currently: " + txtCompetitorFName.Text + " " + txtCompetitorLName.Text, "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //delete row
                    try
                    {
                        deleteCompetitorRow.Delete();
                        DM.UpdateCompetitor();
                        MessageBox.Show("Competitor deleted successfully", "Success");
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
        /// this region holds the code for determining if an email is valid
        /// </summary>
        #region emailStuff

        /// <summary>
        /// this method makes the save competitor button not work
        /// if the email is invalid during input
        /// </summary>
        private void txtCompetitorEmailAdd_TextChanged(object sender, EventArgs e)
        {
            Button[] btn = new Button[] { btnCompetitorSave };

            //check not empty
            if(txtCompetitorEmailAdd.Text != "")
            {
                //email not valid
                if (!Utilities.EmailCheck(txtCompetitorEmailAdd.Text))
                {
                    //button disabled
                    Utilities.ButtonsMagic(btn, false);
                    //error text
                    lblEmailInvalidAdd.Visible = true;
                }
                else
                {
                    Utilities.ButtonsMagic(btn, true);
                    lblEmailInvalidAdd.Visible = false;
                }
            }
            //because email is not required, allow adding without one
            else
            {
                Utilities.ButtonsMagic(btn, true);
                lblEmailInvalidAdd.Visible = false;
            }
        }

        /// <summary>
        /// this method makes the update competitor button not work
        /// if the email is invalid during input
        /// </summary>
        private void txtCompetitorEmailUpdate_TextChanged(object sender, EventArgs e)
        {
            Button[] btn = new Button[] { btnCompetitorUpdate };

            //check not empty
            if (txtCompetitorEmailUpdate.Text != "")
            {
                //email not valid
                if (!Utilities.EmailCheck(txtCompetitorEmailUpdate.Text))
                {
                    //button disabled
                    Utilities.ButtonsMagic(btn, false);
                    //error text
                    lblEmailInvalidUpdate.Visible = true;
                }
                else
                {
                    Utilities.ButtonsMagic(btn, true);
                    lblEmailInvalidUpdate.Visible = false;
                }
            }
            //because email is not required, allow updating without one
            else
            {
                Utilities.ButtonsMagic(btn, true);
                lblEmailInvalidUpdate.Visible = false;
            }
        }
        #endregion
    }
}