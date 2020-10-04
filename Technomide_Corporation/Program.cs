using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technomide_Corporation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Login_Signup());
            //Application.Run(new Owner_Form());


            do
            {
                
                
                Application.Run(new Login_Signup());

                if (Login_Signup.State == "Owner")
                {
                    Application.Run(new Owner_Form());
                }

                else if (Login_Signup.State == "Student")
                {
                     MessageBox.Show("Logged in as a Student will be right back soon");
                }
                else if (Login_Signup.State == "Admin")
                {
                    MessageBox.Show("Logged in as a Admin will be right back soon");
                }

                Login_Signup.State = "";


            }
            while (Login_Signup.LogOutStatus);

        }
    }
}
