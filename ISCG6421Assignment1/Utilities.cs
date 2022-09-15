using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCG6421Assignment1
{
    class Utilities
    {

        public static MainForm frmMenu;
        public static DataModule DM;

        /// <summary>
        /// this method makes the buttons on each form enable or disable on request
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="enabled"></param>
        public static void ButtonsMagic(Button[] buttons, bool enabled)
        {
            foreach (Button button in buttons)
            {
                button.Enabled = enabled;
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


        /// <summary>
        /// this method allows the user to select the NZESL.mdb file location and saves it for future reference
        /// </summary>
        public static void selectDBFile()
        {
            OpenFileDialog DBFile = new OpenFileDialog(); // <-- create file dialog
            DBFile.Filter = "Access files (*.mdb)|*.mdb"; // <-- set file filter
            DialogResult result = DBFile.ShowDialog();    // <-- user to choose file
            if (result == DialogResult.OK)
            {
                if (DBFile.FileName.Equals("NZESL.mdb")) // <-- check that the file name is correct
                {
                    try
                    {
                        DM.setDBFilePath(DBFile.FileName); // <-- set the connection string in the DataModule

                        //restart application
                        MessageBox.Show("The application will now restart to apply changes.", "Warning");
                        Application.Restart(); 
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unexpected error encountered.\n\nPlease try again", "Error");
                        selectDBFile();
                    }
                }
                else
                {
                    Utilities.DBExceptionError();
                }
            }
        }

        /// <summary>
        /// this method writes the passed connection string 
        /// </summary>
        /// <param name="fileString"></param>
        public static void writeCtnString(string fileString)
        {
            File.WriteAllText("connection.txt", fileString); // <-- write the fileString to txt file
        }
    }
}
