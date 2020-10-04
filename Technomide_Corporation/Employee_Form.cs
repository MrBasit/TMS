using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConsoleApplication3;

namespace Technomide_Corporation
{
    public partial class Employee_Form : Form
    {
        public Employee_Form()
        {
            InitializeComponent();
        }

        UC_Employee_Data emp_UC;
        UC_Modify modify_UC;

        Model_Employees cls_employee = new Model_Employees();
        DataTable dt = new DataTable();

        int count = 0;

        private void Employee_Form_Load(object sender, EventArgs e)
        {

            btn_sort_emp_name.Checked = true;
            Refresh();

        }


        public void get_combobox_data()
        {

            txt_search_emp_name.Items.Add("Employee Name");
            txt_search_emp_id.Items.Add("Employee ID");


            dt = cls_employee.ShowEmp("select Name from EmployeeTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_emp_name.Items.Add(dr["Name"].ToString());

            dt = cls_employee.ShowEmp("select Employee_ID from EmployeeTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_emp_id.Items.Add(dr["Employee_ID"].ToString());

            dt = cls_employee.ShowEmp("select PostName from DesignationTable");
            foreach (DataRow dr in dt.Rows)
                txt_emp_designation.Items.Add(dr["PostName"].ToString());

            dt = cls_employee.ShowEmp("select QName from QualificationTable");
            foreach (DataRow dr in dt.Rows)
                txt_emp_qualification.Items.Add(dr["QName"].ToString());

            dt = cls_employee.ShowEmp("select TypeName from TypeTable");
            foreach (DataRow dr in dt.Rows)
                txt_emp_type.Items.Add(dr["TypeName"].ToString());


        }


        public void clear_combobox()
        {
            txt_search_emp_name.Items.Clear();
            txt_search_emp_id.Items.Clear();
            txt_emp_designation.Items.Clear();
            txt_emp_qualification.Items.Clear();
            txt_emp_type.Items.Clear();
        }


        public void Refresh()
        {
            clear_combobox();
            get_combobox_data();

            txt_search_emp_name.SelectedIndex = 0;
            txt_search_emp_id.SelectedIndex = 0;

            disable_textboxes();

            if (btn_sort_emp_type.Checked)
            {
                dt = cls_employee.SortByType();
            }
            else
            {
                dt = cls_employee.SortByName();
            }

            count = dt.Rows.Count;


            get_UC();
            update_Btn.Hide();

        }



        public void enable_textboxes()
        {
            txt_emp_name.ReadOnly = false;
            txt_emp_phone1.ReadOnly = false;
            txt_emp_phone2.ReadOnly = false;
            txt_emp_salary.ReadOnly = false;
            txt_emp_agreement.ReadOnly = false;
            txt_emp_address.ReadOnly = false;
            txt_employee_id.ReadOnly = false;
            txt_emp_father_name.ReadOnly = false;
            txt_emp_cnic.ReadOnly = false;
            txt_emp_dob.Enabled = true;
        }

        public void disable_textboxes()
        {
            txt_emp_name.ReadOnly = true;
            txt_emp_phone1.ReadOnly = true;
            txt_emp_phone2.ReadOnly = true;
            txt_emp_salary.ReadOnly = true;
            txt_emp_agreement.ReadOnly = true;
            txt_emp_address.ReadOnly = true;
            txt_employee_id.ReadOnly = true;
            txt_emp_father_name.ReadOnly = true;
            txt_emp_cnic.ReadOnly = true;
            txt_emp_dob.Enabled = false;
        }


        public void get_UC()
        {
            panel_data.Controls.Clear();
            panel_data.Show();
            panel_emp_info_modify.Hide();


            int j = 0;
            var Top = 10;
            var Left = 200;

            for (int i = 0; i < count; i++)
            {
                emp_UC = new UC_Employee_Data();
                emp_UC.Width = 550;
                emp_UC.Height = 25;


                emp_UC.label_employee_name.Text = dt.Rows[i][j++].ToString();
                emp_UC.label_employee_id.Text = dt.Rows[i][j++].ToString();
                emp_UC.label_employee_type.Text = dt.Rows[i][j++].ToString();
                emp_UC.label_employee_salary.Text = dt.Rows[i][j++].ToString();


                j = 0;

                emp_UC.Left = 0;
                emp_UC.Top = Top;
                panel_data.Controls.Add(emp_UC);

                modify_UC = new UC_Modify();
                modify_UC.Width = 90;
                modify_UC.Height = 30;
                modify_UC.value = dt.Rows[i][1].ToString();
                modify_UC.Top = Top;
                modify_UC.Left = Left + 350;
                panel_data.Controls.Add(modify_UC);

                Top += 30;

                modify_UC.pic_update.Click += new EventHandler(pic_update_Click);
                modify_UC.pic_delete.Click += new EventHandler(pic_delete_Click);
                modify_UC.pic_info.Click += new EventHandler(pic_info_Click);

            }

        }



        private void pic_update_Click(object sender, EventArgs e)
        {
            groupBox_Active_Projects.Hide();
            groupBox_Completed_Projects.Hide();
            groupBox_Employee_Skills.Hide();

            label_function_name.Text = "Update Employee";
            panel_emp_info_modify.Show();
            enable_textboxes();
            update_Btn.Show();
            add_Btn.Hide();
            btn_edit.Hide();

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_employee.SearchEmpById(mod.value.ToString());

            txt_emp_name.Text = dt.Rows[0][0].ToString();
            txt_emp_father_name.Text = dt.Rows[0][1].ToString();
            txt_emp_cnic.Text = dt.Rows[0][2].ToString();
            txt_emp_dob.Text = dt.Rows[0][3].ToString();
            txt_emp_address.Text = dt.Rows[0][4].ToString();
            txt_emp_agreement.Text = dt.Rows[0][5].ToString();
            txt_emp_type.Text = dt.Rows[0][6].ToString();
            txt_emp_gender.Text = dt.Rows[0][7].ToString();
            txt_emp_designation.Text = dt.Rows[0][8].ToString();
            txt_emp_qualification.Text = dt.Rows[0][9].ToString();
            txt_emp_phone1.Text = dt.Rows[0][10].ToString();
            txt_emp_phone2.Text = dt.Rows[0][11].ToString();
            txt_employee_id.Text = dt.Rows[0][12].ToString();
            txt_emp_salary.Text = dt.Rows[0][13].ToString();

            txt_employee_id.ReadOnly = true;


        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            MessageBox.Show(cls_employee.DeleteEmployeeById(mod.value.ToString()));

            Refresh();

        }

        private void pic_info_Click(object sender, EventArgs e)
        {
            groupBox_Active_Projects.Show();
            groupBox_Completed_Projects.Show();
            groupBox_Employee_Skills.Show();

            label_function_name.Text = "Employee Info";
            panel_emp_info_modify.Show();
            disable_textboxes();
            btn_edit.Show();
            add_Btn.Hide();
            update_Btn.Hide();

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_employee.SearchEmpById(mod.value.ToString());

            txt_emp_name.Text = dt.Rows[0][0].ToString();
            txt_emp_father_name.Text = dt.Rows[0][1].ToString();
            txt_emp_cnic.Text = dt.Rows[0][2].ToString();
            txt_emp_dob.Text = dt.Rows[0][3].ToString();
            txt_emp_address.Text = dt.Rows[0][4].ToString();
            txt_emp_agreement.Text = dt.Rows[0][5].ToString();
            txt_emp_type.Text = dt.Rows[0][6].ToString();
            txt_emp_gender.Text = dt.Rows[0][7].ToString();
            txt_emp_designation.Text = dt.Rows[0][8].ToString();
            txt_emp_qualification.Text = dt.Rows[0][9].ToString();
            txt_emp_phone1.Text = dt.Rows[0][10].ToString();
            txt_emp_phone2.Text = dt.Rows[0][11].ToString();
            txt_employee_id.Text = dt.Rows[0][12].ToString();
            txt_emp_salary.Text = dt.Rows[0][13].ToString();


            dt = cls_employee.Search_ongoing_project_names(mod.value.ToString());

            panel_active_projects.Controls.Clear();

            var Top = 20;
            Label newlabel;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                newlabel = new Label();
                newlabel.Left = 20;
                newlabel.Height = 15;
                newlabel.Top = Top;
                newlabel.Text = dt.Rows[i][0].ToString();
                panel_active_projects.Controls.Add(newlabel);
                Top += 20;
            }


            dt = cls_employee.Search_completed_project_names(mod.value.ToString());

            panel_completed_projects.Controls.Clear();

            Top = 20;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                newlabel = new Label();
                newlabel.Left = 20;
                newlabel.Height = 15;
                newlabel.Top = Top;
                newlabel.Text = dt.Rows[i][0].ToString();
                panel_completed_projects.Controls.Add(newlabel);
                Top += 20;
            }


            dt = cls_employee.ShowEmployeeSkills(mod.value.ToString());

            panel_EmpSkills.Controls.Clear();

            Top = 20;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                newlabel = new Label();
                newlabel.Left = 20;
                newlabel.Height = 15;
                newlabel.Top = Top;
                newlabel.Text = dt.Rows[i][0].ToString();
                panel_EmpSkills.Controls.Add(newlabel);
                Top += 20;
            }


        }


