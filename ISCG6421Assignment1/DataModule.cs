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

namespace ISCG6421Assignment1
{
    public partial class DataModule : Form
    {
        public DataTable dtArena;
        public DataTable dtChallenge;
        public DataTable dtCompetitor;
        public DataTable dtEntry;
        public DataTable dtEvent;
        public DataView ArenaView;
        public DataView ChallengeView;
        public DataView CompetitorView;
        public DataView EntryView;
        public DataView EventView;
        public DataModule()
        {
            InitializeComponent();
            dsNZESL.EnforceConstraints = false;
            daArena.Fill(dsNZESL);
            daChallenge.Fill(dsNZESL);
            daCompetitor.Fill(dsNZESL);
            daEntry.Fill(dsNZESL);
            daEvent.Fill(dsNZESL);
            dtArena = dsNZESL.Tables["Arena"];
            dtChallenge = dsNZESL.Tables["Challenge"];
            dtCompetitor = dsNZESL.Tables["Competitor"];
            dtEntry = dsNZESL.Tables["Entry"];
            dtEvent = dsNZESL.Tables["Event"];
            dsNZESL.EnforceConstraints = true;
        }
        public void UpdateArena()
        {
            daArena.Update(dtArena);
        }
        public void UpdateChallenge()
        {
            daChallenge.Update(dtChallenge);
        }

        private void daArena_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNZESL);

            if(e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ArenaID"] = newID;
            }
        }

        private void daChallenge_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNZESL);
            if(e.StatementType == StatementType.Insert)
            {
                newID= (int)idCMD.ExecuteScalar();
                e.Row["ChallengeID"] = newID;
            }
        }
    }
}
