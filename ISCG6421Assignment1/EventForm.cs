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
    public partial class EventForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private int step;
        private Button[] controls;
        public EventForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            controls = new Button[] { btnNext, btnPrevious, btnAddEvent, btnUpdateEvent, btnDeleteEvent, btnReturn };
            step = 0;
        }
        private void BindControls()
        {
            txtEventID.DataBindings.Add("Text", DM.dsNZESL, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsNZESL, "Event.EventName");
            txtArenaID.DataBindings.Add("Text", DM.dsNZESL, "Event.ArenaID");
            txtArenaName.DataBindings.Add("Text", DM.dsNZESL, "Event.ArenaName");
            txtEventStatus.DataBindings.Add("Text", DM.dsNZESL, "Event.Status");
            txtEventCapacity.DataBindings.Add("Text", DM.dsNZESL, "Event.Capacity");
            txtEventDate.DataBindings.Add("Text", DM.dsNZESL, "Event.EventDate");
            lstEvents.DataSource = DM.dsNZESL;
            lstEvents.DisplayMember = "Event.EventName";
            lstEvents.ValueMember = "Event.EventID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZESL, "Event"];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }
    }
}