        public void clear_texts()
        {

            txt_emp_name.Text = "";
            txt_emp_father_name.Text = "";
            txt_emp_cnic.Text = "";
            txt_emp_dob.Text = "";
            txt_emp_address.Text = "";
            txt_emp_agreement.Text = "";
            txt_emp_type.Text = "";
            txt_emp_gender.Text = "";
            txt_emp_designation.Text = "";
            txt_emp_qualification.Text = "";
            txt_emp_phone1.Text = "";
            txt_emp_phone2.Text = "";
            txt_employee_id.Text = "";
            txt_emp_salary.Text = "";

        }

        public void Add_Method()
        {
            groupBox_Active_Projects.Hide();
            groupBox_Completed_Projects.Hide();
            groupBox_Employee_Skills.Hide();

            label_function_name.Text = "Insert Employee";
            btn_edit.Hide();
            update_Btn.Hide();
            add_Btn.Show();
            panel_emp_info_modify.Show();
            clear_texts();
            enable_textboxes();
        }

        private void picture_add_employee_Click(object sender, EventArgs e)
        {
            Add_Method();
        }

        private void label_add_employee_Click(object sender, EventArgs e)
        {
            Add_Method();
        }




        private void update_Btn_Click(object sender, EventArgs e)
        {
            cls_employee.UpdateEmployeeData(txt_emp_name.Text, txt_emp_father_name.Text, txt_emp_cnic.Text, txt_emp_dob.Text, txt_emp_address.Text, txt_emp_agreement.Text, txt_emp_type.Text, txt_emp_gender.Text, txt_emp_designation.Text, txt_emp_qualification.Text, txt_emp_phone1.Text, txt_emp_phone2.Text, txt_employee_id.Text, txt_emp_salary.Text);
            Refresh();
        }

