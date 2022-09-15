using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    public partial class CompetitorReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfReportsPrinted, pagesAmountExpected;
        private DataRow[] reportsForPrint;
        public CompetitorReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            
        }
        private void BindControls()
        {
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            amountOfReportsPrinted = 0;
            string strFilter = "Competitor.CompetitorID IN (SELECT CompetitorID FROM Entry GROUP BY CompetitorID HAVING COUNT(CompetitorID) > 0 )";
            string strSort = "CompetitorID";
            reportsForPrint = DM.dsNZESL.Tables["COMPETITOR"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = reportsForPrint.Length;
            prvCompetitors.Show();
        }

        private void printCompetitors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Century Gothic", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Century Gothic", 10, FontStyle.Regular);
            Font headingFont = new Font("Century Gothic", 10, FontStyle.Regular);
            DataRow drEntry = reportsForPrint[amountOfReportsPrinted];
            CurrencyManager cmEntry;

            cmEntry = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Entry"];

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;


            //heading
            foreach(DataRow dr in DM.dtCompReport.Rows)
            {
                Console.Write(dr["CompetitorID"]);

                g.DrawString("Competitor ID: ".PadRight(20) + dr["CompetitorID"],
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Username: ".PadRight(20) + dr["UserName"].ToString(),
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                //g.DrawString()

            }

            //g.DrawString();
        }
    }
}
