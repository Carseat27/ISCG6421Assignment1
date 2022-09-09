using System;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    partial class ChallengeForm
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
            this.btnDeleteChallenge = new System.Windows.Forms.Button();
            this.btnUpdateChallenge = new System.Windows.Forms.Button();
            this.btnAddChallenge = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnMarkFinished = new System.Windows.Forms.Button();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.lstChallenges = new System.Windows.Forms.ListBox();
            this.lblChallengeID = new System.Windows.Forms.Label();
            this.lblChallengeName = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtChallengeID = new System.Windows.Forms.TextBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.txtChallengeName = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatusAdd = new System.Windows.Forms.ComboBox();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbEventName = new System.Windows.Forms.ComboBox();
            this.cmbEventID = new System.Windows.Forms.ComboBox();
            this.lblAddChallenge = new System.Windows.Forms.Label();
            this.btnChallengeSave = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.txtChallengeNameAdd = new System.Windows.Forms.TextBox();
            this.lblCapacityAdd = new System.Windows.Forms.Label();
            this.lblStartTimeAdd = new System.Windows.Forms.Label();
            this.lblEventAdd = new System.Windows.Forms.Label();
            this.lblChallengeNameAdd = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.txtEventNameUpdate = new System.Windows.Forms.TextBox();
            this.cmbStatusUpdate = new System.Windows.Forms.ComboBox();
            this.lblStatusUpdate = new System.Windows.Forms.Label();
            this.numCapacityUpdate = new System.Windows.Forms.NumericUpDown();
            this.timePickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtChallengeNameUpdate = new System.Windows.Forms.TextBox();
            this.lblCapacityUpdate = new System.Windows.Forms.Label();
            this.lblStartTimeUpdate = new System.Windows.Forms.Label();
            this.lblEventNameUpdate = new System.Windows.Forms.Label();
            this.lblChallengeNameUpdate = new System.Windows.Forms.Label();
            this.lblChallengeUpdate = new System.Windows.Forms.Label();
            this.btnChallengeUpdate = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacityUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(605, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 23);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteChallenge
            // 
            this.btnDeleteChallenge.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteChallenge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteChallenge.Location = new System.Drawing.Point(605, 374);
            this.btnDeleteChallenge.Name = "btnDeleteChallenge";
            this.btnDeleteChallenge.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteChallenge.TabIndex = 23;
            this.btnDeleteChallenge.Text = "Delete Challenge";
            this.btnDeleteChallenge.UseVisualStyleBackColor = false;
            this.btnDeleteChallenge.Click += new System.EventHandler(this.btnDeleteChallenge_Click);
            // 
            // btnUpdateChallenge
            // 
            this.btnUpdateChallenge.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateChallenge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateChallenge.Location = new System.Drawing.Point(448, 374);
            this.btnUpdateChallenge.Name = "btnUpdateChallenge";
            this.btnUpdateChallenge.Size = new System.Drawing.Size(141, 23);
            this.btnUpdateChallenge.TabIndex = 22;
            this.btnUpdateChallenge.Text = "Update Challenge";
            this.btnUpdateChallenge.UseVisualStyleBackColor = false;
            this.btnUpdateChallenge.Click += new System.EventHandler(this.btnUpdateChallenge_Click);
            // 
            // btnAddChallenge
            // 
            this.btnAddChallenge.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddChallenge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChallenge.Location = new System.Drawing.Point(301, 374);
            this.btnAddChallenge.Name = "btnAddChallenge";
            this.btnAddChallenge.Size = new System.Drawing.Size(141, 23);
            this.btnAddChallenge.TabIndex = 21;
            this.btnAddChallenge.Text = "Add Challenge";
            this.btnAddChallenge.UseVisualStyleBackColor = false;
            this.btnAddChallenge.Click += new System.EventHandler(this.btnAddChallenge_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(188, 374);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">>>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(60, 374);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 23);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<<<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnMarkFinished
            // 
            this.btnMarkFinished.BackColor = System.Drawing.SystemColors.Control;
            this.btnMarkFinished.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkFinished.Location = new System.Drawing.Point(60, 415);
            this.btnMarkFinished.Name = "btnMarkFinished";
            this.btnMarkFinished.Size = new System.Drawing.Size(230, 23);
            this.btnMarkFinished.TabIndex = 25;
            this.btnMarkFinished.Text = "Mark Challenge as Finished";
            this.btnMarkFinished.UseVisualStyleBackColor = false;
            this.btnMarkFinished.Click += new System.EventHandler(this.btnMarkFinished_Click);
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.BackColor = System.Drawing.SystemColors.Control;
            this.btnMarkCompleted.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkCompleted.Location = new System.Drawing.Point(301, 415);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(288, 23);
            this.btnMarkCompleted.TabIndex = 26;
            this.btnMarkCompleted.Text = "Mark Challenge as Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = false;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // lstChallenges
            // 
            this.lstChallenges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstChallenges.FormattingEnabled = true;
            this.lstChallenges.ItemHeight = 17;
            this.lstChallenges.Location = new System.Drawing.Point(60, 46);
            this.lstChallenges.Name = "lstChallenges";
            this.lstChallenges.Size = new System.Drawing.Size(230, 242);
            this.lstChallenges.TabIndex = 27;
            // 
            // lblChallengeID
            // 
            this.lblChallengeID.AutoSize = true;
            this.lblChallengeID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallengeID.ForeColor = System.Drawing.Color.White;
            this.lblChallengeID.Location = new System.Drawing.Point(322, 46);
            this.lblChallengeID.Name = "lblChallengeID";
            this.lblChallengeID.Size = new System.Drawing.Size(96, 17);
            this.lblChallengeID.TabIndex = 28;
            this.lblChallengeID.Text = "Challenge ID:";
            this.lblChallengeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChallengeName
            // 
            this.lblChallengeName.AutoSize = true;
            this.lblChallengeName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallengeName.ForeColor = System.Drawing.Color.White;
            this.lblChallengeName.Location = new System.Drawing.Point(295, 92);
            this.lblChallengeName.Name = "lblChallengeName";
            this.lblChallengeName.Size = new System.Drawing.Size(123, 17);
            this.lblChallengeName.TabIndex = 29;
            this.lblChallengeName.Text = "Challenge Name:";
            this.lblChallengeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.ForeColor = System.Drawing.Color.White;
            this.lblEventID.Location = new System.Drawing.Point(353, 134);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(65, 17);
            this.lblEventID.TabIndex = 30;
            this.lblEventID.Text = "Event ID:";
            this.lblEventID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(326, 181);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(92, 17);
            this.lblEventName.TabIndex = 31;
            this.lblEventName.Text = "Event Name:";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(344, 231);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(74, 17);
            this.lblStartTime.TabIndex = 32;
            this.lblStartTime.Text = "Start Time:";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(372, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.ForeColor = System.Drawing.Color.White;
            this.lblCapacity.Location = new System.Drawing.Point(346, 322);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(72, 17);
            this.lblCapacity.TabIndex = 34;
            this.lblCapacity.Text = "Capacity:";
            this.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChallengeID
            // 
            this.txtChallengeID.AcceptsTab = true;
            this.txtChallengeID.Enabled = false;
            this.txtChallengeID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallengeID.Location = new System.Drawing.Point(424, 43);
            this.txtChallengeID.Name = "txtChallengeID";
            this.txtChallengeID.Size = new System.Drawing.Size(38, 23);
            this.txtChallengeID.TabIndex = 35;
            this.txtChallengeID.Text = "ID";
            // 
            // txtEventID
            // 
            this.txtEventID.AcceptsTab = true;
            this.txtEventID.Enabled = false;
            this.txtEventID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(424, 131);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(38, 23);
            this.txtEventID.TabIndex = 36;
            this.txtEventID.Text = "ID";
            // 
            // txtChallengeName
            // 
            this.txtChallengeName.AcceptsTab = true;
            this.txtChallengeName.Enabled = false;
            this.txtChallengeName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallengeName.Location = new System.Drawing.Point(424, 89);
            this.txtChallengeName.Name = "txtChallengeName";
            this.txtChallengeName.Size = new System.Drawing.Size(165, 23);
            this.txtChallengeName.TabIndex = 37;
            this.txtChallengeName.Text = "Challenge Name";
            // 
            // txtEventName
            // 
            this.txtEventName.AcceptsTab = true;
            this.txtEventName.Enabled = false;
            this.txtEventName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(424, 178);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(165, 23);
            this.txtEventName.TabIndex = 38;
            this.txtEventName.Text = "Event Name";
            // 
            // txtStartTime
            // 
            this.txtStartTime.AcceptsTab = true;
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(424, 228);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(165, 23);
            this.txtStartTime.TabIndex = 39;
            this.txtStartTime.Text = "Start Time";
            // 
            // txtStatus
            // 
            this.txtStatus.AcceptsTab = true;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(424, 277);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(165, 23);
            this.txtStatus.TabIndex = 40;
            this.txtStatus.Text = "Status";
            // 
            // txtCapacity
            // 
            this.txtCapacity.AcceptsTab = true;
            this.txtCapacity.Enabled = false;
            this.txtCapacity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(424, 319);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(67, 23);
            this.txtCapacity.TabIndex = 41;
            this.txtCapacity.Text = "Capacity";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.cmbStatusAdd);
            this.pnlAdd.Controls.Add(this.numCapacity);
            this.pnlAdd.Controls.Add(this.timePicker);
            this.pnlAdd.Controls.Add(this.cmbEventName);
            this.pnlAdd.Controls.Add(this.cmbEventID);
            this.pnlAdd.Controls.Add(this.lblAddChallenge);
            this.pnlAdd.Controls.Add(this.btnChallengeSave);
            this.pnlAdd.Controls.Add(this.btnAddCancel);
            this.pnlAdd.Controls.Add(this.txtChallengeNameAdd);
            this.pnlAdd.Controls.Add(this.lblCapacityAdd);
            this.pnlAdd.Controls.Add(this.lblStartTimeAdd);
            this.pnlAdd.Controls.Add(this.lblEventAdd);
            this.pnlAdd.Controls.Add(this.lblChallengeNameAdd);
            this.pnlAdd.Location = new System.Drawing.Point(60, 27);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(684, 341);
            this.pnlAdd.TabIndex = 42;
            this.pnlAdd.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbStatusAdd
            // 
            this.cmbStatusAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusAdd.FormattingEnabled = true;
            this.cmbStatusAdd.Items.AddRange(new object[] {
            "Scheduled",
            "Completed",
            "Finished"});
            this.cmbStatusAdd.Location = new System.Drawing.Point(363, 265);
            this.cmbStatusAdd.Name = "cmbStatusAdd";
            this.cmbStatusAdd.Size = new System.Drawing.Size(121, 27);
            this.cmbStatusAdd.TabIndex = 47;
            // 
            // numCapacity
            // 
            this.numCapacity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCapacity.Location = new System.Drawing.Point(364, 221);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(120, 23);
            this.numCapacity.TabIndex = 37;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(365, 176);
            this.timePicker.Name = "timePicker";
            this.timePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(120, 23);
            this.timePicker.TabIndex = 36;
            this.timePicker.Value = new System.DateTime(2022, 8, 30, 0, 0, 0, 0);
            // 
            // cmbEventName
            // 
            this.cmbEventName.Enabled = false;
            this.cmbEventName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventName.FormattingEnabled = true;
            this.cmbEventName.Location = new System.Drawing.Point(427, 116);
            this.cmbEventName.Name = "cmbEventName";
            this.cmbEventName.Size = new System.Drawing.Size(248, 25);
            this.cmbEventName.TabIndex = 35;
            // 
            // cmbEventID
            // 
            this.cmbEventID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventID.FormattingEnabled = true;
            this.cmbEventID.Location = new System.Drawing.Point(365, 116);
            this.cmbEventID.Name = "cmbEventID";
            this.cmbEventID.Size = new System.Drawing.Size(56, 25);
            this.cmbEventID.TabIndex = 34;
            // 
            // lblAddChallenge
            // 
            this.lblAddChallenge.AutoSize = true;
            this.lblAddChallenge.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddChallenge.ForeColor = System.Drawing.Color.White;
            this.lblAddChallenge.Location = new System.Drawing.Point(46, 60);
            this.lblAddChallenge.Name = "lblAddChallenge";
            this.lblAddChallenge.Size = new System.Drawing.Size(151, 22);
            this.lblAddChallenge.TabIndex = 33;
            this.lblAddChallenge.Text = "Add Challenge";
            this.lblAddChallenge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChallengeSave
            // 
            this.btnChallengeSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnChallengeSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChallengeSave.Location = new System.Drawing.Point(50, 104);
            this.btnChallengeSave.Name = "btnChallengeSave";
            this.btnChallengeSave.Size = new System.Drawing.Size(139, 56);
            this.btnChallengeSave.TabIndex = 32;
            this.btnChallengeSave.Text = "Save Challenge";
            this.btnChallengeSave.UseVisualStyleBackColor = false;
            this.btnChallengeSave.Click += new System.EventHandler(this.btnChallengeSave_Click);
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
            // txtChallengeNameAdd
            // 
            this.txtChallengeNameAdd.AcceptsTab = true;
            this.txtChallengeNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallengeNameAdd.Location = new System.Drawing.Point(365, 65);
            this.txtChallengeNameAdd.Name = "txtChallengeNameAdd";
            this.txtChallengeNameAdd.Size = new System.Drawing.Size(310, 23);
            this.txtChallengeNameAdd.TabIndex = 26;
            this.txtChallengeNameAdd.Text = "Name";
            // 
            // lblCapacityAdd
            // 
            this.lblCapacityAdd.AutoSize = true;
            this.lblCapacityAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityAdd.ForeColor = System.Drawing.Color.White;
            this.lblCapacityAdd.Location = new System.Drawing.Point(279, 223);
            this.lblCapacityAdd.Name = "lblCapacityAdd";
            this.lblCapacityAdd.Size = new System.Drawing.Size(72, 17);
            this.lblCapacityAdd.TabIndex = 24;
            this.lblCapacityAdd.Text = "Capacity:";
            this.lblCapacityAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartTimeAdd
            // 
            this.lblStartTimeAdd.AutoSize = true;
            this.lblStartTimeAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTimeAdd.ForeColor = System.Drawing.Color.White;
            this.lblStartTimeAdd.Location = new System.Drawing.Point(277, 181);
            this.lblStartTimeAdd.Name = "lblStartTimeAdd";
            this.lblStartTimeAdd.Size = new System.Drawing.Size(74, 17);
            this.lblStartTimeAdd.TabIndex = 23;
            this.lblStartTimeAdd.Text = "Start Time:";
            this.lblStartTimeAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventAdd
            // 
            this.lblEventAdd.AutoSize = true;
            this.lblEventAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventAdd.ForeColor = System.Drawing.Color.White;
            this.lblEventAdd.Location = new System.Drawing.Point(303, 121);
            this.lblEventAdd.Name = "lblEventAdd";
            this.lblEventAdd.Size = new System.Drawing.Size(48, 17);
            this.lblEventAdd.TabIndex = 22;
            this.lblEventAdd.Text = "Event:";
            this.lblEventAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChallengeNameAdd
            // 
            this.lblChallengeNameAdd.AutoSize = true;
            this.lblChallengeNameAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallengeNameAdd.ForeColor = System.Drawing.Color.White;
            this.lblChallengeNameAdd.Location = new System.Drawing.Point(228, 65);
            this.lblChallengeNameAdd.Name = "lblChallengeNameAdd";
            this.lblChallengeNameAdd.Size = new System.Drawing.Size(123, 17);
            this.lblChallengeNameAdd.TabIndex = 21;
            this.lblChallengeNameAdd.Text = "Challenge Name:";
            this.lblChallengeNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.txtEventNameUpdate);
            this.pnlUpdate.Controls.Add(this.cmbStatusUpdate);
            this.pnlUpdate.Controls.Add(this.lblStatusUpdate);
            this.pnlUpdate.Controls.Add(this.numCapacityUpdate);
            this.pnlUpdate.Controls.Add(this.timePickerUpdate);
            this.pnlUpdate.Controls.Add(this.txtChallengeNameUpdate);
            this.pnlUpdate.Controls.Add(this.lblCapacityUpdate);
            this.pnlUpdate.Controls.Add(this.lblStartTimeUpdate);
            this.pnlUpdate.Controls.Add(this.lblEventNameUpdate);
            this.pnlUpdate.Controls.Add(this.lblChallengeNameUpdate);
            this.pnlUpdate.Controls.Add(this.lblChallengeUpdate);
            this.pnlUpdate.Controls.Add(this.btnChallengeUpdate);
            this.pnlUpdate.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdate.Location = new System.Drawing.Point(60, 27);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(684, 341);
            this.pnlUpdate.TabIndex = 38;
            this.pnlUpdate.Visible = false;
            // 
            // txtEventNameUpdate
            // 
            this.txtEventNameUpdate.AcceptsTab = true;
            this.txtEventNameUpdate.Enabled = false;
            this.txtEventNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventNameUpdate.Location = new System.Drawing.Point(338, 119);
            this.txtEventNameUpdate.Name = "txtEventNameUpdate";
            this.txtEventNameUpdate.Size = new System.Drawing.Size(191, 23);
            this.txtEventNameUpdate.TabIndex = 47;
            this.txtEventNameUpdate.Text = "Name";
            // 
            // cmbStatusUpdate
            // 
            this.cmbStatusUpdate.Enabled = false;
            this.cmbStatusUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusUpdate.FormattingEnabled = true;
            this.cmbStatusUpdate.Items.AddRange(new object[] {
            "Scheduled",
            "Completed",
            "Finished"});
            this.cmbStatusUpdate.Location = new System.Drawing.Point(338, 276);
            this.cmbStatusUpdate.Name = "cmbStatusUpdate";
            this.cmbStatusUpdate.Size = new System.Drawing.Size(121, 27);
            this.cmbStatusUpdate.TabIndex = 46;
            // 
            // lblStatusUpdate
            // 
            this.lblStatusUpdate.AutoSize = true;
            this.lblStatusUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusUpdate.ForeColor = System.Drawing.Color.White;
            this.lblStatusUpdate.Location = new System.Drawing.Point(266, 280);
            this.lblStatusUpdate.Name = "lblStatusUpdate";
            this.lblStatusUpdate.Size = new System.Drawing.Size(50, 17);
            this.lblStatusUpdate.TabIndex = 45;
            this.lblStatusUpdate.Text = "Status:";
            this.lblStatusUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numCapacityUpdate
            // 
            this.numCapacityUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCapacityUpdate.Location = new System.Drawing.Point(338, 225);
            this.numCapacityUpdate.Name = "numCapacityUpdate";
            this.numCapacityUpdate.Size = new System.Drawing.Size(120, 23);
            this.numCapacityUpdate.TabIndex = 44;
            this.numCapacityUpdate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timePickerUpdate
            // 
            this.timePickerUpdate.CustomFormat = "HH:mm";
            this.timePickerUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerUpdate.Location = new System.Drawing.Point(338, 174);
            this.timePickerUpdate.Name = "timePickerUpdate";
            this.timePickerUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timePickerUpdate.ShowUpDown = true;
            this.timePickerUpdate.Size = new System.Drawing.Size(120, 23);
            this.timePickerUpdate.TabIndex = 43;
            this.timePickerUpdate.Value = new System.DateTime(2022, 8, 30, 0, 0, 0, 0);
            // 
            // txtChallengeNameUpdate
            // 
            this.txtChallengeNameUpdate.AcceptsTab = true;
            this.txtChallengeNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallengeNameUpdate.Location = new System.Drawing.Point(338, 63);
            this.txtChallengeNameUpdate.Name = "txtChallengeNameUpdate";
            this.txtChallengeNameUpdate.Size = new System.Drawing.Size(191, 23);
            this.txtChallengeNameUpdate.TabIndex = 42;
            this.txtChallengeNameUpdate.Text = "Name";
            // 
            // lblCapacityUpdate
            // 
            this.lblCapacityUpdate.AutoSize = true;
            this.lblCapacityUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityUpdate.ForeColor = System.Drawing.Color.White;
            this.lblCapacityUpdate.Location = new System.Drawing.Point(252, 227);
            this.lblCapacityUpdate.Name = "lblCapacityUpdate";
            this.lblCapacityUpdate.Size = new System.Drawing.Size(72, 17);
            this.lblCapacityUpdate.TabIndex = 41;
            this.lblCapacityUpdate.Text = "Capacity:";
            this.lblCapacityUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartTimeUpdate
            // 
            this.lblStartTimeUpdate.AutoSize = true;
            this.lblStartTimeUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTimeUpdate.ForeColor = System.Drawing.Color.White;
            this.lblStartTimeUpdate.Location = new System.Drawing.Point(250, 179);
            this.lblStartTimeUpdate.Name = "lblStartTimeUpdate";
            this.lblStartTimeUpdate.Size = new System.Drawing.Size(74, 17);
            this.lblStartTimeUpdate.TabIndex = 40;
            this.lblStartTimeUpdate.Text = "Start Time:";
            this.lblStartTimeUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventNameUpdate
            // 
            this.lblEventNameUpdate.AutoSize = true;
            this.lblEventNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventNameUpdate.ForeColor = System.Drawing.Color.White;
            this.lblEventNameUpdate.Location = new System.Drawing.Point(227, 122);
            this.lblEventNameUpdate.Name = "lblEventNameUpdate";
            this.lblEventNameUpdate.Size = new System.Drawing.Size(92, 17);
            this.lblEventNameUpdate.TabIndex = 39;
            this.lblEventNameUpdate.Text = "Event Name:";
            this.lblEventNameUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChallengeNameUpdate
            // 
            this.lblChallengeNameUpdate.AutoSize = true;
            this.lblChallengeNameUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallengeNameUpdate.ForeColor = System.Drawing.Color.White;
            this.lblChallengeNameUpdate.Location = new System.Drawing.Point(201, 63);
            this.lblChallengeNameUpdate.Name = "lblChallengeNameUpdate";
            this.lblChallengeNameUpdate.Size = new System.Drawing.Size(123, 17);
            this.lblChallengeNameUpdate.TabIndex = 38;
            this.lblChallengeNameUpdate.Text = "Challenge Name:";
            this.lblChallengeNameUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChallengeUpdate
            // 
            this.lblChallengeUpdate.AutoSize = true;
            this.lblChallengeUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallengeUpdate.ForeColor = System.Drawing.Color.White;
            this.lblChallengeUpdate.Location = new System.Drawing.Point(18, 59);
            this.lblChallengeUpdate.Name = "lblChallengeUpdate";
            this.lblChallengeUpdate.Size = new System.Drawing.Size(180, 22);
            this.lblChallengeUpdate.TabIndex = 33;
            this.lblChallengeUpdate.Text = "Update Challenge";
            this.lblChallengeUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChallengeUpdate
            // 
            this.btnChallengeUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnChallengeUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChallengeUpdate.Location = new System.Drawing.Point(50, 104);
            this.btnChallengeUpdate.Name = "btnChallengeUpdate";
            this.btnChallengeUpdate.Size = new System.Drawing.Size(139, 56);
            this.btnChallengeUpdate.TabIndex = 32;
            this.btnChallengeUpdate.Text = "Save Changes";
            this.btnChallengeUpdate.UseVisualStyleBackColor = false;
            this.btnChallengeUpdate.Click += new System.EventHandler(this.btnChallengeUpdate_Click);
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
            // ChallengeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.ControlBox = false;
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.txtChallengeName);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.txtChallengeID);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.lblChallengeName);
            this.Controls.Add(this.lblChallengeID);
            this.Controls.Add(this.lstChallenges);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.btnMarkFinished);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteChallenge);
            this.Controls.Add(this.btnUpdateChallenge);
            this.Controls.Add(this.btnAddChallenge);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(813, 481);
            this.MinimumSize = new System.Drawing.Size(813, 481);
            this.Name = "ChallengeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Challenge Maintenance";
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacityUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteChallenge;
        private System.Windows.Forms.Button btnUpdateChallenge;
        private System.Windows.Forms.Button btnAddChallenge;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnMarkFinished;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.ListBox lstChallenges;
        private System.Windows.Forms.Label lblChallengeID;
        private System.Windows.Forms.Label lblChallengeName;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtChallengeID;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.TextBox txtChallengeName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.ComboBox cmbEventName;
        private System.Windows.Forms.ComboBox cmbEventID;
        private System.Windows.Forms.Label lblAddChallenge;
        private System.Windows.Forms.Button btnChallengeSave;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.TextBox txtChallengeNameAdd;
        private System.Windows.Forms.Label lblCapacityAdd;
        private System.Windows.Forms.Label lblStartTimeAdd;
        private System.Windows.Forms.Label lblEventAdd;
        private System.Windows.Forms.Label lblChallengeNameAdd;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label lblChallengeUpdate;
        private System.Windows.Forms.Button btnChallengeUpdate;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.NumericUpDown numCapacityUpdate;
        private System.Windows.Forms.DateTimePicker timePickerUpdate;
        private System.Windows.Forms.TextBox txtChallengeNameUpdate;
        private System.Windows.Forms.Label lblCapacityUpdate;
        private System.Windows.Forms.Label lblStartTimeUpdate;
        private System.Windows.Forms.Label lblEventNameUpdate;
        private System.Windows.Forms.Label lblChallengeNameUpdate;
        private System.Windows.Forms.TextBox txtEventNameUpdate;
        private System.Windows.Forms.ComboBox cmbStatusUpdate;
        private System.Windows.Forms.Label lblStatusUpdate;
        private Label label1;
        private ComboBox cmbStatusAdd;
    }
}