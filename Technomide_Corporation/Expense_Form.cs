using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication3;

namespace Technomide_Corporation
{
    public partial class Expense_Form : Form
    {
        public Expense_Form()
        {
            InitializeComponent();
        }


        UC_Project_Expense_Data project_exp_UC;
        UC_Regular_Expense_Data regular_exp_UC;
        UC_Salary_Expense_Data salary_exp_UC;

        Add_Update_Expenses_Form modify_Expense;

        UC_Modify modify_UC;
        RichTextBox txt_rich;
        DataTable dt;
        public int count = 0;

        Model_Expenses cls_expense = new Model_Expenses();
        Model_Employees cls_employee = new Model_Employees();

        private void Expense_Form_Load(object sender, EventArgs e)
        {

            txt_search_projectexp_specific_day.Items.Add("Day");
            txt_search_projectexp_specific_month.Items.Add("Month");
            txt_search_regularexp_specific_day.Items.Add("Day");
            txt_search_regularexp_specific_month.Items.Add("Month");
            txt_search_salaryexp_specific_day.Items.Add("Day");
            txt_search_salaryexp_specific_month.Items.Add("Month");


            Refresh();
        }


        public void get_combobox_data()
        {
            txt_search_salaryexp_specific_year.Items.Add("Year");
            txt_search_regularexp_specific_year.Items.Add("Year");
            txt_search_projectexp_specific_year.Items.Add("Year");

            txt_search_projectexp_pro_id.Items.Add("Project ID");
            txt_search_projectexp_pro_name.Items.Add("Project Name");

            txt_search_salaryexp_emp_id.Items.Add("Employee ID");
            txt_search_salaryexp_emp_name.Items.Add("Employee Name");

            dt = cls_employee.ShowEmp("select Name from EmployeeTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_salaryexp_emp_name.Items.Add(dr["Name"].ToString());

            dt = cls_employee.ShowEmp("select Employee_ID from EmployeeTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_salaryexp_emp_id.Items.Add(dr["Employee_ID"].ToString());

            dt = cls_employee.ShowEmp("select Name from ProjectTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_projectexp_pro_name.Items.Add(dr["Name"].ToString());

            dt = cls_employee.ShowEmp("select Pro_ID from ProjectTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_projectexp_pro_id.Items.Add(dr["Pro_ID"].ToString());


            dt = cls_employee.ShowEmp("select distinct Year(Date) ExpYear from ProjectExpense");
            foreach (DataRow dr in dt.Rows)
                txt_search_projectexp_specific_year.Items.Add(dr["ExpYear"].ToString());


            dt = cls_employee.ShowEmp("select distinct Year(Date) ExpYear from Employee_Salaries");
            foreach (DataRow dr in dt.Rows)
                txt_search_salaryexp_specific_year.Items.Add(dr["ExpYear"].ToString());


            dt = cls_employee.ShowEmp("select distinct Year(Date) ExpYear from Regular_Expenses");
            foreach (DataRow dr in dt.Rows)
                txt_search_regularexp_specific_year.Items.Add(dr["ExpYear"].ToString());

        }


        public void clear_combobox()
        {

            txt_search_salaryexp_emp_name.Items.Clear();
            txt_search_salaryexp_emp_id.Items.Clear();
            txt_search_projectexp_pro_name.Items.Clear();
            txt_search_projectexp_pro_id.Items.Clear();
            txt_search_projectexp_specific_year.Items.Clear();
            txt_search_salaryexp_specific_year.Items.Clear();
            txt_search_regularexp_specific_year.Items.Clear();
        }



        public void Refresh()
        {

            clear_combobox();
            get_combobox_data();

            txt_search_projectexp_specific_month.Enabled = false;
            txt_search_projectexp_specific_day.Enabled = false;

            txt_search_salaryexp_specific_month.Enabled = false;
            txt_search_salaryexp_specific_day.Enabled = false;

            txt_search_regularexp_specific_month.Enabled = false;
            txt_search_regularexp_specific_day.Enabled = false;


            if (btn_view_project_expenses.Checked)
            {

                txt_search_projectexp_pro_id.SelectedIndex = 0;
                txt_search_projectexp_pro_name.SelectedIndex = 0;
                txt_search_projectexp_specific_day.SelectedIndex = 31;
                txt_search_projectexp_specific_month.SelectedIndex = 12;
                txt_search_projectexp_specific_year.SelectedIndex = 0;

                dt = cls_expense.ProjectExpenseDetailShow();
                count = dt.Rows.Count;

                get_projectexp_UC();
            }

            else if (btn_view_regular_expenses.Checked)
            {

                txt_search_regularexp_specific_day.SelectedIndex = 31;
                txt_search_regularexp_specific_month.SelectedIndex = 12;
                txt_search_regularexp_specific_year.SelectedIndex = 0;

                dt = cls_expense.RegularExpenseDetailShow();
                count = dt.Rows.Count;

                get_regularexp_UC();
            }

            else
            {

                txt_search_salaryexp_emp_id.SelectedIndex = 0;
                txt_search_salaryexp_emp_name.SelectedIndex = 0;
                txt_search_salaryexp_specific_day.SelectedIndex = 31;
                txt_search_salaryexp_specific_month.SelectedIndex = 12;
                txt_search_salaryexp_specific_year.SelectedIndex = 0;                

                dt = cls_expense.EmployeeSalariesDetailShow();
                count = dt.Rows.Count;

                get_salaryexp_UC();
            }

        }




        public void get_projectexp_UC()
        {



            panel_projectexp_data.Controls.Clear();
            panel_projectexp_data.Show();
            panel_Project_Expenses.BringToFront();


            int j = 0;
            var Top = 10;
            var Left = 200;


            for (int i = 0; i < count; i++)
            {
                project_exp_UC = new UC_Project_Expense_Data();
                project_exp_UC.Width = 725;
                project_exp_UC.Height = 25;

                project_exp_UC.label_projectexpense_id.Text = dt.Rows[i][j++].ToString();
                project_exp_UC.label_project_name.Text = dt.Rows[i][j++].ToString();
                project_exp_UC.label_project_emp_name.Text = dt.Rows[i][j++].ToString();
                project_exp_UC.label_project_amount.Text = dt.Rows[i][j++].ToString();
                project_exp_UC.label_project_date.Text = (Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy"));


                project_exp_UC.Left = 0;
                project_exp_UC.Top = Top;
                panel_projectexp_data.Controls.Add(project_exp_UC);

                modify_UC = new UC_Modify();

                modify_UC.Width = 60;
                modify_UC.Height = 30;
                modify_UC.Top = Top;
                modify_UC.Left = Left + 535;

                modify_UC.value = dt.Rows[i][0].ToString();

                panel_projectexp_data.Controls.Add(modify_UC);


                txt_rich = new RichTextBox();
                txt_rich.Top = Top;
                txt_rich.Height = 30;
                txt_rich.Width = 190;
                txt_rich.Left = Left + 605;
                txt_rich.Text = dt.Rows[i][j++].ToString();
                txt_rich.Enabled = false;
                panel_projectexp_data.Controls.Add(txt_rich);


                Top += 60;
                j = 0;

                modify_UC.pic_update.Click += new EventHandler(pic_update_projectexpense_Click);
                modify_UC.pic_delete.Click += new EventHandler(pic_delete_projectexpense_Click);


            }

        }

        private void pic_update_projectexpense_Click(object sender, EventArgs e)
        {
            modify_Expense = new Add_Update_Expenses_Form(this);
            modify_Expense.Function_Name = "Update";
            modify_Expense.Expense_Name = "Project";

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_expense.ProjectExpenseDetailShowByProjectExpenseId(mod.value.ToString());

            modify_Expense.dt = dt;
            modify_Expense.Show();
            
        }

        private void pic_delete_projectexpense_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            cls_expense.ProcDeleteProjectExpense(mod.value.ToString());
            Refresh();
        }








        public void get_regularexp_UC()
        {

            panel_regularexp_data.Controls.Clear();
            panel_regularexp_data.Show();
            panel_Regular_Expenses.BringToFront();


            int j = 0;
            var Top = 10;
            var Left = 200;


            for (int i = 0; i < count; i++)
            {
                regular_exp_UC = new UC_Regular_Expense_Data();
                regular_exp_UC.Width = 340;
                regular_exp_UC.Height = 25;

                regular_exp_UC.label_regularexpense_id.Text = dt.Rows[i][j++].ToString();
                regular_exp_UC.label_regular_amount.Text = dt.Rows[i][j++].ToString();
                regular_exp_UC.label_regular_date.Text = Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy");

                regular_exp_UC.Left = 210;
                regular_exp_UC.Top = Top;
                panel_regularexp_data.Controls.Add(regular_exp_UC);

                modify_UC = new UC_Modify();

                modify_UC.Width = 60;
                modify_UC.Height = 30;
                modify_UC.Top = Top;
                modify_UC.Left = Left + 360;

                modify_UC.value = dt.Rows[i][0].ToString();

                panel_regularexp_data.Controls.Add(modify_UC);


                txt_rich = new RichTextBox();
                txt_rich.Top = Top;
                txt_rich.Height = 30;
                txt_rich.Width = 200;
                txt_rich.Left = Left + 430;
                txt_rich.Text = dt.Rows[i][j++].ToString();
                txt_rich.Enabled = false;
                panel_regularexp_data.Controls.Add(txt_rich);


                Top += 60;
                j = 0;

                modify_UC.pic_update.Click += new EventHandler(pic_update_regularexpense_Click);
                modify_UC.pic_delete.Click += new EventHandler(pic_delete_regularexpense_Click);

            }

        }


        private void pic_update_regularexpense_Click(object sender, EventArgs e)
        {
            modify_Expense = new Add_Update_Expenses_Form(this);
            modify_Expense.Function_Name = "Update";
            modify_Expense.Expense_Name = "Regular";

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_expense.RegularExpenseDetailShowByRegularExpenseID(mod.value.ToString());

            modify_Expense.dt = dt;
            modify_Expense.Show();

        }

        private void pic_delete_regularexpense_Click(object sender, EventArgs e)
        {

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            cls_expense.ProcDeleteRegularExpense(mod.value.ToString());
            Refresh();


        }







        public void get_salaryexp_UC()
        {

            panel_salaryexp_data.Controls.Clear();
            panel_salaryexp_data.Show();
            panel_Salary_Expenses.BringToFront();


            int j = 0;
            var Top = 10;
            var Left = 200;


            for (int i = 0; i < count; i++)
            {
                salary_exp_UC = new UC_Salary_Expense_Data();
                salary_exp_UC.Width = 550;
                salary_exp_UC.Height = 25;

                salary_exp_UC.label_salaryexpense_id.Text = dt.Rows[i][j++].ToString();
                salary_exp_UC.label_salary_emp_name.Text = dt.Rows[i][j++].ToString();
                salary_exp_UC.label_salary_amount.Text = dt.Rows[i][j++].ToString();
                salary_exp_UC.label_salary_date.Text = (Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy"));


                salary_exp_UC.Left = 0;
                salary_exp_UC.Top = Top;
                panel_salaryexp_data.Controls.Add(salary_exp_UC);

                modify_UC = new UC_Modify();

                modify_UC.Width = 60;
                modify_UC.Height = 30;
                modify_UC.Top = Top;
                modify_UC.Left = Left + 360;

                modify_UC.value = dt.Rows[i][0].ToString();

                panel_salaryexp_data.Controls.Add(modify_UC);


                txt_rich = new RichTextBox();
                txt_rich.Top = Top;
                txt_rich.Height = 30;
                txt_rich.Width = 200;
                txt_rich.Left = Left + 430;
                txt_rich.Text = dt.Rows[i][j++].ToString();
                txt_rich.Enabled = false;
                panel_salaryexp_data.Controls.Add(txt_rich);


                Top += 60;
                j = 0;

                modify_UC.pic_update.Click += new EventHandler(pic_update_employeesalary_Click);
                modify_UC.pic_delete.Click += new EventHandler(pic_delete_employeesalary_Click);

            }

        }


        private void pic_update_employeesalary_Click(object sender, EventArgs e)
        {
            modify_Expense = new Add_Update_Expenses_Form(this);
            modify_Expense.Function_Name = "Update";
            modify_Expense.Expense_Name = "Salary";

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_expense.EmployeeSalaryDetailShowByEmpSalaryId(mod.value.ToString());

            modify_Expense.dt = dt;
            modify_Expense.Show();



        }

        private void pic_delete_employeesalary_Click(object sender, EventArgs e)
        {

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            cls_employee.ProcDeleteEmployeeSalaries(mod.value.ToString());

            Refresh();


        }













        private void btn_view_project_expenses_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_view_regular_expenses_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_view_salaries_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txt_search_projectexp_pro_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_projectexp_pro_name.Text == "Project Name")
            {
                return;
            }

            dt = cls_expense.ProjectExpenseDetailShowByProjectName(txt_search_projectexp_pro_name.Text);
            count = dt.Rows.Count;

            get_projectexp_UC();

        }

        private void txt_search_projectexp_pro_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_projectexp_pro_id.Text == "Project ID")
            {
                return;
            }

            dt = cls_expense.ProjectExpenseDetailShowByProjectId(txt_search_projectexp_pro_id.Text);
            count = dt.Rows.Count;

            get_projectexp_UC();

        }

        private void txt_search_projectexp_specific_year_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_projectexp_specific_year.Text == "Year")
            {
                return;
            }

