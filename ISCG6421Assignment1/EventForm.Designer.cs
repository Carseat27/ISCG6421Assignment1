namespace ISCG6421Assignment1
{
    partial class EventForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblArenaID = new System.Windows.Forms.Label();
            this.lblArenaName = new System.Windows.Forms.Label();
            this.lblEventStatus = new System.Windows.Forms.Label();
            this.lblEventCapacity = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtArenaID = new System.Windows.Forms.TextBox();
            this.txtArenaName = new System.Windows.Forms.TextBox();
            this.txtEventStatus = new System.Windows.Forms.TextBox();
            this.txtEventCapacity = new System.Windows.Forms.TextBox();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblEventStausAdd = new System.Windows.Forms.Label();
            this.cmbEventStatusAdd = new System.Windows.Forms.ComboBox();
            this.numEventCapacityAdd = new System.Windows.Forms.NumericUpDown();
            this.cmbArenaName = new System.Windows.Forms.ComboBox();
            this.cmbArenaID = new System.Windows.Forms.ComboBox();
            this.lblAddEvent = new System.Windows.Forms.Label();
            this.btnEventSave = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.txtEventNameAdd = new System.Windows.Forms.TextBox();
            this.lblEventCapacityAdd = new System.Windows.Forms.Label();
            this.lblEventDateAdd = new System.Windows.Forms.Label();
            this.lblEventAdd = new System.Windows.Forms.Label();
            this.lblEventNameAdd = new System.Windows.Forms.Label();
            this.DatePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEventCapacityAdd)).BeginInit();
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
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteEvent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.Location = new System.Drawing.Point(605, 374);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteEvent.TabIndex = 29;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateEvent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.Location = new System.Drawing.Point(448, 374);
            this.btnUpdateEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateEvent.TabIndex = 28;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddEvent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(301, 374);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(144, 23);
            this.btnAddEvent.TabIndex = 27;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(188, 374);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 23);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = ">>>";
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
            this.btnPrevious.TabIndex = 25;
            this.btnPrevious.Text = "<<<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lstEvents
            // 
            this.lstEvents.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 21;
            this.lstEvents.Location = new System.Drawing.Point(60, 46);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(230, 277);
            this.lstEvents.TabIndex = 31;
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.ForeColor = System.Drawing.Color.White;
            this.lblEventID.Location = new System.Drawing.Point(329, 49);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(86, 21);
            this.lblEventID.TabIndex = 32;
            this.lblEventID.Text = "Event ID:";
            // 
            // txtEventID
            // 
            this.txtEventID.Enabled = false;
            this.txtEventID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(421, 46);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(74, 28);
            this.txtEventID.TabIndex = 33;
            this.txtEventID.Text = "ID";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(297, 92);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(119, 21);
            this.lblEventName.TabIndex = 34;
            this.lblEventName.Text = "Event Name:";
            // 
            // lblArenaID
            // 
            this.lblArenaID.AutoSize = true;
            this.lblArenaID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaID.ForeColor = System.Drawing.Color.White;
            this.lblArenaID.Location = new System.Drawing.Point(326, 135);
            this.lblArenaID.Name = "lblArenaID";
            this.lblArenaID.Size = new System.Drawing.Size(89, 21);
            this.lblArenaID.TabIndex = 35;
            this.lblArenaID.Text = "Arena ID:";
            // 
            // lblArenaName
            // 
            this.lblArenaName.AutoSize = true;
            this.lblArenaName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaName.ForeColor = System.Drawing.Color.White;
            this.lblArenaName.Location = new System.Drawing.Point(293, 177);
            this.lblArenaName.Name = "lblArenaName";
            this.lblArenaName.Size = new System.Drawing.Size(122, 21);
            this.lblArenaName.TabIndex = 36;
            this.lblArenaName.Text = "Arena Name:";
            // 
            // lblEventStatus
            // 
            this.lblEventStatus.AutoSize = true;
            this.lblEventStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStatus.ForeColor = System.Drawing.Color.White;
            this.lblEventStatus.Location = new System.Drawing.Point(356, 219);
            this.lblEventStatus.Name = "lblEventStatus";
            this.lblEventStatus.Size = new System.Drawing.Size(59, 21);
            this.lblEventStatus.TabIndex = 37;
            this.lblEventStatus.Text = "Staus:";
            // 
            // lblEventCapacity
            // 
            this.lblEventCapacity.AutoSize = true;
            this.lblEventCapacity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventCapacity.ForeColor = System.Drawing.Color.White;
            this.lblEventCapacity.Location = new System.Drawing.Point(321, 257);
            this.lblEventCapacity.Name = "lblEventCapacity";
            this.lblEventCapacity.Size = new System.Drawing.Size(94, 21);
            this.lblEventCapacity.TabIndex = 38;
            this.lblEventCapacity.Text = "Capacity:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.ForeColor = System.Drawing.Color.White;
            this.lblEventDate.Location = new System.Drawing.Point(305, 298);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(111, 21);
            this.lblEventDate.TabIndex = 39;
            this.lblEventDate.Text = "Event Date:";
            // 
            // txtEventName
            // 
            this.txtEventName.Enabled = false;
            this.txtEventName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(421, 89);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(241, 28);
            this.txtEventName.TabIndex = 40;
            this.txtEventName.Text = "Event Name";
            // 
            // txtArenaID
            // 
            this.txtArenaID.Enabled = false;
            this.txtArenaID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaID.Location = new System.Drawing.Point(421, 132);
            this.txtArenaID.Name = "txtArenaID";
            this.txtArenaID.Size = new System.Drawing.Size(74, 28);
            this.txtArenaID.TabIndex = 41;
            this.txtArenaID.Text = "ID";
            // 
            // txtArenaName
            // 
            this.txtArenaName.Enabled = false;
            this.txtArenaName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaName.Location = new System.Drawing.Point(421, 174);
            this.txtArenaName.Name = "txtArenaName";
            this.txtArenaName.Size = new System.Drawing.Size(241, 28);
            this.txtArenaName.TabIndex = 42;
            this.txtArenaName.Text = "Arena Name";
            // 
            // txtEventStatus
            // 
            this.txtEventStatus.Enabled = false;
            this.txtEventStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventStatus.Location = new System.Drawing.Point(421, 216);
            this.txtEventStatus.Name = "txtEventStatus";
            this.txtEventStatus.Size = new System.Drawing.Size(104, 28);
            this.txtEventStatus.TabIndex = 43;
            this.txtEventStatus.Text = "Status";
            // 
            // txtEventCapacity
            // 
            this.txtEventCapacity.Enabled = false;
            this.txtEventCapacity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventCapacity.Location = new System.Drawing.Point(421, 254);
            this.txtEventCapacity.Name = "txtEventCapacity";
            this.txtEventCapacity.Size = new System.Drawing.Size(80, 28);
            this.txtEventCapacity.TabIndex = 44;
            this.txtEventCapacity.Text = "Capacity";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Enabled = false;
            this.txtEventDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDate.Location = new System.Drawing.Point(421, 295);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(80, 28);
            this.txtEventDate.TabIndex = 45;
            this.txtEventDate.Text = "Event Date";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.DatePickerAdd);
            this.pnlAdd.Controls.Add(this.lblEventStausAdd);
            this.pnlAdd.Controls.Add(this.cmbEventStatusAdd);
            this.pnlAdd.Controls.Add(this.numEventCapacityAdd);
            this.pnlAdd.Controls.Add(this.cmbArenaName);
            this.pnlAdd.Controls.Add(this.cmbArenaID);
            this.pnlAdd.Controls.Add(this.lblAddEvent);
            this.pnlAdd.Controls.Add(this.btnEventSave);
            this.pnlAdd.Controls.Add(this.btnAddCancel);
            this.pnlAdd.Controls.Add(this.txtEventNameAdd);
            this.pnlAdd.Controls.Add(this.lblEventCapacityAdd);
            this.pnlAdd.Controls.Add(this.lblEventDateAdd);
            this.pnlAdd.Controls.Add(this.lblEventAdd);
            this.pnlAdd.Controls.Add(this.lblEventNameAdd);
            this.pnlAdd.Location = new System.Drawing.Point(51, 12);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(684, 341);
            this.pnlAdd.TabIndex = 46;
            this.pnlAdd.Visible = false;
            // 
            // lblEventStausAdd
            // 
            this.lblEventStausAdd.AutoSize = true;
            this.lblEventStausAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStausAdd.ForeColor = System.Drawing.Color.White;
            this.lblEventStausAdd.Location = new System.Drawing.Point(270, 165);
            this.lblEventStausAdd.Name = "lblEventStausAdd";
            this.lblEventStausAdd.Size = new System.Drawing.Size(66, 21);
            this.lblEventStausAdd.TabIndex = 48;
            this.lblEventStausAdd.Text = "Status:";
            this.lblEventStausAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEventStatusAdd
            // 
            this.cmbEventStatusAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventStatusAdd.FormattingEnabled = true;
            this.cmbEventStatusAdd.Items.AddRange(new object[] {
            "Unconfirmed",
            "Confirmed",
            "Cancelled"});
            this.cmbEventStatusAdd.Location = new System.Drawing.Point(353, 162);
            this.cmbEventStatusAdd.Name = "cmbEventStatusAdd";
            this.cmbEventStatusAdd.Size = new System.Drawing.Size(121, 29);
            this.cmbEventStatusAdd.TabIndex = 47;
            // 
            // numEventCapacityAdd
            // 
            this.numEventCapacityAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEventCapacityAdd.Location = new System.Drawing.Point(353, 215);
            this.numEventCapacityAdd.Name = "numEventCapacityAdd";
            this.numEventCapacityAdd.Size = new System.Drawing.Size(120, 27);
            this.numEventCapacityAdd.TabIndex = 37;
            this.numEventCapacityAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbArenaName
            // 
            this.cmbArenaName.Enabled = false;
            this.cmbArenaName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArenaName.FormattingEnabled = true;
            this.cmbArenaName.Location = new System.Drawing.Point(415, 113);
            this.cmbArenaName.Name = "cmbArenaName";
            this.cmbArenaName.Size = new System.Drawing.Size(248, 29);
            this.cmbArenaName.TabIndex = 35;
            // 
            // cmbArenaID
            // 
            this.cmbArenaID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArenaID.FormattingEnabled = true;
            this.cmbArenaID.Location = new System.Drawing.Point(353, 113);
            this.cmbArenaID.Name = "cmbArenaID";
            this.cmbArenaID.Size = new System.Drawing.Size(56, 29);
            this.cmbArenaID.TabIndex = 34;
            // 
            // lblAddEvent
            // 
            this.lblAddEvent.AutoSize = true;
            this.lblAddEvent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEvent.ForeColor = System.Drawing.Color.White;
            this.lblAddEvent.Location = new System.Drawing.Point(58, 59);
            this.lblAddEvent.Name = "lblAddEvent";
            this.lblAddEvent.Size = new System.Drawing.Size(131, 27);
            this.lblAddEvent.TabIndex = 33;
            this.lblAddEvent.Text = "Add Event";
            this.lblAddEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEventSave
            // 
            this.btnEventSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnEventSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventSave.Location = new System.Drawing.Point(50, 104);
            this.btnEventSave.Name = "btnEventSave";
            this.btnEventSave.Size = new System.Drawing.Size(139, 56);
            this.btnEventSave.TabIndex = 32;
            this.btnEventSave.Text = "Save Event";
            this.btnEventSave.UseVisualStyleBackColor = false;
            this.btnEventSave.Click += new System.EventHandler(this.btnEventSave_Click);
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
            // txtEventNameAdd
            // 
            this.txtEventNameAdd.AcceptsTab = true;
            this.txtEventNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventNameAdd.Location = new System.Drawing.Point(353, 59);
            this.txtEventNameAdd.Name = "txtEventNameAdd";
            this.txtEventNameAdd.Size = new System.Drawing.Size(310, 27);
            this.txtEventNameAdd.TabIndex = 26;
            this.txtEventNameAdd.Text = "Name";
            // 
            // lblEventCapacityAdd
            // 
            this.lblEventCapacityAdd.AutoSize = true;
            this.lblEventCapacityAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventCapacityAdd.ForeColor = System.Drawing.Color.White;
            this.lblEventCapacityAdd.Location = new System.Drawing.Point(246, 217);
            this.lblEventCapacityAdd.Name = "lblEventCapacityAdd";
            this.lblEventCapacityAdd.Size = new System.Drawing.Size(94, 21);
            this.lblEventCapacityAdd.TabIndex = 24;
            this.lblEventCapacityAdd.Text = "Capacity:";
            this.lblEventCapacityAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventDateAdd
            // 
            this.lblEventDateAdd.AutoSize = true;
            this.lblEventDateAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDateAdd.ForeColor = System.Drawing.Color.White;
            this.lblEventDateAdd.Location = new System.Drawing.Point(225, 265);
            this.lblEventDateAdd.Name = "lblEventDateAdd";
            this.lblEventDateAdd.Size = new System.Drawing.Size(111, 21);
            this.lblEventDateAdd.TabIndex = 23;
            this.lblEventDateAdd.Text = "Event Date:";
            this.lblEventDateAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventAdd
            // 
            this.lblEventAdd.AutoSize = true;
            this.lblEventAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventAdd.ForeColor = System.Drawing.Color.White;
            this.lblEventAdd.Location = new System.Drawing.Point(270, 116);
            this.lblEventAdd.Name = "lblEventAdd";
            this.lblEventAdd.Size = new System.Drawing.Size(66, 21);
            this.lblEventAdd.TabIndex = 22;
            this.lblEventAdd.Text = "Arena:";
            this.lblEventAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventNameAdd
            // 
            this.lblEventNameAdd.AutoSize = true;
            this.lblEventNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventNameAdd.ForeColor = System.Drawing.Color.White;
            this.lblEventNameAdd.Location = new System.Drawing.Point(217, 62);
            this.lblEventNameAdd.Name = "lblEventNameAdd";
            this.lblEventNameAdd.Size = new System.Drawing.Size(119, 21);
            this.lblEventNameAdd.TabIndex = 21;
            this.lblEventNameAdd.Text = "Event Name:";
            this.lblEventNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DatePickerAdd
            // 
            this.DatePickerAdd.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerAdd.Location = new System.Drawing.Point(353, 260);
            this.DatePickerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.DatePickerAdd.MaxDate = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            this.DatePickerAdd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DatePickerAdd.Name = "DatePickerAdd";
            this.DatePickerAdd.Size = new System.Drawing.Size(125, 27);
            this.DatePickerAdd.TabIndex = 49;
            this.DatePickerAdd.Value = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            // 
            // EventForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.txtEventCapacity);
            this.Controls.Add(this.txtEventStatus);
            this.Controls.Add(this.txtArenaName);
            this.Controls.Add(this.txtArenaID);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblEventCapacity);
            this.Controls.Add(this.lblEventStatus);
            this.Controls.Add(this.lblArenaName);
            this.Controls.Add(this.lblArenaID);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event Maintenance";
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEventCapacityAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblArenaID;
        private System.Windows.Forms.Label lblArenaName;
        private System.Windows.Forms.Label lblEventStatus;
        private System.Windows.Forms.Label lblEventCapacity;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtArenaID;
        private System.Windows.Forms.TextBox txtArenaName;
        private System.Windows.Forms.TextBox txtEventStatus;
        private System.Windows.Forms.TextBox txtEventCapacity;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblEventStausAdd;
        private System.Windows.Forms.ComboBox cmbEventStatusAdd;
        private System.Windows.Forms.NumericUpDown numEventCapacityAdd;
        private System.Windows.Forms.ComboBox cmbArenaName;
        private System.Windows.Forms.ComboBox cmbArenaID;
        private System.Windows.Forms.Label lblAddEvent;
        private System.Windows.Forms.Button btnEventSave;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TextBox txtEventNameAdd;
        private System.Windows.Forms.Label lblEventCapacityAdd;
        private System.Windows.Forms.Label lblEventDateAdd;
        private System.Windows.Forms.Label lblEventAdd;
        private System.Windows.Forms.Label lblEventNameAdd;
        private System.Windows.Forms.DateTimePicker DatePickerAdd;
    }
}