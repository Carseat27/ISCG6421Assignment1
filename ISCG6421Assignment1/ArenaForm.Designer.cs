namespace ISCG6421Assignment1
{
    partial class ArenaForm
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
            this.lstArenas = new System.Windows.Forms.ListBox();
            this.lblArenaNo = new System.Windows.Forms.Label();
            this.lblArenaName = new System.Windows.Forms.Label();
            this.lblArenaAddress = new System.Windows.Forms.Label();
            this.lblArenaSuburb = new System.Windows.Forms.Label();
            this.lblArenaCity = new System.Windows.Forms.Label();
            this.lblArenaPhoneNumber = new System.Windows.Forms.Label();
            this.txtArenaID = new System.Windows.Forms.TextBox();
            this.txtArenaName = new System.Windows.Forms.TextBox();
            this.txtArenaAddress = new System.Windows.Forms.TextBox();
            this.txtArenaSuburb = new System.Windows.Forms.TextBox();
            this.txtArenaCity = new System.Windows.Forms.TextBox();
            this.txtArenaPhone = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddArena = new System.Windows.Forms.Button();
            this.btnUpdateArena = new System.Windows.Forms.Button();
            this.btnDeleteArena = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblAddArena = new System.Windows.Forms.Label();
            this.btnArenaSave = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.txtArenaPhoneAdd = new System.Windows.Forms.TextBox();
            this.txtArenaCityAdd = new System.Windows.Forms.TextBox();
            this.txtArenaSuburbAdd = new System.Windows.Forms.TextBox();
            this.txtArenaAddressAdd = new System.Windows.Forms.TextBox();
            this.txtArenaNameAdd = new System.Windows.Forms.TextBox();
            this.lblArenaPhoneAdd = new System.Windows.Forms.Label();
            this.lblArenaCityAdd = new System.Windows.Forms.Label();
            this.lblArenaSuburbAdd = new System.Windows.Forms.Label();
            this.lblArenaAddressAdd = new System.Windows.Forms.Label();
            this.lblArenaNameAdd = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.lblArenaUpdate = new System.Windows.Forms.Label();
            this.btnArenaUpdate = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.pnlAdd.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstArenas
            // 
            this.lstArenas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstArenas.FormattingEnabled = true;
            this.lstArenas.ItemHeight = 17;
            this.lstArenas.Location = new System.Drawing.Point(60, 39);
            this.lstArenas.Name = "lstArenas";
            this.lstArenas.Size = new System.Drawing.Size(230, 293);
            this.lstArenas.TabIndex = 0;
            // 
            // lblArenaNo
            // 
            this.lblArenaNo.AutoSize = true;
            this.lblArenaNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaNo.ForeColor = System.Drawing.Color.White;
            this.lblArenaNo.Location = new System.Drawing.Point(343, 39);
            this.lblArenaNo.Name = "lblArenaNo";
            this.lblArenaNo.Size = new System.Drawing.Size(67, 17);
            this.lblArenaNo.TabIndex = 1;
            this.lblArenaNo.Text = "Arena ID:";
            this.lblArenaNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaName
            // 
            this.lblArenaName.AutoSize = true;
            this.lblArenaName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaName.ForeColor = System.Drawing.Color.White;
            this.lblArenaName.Location = new System.Drawing.Point(316, 92);
            this.lblArenaName.Name = "lblArenaName";
            this.lblArenaName.Size = new System.Drawing.Size(94, 17);
            this.lblArenaName.TabIndex = 2;
            this.lblArenaName.Text = "Arena Name:";
            this.lblArenaName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaAddress
            // 
            this.lblArenaAddress.AutoSize = true;
            this.lblArenaAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaAddress.ForeColor = System.Drawing.Color.White;
            this.lblArenaAddress.Location = new System.Drawing.Point(309, 149);
            this.lblArenaAddress.Name = "lblArenaAddress";
            this.lblArenaAddress.Size = new System.Drawing.Size(101, 17);
            this.lblArenaAddress.TabIndex = 3;
            this.lblArenaAddress.Text = "Street Address:";
            this.lblArenaAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaSuburb
            // 
            this.lblArenaSuburb.AutoSize = true;
            this.lblArenaSuburb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaSuburb.ForeColor = System.Drawing.Color.White;
            this.lblArenaSuburb.Location = new System.Drawing.Point(354, 208);
            this.lblArenaSuburb.Name = "lblArenaSuburb";
            this.lblArenaSuburb.Size = new System.Drawing.Size(56, 17);
            this.lblArenaSuburb.TabIndex = 4;
            this.lblArenaSuburb.Text = "Suburb:";
            this.lblArenaSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaCity
            // 
            this.lblArenaCity.AutoSize = true;
            this.lblArenaCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaCity.ForeColor = System.Drawing.Color.White;
            this.lblArenaCity.Location = new System.Drawing.Point(373, 272);
            this.lblArenaCity.Name = "lblArenaCity";
            this.lblArenaCity.Size = new System.Drawing.Size(37, 17);
            this.lblArenaCity.TabIndex = 5;
            this.lblArenaCity.Text = "City:";
            this.lblArenaCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaPhoneNumber
            // 
            this.lblArenaPhoneNumber.AutoSize = true;
            this.lblArenaPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblArenaPhoneNumber.Location = new System.Drawing.Point(301, 332);
            this.lblArenaPhoneNumber.Name = "lblArenaPhoneNumber";
            this.lblArenaPhoneNumber.Size = new System.Drawing.Size(109, 17);
            this.lblArenaPhoneNumber.TabIndex = 6;
            this.lblArenaPhoneNumber.Text = "Phone Number:";
            this.lblArenaPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArenaID
            // 
            this.txtArenaID.Enabled = false;
            this.txtArenaID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaID.Location = new System.Drawing.Point(416, 36);
            this.txtArenaID.Name = "txtArenaID";
            this.txtArenaID.ReadOnly = true;
            this.txtArenaID.Size = new System.Drawing.Size(45, 23);
            this.txtArenaID.TabIndex = 7;
            this.txtArenaID.Text = "arena";
            // 
            // txtArenaName
            // 
            this.txtArenaName.AcceptsTab = true;
            this.txtArenaName.Enabled = false;
            this.txtArenaName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaName.Location = new System.Drawing.Point(416, 92);
            this.txtArenaName.Name = "txtArenaName";
            this.txtArenaName.Size = new System.Drawing.Size(191, 23);
            this.txtArenaName.TabIndex = 8;
            this.txtArenaName.Text = "Name";
            // 
            // txtArenaAddress
            // 
            this.txtArenaAddress.AcceptsTab = true;
            this.txtArenaAddress.Enabled = false;
            this.txtArenaAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaAddress.Location = new System.Drawing.Point(416, 146);
            this.txtArenaAddress.Name = "txtArenaAddress";
            this.txtArenaAddress.Size = new System.Drawing.Size(319, 23);
            this.txtArenaAddress.TabIndex = 9;
            this.txtArenaAddress.Text = "Address";
            // 
            // txtArenaSuburb
            // 
            this.txtArenaSuburb.AcceptsTab = true;
            this.txtArenaSuburb.Enabled = false;
            this.txtArenaSuburb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaSuburb.Location = new System.Drawing.Point(416, 205);
            this.txtArenaSuburb.Name = "txtArenaSuburb";
            this.txtArenaSuburb.Size = new System.Drawing.Size(141, 23);
            this.txtArenaSuburb.TabIndex = 10;
            this.txtArenaSuburb.Text = "Suburb";
            // 
            // txtArenaCity
            // 
            this.txtArenaCity.AcceptsTab = true;
            this.txtArenaCity.Enabled = false;
            this.txtArenaCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaCity.Location = new System.Drawing.Point(416, 269);
            this.txtArenaCity.Name = "txtArenaCity";
            this.txtArenaCity.Size = new System.Drawing.Size(141, 23);
            this.txtArenaCity.TabIndex = 11;
            this.txtArenaCity.Text = "City";
            // 
            // txtArenaPhone
            // 
            this.txtArenaPhone.AcceptsTab = true;
            this.txtArenaPhone.Enabled = false;
            this.txtArenaPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaPhone.Location = new System.Drawing.Point(416, 326);
            this.txtArenaPhone.Name = "txtArenaPhone";
            this.txtArenaPhone.Size = new System.Drawing.Size(117, 23);
            this.txtArenaPhone.TabIndex = 12;
            this.txtArenaPhone.Text = "Phone No.";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(60, 374);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 23);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "<<<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(188, 374);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">>>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddArena
            // 
            this.btnAddArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArena.Location = new System.Drawing.Point(346, 374);
            this.btnAddArena.Name = "btnAddArena";
            this.btnAddArena.Size = new System.Drawing.Size(102, 23);
            this.btnAddArena.TabIndex = 15;
            this.btnAddArena.Text = "Add Arena";
            this.btnAddArena.UseVisualStyleBackColor = false;
            this.btnAddArena.Click += new System.EventHandler(this.btnAddArena_Click);
            // 
            // btnUpdateArena
            // 
            this.btnUpdateArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateArena.Location = new System.Drawing.Point(487, 374);
            this.btnUpdateArena.Name = "btnUpdateArena";
            this.btnUpdateArena.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateArena.TabIndex = 16;
            this.btnUpdateArena.Text = "Update Arena";
            this.btnUpdateArena.UseVisualStyleBackColor = false;
            this.btnUpdateArena.Click += new System.EventHandler(this.btnUpdateArena_Click);
            // 
            // btnDeleteArena
            // 
            this.btnDeleteArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArena.Location = new System.Drawing.Point(633, 374);
            this.btnDeleteArena.Name = "btnDeleteArena";
            this.btnDeleteArena.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteArena.TabIndex = 17;
            this.btnDeleteArena.Text = "Delete Arena";
            this.btnDeleteArena.UseVisualStyleBackColor = false;
            this.btnDeleteArena.Click += new System.EventHandler(this.btnDeleteArena_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(633, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 23);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.lblAddArena);
            this.pnlAdd.Controls.Add(this.btnArenaSave);
            this.pnlAdd.Controls.Add(this.btnAddCancel);
            this.pnlAdd.Controls.Add(this.txtArenaPhoneAdd);
            this.pnlAdd.Controls.Add(this.txtArenaCityAdd);
            this.pnlAdd.Controls.Add(this.txtArenaSuburbAdd);
            this.pnlAdd.Controls.Add(this.txtArenaAddressAdd);
            this.pnlAdd.Controls.Add(this.txtArenaNameAdd);
            this.pnlAdd.Controls.Add(this.lblArenaPhoneAdd);
            this.pnlAdd.Controls.Add(this.lblArenaCityAdd);
            this.pnlAdd.Controls.Add(this.lblArenaSuburbAdd);
            this.pnlAdd.Controls.Add(this.lblArenaAddressAdd);
            this.pnlAdd.Controls.Add(this.lblArenaNameAdd);
            this.pnlAdd.Location = new System.Drawing.Point(51, 27);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(684, 341);
            this.pnlAdd.TabIndex = 21;
            this.pnlAdd.Visible = false;
            // 
            // lblAddArena
            // 
            this.lblAddArena.AutoSize = true;
            this.lblAddArena.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddArena.ForeColor = System.Drawing.Color.White;
            this.lblAddArena.Location = new System.Drawing.Point(53, 59);
            this.lblAddArena.Name = "lblAddArena";
            this.lblAddArena.Size = new System.Drawing.Size(114, 22);
            this.lblAddArena.TabIndex = 33;
            this.lblAddArena.Text = "Add Arena";
            this.lblAddArena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnArenaSave
            // 
            this.btnArenaSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnArenaSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArenaSave.Location = new System.Drawing.Point(50, 104);
            this.btnArenaSave.Name = "btnArenaSave";
            this.btnArenaSave.Size = new System.Drawing.Size(139, 56);
            this.btnArenaSave.TabIndex = 32;
            this.btnArenaSave.Text = "Save Arena";
            this.btnArenaSave.UseVisualStyleBackColor = false;
            this.btnArenaSave.Click += new System.EventHandler(this.btnArenaSave_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Location = new System.Drawing.Point(50, 209);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(139, 56);
            this.btnAddCancel.TabIndex = 31;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // txtArenaPhoneAdd
            // 
            this.txtArenaPhoneAdd.AcceptsTab = true;
            this.txtArenaPhoneAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaPhoneAdd.Location = new System.Drawing.Point(365, 299);
            this.txtArenaPhoneAdd.Name = "txtArenaPhoneAdd";
            this.txtArenaPhoneAdd.Size = new System.Drawing.Size(117, 23);
            this.txtArenaPhoneAdd.TabIndex = 30;
            this.txtArenaPhoneAdd.Text = "Phone No.";
            // 
            // txtArenaCityAdd
            // 
            this.txtArenaCityAdd.AcceptsTab = true;
            this.txtArenaCityAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaCityAdd.Location = new System.Drawing.Point(365, 242);
            this.txtArenaCityAdd.Name = "txtArenaCityAdd";
            this.txtArenaCityAdd.Size = new System.Drawing.Size(141, 23);
            this.txtArenaCityAdd.TabIndex = 29;
            this.txtArenaCityAdd.Text = "City";
            // 
            // txtArenaSuburbAdd
            // 
            this.txtArenaSuburbAdd.AcceptsTab = true;
            this.txtArenaSuburbAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaSuburbAdd.Location = new System.Drawing.Point(365, 178);
            this.txtArenaSuburbAdd.Name = "txtArenaSuburbAdd";
            this.txtArenaSuburbAdd.Size = new System.Drawing.Size(141, 23);
            this.txtArenaSuburbAdd.TabIndex = 28;
            this.txtArenaSuburbAdd.Text = "Suburb";
            // 
            // txtArenaAddressAdd
            // 
            this.txtArenaAddressAdd.AcceptsTab = true;
            this.txtArenaAddressAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaAddressAdd.Location = new System.Drawing.Point(365, 119);
            this.txtArenaAddressAdd.Name = "txtArenaAddressAdd";
            this.txtArenaAddressAdd.Size = new System.Drawing.Size(316, 23);
            this.txtArenaAddressAdd.TabIndex = 27;
            this.txtArenaAddressAdd.Text = "Address";
            // 
            // txtArenaNameAdd
            // 
            this.txtArenaNameAdd.AcceptsTab = true;
            this.txtArenaNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaNameAdd.Location = new System.Drawing.Point(365, 65);
            this.txtArenaNameAdd.Name = "txtArenaNameAdd";
            this.txtArenaNameAdd.Size = new System.Drawing.Size(191, 23);
            this.txtArenaNameAdd.TabIndex = 26;
            this.txtArenaNameAdd.Text = "Name";
            // 
            // lblArenaPhoneAdd
            // 
            this.lblArenaPhoneAdd.AutoSize = true;
            this.lblArenaPhoneAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaPhoneAdd.ForeColor = System.Drawing.Color.White;
            this.lblArenaPhoneAdd.Location = new System.Drawing.Point(250, 305);
            this.lblArenaPhoneAdd.Name = "lblArenaPhoneAdd";
            this.lblArenaPhoneAdd.Size = new System.Drawing.Size(109, 17);
            this.lblArenaPhoneAdd.TabIndex = 25;
            this.lblArenaPhoneAdd.Text = "Phone Number:";
            this.lblArenaPhoneAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaCityAdd
            // 
            this.lblArenaCityAdd.AutoSize = true;
            this.lblArenaCityAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaCityAdd.ForeColor = System.Drawing.Color.White;
            this.lblArenaCityAdd.Location = new System.Drawing.Point(322, 245);
            this.lblArenaCityAdd.Name = "lblArenaCityAdd";
            this.lblArenaCityAdd.Size = new System.Drawing.Size(37, 17);
            this.lblArenaCityAdd.TabIndex = 24;
            this.lblArenaCityAdd.Text = "City:";
            this.lblArenaCityAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaSuburbAdd
            // 
            this.lblArenaSuburbAdd.AutoSize = true;
            this.lblArenaSuburbAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaSuburbAdd.ForeColor = System.Drawing.Color.White;
            this.lblArenaSuburbAdd.Location = new System.Drawing.Point(303, 181);
            this.lblArenaSuburbAdd.Name = "lblArenaSuburbAdd";
            this.lblArenaSuburbAdd.Size = new System.Drawing.Size(56, 17);
            this.lblArenaSuburbAdd.TabIndex = 23;
            this.lblArenaSuburbAdd.Text = "Suburb:";
            this.lblArenaSuburbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaAddressAdd
            // 
            this.lblArenaAddressAdd.AutoSize = true;
            this.lblArenaAddressAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaAddressAdd.ForeColor = System.Drawing.Color.White;
            this.lblArenaAddressAdd.Location = new System.Drawing.Point(258, 122);
            this.lblArenaAddressAdd.Name = "lblArenaAddressAdd";
            this.lblArenaAddressAdd.Size = new System.Drawing.Size(101, 17);
            this.lblArenaAddressAdd.TabIndex = 22;
            this.lblArenaAddressAdd.Text = "Street Address:";
            this.lblArenaAddressAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArenaNameAdd
            // 
            this.lblArenaNameAdd.AutoSize = true;
            this.lblArenaNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaNameAdd.ForeColor = System.Drawing.Color.White;
            this.lblArenaNameAdd.Location = new System.Drawing.Point(265, 65);
            this.lblArenaNameAdd.Name = "lblArenaNameAdd";
            this.lblArenaNameAdd.Size = new System.Drawing.Size(94, 17);
            this.lblArenaNameAdd.TabIndex = 21;
            this.lblArenaNameAdd.Text = "Arena Name:";
            this.lblArenaNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.lblArenaUpdate);
            this.pnlUpdate.Controls.Add(this.btnArenaUpdate);
            this.pnlUpdate.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdate.Location = new System.Drawing.Point(47, 27);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(243, 341);
            this.pnlUpdate.TabIndex = 34;
            this.pnlUpdate.Visible = false;
            // 
            // lblArenaUpdate
            // 
            this.lblArenaUpdate.AutoSize = true;
            this.lblArenaUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaUpdate.ForeColor = System.Drawing.Color.White;
            this.lblArenaUpdate.Location = new System.Drawing.Point(45, 59);
            this.lblArenaUpdate.Name = "lblArenaUpdate";
            this.lblArenaUpdate.Size = new System.Drawing.Size(143, 22);
            this.lblArenaUpdate.TabIndex = 33;
            this.lblArenaUpdate.Text = "Update Arena";
            this.lblArenaUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnArenaUpdate
            // 
            this.btnArenaUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnArenaUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArenaUpdate.Location = new System.Drawing.Point(50, 104);
            this.btnArenaUpdate.Name = "btnArenaUpdate";
            this.btnArenaUpdate.Size = new System.Drawing.Size(139, 56);
            this.btnArenaUpdate.TabIndex = 32;
            this.btnArenaUpdate.Text = "Save Changes";
            this.btnArenaUpdate.UseVisualStyleBackColor = false;
            this.btnArenaUpdate.Click += new System.EventHandler(this.btnArenaUpdate_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCancel.Location = new System.Drawing.Point(50, 209);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(139, 56);
            this.btnUpdateCancel.TabIndex = 31;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = false;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // ArenaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteArena);
            this.Controls.Add(this.btnUpdateArena);
            this.Controls.Add(this.btnAddArena);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtArenaPhone);
            this.Controls.Add(this.txtArenaCity);
            this.Controls.Add(this.txtArenaSuburb);
            this.Controls.Add(this.txtArenaAddress);
            this.Controls.Add(this.txtArenaName);
            this.Controls.Add(this.txtArenaID);
            this.Controls.Add(this.lblArenaPhoneNumber);
            this.Controls.Add(this.lblArenaCity);
            this.Controls.Add(this.lblArenaSuburb);
            this.Controls.Add(this.lblArenaAddress);
            this.Controls.Add(this.lblArenaName);
            this.Controls.Add(this.lblArenaNo);
            this.Controls.Add(this.lstArenas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ArenaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arena Maintenance";
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArenas;
        private System.Windows.Forms.Label lblArenaNo;
        private System.Windows.Forms.Label lblArenaName;
        private System.Windows.Forms.Label lblArenaAddress;
        private System.Windows.Forms.Label lblArenaSuburb;
        private System.Windows.Forms.Label lblArenaCity;
        private System.Windows.Forms.Label lblArenaPhoneNumber;
        private System.Windows.Forms.TextBox txtArenaID;
        private System.Windows.Forms.TextBox txtArenaName;
        private System.Windows.Forms.TextBox txtArenaAddress;
        private System.Windows.Forms.TextBox txtArenaSuburb;
        private System.Windows.Forms.TextBox txtArenaCity;
        private System.Windows.Forms.TextBox txtArenaPhone;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddArena;
        private System.Windows.Forms.Button btnUpdateArena;
        private System.Windows.Forms.Button btnDeleteArena;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.TextBox txtArenaPhoneAdd;
        private System.Windows.Forms.TextBox txtArenaCityAdd;
        private System.Windows.Forms.TextBox txtArenaSuburbAdd;
        private System.Windows.Forms.TextBox txtArenaAddressAdd;
        private System.Windows.Forms.TextBox txtArenaNameAdd;
        private System.Windows.Forms.Label lblArenaPhoneAdd;
        private System.Windows.Forms.Label lblArenaCityAdd;
        private System.Windows.Forms.Label lblArenaSuburbAdd;
        private System.Windows.Forms.Label lblArenaAddressAdd;
        private System.Windows.Forms.Label lblArenaNameAdd;
        private System.Windows.Forms.Button btnArenaSave;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Label lblAddArena;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label lblArenaUpdate;
        private System.Windows.Forms.Button btnArenaUpdate;
        private System.Windows.Forms.Button btnUpdateCancel;
    }
}