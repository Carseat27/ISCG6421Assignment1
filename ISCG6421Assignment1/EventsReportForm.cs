using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    public partial class EventsReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfReportsPrinted, pagesAmountExpected;
        private DataRow[] reportsForPrint;
        private int eventInfoTracker;
        private ArrayList eventInfo = new ArrayList();
        private ArrayList IDRun = new ArrayList(); // <-- holds the id of competitors that have already been run, so that they do not duplicate
        public EventsReportForm(DataModule dm, MainForm mnu)
        {
            DM = dm;
            frmMenu = mnu;
            InitializeComponent();
        }
 
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            amountOfReportsPrinted = 0;                     // <-- set to zero
            string strFilter = "EventID = EventID";
            string strSort = "EventID, ChallengeID";
            reportsForPrint = DM.dsEventReport.Tables["ARENA"].Select(strFilter, strSort, DataViewRowState.CurrentRows);

            //get number of unique events in the datarow
            ArrayList uniqueEventIDs = new ArrayList();
            foreach(DataRow r in reportsForPrint)
            {
                if (!uniqueEventIDs.Contains((int)r["EventID"]))
                {
                    uniqueEventIDs.Add((int)r["EventID"]);      // <-- add unique compIDs to array to ensure no repeats
                    eventInfo.Add(r);                           // <-- add datarow to array if unique
                }
            }
            pagesAmountExpected = uniqueEventIDs.Count;         // <-- get count of uniques events

            eventInfoTracker = 0;                               // <-- this keeps track of the position in the compInfo array.

            prvEvents.ShowDialog();
        }

        private void printEvents_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printEvents.DefaultPageSettings.PaperSize = new PaperSize("210 x 297 mm", 800, 800); // <-- set page size to A4

            //define the used datarow in the datarow list
            DataRow dr = (DataRow)this.eventInfo[eventInfoTracker];

            //set fonts
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Century Gothic", 10, FontStyle.Regular);
            Font headingFont = new Font("Century Gothic", 10, FontStyle.Regular);
            Font titleFont = new Font("Century Gothic", 20, FontStyle.Underline);

            Brush brush = new SolidBrush(Color.Black);

            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;

            int EventID;

            //make a title
            g.DrawString("Event Report",
                titleFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            //print events with challenges
            EventID = (int)dr["EventID"];       // <-- store eventID

            if (!IDRun.Contains(EventID))       // <-- check if not run yet
            {
                IDRun.Add(EventID);             // <-- add eventID to IDRun array

                //draw event details heading
                g.DrawString("Event ID:",
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                g.DrawString("________",
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                g.DrawString(EventID.ToString().PadLeft(20),
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;

                g.DrawString(dr["EventName"].ToString(),
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                g.DrawString(dr["ArenaName"].ToString(),
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                g.DrawString(dr["StreetAddress"].ToString(),
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                g.DrawString(dr["Suburb"].ToString(),
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                g.DrawString(dr["City"].ToString(),
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;

                g.DrawString("Event Date: ",
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                g.DrawString(dr["EventDate"].ToString().Split(' ')[0].ToString().PadLeft(35),
                    headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;

                g.DrawString("Challenges:",
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

                //loop through all events again for challenges
                foreach (DataRow dr2 in DM.dtEventReport.Rows)
                {
                    if ((int)dr2["EventID"] == EventID) // <-- make sure all challenges have the same eventID
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

                if(eventInfoTracker < eventInfo.Count)
                {
                    eventInfoTracker++;     // <-- increase the used array list index
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
