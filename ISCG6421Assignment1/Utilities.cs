using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    class Utilities
    {

        public static MainForm frmMenu;
        /// <summary>
        /// this method makes the buttons on each form enable or disable on request
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="enabled"></param>
        public static void ButtonsMagic(Button[] buttons, bool enabled)
        {
            //foreach (Button button in buttons)
            //{
            //    button.Enabled = enabled;
            //}
            Console.WriteLine(buttons);
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = enabled;
            }
        }

        /// <summary>
        /// this method ensures that the child form (Arena) will make the parent form (MainForm) move with it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static int Movement(int step, object sender, EventArgs e)
        {
            Console.WriteLine(step);
            if (step != 0)
            {
                frmMenu.On_Move(sender, e);
            }
            else if (step == 0)
            {
                step = 1;
            }
            return step;
        }
    }
}
