using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technomide_Corporation;

namespace ConsoleApplication3
{
    class Model_Dashboard
    {
        string startMonth = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + "01";
        string endMonth = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString();
            

        public string Get_TotalEmployees()
        {
            return DashBoard_Data("exec count_employees");
        }
        public string Get_MarkedEmployees()
        {
            return DashBoard_Data("exec attendence_marked");
        }


        public string Get_UnmarkedEmployees()
        {
            
            return DashBoard_Data("exec attendence_Unmarked");
        }

        public string Get_TotalProjects()
        {
            return DashBoard_Data("exec total_project");
        }
        public string Get_CompletedProjects()
        {
            return DashBoard_Data("exec project_completed");
        }
        public string Get_OngoingProjects()
        {
            return DashBoard_Data("exec ongoing_project");
        }

        public string Get_PhysicalEmployees()
        {
            return DashBoard_Data("exec physical_appearence");
        }

        public string Get_RemotelyEmployees()
        {
            return DashBoard_Data("exec remotely_working");
        }

        public string Get_TotalConsultants()
        {
            return DashBoard_Data("exec total_consultant");
        }

        public string Get_ActiveConsultants()
        {
            return DashBoard_Data("exec Active_consultant");
        }

        public string Get_InactiveConsultants()
        {
            return DashBoard_Data("exec NotActive_consultant");
        }
        public string Get_TodayExpense()
        {
            return DashBoard_Data("exec Total_Expense_Today '" + DateTime.Now.ToString() + "' ");
        }

        public string Get_MonthExpense()
        {
            return DashBoard_Data("exec Total_Expense_Month '" + startMonth + "', '" + endMonth + "'");
        }

        public string Get_TodayIncome()
        {
            return DashBoard_Data(" exec Total_Income_Today '" + DateTime.Now.ToString() + "' ");

        }

        public string Get_MonthIncomes()
        {
            return DashBoard_Data("exec Total_Income_Month '" + startMonth + "', '" + endMonth + "'");

        }

        public string Get_AcademyIncome()
        {
            return DashBoard_Data("exec Academy_Income_Month '" + startMonth + "', '" + endMonth + "'");

        }

        public string Get_ProjectIncome()
        {
            return DashBoard_Data("exec Project_Income_Month '" + startMonth + "', '" + endMonth + "'");

        }
        public string Get_OwnerAccount()
        {
            return DashBoard_Data("exec total_users 1");
        }
        public string Get_AdminAccount()
        {
            return DashBoard_Data("exec total_users 3");
        }
        public string Get_StudentAccount()
        {
            return DashBoard_Data("exec total_users 2");
        }




        string DashBoard_Data(string q)
        {
            SqlCommand dbCommand = new SqlCommand(q, Database_Connection.con);
            Database_Connection.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(dbCommand);

            DataTable dt = new DataTable();
            try
            {
                sda.Fill(dt);
            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
            }
            finally
            {
                Database_Connection.con.Close();
            }

            return dt.Rows[0][0].ToString();
        }
    }
}
