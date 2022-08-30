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
            this.btnDeleteArena = new System.Windows.Forms.Button();
            this.btnUpdateArena = new System.Windows.Forms.Button();
            this.btnAddArena = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(633, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 23);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteArena
            // 
            this.btnDeleteArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArena.Location = new System.Drawing.Point(633, 374);
            this.btnDeleteArena.Name = "btnDeleteArena";
            this.btnDeleteArena.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteArena.TabIndex = 23;
            this.btnDeleteArena.Text = "Delete Arena";
            this.btnDeleteArena.UseVisualStyleBackColor = false;
            this.btnDeleteArena.Click += new System.EventHandler(this.btnDeleteArena_Click);
            // 
            // btnUpdateArena
            // 
            this.btnUpdateArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateArena.Location = new System.Drawing.Point(487, 374);
            this.btnUpdateArena.Name = "btnUpdateArena";
            this.btnUpdateArena.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateArena.TabIndex = 22;
            this.btnUpdateArena.Text = "Update Arena";
            this.btnUpdateArena.UseVisualStyleBackColor = false;
            this.btnUpdateArena.Click += new System.EventHandler(this.btnUpdateArena_Click);
            // 
            // btnAddArena
            // 
            this.btnAddArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArena.Location = new System.Drawing.Point(346, 374);
            this.btnAddArena.Name = "btnAddArena";
            this.btnAddArena.Size = new System.Drawing.Size(102, 23);
            this.btnAddArena.TabIndex = 21;
            this.btnAddArena.Text = "Add Arena";
            this.btnAddArena.UseVisualStyleBackColor = false;
            this.btnAddArena.Click += new System.EventHandler(this.btnAddArena_Click);
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
            this.btnMarkCompleted.Location = new System.Drawing.Point(346, 415);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(243, 23);
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
            this.lstChallenges.Size = new System.Drawing.Size(230, 293);
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
            // ChallengeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(799, 450);
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
            this.Controls.Add(this.btnDeleteArena);
            this.Controls.Add(this.btnUpdateArena);
            this.Controls.Add(this.btnAddArena);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChallengeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Challenge Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteArena;
        private System.Windows.Forms.Button btnUpdateArena;
        private System.Windows.Forms.Button btnAddArena;
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
    }
}