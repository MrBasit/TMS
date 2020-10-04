using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication3;

namespace Technomide_Corporation
{
    public partial class Dashboard_form : Form
    {
        public Dashboard_form()
        {
            InitializeComponent();
        }
        public void Calling_LoadFrom(object sender, EventArgs e)
        {
            Dashboard_form_Load(sender, e);
        }

        Model_Dashboard cls_dashboard = new Model_Dashboard();

        private void Dashboard_form_Load(object sender, EventArgs e)
        {

            UC_Show_Total_Employees.label_function_name.Text = "Total Employees";
            UC_Show_Total_Employees.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Total_Employees.label_count.Text = cls_dashboard.Get_TotalEmployees();

            UC_Show_Marked_Attendance.label_function_name.Text = "Marked Employees";
            UC_Show_Marked_Attendance.picture_logo.Image = Properties.Resources.marked_Attendance;
            UC_Show_Marked_Attendance.label_count.Text = cls_dashboard.Get_MarkedEmployees();

            UC_Show_Unmarked_Attendance.label_function_name.Text = "Unmarked Employees";
            UC_Show_Unmarked_Attendance.picture_logo.Image = Properties.Resources.unmarked_attendance;
            UC_Show_Unmarked_Attendance.label_count.Text = cls_dashboard.Get_UnmarkedEmployees();

            UC_Show_Total_Projects.label_function_name.Text = "Total Projects";
            UC_Show_Total_Projects.picture_logo.Image = Properties.Resources.Project_icon;
            UC_Show_Total_Projects.label_count.Text = cls_dashboard.Get_TotalProjects();

            UC_Show_Completed_Projects.label_function_name.Text = "Completed Projects";
            UC_Show_Completed_Projects.picture_logo.Image = Properties.Resources.completed_project;
            UC_Show_Completed_Projects.label_count.Text = cls_dashboard.Get_CompletedProjects();

            UC_Show_Ongoing_Projects.label_function_name.Text = "Ongoing Projects";
            UC_Show_Ongoing_Projects.picture_logo.Image = Properties.Resources.ongoing_projects;
            UC_Show_Ongoing_Projects.label_count.Text = cls_dashboard.Get_OngoingProjects();

            UC_Show_Total_Employees_1.label_function_name.Text = "Total Employees";
            UC_Show_Total_Employees_1.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Total_Employees_1.label_count.Text = cls_dashboard.Get_TotalEmployees();

            UC_Show_Physical_Employees.label_function_name.Text = "Physical Employees";
            UC_Show_Physical_Employees.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Physical_Employees.label_count.Text = cls_dashboard.Get_PhysicalEmployees();

            UC_Show_Remotely_Employees.label_function_name.Text = "Remotely Employees";
            UC_Show_Remotely_Employees.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Remotely_Employees.label_count.Text = cls_dashboard.Get_RemotelyEmployees();

            UC_Show_Total_Consultant.label_function_name.Text = "Total Consultants";
            UC_Show_Total_Consultant.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Total_Consultant.label_count.Text = cls_dashboard.Get_TotalConsultants();

            UC_Show_Active_Consultant.label_function_name.Text = "Active Consultants";
            UC_Show_Active_Consultant.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Active_Consultant.label_count.Text = cls_dashboard.Get_ActiveConsultants();

            UC_Show_Inactive_Consultant.label_function_name.Text = "Inactive Consultants";
            UC_Show_Inactive_Consultant.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Inactive_Consultant.label_count.Text = cls_dashboard.Get_InactiveConsultants();

            UC_Show_Today_Expense.label_function_name.Text = "Today Expense";
            UC_Show_Today_Expense.picture_logo.Image = Properties.Resources.expenses;
            UC_Show_Today_Expense.label_count.Text = cls_dashboard.Get_TodayExpense();

            UC_Show_Monthly_Expense.label_function_name.Text = "Month Expense";
            UC_Show_Monthly_Expense.picture_logo.Image = Properties.Resources.expenses;
            UC_Show_Monthly_Expense.label_count.Text = cls_dashboard.Get_MonthExpense();

            UC_Show_Today_Income.label_function_name.Text = "Today Income";
            UC_Show_Today_Income.picture_logo.Image = Properties.Resources.incomeicon;
            UC_Show_Today_Income.label_count.Text = cls_dashboard.Get_TodayIncome();

            UC_Show_Month_Income.label_function_name.Text = "Month Income";
            UC_Show_Month_Income.picture_logo.Image = Properties.Resources.incomeicon;
            UC_Show_Month_Income.label_count.Text = cls_dashboard.Get_MonthIncomes();

            UC_Show_Academy_Income.label_function_name.Text = "Academy Income";
            UC_Show_Academy_Income.picture_logo.Image = Properties.Resources.incomeicon;
            UC_Show_Academy_Income.label_count.Text = cls_dashboard.Get_AcademyIncome();

            UC_Show_Project_Income.label_function_name.Text = "Project Income";
            UC_Show_Project_Income.picture_logo.Image = Properties.Resources.incomeicon;
            UC_Show_Project_Income.label_count.Text = cls_dashboard.Get_ProjectIncome();

            UC_Show_Owner_Account.label_function_name.Text = "Owner Account";
            UC_Show_Owner_Account.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Owner_Account.label_count.Text = cls_dashboard.Get_OwnerAccount();

            UC_Show_Admin_Account.label_function_name.Text = "Admin Account";
            UC_Show_Admin_Account.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Admin_Account.label_count.Text = cls_dashboard.Get_AdminAccount();

            UC_Show_Student_Account.label_function_name.Text = "Student Account";
            UC_Show_Student_Account.picture_logo.Image = Properties.Resources.employee;
            UC_Show_Student_Account.label_count.Text = cls_dashboard.Get_StudentAccount();

        }


        public string DashBoard_Data(string q)
        {
            SqlCommand dbCommand = new SqlCommand(q, Database_Connection.con);
            Database_Connection.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(dbCommand);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            Database_Connection.con.Close();

            return dt.Rows[0][0].ToString();
        }

    }
}
