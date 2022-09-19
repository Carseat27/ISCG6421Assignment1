namespace ISCG6421Assignment1
{
    partial class EventsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsReportForm));
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printEvents = new System.Drawing.Printing.PrintDocument();
            this.prvEvents = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTipEventReport = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(176, 198);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(146, 46);
            this.btnPrintReport.TabIndex = 29;
            this.btnPrintReport.Text = "Print Event Report";
            this.toolTipEventReport.SetToolTip(this.btnPrintReport, "Click me to generate the report to print");
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(474, 198);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(146, 46);
            this.btnReturn.TabIndex = 28;
            this.btnReturn.Text = "Return";
            this.toolTipEventReport.SetToolTip(this.btnReturn, "Return to the main menu");
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printEvents
            // 
            this.printEvents.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printEvents_PrintPage);
            // 
            // prvEvents
            // 
            this.prvEvents.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvEvents.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvEvents.ClientSize = new System.Drawing.Size(400, 300);
            this.prvEvents.Document = this.printEvents;
            this.prvEvents.Enabled = true;
            this.prvEvents.Icon = ((System.Drawing.Icon)(resources.GetObject("prvEvents.Icon")));
            this.prvEvents.Name = "prvEvents";
            this.prvEvents.Visible = false;
            // 
            // EventsReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(813, 481);
            this.MinimumSize = new System.Drawing.Size(813, 481);
            this.Name = "EventsReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Events Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printEvents;
        private System.Windows.Forms.PrintPreviewDialog prvEvents;
        private System.Windows.Forms.ToolTip toolTipEventReport;
    }
}