            txt_search_projectexp_specific_month.Enabled = true;
            txt_search_projectexp_specific_day.Enabled = false;


            dt = cls_expense.ProjectExpenseDetailShowBySpecificYear(txt_search_projectexp_specific_year.Text);
            count = dt.Rows.Count;

            get_projectexp_UC();

        }

        private void txt_search_projectexp_specific_month_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_projectexp_specific_month.Text == "Month")
            {
                return;
            }

            txt_search_projectexp_specific_day.Enabled = true;

            dt = cls_expense.ProjectExpenseDetailShowBySpecificMonth(txt_search_projectexp_specific_year.Text,txt_search_projectexp_specific_month.Text);
            count = dt.Rows.Count;

            get_projectexp_UC();

        }

        private void txt_search_projectexp_specific_day_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_projectexp_specific_day.Text == "Day")
            {
                return;
            }

            dt = cls_expense.ProjectExpenseDetailShowBySpecificDay(txt_search_projectexp_specific_year.Text, txt_search_projectexp_specific_month.Text,txt_search_projectexp_specific_day.Text);
            count = dt.Rows.Count;

            get_projectexp_UC();

        }

        private void btn_sort_projectexp_pro_name_CheckedChanged(object sender, EventArgs e)
        {

            txt_search_projectexp_specific_month.Enabled = false;
            txt_search_projectexp_specific_day.Enabled = false;

            txt_search_projectexp_pro_name.SelectedIndex = 0;
            txt_search_projectexp_pro_id.SelectedIndex = 0;
            txt_search_projectexp_specific_day.SelectedIndex = 31;
            txt_search_projectexp_specific_month.SelectedIndex = 12;
            txt_search_projectexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.ProjectExpenseDetailShowSortByProjectName();
            count = dt.Rows.Count;

            get_projectexp_UC();

        }

        private void btn_sort_projectexp_employee_name_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_projectexp_specific_month.Enabled = false;
            txt_search_projectexp_specific_day.Enabled = false;

            txt_search_projectexp_pro_name.SelectedIndex = 0;
            txt_search_projectexp_pro_id.SelectedIndex = 0;
            txt_search_projectexp_specific_day.SelectedIndex = 31;
            txt_search_projectexp_specific_month.SelectedIndex = 12;
            txt_search_projectexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.ProjectExpenseDetailShowSortByEmployeeName();
            count = dt.Rows.Count;

            get_projectexp_UC();

        }

        private void btn_sort_projectexp_date_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_projectexp_specific_month.Enabled = false;
            txt_search_projectexp_specific_day.Enabled = false;

            txt_search_projectexp_pro_id.SelectedIndex = 0;
            txt_search_projectexp_pro_name.SelectedIndex = 0;
            txt_search_projectexp_specific_day.SelectedIndex = 31;
            txt_search_projectexp_specific_month.SelectedIndex = 12;
            txt_search_projectexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.ProjectExpenseDetailShowSortByDate();
            count = dt.Rows.Count;

            get_projectexp_UC();

        }

        private void txt_search_salaryexp_emp_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_salaryexp_emp_name.Text == "Employee Name")
            {
                return;

            }

            dt = cls_expense.EmployeeSalariesDetailSearchByName(txt_search_salaryexp_emp_name.Text);
            count = dt.Rows.Count;

            get_salaryexp_UC();
        }

        private void txt_search_salaryexp_emp_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_salaryexp_emp_id.Text == "Employee ID")
            {
                return;
            }

            dt = cls_expense.EmployeesSalariesDetailSearchById(txt_search_salaryexp_emp_id.Text);
            count = dt.Rows.Count;

            get_salaryexp_UC();
        }

        private void txt_search_salaryexp_specific_year_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_salaryexp_specific_year.Text == "Year")
            {
                return;

            }

            txt_search_salaryexp_specific_month.Enabled = true;
            txt_search_salaryexp_specific_day.Enabled = false;


            dt = cls_expense.EmployeeSalariesDetailSearchBySpecific_Year(txt_search_salaryexp_specific_year.Text);
            count = dt.Rows.Count;

            get_salaryexp_UC();
        }

        private void txt_search_salaryexp_specific_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_salaryexp_specific_month.Text == "Month")
            {
                return;

            }

            txt_search_salaryexp_specific_day.Enabled = true;

            dt = cls_expense.EmployeeSalariesDetailSearchBySpecific_Month(txt_search_salaryexp_specific_year.Text,txt_search_salaryexp_specific_month.Text);
            count = dt.Rows.Count;

            get_salaryexp_UC();
        }

        private void txt_search_salaryexp_specific_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_salaryexp_specific_day.Text == "Day")
            {
                return;
            }

            dt = cls_expense.EmployeeSalariesDetailSearchBySpecific_Day(txt_search_salaryexp_specific_year.Text, txt_search_salaryexp_specific_month.Text, txt_search_salaryexp_specific_day.Text);
            count = dt.Rows.Count;

            get_salaryexp_UC();

        }

        private void btn_sort_salaryexp_emp_name_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_salaryexp_specific_month.Enabled = false;
            txt_search_salaryexp_specific_day.Enabled = false;


            txt_search_salaryexp_emp_id.SelectedIndex = 0;
            txt_search_salaryexp_emp_name.SelectedIndex = 0;
            txt_search_salaryexp_specific_day.SelectedIndex = 31;
            txt_search_salaryexp_specific_month.SelectedIndex = 12;
            txt_search_salaryexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.EmployeeSalariesDetailShowSortByE_Name();
            count = dt.Rows.Count;

            get_salaryexp_UC();

        }

        private void btn_sort_salaryexp_amount_asc_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_salaryexp_specific_month.Enabled = false;
            txt_search_salaryexp_specific_day.Enabled = false;

            txt_search_salaryexp_emp_id.SelectedIndex = 0;
            txt_search_salaryexp_emp_name.SelectedIndex = 0;
            txt_search_salaryexp_specific_day.SelectedIndex = 31;
            txt_search_salaryexp_specific_month.SelectedIndex = 12;
            txt_search_salaryexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.employeeSalariesDetailShowSortByAmountAsc();
            count = dt.Rows.Count;

            get_salaryexp_UC();

        }

        private void btn_sort_salaryexp_amount_des_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_salaryexp_specific_month.Enabled = false;
            txt_search_salaryexp_specific_day.Enabled = false;

            txt_search_salaryexp_emp_id.SelectedIndex = 0;
            txt_search_salaryexp_emp_name.SelectedIndex = 0;
            txt_search_salaryexp_specific_day.SelectedIndex = 31;
            txt_search_salaryexp_specific_month.SelectedIndex = 12;
            txt_search_salaryexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.EmployeeSalariesDetailShowSortByAmountDesc();
            count = dt.Rows.Count;

            get_salaryexp_UC();
        }

        private void txt_search_regularexp_specific_year_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_regularexp_specific_year.Text == "Year")
            {
                return;

            }

            txt_search_regularexp_specific_month.Enabled = true;
            txt_search_regularexp_specific_day.Enabled = false;

            dt = cls_expense.RegularExpenseDetailSearchBySpecificYear(txt_search_regularexp_specific_year.Text);
            count = dt.Rows.Count;

            get_regularexp_UC();
        }

        private void txt_search_regularexp_specific_month_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_regularexp_specific_month.Text == "Month")
            {
                return;
            }

            txt_search_regularexp_specific_day.Enabled = true;

            dt = cls_expense.RegularExpenseDetailSearchBySpecificMonth(txt_search_regularexp_specific_year.Text,txt_search_regularexp_specific_month.Text);
            count = dt.Rows.Count;

            get_regularexp_UC();

        }

        private void txt_search_regularexp_specific_day_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_regularexp_specific_day.Text == "Day")
            {
                return;
            }

            dt = cls_expense.RegularExpenseDetailSearchBySpecificDay(txt_search_regularexp_specific_year.Text, txt_search_regularexp_specific_month.Text,txt_search_regularexp_specific_day.Text);
            count = dt.Rows.Count;

            get_regularexp_UC();

        }

        private void btn_sort_regularexp_amount_ascending_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_regularexp_specific_day.Enabled = false;
            txt_search_regularexp_specific_month.Enabled = false;

            txt_search_regularexp_specific_day.SelectedIndex = 31;
            txt_search_regularexp_specific_month.SelectedIndex = 12;
            txt_search_regularexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.RegularExpenseDetailShowSortByAmountASC();
            count = dt.Rows.Count;

            get_regularexp_UC();

        }

        private void btn_sort_regularexp_amount_descending_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_regularexp_specific_day.Enabled = false;
            txt_search_regularexp_specific_month.Enabled = false;

            txt_search_regularexp_specific_day.SelectedIndex = 31;
            txt_search_regularexp_specific_month.SelectedIndex = 12;
            txt_search_regularexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.RegularExpenseDetailShowSortByAmountDesc();
            count = dt.Rows.Count;

            get_regularexp_UC();

        }

        private void btn_sort_regularexp_date_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_regularexp_specific_day.Enabled = false;
            txt_search_regularexp_specific_month.Enabled = false;

            txt_search_regularexp_specific_day.SelectedIndex = 31;
            txt_search_regularexp_specific_month.SelectedIndex = 12;
            txt_search_regularexp_specific_year.SelectedIndex = 0;

            dt = cls_expense.RegularExpenseDetailShowSortByDateAsc();
            count = dt.Rows.Count;

            get_regularexp_UC();

        }

        private void txt_select_expense_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_select_expense_time.Text == "Today")
            {
                dt = cls_expense.today_project_expense(DateTime.Now.Date.ToShortDateString());
                label_project_expense.Text = "Project:"+dt.Rows[0][0].ToString()+ "Rps";

                dt = cls_expense.today_regular_expense(DateTime.Now.Date.ToShortDateString());
                label_regular_expense.Text = "Regular:" + dt.Rows[0][0].ToString()+ "Rps";

                dt = cls_expense.ProcTodayEmployeeSalaries(DateTime.Now.Date.ToShortDateString());
                label_salary_expense.Text = "Salary:" + dt.Rows[0][0].ToString()+ "Rps";

                if (label_project_expense.Text == "Project:")
                {
                    label_project_expense.Text = "Project:0Rps";
                }

                if (label_regular_expense.Text == "Regular:")
                {
                    label_regular_expense.Text = "Regular:0Rps";
                }

                if (label_salary_expense.Text == "Salary:")
                {
                    label_salary_expense.Text = "Salary:0Rps";
                }

            }

            else if (txt_select_expense_time.Text == "This Month")
            {

                dt = cls_expense.ProcMonthlyProjectExpenses(DateTime.Now.Date.Year.ToString(), DateTime.Now.Date.Month.ToString());
                label_project_expense.Text = "Project:" + dt.Rows[0][0].ToString() + "Rps";

                dt = cls_expense.ProcMonthlyRegularExpense(DateTime.Now.Date.Year.ToString(), DateTime.Now.Date.Month.ToString());
                label_regular_expense.Text = "Regular:" + dt.Rows[0][0].ToString() + "Rps";

                dt = cls_expense.ProcMonthlyEmployeeSalaries(DateTime.Now.Date.Year.ToString(), DateTime.Now.Date.Month.ToString());
                label_salary_expense.Text = "Salary:" + dt.Rows[0][0].ToString() + "Rps";

                if (label_project_expense.Text == "Project:")
                {
                    label_project_expense.Text = "Project:0Rps";
                }

                if (label_regular_expense.Text == "Regular:")
                {
                    label_regular_expense.Text = "Regular:0Rps";
                }

                if (label_salary_expense.Text == "Salary:")
                {
                    label_salary_expense.Text = "Salary:0Rps";
                }

            }

            else if (txt_select_expense_time.Text == "This Year")
            {


                dt = cls_expense.ProcYearlyProjectExpense(DateTime.Now.Date.Year.ToString());
                label_project_expense.Text = "Project:" + dt.Rows[0][0].ToString() + "Rps";

                dt = cls_expense.ProcYearlyRegularExpense(DateTime.Now.Date.Year.ToString());
                label_regular_expense.Text = "Regular:" + dt.Rows[0][0].ToString() + "Rps";

                dt = cls_expense.ProcYearlyEmployeeSalaries(DateTime.Now.Date.Year.ToString());
                label_salary_expense.Text = "Salary:" + dt.Rows[0][0].ToString() + "Rps";

                if (label_project_expense.Text == "Project:")
                {
                    label_project_expense.Text = "Project:0Rps";
                }

                if (label_regular_expense.Text == "Regular:")
                {
                    label_regular_expense.Text = "Regular:0Rps";
                }

                if (label_salary_expense.Text == "Salary:")
                {
                    label_salary_expense.Text = "Salary:0Rps";
                }



            }

        }

        private void label_add_expenses_Click(object sender, EventArgs e)
        {
            AddExpenses();
        }

        private void picture_add_expenses_Click(object sender, EventArgs e)
        {
            AddExpenses();
        }

        public void AddExpenses()
        {

            modify_Expense = new Add_Update_Expenses_Form(this);
            modify_Expense.Function_Name = "Add";
            modify_Expense.Show();


        }

        private void txt_search_projectexp_pro_name_Click(object sender, EventArgs e)
        {
            txt_search_projectexp_specific_day.Enabled = false;
            txt_search_projectexp_specific_month.Enabled = false;

            txt_search_projectexp_pro_id.SelectedIndex = 0;
            txt_search_projectexp_specific_day.SelectedIndex = 31;
            txt_search_projectexp_specific_month.SelectedIndex = 12;
            txt_search_projectexp_specific_year.SelectedIndex = 0;

        }

        private void txt_search_projectexp_pro_id_Click(object sender, EventArgs e)
        {
            txt_search_projectexp_specific_day.Enabled = false;
            txt_search_projectexp_specific_month.Enabled = false;

            txt_search_projectexp_pro_name.SelectedIndex = 0;
            txt_search_projectexp_specific_day.SelectedIndex = 31;
            txt_search_projectexp_specific_month.SelectedIndex = 12;
            txt_search_projectexp_specific_year.SelectedIndex = 0;

        }

        private void txt_search_projectexp_specific_year_Click(object sender, EventArgs e)
        {
            txt_search_projectexp_specific_day.Enabled = false;
            txt_search_projectexp_specific_month.Enabled = false;

            txt_search_projectexp_pro_id.SelectedIndex = 0;
            txt_search_projectexp_pro_name.SelectedIndex = 0;
            txt_search_projectexp_specific_day.SelectedIndex = 31;
            txt_search_projectexp_specific_month.SelectedIndex = 12;

        }

        private void txt_search_projectexp_specific_month_Click(object sender, EventArgs e)
        {
            txt_search_projectexp_specific_day.Enabled = false;

            txt_search_projectexp_pro_id.SelectedIndex = 0;
            txt_search_projectexp_pro_name.SelectedIndex = 0;
            txt_search_projectexp_specific_day.SelectedIndex = 31;

        }

        private void txt_search_projectexp_specific_day_Click(object sender, EventArgs e)
        {
            txt_search_projectexp_pro_id.SelectedIndex = 0;
            txt_search_projectexp_pro_name.SelectedIndex = 0;

        }

        private void txt_search_salaryexp_emp_name_Click(object sender, EventArgs e)
        {

            txt_search_salaryexp_specific_month.Enabled = false;
            txt_search_salaryexp_specific_day.Enabled = false;

            txt_search_salaryexp_emp_id.SelectedIndex = 0;
            txt_search_salaryexp_specific_day.SelectedIndex = 31;
            txt_search_salaryexp_specific_month.SelectedIndex = 12;
            txt_search_salaryexp_specific_year.SelectedIndex = 0;
        }

        private void txt_search_salaryexp_emp_id_Click(object sender, EventArgs e)
        {
            txt_search_salaryexp_specific_month.Enabled = false;
            txt_search_salaryexp_specific_day.Enabled = false;

            txt_search_salaryexp_emp_name.SelectedIndex = 0;
            txt_search_salaryexp_specific_day.SelectedIndex = 31;
            txt_search_salaryexp_specific_month.SelectedIndex = 12;
            txt_search_salaryexp_specific_year.SelectedIndex = 0;
        }

        private void txt_search_salaryexp_specific_year_Click(object sender, EventArgs e)
        {

            txt_search_salaryexp_specific_month.Enabled = false;
            txt_search_salaryexp_specific_day.Enabled = false;

            txt_search_salaryexp_emp_id.SelectedIndex = 0;
            txt_search_salaryexp_emp_name.SelectedIndex = 0;
            txt_search_salaryexp_specific_day.SelectedIndex = 31;
            txt_search_salaryexp_specific_month.SelectedIndex = 12;
        }

        private void txt_search_salaryexp_specific_month_Click(object sender, EventArgs e)
        {
            txt_search_salaryexp_specific_day.Enabled = false;

            txt_search_salaryexp_emp_id.SelectedIndex = 0;
            txt_search_salaryexp_emp_name.SelectedIndex = 0;
            txt_search_salaryexp_specific_day.SelectedIndex = 31;
        }

        private void txt_search_salaryexp_specific_day_Click(object sender, EventArgs e)
        {
            txt_search_salaryexp_emp_id.SelectedIndex = 0;
            txt_search_salaryexp_emp_name.SelectedIndex = 0;
        }


        private void txt_search_regularexp_specific_year_Click(object sender, EventArgs e)
        {

            txt_search_regularexp_specific_day.Enabled = false;
            txt_search_regularexp_specific_month.Enabled = false;

            txt_search_regularexp_specific_day.SelectedIndex = 31;
            txt_search_regularexp_specific_month.SelectedIndex = 12;
        }


        private void txt_search_regularexp_specific_month_Click(object sender, EventArgs e)
        {
            txt_search_regularexp_specific_day.Enabled = false;
            txt_search_regularexp_specific_day.SelectedIndex = 31;
        }
    }
}
