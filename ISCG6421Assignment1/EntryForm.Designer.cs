namespace ISCG6421Assignment1
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstChallenges = new System.Windows.Forms.ListBox();
            this.lstEntries = new System.Windows.Forms.ListBox();
            this.lblChallenges = new System.Windows.Forms.Label();
            this.lblChallengeEntries = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtChallengeName = new System.Windows.Forms.TextBox();
            this.lblCompetitorFName = new System.Windows.Forms.Label();
            this.txtCompetitorFName = new System.Windows.Forms.TextBox();
            this.btnNextChallenge = new System.Windows.Forms.Button();
            this.btnPreviousChallenge = new System.Windows.Forms.Button();
            this.btnNextCompetitor = new System.Windows.Forms.Button();
            this.btnPreviousCompetitor = new System.Windows.Forms.Button();
            this.lblEntryStatus = new System.Windows.Forms.Label();
            this.txtEntryStatus = new System.Windows.Forms.TextBox();
            this.lblCompetitorLName = new System.Windows.Forms.Label();
            this.txtCompetitorLName = new System.Windows.Forms.TextBox();
            this.btnEntryConfirm = new System.Windows.Forms.Button();
            this.btnMarkDSQ = new System.Windows.Forms.Button();
            this.toolTipEntry = new System.Windows.Forms.ToolTip(this.components);
            this.lblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(544, 374);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 23);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return";
            this.toolTipEntry.SetToolTip(this.btnReturn, "Return to the main menu");
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstChallenges
            // 
            this.lstChallenges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstChallenges.FormattingEnabled = true;
            this.lstChallenges.ItemHeight = 17;
            this.lstChallenges.Location = new System.Drawing.Point(60, 46);
            this.lstChallenges.Name = "lstChallenges";
            this.lstChallenges.Size = new System.Drawing.Size(230, 310);
            this.lstChallenges.TabIndex = 28;
            // 
            // lstEntries
            // 
            this.lstEntries.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEntries.FormattingEnabled = true;
            this.lstEntries.ItemHeight = 17;
            this.lstEntries.Location = new System.Drawing.Point(305, 46);
            this.lstEntries.Name = "lstEntries";
            this.lstEntries.Size = new System.Drawing.Size(230, 310);
            this.lstEntries.TabIndex = 29;
            // 
            // lblChallenges
            // 
            this.lblChallenges.AutoSize = true;
            this.lblChallenges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallenges.ForeColor = System.Drawing.Color.White;
            this.lblChallenges.Location = new System.Drawing.Point(57, 26);
            this.lblChallenges.Name = "lblChallenges";
            this.lblChallenges.Size = new System.Drawing.Size(84, 17);
            this.lblChallenges.TabIndex = 39;
            this.lblChallenges.Text = "Challenges:";
            this.lblChallenges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChallengeEntries
            // 
            this.lblChallengeEntries.AutoSize = true;
            this.lblChallengeEntries.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallengeEntries.ForeColor = System.Drawing.Color.White;
            this.lblChallengeEntries.Location = new System.Drawing.Point(302, 26);
            this.lblChallengeEntries.Name = "lblChallengeEntries";
            this.lblChallengeEntries.Size = new System.Drawing.Size(146, 17);
            this.lblChallengeEntries.TabIndex = 40;
            this.lblChallengeEntries.Text = "Competitors Entered:";
            this.lblChallengeEntries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(541, 49);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(123, 17);
            this.lblEventName.TabIndex = 46;
            this.lblEventName.Text = "Challenge Name:";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChallengeName
            // 
            this.txtChallengeName.AcceptsTab = true;
            this.txtChallengeName.Enabled = false;
            this.txtChallengeName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallengeName.Location = new System.Drawing.Point(544, 69);
            this.txtChallengeName.Name = "txtChallengeName";
            this.txtChallengeName.Size = new System.Drawing.Size(191, 23);
            this.txtChallengeName.TabIndex = 45;
            this.txtChallengeName.Text = "Name";
            // 
            // lblCompetitorFName
            // 
            this.lblCompetitorFName.AutoSize = true;
            this.lblCompetitorFName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorFName.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorFName.Location = new System.Drawing.Point(541, 107);
            this.lblCompetitorFName.Name = "lblCompetitorFName";
            this.lblCompetitorFName.Size = new System.Drawing.Size(79, 17);
            this.lblCompetitorFName.TabIndex = 48;
            this.lblCompetitorFName.Text = "First Name:";
            this.lblCompetitorFName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompetitorFName
            // 
            this.txtCompetitorFName.AcceptsTab = true;
            this.txtCompetitorFName.Enabled = false;
            this.txtCompetitorFName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorFName.Location = new System.Drawing.Point(544, 127);
            this.txtCompetitorFName.Name = "txtCompetitorFName";
            this.txtCompetitorFName.Size = new System.Drawing.Size(191, 23);
            this.txtCompetitorFName.TabIndex = 47;
            this.txtCompetitorFName.Text = "Name";
            // 
            // btnNextChallenge
            // 
            this.btnNextChallenge.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextChallenge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextChallenge.Location = new System.Drawing.Point(188, 374);
            this.btnNextChallenge.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextChallenge.Name = "btnNextChallenge";
            this.btnNextChallenge.Size = new System.Drawing.Size(102, 23);
            this.btnNextChallenge.TabIndex = 50;
            this.btnNextChallenge.Text = ">>>";
            this.toolTipEntry.SetToolTip(this.btnNextChallenge, "Next Challenge");
            this.btnNextChallenge.UseVisualStyleBackColor = false;
            this.btnNextChallenge.Click += new System.EventHandler(this.btnNextChallenge_Click);
            // 
            // btnPreviousChallenge
            // 
            this.btnPreviousChallenge.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousChallenge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousChallenge.Location = new System.Drawing.Point(60, 374);
            this.btnPreviousChallenge.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousChallenge.Name = "btnPreviousChallenge";
            this.btnPreviousChallenge.Size = new System.Drawing.Size(102, 23);
            this.btnPreviousChallenge.TabIndex = 49;
            this.btnPreviousChallenge.Text = "<<<";
            this.toolTipEntry.SetToolTip(this.btnPreviousChallenge, "Previous Challenge");
            this.btnPreviousChallenge.UseVisualStyleBackColor = false;
            this.btnPreviousChallenge.Click += new System.EventHandler(this.btnPreviousChallenge_Click);
            // 
            // btnNextCompetitor
            // 
            this.btnNextCompetitor.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextCompetitor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextCompetitor.Location = new System.Drawing.Point(433, 374);
            this.btnNextCompetitor.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextCompetitor.Name = "btnNextCompetitor";
            this.btnNextCompetitor.Size = new System.Drawing.Size(102, 23);
            this.btnNextCompetitor.TabIndex = 52;
            this.btnNextCompetitor.Text = ">>>";
            this.toolTipEntry.SetToolTip(this.btnNextCompetitor, "Next Entry");
            this.btnNextCompetitor.UseVisualStyleBackColor = false;
            this.btnNextCompetitor.Click += new System.EventHandler(this.btnNextCompetitor_Click);
            // 
            // btnPreviousCompetitor
            // 
            this.btnPreviousCompetitor.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousCompetitor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousCompetitor.Location = new System.Drawing.Point(305, 374);
            this.btnPreviousCompetitor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousCompetitor.Name = "btnPreviousCompetitor";
            this.btnPreviousCompetitor.Size = new System.Drawing.Size(102, 23);
            this.btnPreviousCompetitor.TabIndex = 51;
            this.btnPreviousCompetitor.Text = "<<<";
            this.toolTipEntry.SetToolTip(this.btnPreviousCompetitor, "Previous Entry");
            this.btnPreviousCompetitor.UseVisualStyleBackColor = false;
            this.btnPreviousCompetitor.Click += new System.EventHandler(this.btnPreviousCompetitor_Click);
            // 
            // lblEntryStatus
            // 
            this.lblEntryStatus.AutoSize = true;
            this.lblEntryStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryStatus.ForeColor = System.Drawing.Color.White;
            this.lblEntryStatus.Location = new System.Drawing.Point(541, 221);
            this.lblEntryStatus.Name = "lblEntryStatus";
            this.lblEntryStatus.Size = new System.Drawing.Size(84, 17);
            this.lblEntryStatus.TabIndex = 54;
            this.lblEntryStatus.Text = "Entry Status:";
            this.lblEntryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEntryStatus
            // 
            this.txtEntryStatus.AcceptsTab = true;
            this.txtEntryStatus.Enabled = false;
            this.txtEntryStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryStatus.Location = new System.Drawing.Point(544, 241);
            this.txtEntryStatus.Name = "txtEntryStatus";
            this.txtEntryStatus.Size = new System.Drawing.Size(191, 23);
            this.txtEntryStatus.TabIndex = 53;
            this.txtEntryStatus.Text = "Status";
            // 
            // lblCompetitorLName
            // 
            this.lblCompetitorLName.AutoSize = true;
            this.lblCompetitorLName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorLName.ForeColor = System.Drawing.Color.White;
            this.lblCompetitorLName.Location = new System.Drawing.Point(541, 162);
            this.lblCompetitorLName.Name = "lblCompetitorLName";
            this.lblCompetitorLName.Size = new System.Drawing.Size(81, 17);
            this.lblCompetitorLName.TabIndex = 56;
            this.lblCompetitorLName.Text = "Last Name:";
            this.lblCompetitorLName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompetitorLName
            // 
            this.txtCompetitorLName.AcceptsTab = true;
            this.txtCompetitorLName.Enabled = false;
            this.txtCompetitorLName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorLName.Location = new System.Drawing.Point(544, 182);
            this.txtCompetitorLName.Name = "txtCompetitorLName";
            this.txtCompetitorLName.Size = new System.Drawing.Size(191, 23);
            this.txtCompetitorLName.TabIndex = 55;
            this.txtCompetitorLName.Text = "Name";
            // 
            // btnEntryConfirm
            // 
            this.btnEntryConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntryConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntryConfirm.Location = new System.Drawing.Point(544, 303);
            this.btnEntryConfirm.Name = "btnEntryConfirm";
            this.btnEntryConfirm.Size = new System.Drawing.Size(191, 23);
            this.btnEntryConfirm.TabIndex = 57;
            this.btnEntryConfirm.Text = "Confirm";
            this.toolTipEntry.SetToolTip(this.btnEntryConfirm, "Click me to change the selected entry\'s status to \"Confirmed\"");
            this.btnEntryConfirm.UseVisualStyleBackColor = false;
            this.btnEntryConfirm.Click += new System.EventHandler(this.btnEntryConfirm_Click);
            // 
            // btnMarkDSQ
            // 
            this.btnMarkDSQ.BackColor = System.Drawing.SystemColors.Control;
            this.btnMarkDSQ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkDSQ.Location = new System.Drawing.Point(544, 332);
            this.btnMarkDSQ.Name = "btnMarkDSQ";
            this.btnMarkDSQ.Size = new System.Drawing.Size(191, 23);
            this.btnMarkDSQ.TabIndex = 58;
            this.btnMarkDSQ.Text = "Disqualify";
            this.toolTipEntry.SetToolTip(this.btnMarkDSQ, "Click me to change the selected entry\'s status to \"Disqualified\"");
            this.btnMarkDSQ.UseVisualStyleBackColor = false;
            this.btnMarkDSQ.Click += new System.EventHandler(this.btnMarkDSQ_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(690, 267);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(45, 17);
            this.lblHelp.TabIndex = 59;
            this.lblHelp.Text = "Help?";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipEntry.SetToolTip(this.lblHelp, resources.GetString("lblHelp.ToolTip"));
            // 
            // EntryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.ControlBox = false;
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnMarkDSQ);
            this.Controls.Add(this.btnEntryConfirm);
            this.Controls.Add(this.lblCompetitorLName);
            this.Controls.Add(this.txtCompetitorLName);
            this.Controls.Add(this.lblEntryStatus);
            this.Controls.Add(this.txtEntryStatus);
            this.Controls.Add(this.btnNextCompetitor);
            this.Controls.Add(this.btnPreviousCompetitor);
            this.Controls.Add(this.btnNextChallenge);
            this.Controls.Add(this.btnPreviousChallenge);
            this.Controls.Add(this.lblCompetitorFName);
            this.Controls.Add(this.txtCompetitorFName);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txtChallengeName);
            this.Controls.Add(this.lblChallengeEntries);
            this.Controls.Add(this.lblChallenges);
            this.Controls.Add(this.lstEntries);
            this.Controls.Add(this.lstChallenges);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(813, 481);
            this.MinimumSize = new System.Drawing.Size(813, 481);
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entry Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstChallenges;
        private System.Windows.Forms.ListBox lstEntries;
        private System.Windows.Forms.Label lblChallenges;
        private System.Windows.Forms.Label lblChallengeEntries;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtChallengeName;
        private System.Windows.Forms.Label lblCompetitorFName;
        private System.Windows.Forms.TextBox txtCompetitorFName;
        private System.Windows.Forms.Button btnNextChallenge;
        private System.Windows.Forms.Button btnPreviousChallenge;
        private System.Windows.Forms.Button btnNextCompetitor;
        private System.Windows.Forms.Button btnPreviousCompetitor;
        private System.Windows.Forms.Label lblEntryStatus;
        private System.Windows.Forms.TextBox txtEntryStatus;
        private System.Windows.Forms.Label lblCompetitorLName;
        private System.Windows.Forms.TextBox txtCompetitorLName;
        private System.Windows.Forms.Button btnEntryConfirm;
        private System.Windows.Forms.Button btnMarkDSQ;
        private System.Windows.Forms.ToolTip toolTipEntry;
        private System.Windows.Forms.Label lblHelp;
    }
}