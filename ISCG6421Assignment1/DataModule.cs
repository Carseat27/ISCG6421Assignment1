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
        public DataView ArenaView;
        public DataView ChallengeView;
        public DataView CompetitorView;
        public DataView EntryView;
        public DataView EventView;
        public DataView CompReportView;
        public DataModule()
        {
            InitializeComponent();
            Utilities.DM = this;

            readCtnString(); // <-- make ctn from file

            try
            {
                dsNZESL.EnforceConstraints = false;
                daArena.Fill(dsNZESL);
                daChallenge.Fill(dsNZESL);
                daCompetitor.Fill(dsNZESL);
                daEntry.Fill(dsNZESL);
                daEvent.Fill(dsNZESL);
                daCompReport.Fill(dsCompReport);
                dtArena = dsNZESL.Tables["Arena"];
                dtChallenge = dsNZESL.Tables["Challenge"];
                dtCompetitor = dsNZESL.Tables["Competitor"];
                dtEntry = dsNZESL.Tables["Entry"];
                dtEvent = dsNZESL.Tables["Event"];
                dtCompReport = dsCompReport.Tables["Challenge"];
                dsNZESL.EnforceConstraints = true;
            }
            catch (Exception)
            {
                MessageBox.Show("There is no database file located in the saved directory.\n\nPlease select one now.");
                Utilities.selectDBFile();
            }
        }
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
            daEntry.Update(dtEntry);
        }

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

        }

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
                //Utilities.writeCtnString(fileString); // <-- create the file and write the default string
                MessageBox.Show("Could not find the required database file.\n\nThe default has been set to " + fileString);
            }
            //try set ctn string
            try
            {
                this.ctnNZESL.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"" + fileString + "\"";
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error has been encountered.\n\nPlease select your database file", "Error");
                Utilities.selectDBFile();
            }
        }
    }
}
