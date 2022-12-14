namespace ISCG6421Assignment1
{
    partial class CompetitiorChallengeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitiorChallengeForm));
            this.dgvCompetitor = new System.Windows.Forms.DataGridView();
            this.dgvEntry = new System.Windows.Forms.DataGridView();
            this.dgvChallenge = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventStatus = new System.Windows.Forms.Label();
            this.txtEventStatus = new System.Windows.Forms.TextBox();
            this.toolTipEntry = new System.Windows.Forms.ToolTip(this.components);
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblEntryNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallenge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompetitor
            // 
            this.dgvCompetitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetitor.Location = new System.Drawing.Point(46, 33);
            this.dgvCompetitor.MultiSelect = false;
            this.dgvCompetitor.Name = "dgvCompetitor";
            this.dgvCompetitor.ReadOnly = true;
            this.dgvCompetitor.RowHeadersWidth = 51;
            this.dgvCompetitor.Size = new System.Drawing.Size(442, 150);
            this.dgvCompetitor.TabIndex = 0;
            // 
            // dgvEntry
            // 
            this.dgvEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntry.Location = new System.Drawing.Point(511, 225);
            this.dgvEntry.MultiSelect = false;
            this.dgvEntry.Name = "dgvEntry";
            this.dgvEntry.ReadOnly = true;
            this.dgvEntry.RowHeadersWidth = 51;
            this.dgvEntry.Size = new System.Drawing.Size(240, 150);
            this.dgvEntry.TabIndex = 1;
            // 
            // dgvChallenge
            // 
            this.dgvChallenge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChallenge.Location = new System.Drawing.Point(46, 225);
            this.dgvChallenge.MultiSelect = false;
            this.dgvChallenge.Name = "dgvChallenge";
            this.dgvChallenge.ReadOnly = true;
            this.dgvChallenge.RowHeadersWidth = 51;
            this.dgvChallenge.Size = new System.Drawing.Size(442, 150);
            this.dgvChallenge.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(605, 392);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(146, 46);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return";
            this.toolTipEntry.SetToolTip(this.btnReturn, "Return to the main menu");
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddEntry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntry.Location = new System.Drawing.Point(46, 392);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(139, 46);
            this.btnAddEntry.TabIndex = 33;
            this.btnAddEntry.Text = "Add Entry";
            this.toolTipEntry.SetToolTip(this.btnAddEntry, "Select the desired competitor from the top-left table\r\nand the challenge you wish" +
        " to enter them into from the\r\nbottom-left table, then click me\r\n");
            this.btnAddEntry.UseVisualStyleBackColor = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveEntry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEntry.Location = new System.Drawing.Point(349, 392);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(139, 46);
            this.btnRemoveEntry.TabIndex = 34;
            this.btnRemoveEntry.Text = "Remove Entry";
            this.toolTipEntry.SetToolTip(this.btnRemoveEntry, "Select the challenge from which you want to remove \r\nan entry from the bottom-lef" +
        "t table and select\r\nthe entry you wish to remove from the bottom-right\r\ntable, t" +
        "hen click me");
            this.btnRemoveEntry.UseVisualStyleBackColor = false;
            this.btnRemoveEntry.Click += new System.EventHandler(this.btnRemoveEntry_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.AcceptsTab = true;
            this.txtEventName.Enabled = false;
            this.txtEventName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(605, 56);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(146, 23);
            this.txtEventName.TabIndex = 43;
            this.txtEventName.Text = "Name";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(507, 59);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(92, 17);
            this.lblEventName.TabIndex = 44;
            this.lblEventName.Text = "Event Name:";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventStatus
            // 
            this.lblEventStatus.AutoSize = true;
            this.lblEventStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStatus.ForeColor = System.Drawing.Color.White;
            this.lblEventStatus.Location = new System.Drawing.Point(509, 106);
            this.lblEventStatus.Name = "lblEventStatus";
            this.lblEventStatus.Size = new System.Drawing.Size(90, 17);
            this.lblEventStatus.TabIndex = 48;
            this.lblEventStatus.Text = "Event Status:";
            this.lblEventStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEventStatus
            // 
            this.txtEventStatus.AcceptsTab = true;
            this.txtEventStatus.Enabled = false;
            this.txtEventStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventStatus.Location = new System.Drawing.Point(605, 103);
            this.txtEventStatus.Name = "txtEventStatus";
            this.txtEventStatus.Size = new System.Drawing.Size(146, 23);
            this.txtEventStatus.TabIndex = 49;
            this.txtEventStatus.Text = "Status";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(706, 166);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(45, 17);
            this.lblHelp.TabIndex = 50;
            this.lblHelp.Text = "Help?";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipEntry.SetToolTip(this.lblHelp, resources.GetString("lblHelp.ToolTip"));
            // 
            // lblEntryNote
            // 
            this.lblEntryNote.AutoSize = true;
            this.lblEntryNote.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblEntryNote.ForeColor = System.Drawing.Color.White;
            this.lblEntryNote.Location = new System.Drawing.Point(511, 192);
            this.lblEntryNote.Name = "lblEntryNote";
            this.lblEntryNote.Size = new System.Drawing.Size(240, 30);
            this.lblEntryNote.TabIndex = 51;
            this.lblEntryNote.Text = "*all entries are added as \'Pending\' and need\r\nto be changed in the Entry Maintena" +
    "nce form";
            this.lblEntryNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompetitiorChallengeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(796, 439);
            this.ControlBox = false;
            this.Controls.Add(this.lblEntryNote);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.txtEventStatus);
            this.Controls.Add(this.lblEventStatus);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvChallenge);
            this.Controls.Add(this.dgvEntry);
            this.Controls.Add(this.dgvCompetitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(812, 478);
            this.MinimumSize = new System.Drawing.Size(812, 478);
            this.Name = "CompetitiorChallengeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Competitor into Challenge";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallenge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompetitor;
        private System.Windows.Forms.DataGridView dgvEntry;
        private System.Windows.Forms.DataGridView dgvChallenge;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnRemoveEntry;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventStatus;
        private System.Windows.Forms.TextBox txtEventStatus;
        private System.Windows.Forms.ToolTip toolTipEntry;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblEntryNote;
    }
}