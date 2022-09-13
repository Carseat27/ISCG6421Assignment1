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
        /// this method checks the validity of an inputted email and returns true or false
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true/false</returns>
        public static bool EmailCheck(string email)
        {
            return email.Contains("@");
        }

        /// <summary>
        /// this method displays an error message.
        /// it is called when an exception is caught during adding, updating, or deleting any of the Database entities
        /// </summary>
        public static void DBExceptionError()
        {
            MessageBox.Show("There has been an unexpected error.\n\nPlease check that you are using 'NZESL.mdb' as provided.", "Error");
        }
    }
}
