using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ISCG6421Assignment1
{
    public partial class DataModule : Form
    {
        public DataTable dtArena;
        public DataTable dtChallenge;
        public DataTable dtCompetitor;
        public DataTable dtEntry;
        public DataTable dtEvent;
        public DataTable dtCompReport;
        public DataTable dtEventReport;
        public DataView ArenaView;
        public DataView ChallengeView;
        public DataView CompetitorView;
        public DataView EntryView;
        public DataView EventView;
        public DataView CompReportView;
        public DataView EventReportView;
        public DataModule()
        {
            InitializeComponent();
            Utilities.DM = this;

            readCtnString(); // <-- make ctn from file

            //attempt to fill dataAdapters and dataTables
            try
            {
                dsNZESL.EnforceConstraints = false;
                daArena.Fill(dsNZESL);
                daChallenge.Fill(dsNZESL);
                daCompetitor.Fill(dsNZESL);
                daEntry.Fill(dsNZESL);
                daEvent.Fill(dsNZESL);
                daCompReport.Fill(dsCompReport);
                daEventReport.Fill(dsEventReport);
                dtArena = dsNZESL.Tables["Arena"];
                dtChallenge = dsNZESL.Tables["Challenge"];
                dtCompetitor = dsNZESL.Tables["Competitor"];
                dtEntry = dsNZESL.Tables["Entry"];
                dtEvent = dsNZESL.Tables["Event"];
                dtCompReport = dsCompReport.Tables["Challenge"];
                dtEventReport = dsEventReport.Tables["Arena"];
                dsNZESL.EnforceConstraints = true;
            }
            catch (Exception)
            {
                MessageBox.Show("There is no database file located in the saved directory.\n\nPlease select one now.");
                Utilities.selectDBFile();
            }
        }

        /// <summary>
        /// this region does the updates for each table
        /// </summary>
        #region updateMethods
        public void UpdateArena()
        {
            daArena.Update(dtArena);
        }
        public void UpdateChallenge()
        {
            daChallenge.Update(dtChallenge);
        }
        
        public void UpdateCompetitor()
        {
            daCompetitor.Update(dtCompetitor);
        }
        public void UpdateEvent()
        {
            daEvent.Update(dtEvent);
        }
        public void UpdateEntry()
        {
            daCompReport.Update(dtCompReport);
            daEntry.Update(dtEntry);
        }
        #endregion

        /// <summary>
        /// this region holds the code for setting the primary key upon the RowUpdated event
        /// and ensures that the ID is set to the correct value
        /// </summary>
        #region rowUpdatedMethods
        private void daArena_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNZESL);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ArenaID"] = newID;
            }
        }

        private void daChallenge_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNZESL);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ChallengeID"] = newID;
            }
        }

        private void daCompetitor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNZESL);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CompetitorID"] = newID;
            }
        }

        private void daEvent_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNZESL);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EventID"] = newID;
            }
        }

        private void daEntry_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //no primary key ID is required for this table as it uses a
            //composite primary key of both the ChallengeID and the CompetitorID
        }
        #endregion

        /// <summary>
        /// this method sets the connection string to the sed
        /// </summary>
        /// <param name="fileString"></param>
        public void setDBFilePath(string fileString)
        {
            //set the connection string
            this.ctnNZESL.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"" + fileString + "\"";
            //save the connection string to a file
            Utilities.writeCtnString(fileString);
        }

        /// <summary>
        /// this method reads the connection string from 'connection.txt' and
        /// attempts to set it.
        /// 
        /// It will force the default to be 'C:\Temp\NZESL.mdb' if 'connection.txt' is not found.
        /// 
        /// It will ask the user to select a file if 'NZESL.mdb' does not exist in the location given - default or otherwise.
        /// </summary>
        public void readCtnString()
        {
            //try reading file
            string fileString;
            try
            {
                fileString = File.ReadAllText("connection.txt"); // <-- read the fileString from txt file
            }
            catch (Exception)
            {
                fileString = @"C:\Temp\NZESL.mdb"; // <-- set default if file not found
                MessageBox.Show("Could not find the required database file.\n\nThe default has been set to " + fileString);
            }
            //try set ctn string
            try
            {
                this.ctnNZESL.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"" + fileString + "\"";
            }
            catch (Exception)
            {
                MessageBox.Show("We could not find the file at the following location:\n\n" + fileString + "\n\nPlease select your database file", "Error");
                Utilities.selectDBFile();
            }
        }

        /// <summary>
        /// this method clears the competitor report dataset and then refills it from the data adapter
        /// to ensure report is always up to date with changes made during runtime
        /// </summary>
        public void refreshCompReportDS()
        {
            dsCompReport.Clear();
            daCompReport.Fill(dsCompReport);
        }

        /// <summary>
        /// this method clears the event report dataset and then refills it from the data adapter
        /// to ensure report is always up to date with changes made during runtime
        /// </summary>
        public void refreshEventReportDS()
        {
            dsEventReport.Clear();
            daEventReport.Fill(dsEventReport);
        }
    }
}
