using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technomide_Corporation;
using System.Windows.Forms;

namespace ConsoleApplication3
{
    class ErrorHandling
    {
        public void GetError(int ErrNumber)
        {
            string Error = "";
            if (ErrNumber==2)
            {
                Error = "Server Agent not Running";
            }
            else if (ErrNumber>=100 && ErrNumber <=999)
            {
                Error = "Error In Sql Syntex";
            }
            else if (ErrNumber == 8114)
            {
                Error = "Parameter Type MissMatch";
            }
            else if (ErrNumber == 53)
            {
                Error = "Connection string error";
            }
            else if (ErrNumber == 2812)
            {
                Error = "Procedure Not Found";
            }
            else if (ErrNumber == 512)
            {
                Error = "In SubQuery More Than One values returns";
            }
            else
            {
                Error = "Unhandled Error";
            }

            MessageBox.Show(Error,"Error Handling",MessageBoxButtons.OK,MessageBoxIcon.Error);
          
        }
    }
}