        private void btn_sort_emp_name_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txt_search_emp_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_emp_name.Text == "Employee Name")
            {
                return;
            }

            dt = cls_employee.SearchByName(txt_search_emp_name.Text);
            count = dt.Rows.Count;
            get_UC();
        }

        private void txt_search_emp_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_emp_id.Text == "Employee ID")
            {
                return;
            }

            dt = cls_employee.SearchById(txt_search_emp_id.Text);
            count = dt.Rows.Count;
            get_UC();
        }

        private void btn_sort_emp_type_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            cls_employee.AddEmployeeData(txt_emp_name.Text, txt_emp_father_name.Text, txt_emp_cnic.Text, txt_emp_dob.Text, txt_emp_address.Text, txt_emp_agreement.Text, txt_emp_type.Text, txt_emp_gender.Text, txt_emp_designation.Text, txt_emp_qualification.Text, txt_emp_phone1.Text, txt_emp_phone2.Text, txt_employee_id.Text, txt_emp_salary.Text);
            Refresh();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            groupBox_Active_Projects.Hide();
            groupBox_Completed_Projects.Hide();
            groupBox_Employee_Skills.Hide();

            label_function_name.Text = "Update Employee";
            enable_textboxes();
            update_Btn.Show();
            btn_edit.Hide();
            add_Btn.Hide();
            txt_employee_id.ReadOnly = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label_Manage_Designations_Click(object sender, EventArgs e)
        {
            Manage_Designation_Form form_design = new Manage_Designation_Form();
            form_design.Show();
        }

        private void label_Manage_EmpTypes_Click(object sender, EventArgs e)
        {
            Manage_EmployeeType_Form form_type = new Manage_EmployeeType_Form();
            form_type.Show();
        }

        private void label_Manage_Skills_Click(object sender, EventArgs e)
        {
            Manage_Skills_Form form_skills = new Manage_Skills_Form();
            form_skills.Show();
        }

        private void txt_search_emp_name_Click(object sender, EventArgs e)
        {
            txt_search_emp_id.SelectedIndex = 0;
        }

        private void txt_search_emp_id_Click(object sender, EventArgs e)
        {
            txt_search_emp_name.SelectedIndex = 0;
        }

        private void label_Manage_Qualification_Click(object sender, EventArgs e)
        {
            Manage_Qualification_Form form_qualification = new Manage_Qualification_Form();
            form_qualification.Show();
        }

        private void label_Manage_EmpSkills_Click(object sender, EventArgs e)
        {
            Manage_EmployeeSkills_Form form_empskills = new Manage_EmployeeSkills_Form();
            form_empskills.Show();
        }
    }
}
