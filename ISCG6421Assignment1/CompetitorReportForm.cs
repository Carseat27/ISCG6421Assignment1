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
/// <summary>
/// this class runs the competitor report form.
/// From here, the user can print out the competitor report to a printPreviewDialog,
/// then choose to save or print it from there.
/// Author: Carson Loveday
/// Date Finished: 22/09/2022
namespace ISCG6421Assignment1
{
    public partial class CompetitorReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfReportsPrinted, pagesAmountExpected;
        private DataRow[] reportsForPrint;
        private int compDataRowTracker;
        private ArrayList compDataRowList;
        private ArrayList IDRun; // <-- holds the id of competitors that have already been run, so that they do not duplicate
        public CompetitorReportForm(DataModule dm, MainForm mnu)
        {
            DM = dm;
            frmMenu = mnu;
            InitializeComponent();
        }

        /// <summary>
        /// close the form
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// user clicks on print report
        /// </summary>
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            compDataRowList = new ArrayList();
            IDRun = new ArrayList();

            amountOfReportsPrinted = 0;                         // <-- set to zero
            string strFilter = "ChallengeID = ChallengeID";
            string strSort = "CompetitorID, ChallengeID";
            reportsForPrint = DM.dsCompReport.Tables["CHALLENGE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);

            //get the number of unique competitors in the datarow
            ArrayList uniqueCompIDs = new ArrayList();
            foreach (DataRow r in reportsForPrint)
            {
                if (!uniqueCompIDs.Contains((int)r["CompetitorID"]))
                {
                    uniqueCompIDs.Add((int)r["CompetitorID"]);      // <-- add unique compIDs to array to ensure no repeats
                    compDataRowList.Add(r);                         // <-- add datarow to array if unique
                }
            }
            pagesAmountExpected = uniqueCompIDs.Count;              // <-- get count of unique competitors

            compDataRowTracker = 0;                                 // <-- this keeps track of the position in the compDataRowList array.

            prvCompetitors.ShowDialog();
        }

        /// <summary>
        /// print the report
        /// </summary>
        private void printCompetitors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printCompetitors.DefaultPageSettings.PaperSize = new PaperSize("210 x 297 mm", 800, 800); // <-- set page size to A4

            //define the used datarow in the datarow list using the tracker
            DataRow dr = (DataRow)compDataRowList[compDataRowTracker];

            //set fonts
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Century Gothic", 10, FontStyle.Regular);
            Font headingFont = new Font("Century Gothic", 10, FontStyle.Regular);
            Font titleFont = new Font("Century Gothic", 20, FontStyle.Underline);

            Brush brush = new SolidBrush(Color.Black);

            //set margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;

            int CompID;

            //make a title
            g.DrawString("Entry Report by Competitor",
                titleFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            //print competitor with entries
            int HEADING_PAD_LEFT = 50;                  // <-- define padding
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

                if (compDataRowTracker < compDataRowList.Count)
                {
                    compDataRowTracker++;       // <-- increase the used arraylist index
                    if (!(amountOfReportsPrinted >= pagesAmountExpected))
                    {
                        e.HasMorePages = true;
                        return;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
            }
        }
    }
}
