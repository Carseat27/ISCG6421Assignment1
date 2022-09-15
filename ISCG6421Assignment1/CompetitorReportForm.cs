using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
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
            //string strFilter = "Competitor.CompetitorID IN (SELECT Competitor.CompetitorID FROM Entry GROUP BY Competitor.CompetitorID HAVING COUNT(Competitor.CompetitorID) > 0 )";
            string strFilter = "ChallengeID = ChallengeID";
            string strSort = "CompetitorID";
            reportsForPrint = DM.dsCompReport.Tables["CHALLENGE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            Console.WriteLine(reportsForPrint);
            pagesAmountExpected = reportsForPrint.Length;
            prvCompetitors.ShowDialog();
        }

        private void printCompetitors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            prvCompetitors.Size = new System.Drawing.Size(630, 891);
            printCompetitors.DefaultPageSettings.PaperSize = new PaperSize("210 x 297 mm", 800, 800); // <-- set page size to A4
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
            DataRow dr = DM.dtCompReport.Rows[cmEntry.Position];
            Console.Write(dr["CompetitorID"]);

            g.DrawString("Competitor ID: ".PadRight(15) + dr["CompetitorID"],
                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading+=2;
            g.DrawString("Username: ".PadRight(20) + dr["UserName"],
                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Name: ".PadRight(24) + dr["FirstName"] + " " + dr["LastName"],
                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Gender: ".PadRight(22) + dr["Gender"],
                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Date of Birth: ".PadRight(15) + dr["DateOfBirth"].ToString().Split(' ')[0],
                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Email: ".PadRight(23) + dr["EmailAddress"],
                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading+=2;
            g.DrawString("Entries: ",
                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading+=2;
            g.DrawString("Challenge ID".PadRight(17) + "Challenge Name".PadRight(16) + "Start Time".PadRight(20),
                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            //g.DrawString("Challenge Name".PadRight(16),
            //    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            //g.DrawString("Start Time".PadRight(20),
            //    headingFont, brush, leftMargin + headingLeftMargin, topMargin =(linesSoFarHeading * textFont.Height));
            linesSoFarHeading+=2;

            //g.DrawString();
        }
    }
}
