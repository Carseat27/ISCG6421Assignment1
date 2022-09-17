﻿namespace ISCG6421Assignment1
{
    partial class CompetitorReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitorReportForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.printCompetitors = new System.Drawing.Printing.PrintDocument();
            this.prvCompetitors = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(672, 242);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(195, 57);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(275, 242);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(195, 57);
            this.btnPrintReport.TabIndex = 27;
            this.btnPrintReport.Text = "Print Competitor Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // printCompetitors
            // 
            this.printCompetitors.DocumentName = "Competitor Report";
            this.printCompetitors.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCompetitors_PrintPage);
            // 
            // prvCompetitors
            // 
            this.prvCompetitors.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvCompetitors.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvCompetitors.ClientSize = new System.Drawing.Size(400, 300);
            this.prvCompetitors.Document = this.printCompetitors;
            this.prvCompetitors.Enabled = true;
            this.prvCompetitors.Icon = ((System.Drawing.Icon)(resources.GetObject("prvCompetitors.Icon")));
            this.prvCompetitors.Name = "prvCompetitors";
            this.prvCompetitors.Visible = false;
            // 
            // CompetitorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1060, 534);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1078, 581);
            this.MinimumSize = new System.Drawing.Size(1078, 581);
            this.Name = "CompetitorReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Competitor Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Drawing.Printing.PrintDocument printCompetitors;
        private System.Windows.Forms.PrintPreviewDialog prvCompetitors;
    }
}