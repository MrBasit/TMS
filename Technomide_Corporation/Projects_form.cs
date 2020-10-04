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
    public partial class Projects_form : Form
    {

        UC_Modify modify_UC;
        UC_Project_Data proj_UC;
        DataTable dt;
        public int count = 0;

        Model_Project cls_project = new Model_Project();

        public Projects_form()
        {
            InitializeComponent();
        }

        private void Projects_form_Load(object sender, EventArgs e)
        {


            btn_sort_pro_name.Checked = true;
            Refresh();

        }



        public void get_combobox_data()
        {

            txt_search_pro_name.Items.Add("Project Name");
            txt_search_pro_date.Items.Add("Project Date");

            dt = cls_project.ShowProj("select Name from ProjectTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_pro_name.Items.Add(dr["Name"].ToString());

            dt = cls_project.ShowProj("select Name from ConsultantTable");
            foreach (DataRow dr in dt.Rows)
                txt_consultant_proj.Items.Add(dr["Name"].ToString());

            dt = cls_project.ShowProj("select Project_Date from ProjectTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_pro_date.Items.Add(dr["Project_Date"].ToString());

        }


        public void clear_combobox()
        {
            txt_search_pro_name.Items.Clear();
            txt_consultant_proj.Items.Clear();
            txt_search_pro_date.Items.Clear();

        }



        public void Refresh()
        {


            clear_combobox();
            get_combobox_data();

            txt_search_pro_name.SelectedIndex = 0;
            txt_search_pro_date.SelectedIndex = 0;

            panel_data.Left = 0;
            disabletextboxes();

            if (btn_sort_pro_name.Checked)
            {
                dt = cls_project.SortByName();
            }
            else
            {
                dt = cls_project.SortByStatus();
            }

            count = dt.Rows.Count;

            get_UC();
            update_Btn.Hide();
            add_Btn.Hide();

        }



        public void get_UC()
        {
            panel_data.Controls.Clear();
            panel_data.Show();
            panel_proj_info_modify.Hide();


            int j = 0;
            var Top = 10;
            var Left = 200;

            for (int i = 0; i < count; i++)
            {
                proj_UC = new UC_Project_Data();
                proj_UC.Width = 580;
                proj_UC.Height = 25;


                proj_UC.label_project_name.Text = dt.Rows[i][j++].ToString();
                proj_UC.label_project_id.Text = dt.Rows[i][j++].ToString();
                proj_UC.label_project_status.Text = dt.Rows[i][j++].ToString();
                proj_UC.label_project_amount.Text = dt.Rows[i][j++].ToString();

                j = 0;


                proj_UC.Left = 0;
                proj_UC.Top = Top;
                panel_data.Controls.Add(proj_UC);

                modify_UC = new UC_Modify();

                modify_UC.Width = 90;
                modify_UC.Height = 30;
                modify_UC.Top = Top;
                modify_UC.Left = Left + 400;

                modify_UC.value = dt.Rows[i][1].ToString();

                panel_data.Controls.Add(modify_UC);

                Top += 30;

                modify_UC.pic_update.Click += new EventHandler(pic_update_Click);
                modify_UC.pic_delete.Click += new EventHandler(pic_delete_Click);
                modify_UC.pic_info.Click += new EventHandler(pic_info_Click);

            }

        }


        private void pic_update_Click(object sender, EventArgs e)
        {
            groupBox_WorkingEmp.Hide();

            label_function_name.Text = "Update Project";
            panel_proj_info_modify.Show();
            enabletextboxes();
            update_Btn.Show();
            add_Btn.Hide();
            edit_Button.Hide();


            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_project.ProjectSearchByID(mod.value.ToString());

            txt_id_proj.Text = dt.Rows[0][col1++].ToString();
            txt_startdate_proj.Text = dt.Rows[0][col1++].ToString();
            txt_name_proj.Text = dt.Rows[0][col1++].ToString();
            txt_description_proj.Text = dt.Rows[0][col1++].ToString();
            txt_consultant_proj.Text = dt.Rows[0][col1++].ToString();
            txt_amount_proj.Text = dt.Rows[0][col1++].ToString();
            txt_completedate_proj.Text = dt.Rows[0][col1++].ToString();
            txt_delieverydate_proj.Text = dt.Rows[0][col1++].ToString();
            txt_dateproject.Text = dt.Rows[0][col1++].ToString();

            col1 = 0;

            txt_id_proj.ReadOnly = true;

        }
        private void pic_delete_Click(object sender, EventArgs e)
        {
            add_Btn.Hide();

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            cls_project.DeleteProjectByID(Convert.ToInt32(mod.value));
            Refresh();

        }


        int col1 = 0;

        private void pic_info_Click(object sender, EventArgs e)
        {
            label_function_name.Text = "Project Info";

            Projects_form pro_form = new Projects_form();

            groupBox_WorkingEmp.Show();
            add_Btn.Hide();
            update_Btn.Hide();
            edit_Button.Show();

            panel_proj_info_modify.Show();
            disabletextboxes();

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_project.ProjectSearchByID(mod.value.ToString());

            txt_id_proj.Text = dt.Rows[0][col1++].ToString();
            txt_startdate_proj.Text = dt.Rows[0][col1++].ToString();
            txt_name_proj.Text = dt.Rows[0][col1++].ToString();
            txt_description_proj.Text = dt.Rows[0][col1++].ToString();
            txt_consultant_proj.Text = dt.Rows[0][col1++].ToString();
            txt_amount_proj.Text = dt.Rows[0][col1++].ToString();
            txt_completedate_proj.Text = dt.Rows[0][col1++].ToString();
            txt_delieverydate_proj.Text = dt.Rows[0][col1++].ToString();
            txt_dateproject.Text = dt.Rows[0][col1++].ToString();

            col1 = 0;

            dt = cls_project.EmployeesAssigentToProjectID(Convert.ToInt32(mod.value));

            panel_emp_working_projects.Controls.Clear();

            var Top = 10;
            Label newlabel;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                newlabel = new Label();
                newlabel.Left = 20;
                newlabel.Height = 15;
                newlabel.Top = Top;
                newlabel.Text = dt.Rows[i][0].ToString();
                panel_emp_working_projects.Controls.Add(newlabel);
                Top += 20;
            }

        }


        public void enabletextboxes()
        {
            txt_amount_proj.ReadOnly = false;
            txt_completedate_proj.Enabled = true;
            txt_dateproject.Enabled = true;
            txt_startdate_proj.Enabled = true;
            txt_delieverydate_proj.Enabled = true;
            txt_description_proj.ReadOnly = false;
            txt_id_proj.ReadOnly = false;
            txt_name_proj.ReadOnly = false;
        }

        public void disabletextboxes()
        {
            txt_amount_proj.ReadOnly = true;
            txt_completedate_proj.Enabled = false;
            txt_dateproject.Enabled = false;
            txt_startdate_proj.Enabled = false;
            txt_delieverydate_proj.Enabled = false;
            txt_description_proj.ReadOnly = true;
            txt_id_proj.ReadOnly = true;
            txt_name_proj.ReadOnly = true;
        }

        public void clear_texts()
        {

            txt_amount_proj.Text = "";
            txt_completedate_proj.Text = "";
            txt_consultant_proj.Text = "";
            txt_dateproject.Text = "";
            txt_startdate_proj.Text = "";
            txt_delieverydate_proj.Text = "";
            txt_description_proj.Text = "";
            txt_id_proj.Text = "";
            txt_name_proj.Text = "";

        }



        private void edit_Button_Click(object sender, EventArgs e)
        {
            groupBox_WorkingEmp.Hide();

            label_function_name.Text = "Update Project";
            enabletextboxes();
            update_Btn.Show();
            edit_Button.Hide();
        }


        private void update_Btn_Click(object sender, EventArgs e)
        {
            cls_project.UpdateProjectData(
                            Convert.ToInt32(txt_id_proj.Text), 
                            txt_startdate_proj.Text, 
                            txt_name_proj.Text, 
                            txt_description_proj.Text,
                            txt_consultant_proj.Text,
                            txt_amount_proj.Text,
                            txt_completedate_proj.Text, 
                            txt_delieverydate_proj.Text, 
                            txt_dateproject.Text);
            Refresh();
        }


        private void add_Btn_Click(object sender, EventArgs e)
        {
            cls_project.AddProjectData(txt_startdate_proj.Text, txt_name_proj.Text, txt_description_proj.Text, txt_consultant_proj.Text, txt_amount_proj.Text,  txt_completedate_proj.Text, txt_delieverydate_proj.Text, txt_dateproject.Text);
            Refresh();
        }


        public void Add_Btn()
        {
            groupBox_WorkingEmp.Hide();

            label_function_name.Text = "Insert Project";
            clear_texts();
            add_Btn.Show();
            panel_proj_info_modify.Show();
            enabletextboxes();
            update_Btn.Hide();
            edit_Button.Hide();
            txt_id_proj.ReadOnly = true;
        }

        private void label_add_employee_Click(object sender, EventArgs e)
        {
            Add_Btn();
        }

        private void picture_add_employee_Click(object sender, EventArgs e)
        {
            Add_Btn();
        }

        private void btn_sort_pro_status_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_sort_pro_name_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txt_search_pro_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_pro_name.Text == "Project Name")
            {
                return;
            }

            dt = cls_project.ProjectSearchByName(txt_search_pro_name.Text);
            count = dt.Rows.Count;
            get_UC();
            update_Btn.Hide();
            add_Btn.Hide();

        }

        private void txt_search_pro_date_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_pro_date.Text == "Project Date")
            {
                return;
            }

            dt = cls_project.ProjectSearchByDate(txt_search_pro_date.Text);
            count = dt.Rows.Count;
            get_UC();
            update_Btn.Hide();
            add_Btn.Hide();

        }

        private void txt_search_pro_name_Click(object sender, EventArgs e)
        {
            txt_search_pro_date.SelectedIndex = 0;
        }

        private void txt_search_pro_date_Click(object sender, EventArgs e)
        {
            txt_search_pro_name.SelectedIndex = 0;
        }
    }
}
