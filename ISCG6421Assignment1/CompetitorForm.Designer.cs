namespace ISCG6421Assignment1
{
    partial class CompetitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteCompetitor = new System.Windows.Forms.Button();
            this.btnUpdateCompetitor = new System.Windows.Forms.Button();
            this.btnAddCompetitor = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lstCompetitors = new System.Windows.Forms.ListBox();
            this.txtCompetitorID = new System.Windows.Forms.TextBox();
            this.lblCompetitorID = new System.Windows.Forms.Label();
            this.lblCompetitorUserName = new System.Windows.Forms.Label();
            this.lblCompetitorFName = new System.Windows.Forms.Label();
            this.lblCompetitorLName = new System.Windows.Forms.Label();
            this.lblCompetitorGender = new System.Windows.Forms.Label();
            this.lblCompetitorDoB = new System.Windows.Forms.Label();
            this.lblCompetitorEmail = new System.Windows.Forms.Label();
            this.txtCompetitorUsername = new System.Windows.Forms.TextBox();
            this.txtCompetitorFName = new System.Windows.Forms.TextBox();
            this.txtCompetitorLName = new System.Windows.Forms.TextBox();
            this.txtCompetitorGender = new System.Windows.Forms.TextBox();
            this.txtCompetitorDoB = new System.Windows.Forms.TextBox();
            this.txtCompetitorEmail = new System.Windows.Forms.TextBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.radCompetitorOtherAdd = new System.Windows.Forms.RadioButton();
            this.radCompetitorMaleAdd = new System.Windows.Forms.RadioButton();
            this.radCompetitorFemaleAdd = new System.Windows.Forms.RadioButton();
            this.DoBPickerAdd = new System.Windows.Forms.DateTimePicker();
            this.lblCompetitorEmailAdd = new System.Windows.Forms.Label();
            this.lblAddCompetitor = new System.Windows.Forms.Label();
            this.btnCompetitorSave = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.txtCompetitorEmailAdd = new System.Windows.Forms.TextBox();
            this.txtCompetitorLNameAdd = new System.Windows.Forms.TextBox();
            this.txtCompetitorFNameAdd = new System.Windows.Forms.TextBox();
            this.txtCompetitorUsernameAdd = new System.Windows.Forms.TextBox();
            this.lblCompetitorDoBAdd = new System.Windows.Forms.Label();
            this.lblCompetitorGenderAdd = new System.Windows.Forms.Label();
            this.lblCompetitorLNameAdd = new System.Windows.Forms.Label();
            this.lblCompetitorFNameAdd = new System.Windows.Forms.Label();
            this.lblCompetitorUserNameAdd = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.radCompetitorOtherUpdate = new System.Windows.Forms.RadioButton();
            this.radCompetitorMaleUpdate = new System.Windows.Forms.RadioButton();
            this.radCompetitorFemaleUpdate = new System.Windows.Forms.RadioButton();
            this.DoBPickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.lblCompetitorEmailUpdate = new System.Windows.Forms.Label();
            this.lblCompetitorUpdate = new System.Windows.Forms.Label();
            this.btnCompetitorUpdate = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.txtCompetitorEmailUpdate = new System.Windows.Forms.TextBox();
            this.txtCompetitorLNameUpdate = new System.Windows.Forms.TextBox();
            this.txtCompetitorFNameUpdate = new System.Windows.Forms.TextBox();
            this.txtCompetitorUsernameUpdate = new System.Windows.Forms.TextBox();
            this.lblCompetitorDoBUpdate = new System.Windows.Forms.Label();
            this.lblCompetitorGenderUpdate = new System.Windows.Forms.Label();
            this.lblCompetitorLNameUpdate = new System.Windows.Forms.Label();
            this.lblCompetitorFNameUpdate = new System.Windows.Forms.Label();
            this.lblCompetitorUsernameUpdate = new System.Windows.Forms.Label();
            this.toolTipCompetitor = new System.Windows.Forms.ToolTip(this.components);
            this.lblEmailRequired = new System.Windows.Forms.Label();
            this.lblEmailRequired2 = new System.Windows.Forms.Label();
            this.pnlAdd.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(605, 415);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 23);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.toolTipCompetitor.SetToolTip(this.btnReturn, "Return to the main menu");
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteCompetitor
            // 
            this.btnDeleteCompetitor.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCompetitor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompetitor.Location = new System.Drawing.Point(605, 374);
            this.btnDeleteCompetitor.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCompetitor.Name = "btnDeleteCompetitor";
            this.btnDeleteCompetitor.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteCompetitor.TabIndex = 23;
            this.btnDeleteCompetitor.Text = "Delete Competitor";
            this.toolTipCompetitor.SetToolTip(this.btnDeleteCompetitor, "Click me to delete the current Competitor");
            this.btnDeleteCompetitor.UseVisualStyleBackColor = false;
            this.btnDeleteCompetitor.Click += new System.EventHandler(this.btnDeleteCompetitor_Click);
            // 
            // btnUpdateCompetitor
            // 
            this.btnUpdateCompetitor.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCompetitor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCompetitor.Location = new System.Drawing.Point(448, 374);
            this.btnUpdateCompetitor.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCompetitor.Name = "btnUpdateCompetitor";
            this.btnUpdateCompetitor.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateCompetitor.TabIndex = 22;
            this.btnUpdateCompetitor.Text = "Update Competitor";
            this.toolTipCompetitor.SetToolTip(this.btnUpdateCompetitor, "Click me to update the current Competitor");
            this.btnUpdateCompetitor.UseVisualStyleBackColor = false;
            this.btnUpdateCompetitor.Click += new System.EventHandler(this.btnUpdateCompetitor_Click);
            // 
            // btnAddCompetitor
            // 
            this.btnAddCompetitor.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCompetitor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompetitor.Location = new System.Drawing.Point(301, 374);
            this.btnAddCompetitor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCompetitor.Name = "btnAddCompetitor";
            this.btnAddCompetitor.Size = new System.Drawing.Size(144, 23);
            this.btnAddCompetitor.TabIndex = 21;
            this.btnAddCompetitor.Text = "Add Competitor";
            this.toolTipCompetitor.SetToolTip(this.btnAddCompetitor, "Click me to add a Competitor");
            this.btnAddCompetitor.UseVisualStyleBackColor = false;
            this.btnAddCompetitor.Click += new System.EventHandler(this.btnAddCompetitor_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(188, 374);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">>>";
            this.toolTipCompetitor.SetToolTip(this.btnNext, "Next");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(60, 374);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 23);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<<<";
            this.toolTipCompetitor.SetToolTip(this.btnPrevious, "Previous");
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lstCompetitors
            // 
            this.lstCompetitors.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCompetitors.FormattingEnabled = true;
            this.lstCompetitors.ItemHeight = 17;
            this.lstCompetitors.Location = new System.Drawing.Point(60, 46);
            this.lstCompetitors.Margin = new System.Windows.Forms.Padding(4);
            this.lstCompetitors.Name = "lstCompetitors";
            this.lstCompetitors.Size = new System.Drawing.Size(230, 276);
            this.lstCompetitors.TabIndex = 28;
            // 
            // txtCompetitorID
            // 
            this.txtCompetitorID.AcceptsTab = true;
            this.txtCompetitorID.Enabled = false;
            this.txtCompetitorID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorID.Location = new System.Drawing.Point(450, 43);
            this.txtCompetitorID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorID.Name = "txtCompetitorID";
            this.txtCompetitorID.Size = new System.Drawing.Size(64, 23);
            this.txtCompetitorID.TabIndex = 30;
            this.txtCompetitorID.Text = "ID";
            // 
            // lblCompetitorID
            // 
            this.lblCompetitorID.AutoSize = true;
            this.lblCompetitorID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorID.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorID.Location = new System.Drawing.Point(308, 46);
            this.lblCompetitorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorID.Name = "lblCompetitorID";
            this.lblCompetitorID.Size = new System.Drawing.Size(105, 17);
            this.lblCompetitorID.TabIndex = 29;
            this.lblCompetitorID.Text = "Competitor ID:";
            this.lblCompetitorID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorUserName
            // 
            this.lblCompetitorUserName.AutoSize = true;
            this.lblCompetitorUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorUserName.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorUserName.Location = new System.Drawing.Point(344, 82);
            this.lblCompetitorUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorUserName.Name = "lblCompetitorUserName";
            this.lblCompetitorUserName.Size = new System.Drawing.Size(75, 17);
            this.lblCompetitorUserName.TabIndex = 31;
            this.lblCompetitorUserName.Text = "Username:";
            this.lblCompetitorUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorFName
            // 
            this.lblCompetitorFName.AutoSize = true;
            this.lblCompetitorFName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorFName.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorFName.Location = new System.Drawing.Point(341, 123);
            this.lblCompetitorFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorFName.Name = "lblCompetitorFName";
            this.lblCompetitorFName.Size = new System.Drawing.Size(79, 17);
            this.lblCompetitorFName.TabIndex = 32;
            this.lblCompetitorFName.Text = "First Name:";
            this.lblCompetitorFName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorLName
            // 
            this.lblCompetitorLName.AutoSize = true;
            this.lblCompetitorLName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorLName.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorLName.Location = new System.Drawing.Point(337, 161);
            this.lblCompetitorLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorLName.Name = "lblCompetitorLName";
            this.lblCompetitorLName.Size = new System.Drawing.Size(81, 17);
            this.lblCompetitorLName.TabIndex = 33;
            this.lblCompetitorLName.Text = "Last Name:";
            this.lblCompetitorLName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorGender
            // 
            this.lblCompetitorGender.AutoSize = true;
            this.lblCompetitorGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorGender.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorGender.Location = new System.Drawing.Point(363, 205);
            this.lblCompetitorGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorGender.Name = "lblCompetitorGender";
            this.lblCompetitorGender.Size = new System.Drawing.Size(60, 17);
            this.lblCompetitorGender.TabIndex = 34;
            this.lblCompetitorGender.Text = "Gender:";
            this.lblCompetitorGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorDoB
            // 
            this.lblCompetitorDoB.AutoSize = true;
            this.lblCompetitorDoB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorDoB.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorDoB.Location = new System.Drawing.Point(323, 247);
            this.lblCompetitorDoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorDoB.Name = "lblCompetitorDoB";
            this.lblCompetitorDoB.Size = new System.Drawing.Size(92, 17);
            this.lblCompetitorDoB.TabIndex = 35;
            this.lblCompetitorDoB.Text = "Date of Birth:";
            this.lblCompetitorDoB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorEmail
            // 
            this.lblCompetitorEmail.AutoSize = true;
            this.lblCompetitorEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorEmail.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorEmail.Location = new System.Drawing.Point(385, 293);
            this.lblCompetitorEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorEmail.Name = "lblCompetitorEmail";
            this.lblCompetitorEmail.Size = new System.Drawing.Size(47, 17);
            this.lblCompetitorEmail.TabIndex = 36;
            this.lblCompetitorEmail.Text = "Email:";
            this.lblCompetitorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompetitorUsername
            // 
            this.txtCompetitorUsername.AcceptsTab = true;
            this.txtCompetitorUsername.Enabled = false;
            this.txtCompetitorUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorUsername.Location = new System.Drawing.Point(450, 79);
            this.txtCompetitorUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorUsername.Name = "txtCompetitorUsername";
            this.txtCompetitorUsername.Size = new System.Drawing.Size(239, 23);
            this.txtCompetitorUsername.TabIndex = 37;
            this.txtCompetitorUsername.Text = "Username";
            // 
            // txtCompetitorFName
            // 
            this.txtCompetitorFName.AcceptsTab = true;
            this.txtCompetitorFName.Enabled = false;
            this.txtCompetitorFName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorFName.Location = new System.Drawing.Point(448, 120);
            this.txtCompetitorFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorFName.Name = "txtCompetitorFName";
            this.txtCompetitorFName.Size = new System.Drawing.Size(239, 23);
            this.txtCompetitorFName.TabIndex = 38;
            this.txtCompetitorFName.Text = "First Name";
            // 
            // txtCompetitorLName
            // 
            this.txtCompetitorLName.AcceptsTab = true;
            this.txtCompetitorLName.Enabled = false;
            this.txtCompetitorLName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorLName.Location = new System.Drawing.Point(448, 161);
            this.txtCompetitorLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorLName.Name = "txtCompetitorLName";
            this.txtCompetitorLName.Size = new System.Drawing.Size(239, 23);
            this.txtCompetitorLName.TabIndex = 39;
            this.txtCompetitorLName.Text = "Last Name";
            // 
            // txtCompetitorGender
            // 
            this.txtCompetitorGender.AcceptsTab = true;
            this.txtCompetitorGender.Enabled = false;
            this.txtCompetitorGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorGender.Location = new System.Drawing.Point(448, 205);
            this.txtCompetitorGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorGender.Name = "txtCompetitorGender";
            this.txtCompetitorGender.Size = new System.Drawing.Size(96, 23);
            this.txtCompetitorGender.TabIndex = 40;
            this.txtCompetitorGender.Text = "Gender";
            // 
            // txtCompetitorDoB
            // 
            this.txtCompetitorDoB.AcceptsTab = true;
            this.txtCompetitorDoB.Enabled = false;
            this.txtCompetitorDoB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorDoB.Location = new System.Drawing.Point(448, 244);
            this.txtCompetitorDoB.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorDoB.Name = "txtCompetitorDoB";
            this.txtCompetitorDoB.Size = new System.Drawing.Size(73, 23);
            this.txtCompetitorDoB.TabIndex = 41;
            this.txtCompetitorDoB.Text = "DoB";
            // 
            // txtCompetitorEmail
            // 
            this.txtCompetitorEmail.AcceptsTab = true;
            this.txtCompetitorEmail.Enabled = false;
            this.txtCompetitorEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorEmail.Location = new System.Drawing.Point(443, 290);
            this.txtCompetitorEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorEmail.Name = "txtCompetitorEmail";
            this.txtCompetitorEmail.Size = new System.Drawing.Size(246, 23);
            this.txtCompetitorEmail.TabIndex = 42;
            this.txtCompetitorEmail.Text = "Email";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.lblEmailRequired);
            this.pnlAdd.Controls.Add(this.radCompetitorOtherAdd);
            this.pnlAdd.Controls.Add(this.radCompetitorMaleAdd);
            this.pnlAdd.Controls.Add(this.radCompetitorFemaleAdd);
            this.pnlAdd.Controls.Add(this.DoBPickerAdd);
            this.pnlAdd.Controls.Add(this.lblCompetitorEmailAdd);
            this.pnlAdd.Controls.Add(this.lblAddCompetitor);
            this.pnlAdd.Controls.Add(this.btnCompetitorSave);
            this.pnlAdd.Controls.Add(this.btnAddCancel);
            this.pnlAdd.Controls.Add(this.txtCompetitorEmailAdd);
            this.pnlAdd.Controls.Add(this.txtCompetitorLNameAdd);
            this.pnlAdd.Controls.Add(this.txtCompetitorFNameAdd);
            this.pnlAdd.Controls.Add(this.txtCompetitorUsernameAdd);
            this.pnlAdd.Controls.Add(this.lblCompetitorDoBAdd);
            this.pnlAdd.Controls.Add(this.lblCompetitorGenderAdd);
            this.pnlAdd.Controls.Add(this.lblCompetitorLNameAdd);
            this.pnlAdd.Controls.Add(this.lblCompetitorFNameAdd);
            this.pnlAdd.Controls.Add(this.lblCompetitorUserNameAdd);
            this.pnlAdd.Location = new System.Drawing.Point(60, 27);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(684, 341);
            this.pnlAdd.TabIndex = 43;
            this.pnlAdd.Visible = false;
            // 
            // radCompetitorOtherAdd
            // 
            this.radCompetitorOtherAdd.AutoSize = true;
            this.radCompetitorOtherAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompetitorOtherAdd.ForeColor = System.Drawing.Color.White;
            this.radCompetitorOtherAdd.Location = new System.Drawing.Point(528, 182);
            this.radCompetitorOtherAdd.Margin = new System.Windows.Forms.Padding(4);
            this.radCompetitorOtherAdd.Name = "radCompetitorOtherAdd";
            this.radCompetitorOtherAdd.Size = new System.Drawing.Size(62, 21);
            this.radCompetitorOtherAdd.TabIndex = 38;
            this.radCompetitorOtherAdd.TabStop = true;
            this.radCompetitorOtherAdd.Text = "Other";
            this.radCompetitorOtherAdd.UseVisualStyleBackColor = true;
            // 
            // radCompetitorMaleAdd
            // 
            this.radCompetitorMaleAdd.AutoSize = true;
            this.radCompetitorMaleAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompetitorMaleAdd.ForeColor = System.Drawing.Color.White;
            this.radCompetitorMaleAdd.Location = new System.Drawing.Point(453, 182);
            this.radCompetitorMaleAdd.Margin = new System.Windows.Forms.Padding(4);
            this.radCompetitorMaleAdd.Name = "radCompetitorMaleAdd";
            this.radCompetitorMaleAdd.Size = new System.Drawing.Size(57, 21);
            this.radCompetitorMaleAdd.TabIndex = 37;
            this.radCompetitorMaleAdd.TabStop = true;
            this.radCompetitorMaleAdd.Text = "Male";
            this.radCompetitorMaleAdd.UseVisualStyleBackColor = true;
            // 
            // radCompetitorFemaleAdd
            // 
            this.radCompetitorFemaleAdd.AutoSize = true;
            this.radCompetitorFemaleAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompetitorFemaleAdd.ForeColor = System.Drawing.Color.White;
            this.radCompetitorFemaleAdd.Location = new System.Drawing.Point(354, 181);
            this.radCompetitorFemaleAdd.Margin = new System.Windows.Forms.Padding(4);
            this.radCompetitorFemaleAdd.Name = "radCompetitorFemaleAdd";
            this.radCompetitorFemaleAdd.Size = new System.Drawing.Size(73, 21);
            this.radCompetitorFemaleAdd.TabIndex = 36;
            this.radCompetitorFemaleAdd.TabStop = true;
            this.radCompetitorFemaleAdd.Text = "Female";
            this.radCompetitorFemaleAdd.UseVisualStyleBackColor = true;
            // 
            // DoBPickerAdd
            // 
            this.DoBPickerAdd.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBPickerAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBPickerAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoBPickerAdd.Location = new System.Drawing.Point(354, 214);
            this.DoBPickerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.DoBPickerAdd.MaxDate = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            this.DoBPickerAdd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DoBPickerAdd.Name = "DoBPickerAdd";
            this.DoBPickerAdd.Size = new System.Drawing.Size(125, 23);
            this.DoBPickerAdd.TabIndex = 35;
            this.DoBPickerAdd.Value = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            // 
            // lblCompetitorEmailAdd
            // 
            this.lblCompetitorEmailAdd.AutoSize = true;
            this.lblCompetitorEmailAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorEmailAdd.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorEmailAdd.Location = new System.Drawing.Point(275, 257);
            this.lblCompetitorEmailAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorEmailAdd.Name = "lblCompetitorEmailAdd";
            this.lblCompetitorEmailAdd.Size = new System.Drawing.Size(47, 17);
            this.lblCompetitorEmailAdd.TabIndex = 34;
            this.lblCompetitorEmailAdd.Text = "Email:";
            this.lblCompetitorEmailAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddCompetitor
            // 
            this.lblAddCompetitor.AutoSize = true;
            this.lblAddCompetitor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCompetitor.ForeColor = System.Drawing.Color.White;
            this.lblAddCompetitor.Location = new System.Drawing.Point(32, 54);
            this.lblAddCompetitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCompetitor.Name = "lblAddCompetitor";
            this.lblAddCompetitor.Size = new System.Drawing.Size(160, 22);
            this.lblAddCompetitor.TabIndex = 33;
            this.lblAddCompetitor.Text = "Add Competitor";
            this.lblAddCompetitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCompetitorSave
            // 
            this.btnCompetitorSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompetitorSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetitorSave.Location = new System.Drawing.Point(50, 104);
            this.btnCompetitorSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompetitorSave.Name = "btnCompetitorSave";
            this.btnCompetitorSave.Size = new System.Drawing.Size(139, 56);
            this.btnCompetitorSave.TabIndex = 32;
            this.btnCompetitorSave.Text = "Save Competitor";
            this.toolTipCompetitor.SetToolTip(this.btnCompetitorSave, "Fill out the fields to my right, then click me to add a Competitor");
            this.btnCompetitorSave.UseVisualStyleBackColor = false;
            this.btnCompetitorSave.Click += new System.EventHandler(this.btnCompetitorSave_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Location = new System.Drawing.Point(50, 209);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(139, 56);
            this.btnAddCancel.TabIndex = 31;
            this.btnAddCancel.Text = "Cancel";
            this.toolTipCompetitor.SetToolTip(this.btnAddCancel, "Click me to cancel adding a Competitor");
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // txtCompetitorEmailAdd
            // 
            this.txtCompetitorEmailAdd.AcceptsTab = true;
            this.txtCompetitorEmailAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorEmailAdd.Location = new System.Drawing.Point(354, 254);
            this.txtCompetitorEmailAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorEmailAdd.Name = "txtCompetitorEmailAdd";
            this.txtCompetitorEmailAdd.Size = new System.Drawing.Size(253, 23);
            this.txtCompetitorEmailAdd.TabIndex = 30;
            this.txtCompetitorEmailAdd.Text = "Email:";
            // 
            // txtCompetitorLNameAdd
            // 
            this.txtCompetitorLNameAdd.AcceptsTab = true;
            this.txtCompetitorLNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorLNameAdd.Location = new System.Drawing.Point(354, 139);
            this.txtCompetitorLNameAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorLNameAdd.Name = "txtCompetitorLNameAdd";
            this.txtCompetitorLNameAdd.Size = new System.Drawing.Size(253, 23);
            this.txtCompetitorLNameAdd.TabIndex = 28;
            this.txtCompetitorLNameAdd.Text = "Last Name";
            // 
            // txtCompetitorFNameAdd
            // 
            this.txtCompetitorFNameAdd.AcceptsTab = true;
            this.txtCompetitorFNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorFNameAdd.Location = new System.Drawing.Point(354, 95);
            this.txtCompetitorFNameAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorFNameAdd.Name = "txtCompetitorFNameAdd";
            this.txtCompetitorFNameAdd.Size = new System.Drawing.Size(253, 23);
            this.txtCompetitorFNameAdd.TabIndex = 27;
            this.txtCompetitorFNameAdd.Text = "First Name";
            // 
            // txtCompetitorUsernameAdd
            // 
            this.txtCompetitorUsernameAdd.AcceptsTab = true;
            this.txtCompetitorUsernameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorUsernameAdd.Location = new System.Drawing.Point(354, 54);
            this.txtCompetitorUsernameAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorUsernameAdd.Name = "txtCompetitorUsernameAdd";
            this.txtCompetitorUsernameAdd.Size = new System.Drawing.Size(253, 23);
            this.txtCompetitorUsernameAdd.TabIndex = 26;
            this.txtCompetitorUsernameAdd.Text = "Username";
            // 
            // lblCompetitorDoBAdd
            // 
            this.lblCompetitorDoBAdd.AutoSize = true;
            this.lblCompetitorDoBAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorDoBAdd.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorDoBAdd.Location = new System.Drawing.Point(231, 219);
            this.lblCompetitorDoBAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorDoBAdd.Name = "lblCompetitorDoBAdd";
            this.lblCompetitorDoBAdd.Size = new System.Drawing.Size(92, 17);
            this.lblCompetitorDoBAdd.TabIndex = 25;
            this.lblCompetitorDoBAdd.Text = "Date of Birth:";
            this.lblCompetitorDoBAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorGenderAdd
            // 
            this.lblCompetitorGenderAdd.AutoSize = true;
            this.lblCompetitorGenderAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorGenderAdd.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorGenderAdd.Location = new System.Drawing.Point(267, 180);
            this.lblCompetitorGenderAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorGenderAdd.Name = "lblCompetitorGenderAdd";
            this.lblCompetitorGenderAdd.Size = new System.Drawing.Size(60, 17);
            this.lblCompetitorGenderAdd.TabIndex = 24;
            this.lblCompetitorGenderAdd.Text = "Gender:";
            this.lblCompetitorGenderAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorLNameAdd
            // 
            this.lblCompetitorLNameAdd.AutoSize = true;
            this.lblCompetitorLNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorLNameAdd.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorLNameAdd.Location = new System.Drawing.Point(241, 139);
            this.lblCompetitorLNameAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorLNameAdd.Name = "lblCompetitorLNameAdd";
            this.lblCompetitorLNameAdd.Size = new System.Drawing.Size(81, 17);
            this.lblCompetitorLNameAdd.TabIndex = 23;
            this.lblCompetitorLNameAdd.Text = "Last Name:";
            this.lblCompetitorLNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorFNameAdd
            // 
            this.lblCompetitorFNameAdd.AutoSize = true;
            this.lblCompetitorFNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorFNameAdd.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorFNameAdd.Location = new System.Drawing.Point(245, 101);
            this.lblCompetitorFNameAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorFNameAdd.Name = "lblCompetitorFNameAdd";
            this.lblCompetitorFNameAdd.Size = new System.Drawing.Size(79, 17);
            this.lblCompetitorFNameAdd.TabIndex = 22;
            this.lblCompetitorFNameAdd.Text = "First Name:";
            this.lblCompetitorFNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorUserNameAdd
            // 
            this.lblCompetitorUserNameAdd.AutoSize = true;
            this.lblCompetitorUserNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorUserNameAdd.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorUserNameAdd.Location = new System.Drawing.Point(248, 60);
            this.lblCompetitorUserNameAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorUserNameAdd.Name = "lblCompetitorUserNameAdd";
            this.lblCompetitorUserNameAdd.Size = new System.Drawing.Size(75, 17);
            this.lblCompetitorUserNameAdd.TabIndex = 21;
            this.lblCompetitorUserNameAdd.Text = "Username:";
            this.lblCompetitorUserNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.lblEmailRequired2);
            this.pnlUpdate.Controls.Add(this.radCompetitorOtherUpdate);
            this.pnlUpdate.Controls.Add(this.radCompetitorMaleUpdate);
            this.pnlUpdate.Controls.Add(this.radCompetitorFemaleUpdate);
            this.pnlUpdate.Controls.Add(this.DoBPickerUpdate);
            this.pnlUpdate.Controls.Add(this.lblCompetitorEmailUpdate);
            this.pnlUpdate.Controls.Add(this.lblCompetitorUpdate);
            this.pnlUpdate.Controls.Add(this.btnCompetitorUpdate);
            this.pnlUpdate.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdate.Controls.Add(this.txtCompetitorEmailUpdate);
            this.pnlUpdate.Controls.Add(this.txtCompetitorLNameUpdate);
            this.pnlUpdate.Controls.Add(this.txtCompetitorFNameUpdate);
            this.pnlUpdate.Controls.Add(this.txtCompetitorUsernameUpdate);
            this.pnlUpdate.Controls.Add(this.lblCompetitorDoBUpdate);
            this.pnlUpdate.Controls.Add(this.lblCompetitorGenderUpdate);
            this.pnlUpdate.Controls.Add(this.lblCompetitorLNameUpdate);
            this.pnlUpdate.Controls.Add(this.lblCompetitorFNameUpdate);
            this.pnlUpdate.Controls.Add(this.lblCompetitorUsernameUpdate);
            this.pnlUpdate.Location = new System.Drawing.Point(60, 27);
            this.pnlUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(684, 341);
            this.pnlUpdate.TabIndex = 45;
            this.pnlUpdate.Visible = false;
            // 
            // radCompetitorOtherUpdate
            // 
            this.radCompetitorOtherUpdate.AutoSize = true;
            this.radCompetitorOtherUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompetitorOtherUpdate.ForeColor = System.Drawing.Color.White;
            this.radCompetitorOtherUpdate.Location = new System.Drawing.Point(550, 172);
            this.radCompetitorOtherUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.radCompetitorOtherUpdate.Name = "radCompetitorOtherUpdate";
            this.radCompetitorOtherUpdate.Size = new System.Drawing.Size(62, 21);
            this.radCompetitorOtherUpdate.TabIndex = 38;
            this.radCompetitorOtherUpdate.TabStop = true;
            this.radCompetitorOtherUpdate.Text = "Other";
            this.radCompetitorOtherUpdate.UseVisualStyleBackColor = true;
            // 
            // radCompetitorMaleUpdate
            // 
            this.radCompetitorMaleUpdate.AutoSize = true;
            this.radCompetitorMaleUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompetitorMaleUpdate.ForeColor = System.Drawing.Color.White;
            this.radCompetitorMaleUpdate.Location = new System.Drawing.Point(471, 172);
            this.radCompetitorMaleUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.radCompetitorMaleUpdate.Name = "radCompetitorMaleUpdate";
            this.radCompetitorMaleUpdate.Size = new System.Drawing.Size(57, 21);
            this.radCompetitorMaleUpdate.TabIndex = 37;
            this.radCompetitorMaleUpdate.TabStop = true;
            this.radCompetitorMaleUpdate.Text = "Male";
            this.radCompetitorMaleUpdate.UseVisualStyleBackColor = true;
            // 
            // radCompetitorFemaleUpdate
            // 
            this.radCompetitorFemaleUpdate.AutoSize = true;
            this.radCompetitorFemaleUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCompetitorFemaleUpdate.ForeColor = System.Drawing.Color.White;
            this.radCompetitorFemaleUpdate.Location = new System.Drawing.Point(372, 172);
            this.radCompetitorFemaleUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.radCompetitorFemaleUpdate.Name = "radCompetitorFemaleUpdate";
            this.radCompetitorFemaleUpdate.Size = new System.Drawing.Size(73, 21);
            this.radCompetitorFemaleUpdate.TabIndex = 36;
            this.radCompetitorFemaleUpdate.TabStop = true;
            this.radCompetitorFemaleUpdate.Text = "Female";
            this.radCompetitorFemaleUpdate.UseVisualStyleBackColor = true;
            // 
            // DoBPickerUpdate
            // 
            this.DoBPickerUpdate.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBPickerUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBPickerUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoBPickerUpdate.Location = new System.Drawing.Point(372, 204);
            this.DoBPickerUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.DoBPickerUpdate.MaxDate = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            this.DoBPickerUpdate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DoBPickerUpdate.Name = "DoBPickerUpdate";
            this.DoBPickerUpdate.Size = new System.Drawing.Size(125, 23);
            this.DoBPickerUpdate.TabIndex = 35;
            this.DoBPickerUpdate.Value = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            // 
            // lblCompetitorEmailUpdate
            // 
            this.lblCompetitorEmailUpdate.AutoSize = true;
            this.lblCompetitorEmailUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorEmailUpdate.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorEmailUpdate.Location = new System.Drawing.Point(303, 242);
            this.lblCompetitorEmailUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorEmailUpdate.Name = "lblCompetitorEmailUpdate";
            this.lblCompetitorEmailUpdate.Size = new System.Drawing.Size(47, 17);
            this.lblCompetitorEmailUpdate.TabIndex = 34;
            this.lblCompetitorEmailUpdate.Text = "Email:";
            this.lblCompetitorEmailUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorUpdate
            // 
            this.lblCompetitorUpdate.AutoSize = true;
            this.lblCompetitorUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorUpdate.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorUpdate.Location = new System.Drawing.Point(18, 59);
            this.lblCompetitorUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorUpdate.Name = "lblCompetitorUpdate";
            this.lblCompetitorUpdate.Size = new System.Drawing.Size(189, 22);
            this.lblCompetitorUpdate.TabIndex = 33;
            this.lblCompetitorUpdate.Text = "Update Competitor";
            this.lblCompetitorUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCompetitorUpdate
            // 
            this.btnCompetitorUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompetitorUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetitorUpdate.Location = new System.Drawing.Point(50, 104);
            this.btnCompetitorUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompetitorUpdate.Name = "btnCompetitorUpdate";
            this.btnCompetitorUpdate.Size = new System.Drawing.Size(139, 56);
            this.btnCompetitorUpdate.TabIndex = 32;
            this.btnCompetitorUpdate.Text = "Save Changes";
            this.toolTipCompetitor.SetToolTip(this.btnCompetitorUpdate, "Change any details to my right, then click me to save the changes");
            this.btnCompetitorUpdate.UseVisualStyleBackColor = false;
            this.btnCompetitorUpdate.Click += new System.EventHandler(this.btnCompetitorUpdate_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCancel.Location = new System.Drawing.Point(50, 209);
            this.btnUpdateCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(139, 56);
            this.btnUpdateCancel.TabIndex = 31;
            this.btnUpdateCancel.Text = "Cancel";
            this.toolTipCompetitor.SetToolTip(this.btnUpdateCancel, "Click me to cancel updating the Competitor");
            this.btnUpdateCancel.UseVisualStyleBackColor = false;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtCompetitorEmailUpdate
            // 
            this.txtCompetitorEmailUpdate.AcceptsTab = true;
            this.txtCompetitorEmailUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorEmailUpdate.Location = new System.Drawing.Point(373, 242);
            this.txtCompetitorEmailUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorEmailUpdate.Name = "txtCompetitorEmailUpdate";
            this.txtCompetitorEmailUpdate.Size = new System.Drawing.Size(252, 23);
            this.txtCompetitorEmailUpdate.TabIndex = 30;
            this.txtCompetitorEmailUpdate.Text = "Email:";
            // 
            // txtCompetitorLNameUpdate
            // 
            this.txtCompetitorLNameUpdate.AcceptsTab = true;
            this.txtCompetitorLNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorLNameUpdate.Location = new System.Drawing.Point(372, 137);
            this.txtCompetitorLNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorLNameUpdate.Name = "txtCompetitorLNameUpdate";
            this.txtCompetitorLNameUpdate.Size = new System.Drawing.Size(253, 23);
            this.txtCompetitorLNameUpdate.TabIndex = 28;
            this.txtCompetitorLNameUpdate.Text = "Last Name";
            // 
            // txtCompetitorFNameUpdate
            // 
            this.txtCompetitorFNameUpdate.AcceptsTab = true;
            this.txtCompetitorFNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorFNameUpdate.Location = new System.Drawing.Point(372, 99);
            this.txtCompetitorFNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorFNameUpdate.Name = "txtCompetitorFNameUpdate";
            this.txtCompetitorFNameUpdate.Size = new System.Drawing.Size(253, 23);
            this.txtCompetitorFNameUpdate.TabIndex = 27;
            this.txtCompetitorFNameUpdate.Text = "First Name";
            // 
            // txtCompetitorUsernameUpdate
            // 
            this.txtCompetitorUsernameUpdate.AcceptsTab = true;
            this.txtCompetitorUsernameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorUsernameUpdate.Location = new System.Drawing.Point(373, 62);
            this.txtCompetitorUsernameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompetitorUsernameUpdate.Name = "txtCompetitorUsernameUpdate";
            this.txtCompetitorUsernameUpdate.Size = new System.Drawing.Size(253, 23);
            this.txtCompetitorUsernameUpdate.TabIndex = 26;
            this.txtCompetitorUsernameUpdate.Text = "Username";
            // 
            // lblCompetitorDoBUpdate
            // 
            this.lblCompetitorDoBUpdate.AutoSize = true;
            this.lblCompetitorDoBUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorDoBUpdate.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorDoBUpdate.Location = new System.Drawing.Point(245, 209);
            this.lblCompetitorDoBUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorDoBUpdate.Name = "lblCompetitorDoBUpdate";
            this.lblCompetitorDoBUpdate.Size = new System.Drawing.Size(92, 17);
            this.lblCompetitorDoBUpdate.TabIndex = 25;
            this.lblCompetitorDoBUpdate.Text = "Date of Birth:";
            this.lblCompetitorDoBUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorGenderUpdate
            // 
            this.lblCompetitorGenderUpdate.AutoSize = true;
            this.lblCompetitorGenderUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorGenderUpdate.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorGenderUpdate.Location = new System.Drawing.Point(285, 174);
            this.lblCompetitorGenderUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorGenderUpdate.Name = "lblCompetitorGenderUpdate";
            this.lblCompetitorGenderUpdate.Size = new System.Drawing.Size(60, 17);
            this.lblCompetitorGenderUpdate.TabIndex = 24;
            this.lblCompetitorGenderUpdate.Text = "Gender:";
            this.lblCompetitorGenderUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorLNameUpdate
            // 
            this.lblCompetitorLNameUpdate.AutoSize = true;
            this.lblCompetitorLNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorLNameUpdate.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorLNameUpdate.Location = new System.Drawing.Point(259, 137);
            this.lblCompetitorLNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorLNameUpdate.Name = "lblCompetitorLNameUpdate";
            this.lblCompetitorLNameUpdate.Size = new System.Drawing.Size(81, 17);
            this.lblCompetitorLNameUpdate.TabIndex = 23;
            this.lblCompetitorLNameUpdate.Text = "Last Name:";
            this.lblCompetitorLNameUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorFNameUpdate
            // 
            this.lblCompetitorFNameUpdate.AutoSize = true;
            this.lblCompetitorFNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorFNameUpdate.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorFNameUpdate.Location = new System.Drawing.Point(263, 102);
            this.lblCompetitorFNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorFNameUpdate.Name = "lblCompetitorFNameUpdate";
            this.lblCompetitorFNameUpdate.Size = new System.Drawing.Size(79, 17);
            this.lblCompetitorFNameUpdate.TabIndex = 22;
            this.lblCompetitorFNameUpdate.Text = "First Name:";
            this.lblCompetitorFNameUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompetitorUsernameUpdate
            // 
            this.lblCompetitorUsernameUpdate.AutoSize = true;
            this.lblCompetitorUsernameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorUsernameUpdate.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorUsernameUpdate.Location = new System.Drawing.Point(267, 65);
            this.lblCompetitorUsernameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitorUsernameUpdate.Name = "lblCompetitorUsernameUpdate";
            this.lblCompetitorUsernameUpdate.Size = new System.Drawing.Size(75, 17);
            this.lblCompetitorUsernameUpdate.TabIndex = 21;
            this.lblCompetitorUsernameUpdate.Text = "Username:";
            this.lblCompetitorUsernameUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailRequired
            // 
            this.lblEmailRequired.AutoSize = true;
            this.lblEmailRequired.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRequired.ForeColor = System.Drawing.Color.White;
            this.lblEmailRequired.Location = new System.Drawing.Point(351, 279);
            this.lblEmailRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailRequired.Name = "lblEmailRequired";
            this.lblEmailRequired.Size = new System.Drawing.Size(229, 16);
            this.lblEmailRequired.TabIndex = 39;
            this.lblEmailRequired.Text = "*email is not required, but recommended";
            this.lblEmailRequired.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailRequired2
            // 
            this.lblEmailRequired2.AutoSize = true;
            this.lblEmailRequired2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRequired2.ForeColor = System.Drawing.Color.White;
            this.lblEmailRequired2.Location = new System.Drawing.Point(370, 267);
            this.lblEmailRequired2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailRequired2.Name = "lblEmailRequired2";
            this.lblEmailRequired2.Size = new System.Drawing.Size(229, 16);
            this.lblEmailRequired2.TabIndex = 40;
            this.lblEmailRequired2.Text = "*email is not required, but recommended";
            this.lblEmailRequired2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompetitorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.ControlBox = false;
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.txtCompetitorEmail);
            this.Controls.Add(this.txtCompetitorDoB);
            this.Controls.Add(this.txtCompetitorGender);
            this.Controls.Add(this.txtCompetitorLName);
            this.Controls.Add(this.txtCompetitorFName);
            this.Controls.Add(this.txtCompetitorUsername);
            this.Controls.Add(this.lblCompetitorEmail);
            this.Controls.Add(this.lblCompetitorDoB);
            this.Controls.Add(this.lblCompetitorGender);
            this.Controls.Add(this.lblCompetitorLName);
            this.Controls.Add(this.lblCompetitorFName);
            this.Controls.Add(this.lblCompetitorUserName);
            this.Controls.Add(this.txtCompetitorID);
            this.Controls.Add(this.lblCompetitorID);
            this.Controls.Add(this.lstCompetitors);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCompetitor);
            this.Controls.Add(this.btnUpdateCompetitor);
            this.Controls.Add(this.btnAddCompetitor);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(813, 481);
            this.MinimumSize = new System.Drawing.Size(813, 481);
            this.Name = "CompetitorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Competitor Maintenance";
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteCompetitor;
        private System.Windows.Forms.Button btnUpdateCompetitor;
        private System.Windows.Forms.Button btnAddCompetitor;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ListBox lstCompetitors;
        private System.Windows.Forms.TextBox txtCompetitorID;
        private System.Windows.Forms.Label lblCompetitorID;
        private System.Windows.Forms.Label lblCompetitorUserName;
        private System.Windows.Forms.Label lblCompetitorFName;
        private System.Windows.Forms.Label lblCompetitorLName;
        private System.Windows.Forms.Label lblCompetitorGender;
        private System.Windows.Forms.Label lblCompetitorDoB;
        private System.Windows.Forms.Label lblCompetitorEmail;
        private System.Windows.Forms.TextBox txtCompetitorUsername;
        private System.Windows.Forms.TextBox txtCompetitorFName;
        private System.Windows.Forms.TextBox txtCompetitorLName;
        private System.Windows.Forms.TextBox txtCompetitorGender;
        private System.Windows.Forms.TextBox txtCompetitorDoB;
        private System.Windows.Forms.TextBox txtCompetitorEmail;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblAddCompetitor;
        private System.Windows.Forms.Button btnCompetitorSave;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TextBox txtCompetitorEmailAdd;
        private System.Windows.Forms.TextBox txtCompetitorLNameAdd;
        private System.Windows.Forms.TextBox txtCompetitorFNameAdd;
        private System.Windows.Forms.TextBox txtCompetitorUsernameAdd;
        private System.Windows.Forms.Label lblCompetitorDoBAdd;
        private System.Windows.Forms.Label lblCompetitorGenderAdd;
        private System.Windows.Forms.Label lblCompetitorLNameAdd;
        private System.Windows.Forms.Label lblCompetitorFNameAdd;
        private System.Windows.Forms.Label lblCompetitorUserNameAdd;
        private System.Windows.Forms.Label lblCompetitorEmailAdd;
        private System.Windows.Forms.RadioButton radCompetitorOtherAdd;
        private System.Windows.Forms.RadioButton radCompetitorMaleAdd;
        private System.Windows.Forms.RadioButton radCompetitorFemaleAdd;
        private System.Windows.Forms.DateTimePicker DoBPickerAdd;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.RadioButton radCompetitorOtherUpdate;
        private System.Windows.Forms.RadioButton radCompetitorMaleUpdate;
        private System.Windows.Forms.RadioButton radCompetitorFemaleUpdate;
        private System.Windows.Forms.DateTimePicker DoBPickerUpdate;
        private System.Windows.Forms.Label lblCompetitorEmailUpdate;
        private System.Windows.Forms.Label lblCompetitorUpdate;
        private System.Windows.Forms.Button btnCompetitorUpdate;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.TextBox txtCompetitorEmailUpdate;
        private System.Windows.Forms.TextBox txtCompetitorLNameUpdate;
        private System.Windows.Forms.TextBox txtCompetitorFNameUpdate;
        private System.Windows.Forms.TextBox txtCompetitorUsernameUpdate;
        private System.Windows.Forms.Label lblCompetitorDoBUpdate;
        private System.Windows.Forms.Label lblCompetitorGenderUpdate;
        private System.Windows.Forms.Label lblCompetitorLNameUpdate;
        private System.Windows.Forms.Label lblCompetitorFNameUpdate;
        private System.Windows.Forms.Label lblCompetitorUsernameUpdate;
        private System.Windows.Forms.ToolTip toolTipCompetitor;
        private System.Windows.Forms.Label lblEmailRequired;
        private System.Windows.Forms.Label lblEmailRequired2;
    }
}