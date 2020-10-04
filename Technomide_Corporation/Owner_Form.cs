using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technomide_Corporation
{
    public partial class Owner_Form : Form
    {
        public Owner_Form()
        {
            InitializeComponent();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            label_UserName.Text = Login_Signup.UserName;
            UC_Dashboard_Menu.label_function.Text = "DASHBOARD";
            UC_Attendance_Menu.label_function.Text = "Attendance";
            UC_Employee_Menu.label_function.Text = "Employees";
            UC_CONSULTANT_MENU.label_function.Text = "Consultants";
            UC_PROJECTS_MENU.label_function.Text = "Projects";
            UC_Expense_Menu.label_function.Text = "Expense";
            UC_Income_Menu.label_function.Text = "Income";
            UC_login_Meun.label_function.Text = "Login Account";
            UC_withdrawl_Menu.label_function.Text = "Withdrawl";
            UC_About_Menu.label_function.Text = "About Us";

            dash_form = new Dashboard_form();
            panel_menu.Hide();
            panel_main.Controls.Clear();
            dash_form.TopLevel = false;
            dash_form.Left = 0;
            panel_main.Controls.Add(dash_form);
            dash_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;

            UC_About_Menu.label_function.Click += new EventHandler(UC_About_Menu_Click);
            UC_Attendance_Menu.label_function.Click += new EventHandler(UC_Attendance_Menu_Click);
            UC_CONSULTANT_MENU.label_function.Click += new EventHandler(UC_CONSULTANT_MENU_Click);
            UC_Dashboard_Menu.label_function.Click += new EventHandler(UC_Dashboard_Menu_Click);
            UC_Employee_Menu.label_function.Click += new EventHandler(UC_Employee_Menu_Click);
            UC_Expense_Menu.label_function.Click += new EventHandler(UC_Expense_Menu_Click);
            UC_Income_Menu.label_function.Click += new EventHandler(UC_Income_Menu_Click);
            UC_login_Meun.label_function.Click += new EventHandler(UC_login_Meun_Click);
            UC_PROJECTS_MENU.label_function.Click += new EventHandler(UC_PROJECTS_MENU_Click);
            UC_withdrawl_Menu.label_function.Click += new EventHandler(UC_withdrawl_Menu_Click);


            UC_About_Menu.picture_logo_uc.Click += new EventHandler(UC_About_Menu_Click);
            UC_Attendance_Menu.picture_logo_uc.Click += new EventHandler(UC_Attendance_Menu_Click);
            UC_CONSULTANT_MENU.picture_logo_uc.Click += new EventHandler(UC_CONSULTANT_MENU_Click);
            UC_Dashboard_Menu.picture_logo_uc.Click += new EventHandler(UC_Dashboard_Menu_Click);
            UC_Employee_Menu.picture_logo_uc.Click += new EventHandler(UC_Employee_Menu_Click);
            UC_Expense_Menu.picture_logo_uc.Click += new EventHandler(UC_Expense_Menu_Click);
            UC_Income_Menu.picture_logo_uc.Click += new EventHandler(UC_Income_Menu_Click);
            UC_login_Meun.picture_logo_uc.Click += new EventHandler(UC_login_Meun_Click);
            UC_PROJECTS_MENU.picture_logo_uc.Click += new EventHandler(UC_PROJECTS_MENU_Click);
            UC_withdrawl_Menu.picture_logo_uc.Click += new EventHandler(UC_withdrawl_Menu_Click);


            UC_login_Meun.picture_logo_uc.Image = Properties.Resources.Login_in_icon;
            UC_login_Meun.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_Expense_Menu.picture_logo_uc.Image = Properties.Resources.Coins_icon;
            UC_Expense_Menu.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_Income_Menu.picture_logo_uc.Image = Properties.Resources.Money_2_icon;
            UC_Income_Menu.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_Employee_Menu.picture_logo_uc.Image = Properties.Resources.employee;
            UC_Employee_Menu.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_PROJECTS_MENU.picture_logo_uc.Image = Properties.Resources.Project_icon;
            UC_PROJECTS_MENU.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_Attendance_Menu.picture_logo_uc.Image = Properties.Resources.attendance;
            UC_Attendance_Menu.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_withdrawl_Menu.picture_logo_uc.Image = Properties.Resources.Bank_icon;
            UC_withdrawl_Menu.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_About_Menu.picture_logo_uc.Image = Properties.Resources.about;
            UC_About_Menu.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_Dashboard_Menu.picture_logo_uc.Image = Properties.Resources.home_icon;
            UC_Dashboard_Menu.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;
            UC_CONSULTANT_MENU.picture_logo_uc.Image = Properties.Resources.Users_Group_icon;
            UC_CONSULTANT_MENU.picture_logo_uc.SizeMode = PictureBoxSizeMode.StretchImage;


            dash_form.btn_Attendance.Click += new EventHandler(UC_Attendance_Menu_Click);
            dash_form.btn_Projects.Click += new EventHandler(UC_PROJECTS_MENU_Click);
            dash_form.btn_Employees.Click += new EventHandler(UC_Employee_Menu_Click);
            dash_form.btn_Consultant.Click += new EventHandler(UC_CONSULTANT_MENU_Click);
            dash_form.btn_Expense.Click += new EventHandler(UC_Expense_Menu_Click);
            dash_form.btn_Income.Click += new EventHandler(UC_Income_Menu_Click);
            dash_form.btn_Accounts.Click += new EventHandler(UC_login_Meun_Click);

        }

        Dashboard_form dash_form = new Dashboard_form();
        Expense_Form exp_form;
        Attendance_Form att_form;
        Consultants_Form cons_form;
        Employee_Form emp_form;
        Login_form log_form;
        Projects_form proj_form;
        Withdrawl_form with_form;
        About_form about_form;
        Income_form inc_form;

        int count = 0;

        private void pic_burger_menu_Click(object sender, EventArgs e)
        {

            Owner_Form own = new Owner_Form();


            if (count == 0)
            {
                panel_menu.Show();
                count++;
            }

            else if (count == 1)
            {
                panel_menu.Hide();
                count--;
            }

        }

        private void UC_About_Menu_Load(object sender, EventArgs e)
        {

        }

        private void UC_About_Menu_Click(object sender, EventArgs e)
        {
            about_form = new About_form();
            panel_main.Controls.Clear();
            about_form.TopLevel = false;
            about_form.Left = 0;
            panel_main.Controls.Add(about_form);
            about_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_Dashboard_Menu_Click(object sender, EventArgs e)
        {
            dash_form.Calling_LoadFrom(sender, e);
            panel_main.Controls.Clear();
            dash_form.TopLevel = false;
            dash_form.Left = 0;
            panel_main.Controls.Add(dash_form);
            dash_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_Attendance_Menu_Click(object sender, EventArgs e)
        {
            att_form = new Attendance_Form();
            panel_main.Controls.Clear();
            att_form.TopLevel = false;
            att_form.Left = 0;
            panel_main.Controls.Add(att_form);
            att_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_Employee_Menu_Click(object sender, EventArgs e)
        {
            emp_form = new Employee_Form();
            panel_main.Controls.Clear();
            emp_form.TopLevel = false;
            emp_form.Left = 0;
            panel_main.Controls.Add(emp_form);
            emp_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_CONSULTANT_MENU_Click(object sender, EventArgs e)
        {
            cons_form = new Consultants_Form();
            panel_main.Controls.Clear();
            cons_form.TopLevel = false;
            cons_form.Left = 0;
            panel_main.Controls.Add(cons_form);
            cons_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_PROJECTS_MENU_Click(object sender, EventArgs e)
        {
            proj_form = new Projects_form();
            panel_main.Controls.Clear();
            proj_form.TopLevel = false;
            proj_form.Left = 0;
            panel_main.Controls.Add(proj_form);
            proj_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_Expense_Menu_Click(object sender, EventArgs e)
        {

            exp_form = new Expense_Form();
            panel_main.Controls.Clear();
            exp_form.TopLevel = false;
            exp_form.Left = 0;
            panel_main.Controls.Add(exp_form);
            exp_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_Income_Menu_Click(object sender, EventArgs e)
        {
            inc_form = new Income_form();
            panel_main.Controls.Clear();
            inc_form.TopLevel = false;
            inc_form.Left = 0;
            panel_main.Controls.Add(inc_form);
            inc_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_login_Meun_Click(object sender, EventArgs e)
        {
            log_form = new Login_form();
            panel_main.Controls.Clear();
            log_form.TopLevel = false;
            log_form.Left = 200;
            panel_main.Controls.Add(log_form);
            log_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }

        private void UC_withdrawl_Menu_Click(object sender, EventArgs e)
        {
            with_form = new Withdrawl_form();
            panel_main.Controls.Clear();
            with_form.TopLevel = false;
            with_form.Left = 180;
            panel_main.Controls.Add(with_form);
            with_form.Show();
            panel_main.Visible = true;
            panel_menu.Hide();
            count = 0;
        }
      

        private void LogOut_Button_Click_1(object sender, EventArgs e)
        {
            Login_Signup.LogOutStatus = true;
            this.Close();
        }

    }
}
