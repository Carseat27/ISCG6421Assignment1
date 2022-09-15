﻿namespace ISCG6421Assignment1
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
            this.dgvCompetitor = new System.Windows.Forms.DataGridView();
            this.dgvEntry = new System.Windows.Forms.DataGridView();
            this.dgvChallenge = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEntryStatus = new System.Windows.Forms.Label();
            this.cmbEntryStatus = new System.Windows.Forms.ComboBox();
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
            this.dgvEntry.SelectionChanged += new System.EventHandler(this.dgvEntry_SelectionChanged);
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
            // lblEntryStatus
            // 
            this.lblEntryStatus.AutoSize = true;
            this.lblEntryStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryStatus.ForeColor = System.Drawing.Color.White;
            this.lblEntryStatus.Location = new System.Drawing.Point(514, 188);
            this.lblEntryStatus.Name = "lblEntryStatus";
            this.lblEntryStatus.Size = new System.Drawing.Size(84, 17);
            this.lblEntryStatus.TabIndex = 45;
            this.lblEntryStatus.Text = "Entry Status:";
            this.lblEntryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEntryStatus
            // 
            this.cmbEntryStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntryStatus.FormattingEnabled = true;
            this.cmbEntryStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Pending"});
            this.cmbEntryStatus.Location = new System.Drawing.Point(605, 186);
            this.cmbEntryStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEntryStatus.Name = "cmbEntryStatus";
            this.cmbEntryStatus.Size = new System.Drawing.Size(146, 27);
            this.cmbEntryStatus.TabIndex = 47;
            this.cmbEntryStatus.SelectedValueChanged += new System.EventHandler(this.cmbEntryStatus_SelectedValueChanged);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(796, 440);
            this.ControlBox = false;
            this.Controls.Add(this.cmbEntryStatus);
            this.Controls.Add(this.lblEntryStatus);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvChallenge);
            this.Controls.Add(this.dgvEntry);
            this.Controls.Add(this.dgvCompetitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(812, 479);
            this.MinimumSize = new System.Drawing.Size(812, 479);
            this.Name = "EntryForm";
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
        private System.Windows.Forms.Label lblEntryStatus;
        private System.Windows.Forms.ComboBox cmbEntryStatus;
    }
}