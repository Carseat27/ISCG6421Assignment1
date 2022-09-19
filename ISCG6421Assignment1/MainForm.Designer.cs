namespace ISCG6421Assignment1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnEnterCompetitorChallenge = new System.Windows.Forms.Button();
            this.btnCompetitorMaintence = new System.Windows.Forms.Button();
            this.btnChallengeMaintenance = new System.Windows.Forms.Button();
            this.btnEventMaintenance = new System.Windows.Forms.Button();
            this.btnArenaMaintenance = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.btbDbConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCompetitorReport = new System.Windows.Forms.Button();
            this.btnEventsReport = new System.Windows.Forms.Button();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.grpMaintenance.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpMaintenance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpMaintenance.Controls.Add(this.btnEnterCompetitorChallenge);
            this.grpMaintenance.Controls.Add(this.btnCompetitorMaintence);
            this.grpMaintenance.Controls.Add(this.btnChallengeMaintenance);
            this.grpMaintenance.Controls.Add(this.btnEventMaintenance);
            this.grpMaintenance.Controls.Add(this.btnArenaMaintenance);
            this.grpMaintenance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpMaintenance.Location = new System.Drawing.Point(37, 41);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(328, 364);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnEnterCompetitorChallenge
            // 
            this.btnEnterCompetitorChallenge.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnterCompetitorChallenge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterCompetitorChallenge.Location = new System.Drawing.Point(30, 265);
            this.btnEnterCompetitorChallenge.Name = "btnEnterCompetitorChallenge";
            this.btnEnterCompetitorChallenge.Size = new System.Drawing.Size(268, 84);
            this.btnEnterCompetitorChallenge.TabIndex = 4;
            this.btnEnterCompetitorChallenge.Text = "Enter Competitor into Challenge";
            this.toolTipMenu.SetToolTip(this.btnEnterCompetitorChallenge, "Click me add or remove Entries");
            this.btnEnterCompetitorChallenge.UseVisualStyleBackColor = false;
            this.btnEnterCompetitorChallenge.Click += new System.EventHandler(this.btnEnterCompetitorChallenge_Click);
            // 
            // btnCompetitorMaintence
            // 
            this.btnCompetitorMaintence.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompetitorMaintence.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetitorMaintence.Location = new System.Drawing.Point(30, 168);
            this.btnCompetitorMaintence.Name = "btnCompetitorMaintence";
            this.btnCompetitorMaintence.Size = new System.Drawing.Size(268, 39);
            this.btnCompetitorMaintence.TabIndex = 3;
            this.btnCompetitorMaintence.Text = "Competitor Maintenance";
            this.toolTipMenu.SetToolTip(this.btnCompetitorMaintence, "Click to me add, update, or delete Competitors");
            this.btnCompetitorMaintence.UseVisualStyleBackColor = false;
            this.btnCompetitorMaintence.Click += new System.EventHandler(this.btnCompetitorMaintence_Click);
            // 
            // btnChallengeMaintenance
            // 
            this.btnChallengeMaintenance.BackColor = System.Drawing.SystemColors.Control;
            this.btnChallengeMaintenance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChallengeMaintenance.Location = new System.Drawing.Point(30, 123);
            this.btnChallengeMaintenance.Name = "btnChallengeMaintenance";
            this.btnChallengeMaintenance.Size = new System.Drawing.Size(268, 39);
            this.btnChallengeMaintenance.TabIndex = 2;
            this.btnChallengeMaintenance.Text = "Challenge Maintenance";
            this.toolTipMenu.SetToolTip(this.btnChallengeMaintenance, "Click to me add, update, or delete Challenges");
            this.btnChallengeMaintenance.UseVisualStyleBackColor = false;
            this.btnChallengeMaintenance.Click += new System.EventHandler(this.btnChallengeMaintenance_Click);
            // 
            // btnEventMaintenance
            // 
            this.btnEventMaintenance.BackColor = System.Drawing.SystemColors.Control;
            this.btnEventMaintenance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventMaintenance.Location = new System.Drawing.Point(30, 78);
            this.btnEventMaintenance.Name = "btnEventMaintenance";
            this.btnEventMaintenance.Size = new System.Drawing.Size(268, 39);
            this.btnEventMaintenance.TabIndex = 1;
            this.btnEventMaintenance.Text = "Event Maintenance";
            this.toolTipMenu.SetToolTip(this.btnEventMaintenance, "Click to me add, update, or delete Events");
            this.btnEventMaintenance.UseVisualStyleBackColor = false;
            this.btnEventMaintenance.Click += new System.EventHandler(this.btnEventMaintenance_Click);
            // 
            // btnArenaMaintenance
            // 
            this.btnArenaMaintenance.BackColor = System.Drawing.SystemColors.Control;
            this.btnArenaMaintenance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArenaMaintenance.Location = new System.Drawing.Point(30, 33);
            this.btnArenaMaintenance.Name = "btnArenaMaintenance";
            this.btnArenaMaintenance.Size = new System.Drawing.Size(268, 39);
            this.btnArenaMaintenance.TabIndex = 0;
            this.btnArenaMaintenance.Text = "Arena Maintenance";
            this.toolTipMenu.SetToolTip(this.btnArenaMaintenance, "Click to me add, update, or delete Arenas");
            this.btnArenaMaintenance.UseVisualStyleBackColor = false;
            this.btnArenaMaintenance.Click += new System.EventHandler(this.btnArenaMaintenance_Click);
            // 
            // grpReporting
            // 
            this.grpReporting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpReporting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpReporting.Controls.Add(this.btbDbConnect);
            this.grpReporting.Controls.Add(this.btnExit);
            this.grpReporting.Controls.Add(this.btnCompetitorReport);
            this.grpReporting.Controls.Add(this.btnEventsReport);
            this.grpReporting.Location = new System.Drawing.Point(428, 41);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(328, 364);
            this.grpReporting.TabIndex = 1;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // btbDbConnect
            // 
            this.btbDbConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btbDbConnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbDbConnect.Location = new System.Drawing.Point(32, 265);
            this.btbDbConnect.Name = "btbDbConnect";
            this.btbDbConnect.Size = new System.Drawing.Size(268, 39);
            this.btbDbConnect.TabIndex = 4;
            this.btbDbConnect.Text = "Connect to Database";
            this.toolTipMenu.SetToolTip(this.btbDbConnect, "Click me to choose the location of your NZESL.mdb file");
            this.btbDbConnect.UseVisualStyleBackColor = false;
            this.btbDbConnect.Click += new System.EventHandler(this.btbDbConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(32, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.toolTipMenu.SetToolTip(this.btnExit, "Click me to exit the program");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCompetitorReport
            // 
            this.btnCompetitorReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompetitorReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetitorReport.Location = new System.Drawing.Point(32, 78);
            this.btnCompetitorReport.Name = "btnCompetitorReport";
            this.btnCompetitorReport.Size = new System.Drawing.Size(268, 39);
            this.btnCompetitorReport.TabIndex = 2;
            this.btnCompetitorReport.Text = "Competitor Report";
            this.toolTipMenu.SetToolTip(this.btnCompetitorReport, "Click me to produce a Competitors Report");
            this.btnCompetitorReport.UseVisualStyleBackColor = false;
            this.btnCompetitorReport.Click += new System.EventHandler(this.btnCompetitorReport_Click);
            // 
            // btnEventsReport
            // 
            this.btnEventsReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnEventsReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsReport.Location = new System.Drawing.Point(32, 33);
            this.btnEventsReport.Name = "btnEventsReport";
            this.btnEventsReport.Size = new System.Drawing.Size(268, 39);
            this.btnEventsReport.TabIndex = 1;
            this.btnEventsReport.Text = "Events Report";
            this.toolTipMenu.SetToolTip(this.btnEventsReport, "Click me to produce an Events Report");
            this.btnEventsReport.UseVisualStyleBackColor = false;
            this.btnEventsReport.Click += new System.EventHandler(this.btnEventsReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpMaintenance);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(813, 481);
            this.MinimumSize = new System.Drawing.Size(813, 481);
            this.Name = "MainForm";
            this.Text = "NZ E-Sports League";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.GroupBox grpReporting;
        private System.Windows.Forms.Button btnArenaMaintenance;
        private System.Windows.Forms.Button btnEnterCompetitorChallenge;
        private System.Windows.Forms.Button btnCompetitorMaintence;
        private System.Windows.Forms.Button btnChallengeMaintenance;
        private System.Windows.Forms.Button btnEventMaintenance;
        private System.Windows.Forms.Button btnEventsReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCompetitorReport;
        private System.Windows.Forms.Button btbDbConnect;
        private System.Windows.Forms.ToolTip toolTipMenu;
    }
}

