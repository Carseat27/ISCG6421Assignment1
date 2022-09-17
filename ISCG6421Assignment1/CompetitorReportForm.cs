using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
            this.Close();
        }


        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            amountOfReportsPrinted = 0;
            string strFilter = "ChallengeID = ChallengeID";
            string strSort = "CompetitorID, ChallengeID";
            reportsForPrint = DM.dsCompReport.Tables["CHALLENGE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);

            //get the number of unique competitors in the datarow
            ArrayList uniqueCompIDs = new ArrayList();
            foreach (DataRow r in reportsForPrint)
            {
                if (!uniqueCompIDs.Contains((int)r["CompetitorID"]))
                {
                    uniqueCompIDs.Add((int)r["CompetitorID"]);
                }
            }
            pagesAmountExpected = uniqueCompIDs.Count;
            prvCompetitors.ShowDialog();
        }

        private void printCompetitors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //prvCompetitors.Size = new System.Drawing.Size(420, 594);
            //printCompetitors.DefaultPageSettings.PaperSize = new PaperSize("210 x 297 mm", 800, 800); // <-- set page size to A4

            //set fonts
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Century Gothic", 10, FontStyle.Regular);
            //Font textFontCenter = new Font("Century Gothic", 10, FontStyle.Regular);
            Font headingFont = new Font("Century Gothic", 10, FontStyle.Regular);
            Font titleFont = new Font("Century Gothic", 20, FontStyle.Underline);

            //float linesPerPage = e.MarginBounds.Height / headingFont.GetHeight(e.Graphics);

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            //int topMarginDetails = topMargin + 70;
            //int rightMargin = e.MarginBounds.Right;
            //float pageHeight = e.PageSettings.PrintableArea.Height;

            int CompID;
            ArrayList IDRun = new ArrayList(); // <-- holds the id of competitors that have already been run, so that they do not duplicate

            //make a title
            g.DrawString("Entry Report by Competitor",
                titleFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            //loop through all entries
            foreach (DataRow dr in DM.dtCompReport.Rows)    // <-- loop through each row
            {
                int HEADING_PAD_LEFT = 50;
                CompID = (int)dr["CompetitorID"];           // <-- store competitorID

                if (!IDRun.Contains(CompID))                // <-- check if CompID has not been used yet
                {
                    IDRun.Add(CompID);                      // <-- add CompID to IDRun array 

                    //draw competitor details heading
                    g.DrawString("Competitor ID: ",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString("______________",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(CompID.ToString().PadLeft(HEADING_PAD_LEFT),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                    linesSoFarHeading++;

                    g.DrawString("Username: ",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(dr["UserName"].ToString().PadLeft(HEADING_PAD_LEFT),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;

                    g.DrawString("Name: ",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString((dr["FirstName"].ToString() + " " + dr["LastName"].ToString()).PadLeft(HEADING_PAD_LEFT),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;

                    g.DrawString("Gender: ",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(dr["Gender"].ToString().PadLeft(HEADING_PAD_LEFT),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;

                    g.DrawString("Date of Birth: ",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(dr["DateOfBirth"].ToString().Split(' ')[0].ToString().PadLeft(HEADING_PAD_LEFT),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;

                    g.DrawString("Email: ",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(dr["EmailAddress"].ToString().PadLeft(HEADING_PAD_LEFT),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                    linesSoFarHeading++;

                    g.DrawString("Entries: ",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString("_______",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                    linesSoFarHeading++;

                    g.DrawString("Challenge ID",
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString("Challenge Name".PadLeft(50),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString("Start Time".PadLeft(100),
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                    linesSoFarHeading++;

                    //loop through all entries again for the challenges
                    foreach (DataRow dr2 in DM.dtCompReport.Rows)
                    {
                        if ((int)dr2["CompetitorID"] == CompID) // <-- make sure all challenges have the same compID
                        {
                            g.DrawString(dr2["ChallengeID"].ToString(),
                                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                            g.DrawString(dr2["ChallengeName"].ToString().PadLeft(50),
                                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                            g.DrawString((dr2["StartTime"].ToString().Split(' ')[1] + " " + dr2["StartTime"].ToString().Split(' ')[2]).PadLeft(100),
                                headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                            linesSoFarHeading++;
                        }
                    }
                    linesSoFarHeading++;
                    linesSoFarHeading++;
                    linesSoFarHeading++;
                    amountOfReportsPrinted++;

                    if (!(amountOfReportsPrinted >= pagesAmountExpected))
                    {
                        e.HasMorePages = true;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                    //if ((linesSoFarHeading * textFont.Height) >= e.PageSettings.PrintableArea.Height)
                    //{
                    //    e.HasMorePages = true;
                    //    Console.WriteLine(e.HasMorePages);
                    //}
                    //else
                    //{
                    //    e.HasMorePages = false;
                    //    Console.WriteLine(e.HasMorePages);
                    //}
                    //e.HasMorePages = (!(amountOfReportsPrinted >= pagesAmountExpected));
                    //if (!(amountOfReportsPrinted >= pagesAmountExpected))
                    //{
                    //    Console.WriteLine(pagesAmountExpected + " pages Expected");
                    //    Console.WriteLine(amountOfReportsPrinted + " reports printed");
                    //    e.HasMorePages = true;
                    //    Console.WriteLine(e.HasMorePages);
                    //    //return;
                    //}
                    //else
                    //{
                    //    e.HasMorePages = false;
                    //    Console.WriteLine(e.HasMorePages);
                    //}

                }
            }
        }
    }
}
