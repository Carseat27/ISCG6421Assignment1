using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    public partial class ChallengeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public ChallengeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }
        private void BindControls()
        {
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteArena_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateArena_Click(object sender, EventArgs e)
        {

        }

        private void btnAddArena_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
