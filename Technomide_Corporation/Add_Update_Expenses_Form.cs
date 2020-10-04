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
    public partial class Add_Update_Expenses_Form : Form
    {
        Expense_Form expform;

        public Add_Update_Expenses_Form(Expense_Form exp)
        {
            InitializeComponent();
            expform = exp;
        }

        Model_Expenses cls_expense = new Model_Expenses();
        Model_Employees cls_employee = new Model_Employees();
        
        public string Function_Name = "";
        public string Expense_Name = "";
        public DataTable dt;
        public DataTable dt1;




        public void get_combobox_data()
        {

            dt1 = cls_employee.ShowEmp("select Name from EmployeeTable");
            foreach (DataRow dr in dt1.Rows)
            {
                txt_EmpSalary_EmpName.Items.Add(dr["Name"].ToString());
                txt_ProjectExpense_EmpName.Items.Add(dr["Name"].ToString());
            }

            dt1 = cls_employee.ShowEmp("select Name from ProjectTable");
            foreach (DataRow dr in dt1.Rows)
                txt_ProjectExpense_ProName.Items.Add(dr["Name"].ToString());


        }


        private void Add_Update_Expenses_Form_Load(object sender, EventArgs e)
        {
            get_combobox_data();
            
            if (Function_Name == "Add")
            {
                btn_Add_EmpSalary.BringToFront();
                btn_Add_ProjectExpense.BringToFront();
                btn_Add_RegularExpense.BringToFront();

                btn_Project_Expenses.Show();
                btn_Regular_Expenses.Show();
                btn_Employee_Salaries.Show();

                label_EmpSalary.Text = "Add Employee Salary";
                label_ProjectExpense.Text = "Add Project Expense";
                label_RegularExpense.Text = "Add Regular Expense";


                txt_RegularExpense_Date.Text = DateTime.Now.ToShortDateString();
                txt_EmpSalary_Date.Text = DateTime.Now.ToShortDateString();
                txt_ProjectExpense_Date.Text = DateTime.Now.ToShortDateString();

                txt_RegularExpense_Date.Enabled = false;
                txt_EmpSalary_Date.Enabled = false;
                txt_ProjectExpense_Date.Enabled = false;

                txt_RegularExpense_ID.ReadOnly = true;
                txt_EmpSalary_ID.ReadOnly = true;
                txt_ProjectExpense_ID.ReadOnly = true;
            }

            else if (Function_Name == "Update")
            {
                btn_Update_EmpSalary.BringToFront();
                btn_Update_ProjectExpense.BringToFront();
                btn_Update_RegularExpense.BringToFront();

                btn_Project_Expenses.Hide();
                btn_Regular_Expenses.Hide();
                btn_Employee_Salaries.Hide();

                label_EmpSalary.Text = "Update Employee Salary";
                label_ProjectExpense.Text = "Update Project Expense";
                label_RegularExpense.Text = "Update Regular Expense";


                txt_RegularExpense_ID.ReadOnly = true;
                txt_EmpSalary_ID.ReadOnly = true;
                txt_ProjectExpense_ID.ReadOnly = true;

                txt_RegularExpense_Date.Enabled = false;
                txt_EmpSalary_Date.Enabled = false;
                txt_ProjectExpense_Date.Enabled = false;


            }

            if (Expense_Name == "Project")
            {
                panel_Project_Expense.BringToFront();

                txt_ProjectExpense_ID.Text = dt.Rows[0][0].ToString();
                txt_ProjectExpense_ProName.Text = dt.Rows[0][1].ToString();
                txt_ProjectExpense_EmpName.Text = dt.Rows[0][2].ToString();
                txt_ProjectExpense_Amount.Text = dt.Rows[0][3].ToString();
                txt_ProjectExpense_Date.Text = Convert.ToDateTime(dt.Rows[0][4].ToString()).ToShortDateString();
                txt_ProjectExpense_Note.Text = dt.Rows[0][5].ToString();
            }

            else if (Expense_Name == "Regular")
            {

                panel_Regular_Expense.BringToFront();

                txt_RegularExpense_ID.Text = dt.Rows[0][0].ToString();
                txt_RegularExpense_Amount.Text = dt.Rows[0][1].ToString();
                txt_RegularExpense_Date.Text = Convert.ToDateTime(dt.Rows[0][2].ToString()).ToShortDateString();
                txt_RegularExpense_Description.Text = dt.Rows[0][3].ToString();

            }

            else if (Expense_Name == "Salary")
            {

                panel_Employee_Salaries.BringToFront();

                txt_EmpSalary_ID.Text = dt.Rows[0][0].ToString();
                txt_EmpSalary_EmpName.Text = dt.Rows[0][1].ToString();
                txt_EmpSalary_Amount.Text = dt.Rows[0][2].ToString();
                txt_EmpSalary_Date.Text = Convert.ToDateTime(dt.Rows[0][3].ToString()).ToShortDateString();
                txt_EmpSalary_Note.Text = dt.Rows[0][4].ToString();

            }

        }


        public void clearTexts()
        {
            txt_EmpSalary_ID.Text = "";
            txt_EmpSalary_EmpName.Text = "";
            txt_EmpSalary_Amount.Text = "";
            txt_EmpSalary_Note.Text = "";
            txt_RegularExpense_ID.Text = "";
            txt_RegularExpense_Amount.Text = "";
            txt_RegularExpense_Description.Text = "";
            txt_ProjectExpense_ID.Text = "";
            txt_ProjectExpense_ProName.Text = "";
            txt_ProjectExpense_EmpName.Text = "";
            txt_ProjectExpense_Amount.Text = "";
            txt_ProjectExpense_Note.Text = "";

        }


        public void GetData(DataTable dt)
        {
            this.dt = dt;
        }

        private void btn_Project_Expenses_Click(object sender, EventArgs e)
        {
            panel_Project_Expense.BringToFront();
            clearTexts();
        }

        private void btn_Regular_Expenses_Click(object sender, EventArgs e)
        {
            panel_Regular_Expense.BringToFront();
            clearTexts();
        }

        private void btn_Employee_Salaries_Click(object sender, EventArgs e)
        {
            panel_Employee_Salaries.BringToFront();
            clearTexts();
        }

        private void btn_Add_EmpSalary_Click(object sender, EventArgs e)
        {
            cls_employee.ProcInsertEmplyeeSalaries(txt_EmpSalary_EmpName.Text, txt_EmpSalary_Amount.Text, txt_EmpSalary_Date.Text, txt_EmpSalary_Note.Text);
            clearTexts();
            expform.Refresh();
        }

        private void btn_Update_EmpSalary_Click(object sender, EventArgs e)
        {
            cls_employee.ProcUpdateEmplyeeSalaries(Convert.ToInt32(txt_EmpSalary_ID.Text), txt_EmpSalary_EmpName.Text, txt_EmpSalary_Amount.Text, txt_EmpSalary_Date.Text, txt_EmpSalary_Note.Text);
            MessageBox.Show("Updated");
            expform.Refresh();
        }

        private void btn_Add_ProjectExpense_Click(object sender, EventArgs e)
        {
            cls_expense.ProcAddProjectExpense(txt_ProjectExpense_ProName.Text , txt_ProjectExpense_EmpName.Text , txt_ProjectExpense_Amount.Text , txt_ProjectExpense_Date.Text , txt_ProjectExpense_Note.Text);
            clearTexts();
            expform.Refresh();

        }

        private void btn_Update_ProjectExpense_Click(object sender, EventArgs e)
        {
            cls_expense.ProcUpdateProjectExpense(Convert.ToInt32(txt_ProjectExpense_ID.Text), txt_ProjectExpense_ProName.Text, txt_ProjectExpense_EmpName.Text, txt_ProjectExpense_Amount.Text, txt_ProjectExpense_Date.Text, txt_ProjectExpense_Note.Text);
            expform.Refresh();

        }

        private void btn_Add_RegularExpense_Click(object sender, EventArgs e)
        {
            cls_expense.ProcAddRegularExpense(txt_RegularExpense_Amount.Text , txt_RegularExpense_Date.Text, txt_RegularExpense_Description.Text);
            clearTexts();
            expform.Refresh();

        }

        private void btn_Update_RegularExpense_Click(object sender, EventArgs e)
        {
            cls_expense.ProcUpdateRegularExpense(Convert.ToInt32(txt_RegularExpense_ID.Text), txt_RegularExpense_Amount.Text, txt_RegularExpense_Date.Text, txt_RegularExpense_Description.Text);
            expform.Refresh();

        }
    }
}
