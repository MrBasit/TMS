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
    public partial class Income_form : Form
    {
        public Income_form()
        {
            InitializeComponent();
        }

        UC_Modify modify_UC;
        UC_Project_Income_Data pro_income_UC;
        UC_Academy_Income_Data academy_income_UC;
        Add_Update_Income_Form modify;
        RichTextBox txt_rich;
        DataTable dt;
        public int count = 0;

        Model_Income cls_income = new Model_Income();

        private void Income_form_Load(object sender, EventArgs e)
        {              

            Refresh();
            
        }


        public void get_combobox_data()
        {

            txt_search_academy_specific_date.Items.Add("Day");
            txt_search_academy_specific_month.Items.Add("Month");
            txt_search_academy_specific_year.Items.Add("Year");
            txt_search_project_specific_date.Items.Add("Day");
            txt_search_project_specific_month.Items.Add("Month");
            txt_search_project_specific_year.Items.Add("Year");

            txt_search_pro_id.Items.Add("Project ID");
            txt_search_pro_name.Items.Add("Project Name");
            txt_search_std_id.Items.Add("Student ID");
            txt_search_std_name.Items.Add("Student Name");


            dt = cls_income.ShowIncome("select Name from ProjectTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_pro_name.Items.Add(dr["Name"].ToString());

            dt = cls_income.ShowIncome("select Pro_ID from ProjectTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_pro_id.Items.Add(dr["Pro_ID"].ToString());

            dt = cls_income.ShowIncome("select Name from StudentsTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_std_name.Items.Add(dr["Name"].ToString());

            dt = cls_income.ShowIncome("select Std_ID from StudentsTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_std_id.Items.Add(dr["Std_ID"].ToString());

            dt = cls_income.ShowIncome("select distinct Year(Date) IncYear from ProjectIncomeTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_project_specific_year.Items.Add(dr["IncYear"].ToString());

            dt = cls_income.ShowIncome("select distinct Year(Date) IncYear from AcademyIncomeTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_academy_specific_year.Items.Add(dr["IncYear"].ToString());


        }


        public void Clear_Combobox()
        {

            txt_search_pro_name.Items.Clear();
            txt_search_pro_id.Items.Clear();
            txt_search_std_name.Items.Clear();
            txt_search_std_id.Items.Clear();
            txt_search_project_specific_year.Items.Clear();
            txt_search_academy_specific_year.Items.Clear();

        }

        public void Refresh()
        {

            Clear_Combobox();
            get_combobox_data();

            txt_search_academy_specific_month.Enabled = false;
            txt_search_academy_specific_date.Enabled = false;

            txt_search_project_specific_month.Enabled = false;
            txt_search_project_specific_date.Enabled = false;

            panel_add_student.Hide();

            if (btn_view_project_income.Checked)
            {

                txt_search_project_specific_date.SelectedIndex = 31;
                txt_search_project_specific_month.SelectedIndex = 12;
                txt_search_project_specific_year.SelectedIndex = 0;
                txt_search_pro_id.SelectedIndex = 0;
                txt_search_pro_name.SelectedIndex = 0;

                dt = cls_income.Allprojectdatashow();
                count = dt.Rows.Count;

                get_project_UC();
            }

            else
            {

                txt_search_academy_specific_date.SelectedIndex = 31;
                txt_search_academy_specific_month.SelectedIndex = 12;
                txt_search_academy_specific_year.SelectedIndex = 0;
                txt_search_std_id.SelectedIndex = 0;
                txt_search_std_name.SelectedIndex = 0;

                dt = cls_income.AllAcademydatashow();
                count = dt.Rows.Count;

                get_academy_UC();
            }

        }



        public void get_project_UC()
        {

            panel_add_student.Hide();

            panel_project_data.Controls.Clear();
            panel_project_data.Show();
            panel_Project_Income.BringToFront();


            int j = 0;
            var Top = 10;
            var Left = 200;


            for (int i = 0; i < count; i++)
            {
                pro_income_UC = new UC_Project_Income_Data();
                pro_income_UC.Width = 710;
                pro_income_UC.Height = 25;

                pro_income_UC.label_projectincome_id.Text = dt.Rows[i][j++].ToString();
                pro_income_UC.label_project_name.Text = dt.Rows[i][j++].ToString();
                pro_income_UC.label_project_id.Text = dt.Rows[i][j++].ToString();
                pro_income_UC.label_project_amount.Text = dt.Rows[i][j++].ToString();
                pro_income_UC.label_project_date.Text =(Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy"));


                pro_income_UC.Left = 0;
                pro_income_UC.Top = Top;
                panel_project_data.Controls.Add(pro_income_UC);

                modify_UC = new UC_Modify();

                modify_UC.Width = 30;
                modify_UC.Height = 30;
                modify_UC.Top = Top;
                modify_UC.Left = Left + 515;

                modify_UC.value = dt.Rows[i][0].ToString();

                panel_project_data.Controls.Add(modify_UC);


                txt_rich = new RichTextBox();
                txt_rich.Top = Top;
                txt_rich.Height = 30;
                txt_rich.Width = 200;
                txt_rich.Left = Left + 570;
                txt_rich.Text = dt.Rows[i][j++].ToString();
                txt_rich.Enabled = false;
                panel_project_data.Controls.Add(txt_rich);


                Top += 60;
                j = 0;

                modify_UC.pic_update.Click += new EventHandler(pic_update_projectincome_Click);

            }

        }


        private void pic_update_projectincome_Click(object sender, EventArgs e)
        {
            panel_add_student.Hide();
            
            modify = new Add_Update_Income_Form(this);

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_income.SearchbyProjectIncomeid(mod.value.ToString());

            modify.Function_Name = "Update";
            modify.Income_Type = "Project";
            modify.dt = this.dt;
            modify.Show();

        }

        private void label_project_date_Click(object sender, EventArgs e)
        {

        }

        private void btn_sort_pro_name_CheckedChanged(object sender, EventArgs e)
        {

            txt_search_project_specific_month.Enabled = false;
            txt_search_project_specific_date.Enabled = false;

            txt_search_project_specific_date.SelectedIndex = 31;
            txt_search_project_specific_month.SelectedIndex = 12;
            txt_search_project_specific_year.SelectedIndex = 0;
            txt_search_pro_id.SelectedIndex = 0;
            txt_search_pro_name.SelectedIndex = 0;

            dt = cls_income.SortingName(); ;
            count = dt.Rows.Count;

            get_project_UC();

        }

        private void btn_sort_pro_amount_asc_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_project_specific_month.Enabled = false;
            txt_search_project_specific_date.Enabled = false;

            txt_search_project_specific_date.SelectedIndex = 31;
            txt_search_project_specific_month.SelectedIndex = 12;
            txt_search_project_specific_year.SelectedIndex = 0;
            txt_search_pro_id.SelectedIndex = 0;
            txt_search_pro_name.SelectedIndex = 0;

            dt = cls_income.SortingAmountAscending();
            count = dt.Rows.Count;

            get_project_UC();
        }

        private void btn_sort_pro_amount_desc_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_project_specific_month.Enabled = false;
            txt_search_project_specific_date.Enabled = false;

            txt_search_project_specific_date.SelectedIndex = 31;
            txt_search_project_specific_month.SelectedIndex = 12;
            txt_search_project_specific_year.SelectedIndex = 0;
            txt_search_pro_id.SelectedIndex = 0;
            txt_search_pro_name.SelectedIndex = 0;

            dt = cls_income.SortingAmountdescending();
            count = dt.Rows.Count;

            get_project_UC();
        }

        private void txt_search_pro_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_pro_name.Text == "Project Name")
            {
                return;
            }

            dt = cls_income.SearchbyProjectName(txt_search_pro_name.Text.ToString());
            count = dt.Rows.Count;

            get_project_UC();
        }

        private void txt_search_pro_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_pro_id.Text == "Project ID")
            {
                return;
            }

            dt = cls_income.SearchbyProjectid(txt_search_pro_id.Text.ToString());
            count = dt.Rows.Count;

            get_project_UC();
        }


        private void panel_data_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_select_income_SelectedIndexChanged(object sender, EventArgs e)
        {

            panel_add_student.Hide();

            if (txt_select_income.Text == "Today")
            {
                dt = cls_income.today_Proj_income_Sum(DateTime.Now.Date.ToShortDateString());
                label_project_income.Text = "Project:"+dt.Rows[0][0].ToString() + "Rps";
                string pro = dt.Rows[0][0].ToString();

                dt = cls_income.today_academy_income_Sum(DateTime.Now.Date.ToShortDateString());
                label_academy_income.Text = "Academy:" + dt.Rows[0][0].ToString() + "Rps";
                string acad = dt.Rows[0][0].ToString();

                if (label_project_income.Text == "")
                {
                    label_project_income.Text = "Project:" + "0Rps";
                    return;
                }

                if (label_academy_income.Text == "")
                {
                    label_academy_income.Text = "Academy:" + "0Rps";

                }

                if (label_project_income.Text == "" && label_academy_income.Text == "")
                {
                    label_overall_income.Text = "Overall:" + "0Rps";
                }

                else
                {
                    label_overall_income.Text = "Overall:" + (Convert.ToInt32(pro) + Convert.ToInt32(acad)).ToString() + "Rps";
                }

            }


            else if (txt_select_income.Text == "This Month")
            {
                dt = cls_income.ProjectIncomeSum_Month();
                label_project_income.Text = "Project:" + dt.Rows[0][0].ToString() + "Rps";
                string pro = dt.Rows[0][0].ToString();

                dt = cls_income.AcademyIncomeSum_Month();
                label_academy_income.Text = "Academy:" + dt.Rows[0][0].ToString() + "Rps";
                string acad = dt.Rows[0][0].ToString();

                if (label_project_income.Text == "")
                {
                    label_project_income.Text = "Project:" + "0Rps";
                    return;
                }

                if (label_academy_income.Text == "")
                {
                    label_academy_income.Text = "Academy:" + "0Rps";

                }

                if (label_project_income.Text == "" && label_academy_income.Text == "")
                {
                    label_overall_income.Text = "Overall:" + "0";
                }
                else
                {
                    label_overall_income.Text = "Overall:" + (Convert.ToInt32(pro) + Convert.ToInt32(acad)).ToString() + "Rps";
                }
            }

            else if (txt_select_income.Text == "This Year")
            {
                dt = cls_income.ProjectIncomeSum_Year();
                label_project_income.Text = "Project:" + dt.Rows[0][0].ToString() + "Rps";
                string pro = dt.Rows[0][0].ToString();

                dt = cls_income.AcademyIncomeSum_Year();
                label_academy_income.Text = "Academy:" + dt.Rows[0][0].ToString() + "Rps";
                string acad = dt.Rows[0][0].ToString();

                if (label_project_income.Text == "")
                {
                    label_project_income.Text = "Project:" + "0Rps";
                    return;
                }

                if (label_academy_income.Text == "")
                {
                    label_academy_income.Text = "Academy:" + "0Rps";

                }

                if (label_project_income.Text == "" && label_academy_income.Text == "")
                {
                    label_overall_income.Text = "Overall:" + "0Rps";
                }
                else
                {
                    label_overall_income.Text = "Overall:" + (Convert.ToInt32(pro) + Convert.ToInt32(acad)).ToString() + "Rps";
                }

            }


        }


        private void txt_search_project_specific_date_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_project_specific_date.Text == "Day")
            {
                return;
            }

            dt = cls_income.SearchBy_specific_Date_ProjectIncome(txt_search_project_specific_year.Text, txt_search_project_specific_month.Text, txt_search_project_specific_date.Text);
            count = dt.Rows.Count;

            get_project_UC();

        }

        private void txt_search_project_specific_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_project_specific_month.Text == "Month")
            {
                return;
            }

            txt_search_project_specific_date.Enabled = true;

            dt = cls_income.SearchBy_specific_month_ProjectIncome(txt_search_project_specific_year.Text, txt_search_project_specific_month.Text);
            count = dt.Rows.Count;

            get_project_UC();

        }

        private void txt_search_project_specific_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_project_specific_year.Text == "Year")
            {
                return;
            }

            txt_search_project_specific_month.Enabled = true;
            txt_search_project_specific_date.Enabled = false;

            dt = cls_income.SearchBy_specific_Year_ProjectIncome(txt_search_project_specific_year.Text);
            count = dt.Rows.Count;

            get_project_UC();
        }

        private void btn_view_project_income_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_view_academy_income_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }
























        public void get_academy_UC()
        {
            panel_add_student.Hide();

            panel_academy_data.Controls.Clear();
            panel_academy_data.Show();
            panel_Academy_Income.BringToFront();


            int j = 0;
            var Top = 10;
            var Left = 200;

            //MessageBox.Show(DateTime.Now.Date.ToString());

            for (int i = 0; i < count; i++)
            {
                academy_income_UC = new UC_Academy_Income_Data();
                academy_income_UC.Width = 620;
                academy_income_UC.Height = 25;

                academy_income_UC.label_academyincome_id.Text = dt.Rows[i][j++].ToString();
                academy_income_UC.label_std_id.Text = dt.Rows[i][j++].ToString();
                academy_income_UC.label_std_name.Text = dt.Rows[i][j++].ToString();
                academy_income_UC.label_std_amount.Text = dt.Rows[i][j++].ToString();
                academy_income_UC.label_std_date.Text = (Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy"));



                academy_income_UC.Left = 0;
                academy_income_UC.Top = Top;
                panel_academy_data.Controls.Add(academy_income_UC);

                modify_UC = new UC_Modify();

                modify_UC.Width = 30;
                modify_UC.Height = 30;
                modify_UC.Top = Top;
                modify_UC.Left = Left + 440;

                modify_UC.value = dt.Rows[i][0].ToString();

                panel_academy_data.Controls.Add(modify_UC);


                txt_rich = new RichTextBox();
                txt_rich.Top = Top;
                txt_rich.Height = 30;
                txt_rich.Width = 200;
                txt_rich.Left = Left + 505;
                txt_rich.Text = dt.Rows[i][j++].ToString();
                txt_rich.Enabled = false;
                panel_academy_data.Controls.Add(txt_rich);


                Top += 60;
                j = 0;

                modify_UC.pic_update.Click += new EventHandler(pic_update_academyincome_Click);
                //modify_UC.pic_delete.Click += new EventHandler(pic_delete_Click);
                //modify_UC.pic_info.Click += new EventHandler(pic_info_Click);

            }


        }


        private void pic_update_academyincome_Click(object sender, EventArgs e)
        {
            panel_add_student.Hide();

            modify = new Add_Update_Income_Form(this);

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_income.Academydatashowbyacademyincomeid(mod.value.ToString());

            modify.Function_Name = "Update";
            modify.Income_Type = "Academy";
            modify.dt = this.dt;
            modify.Show();

        }




        private void btn_sort_by_std_name_CheckedChanged(object sender, EventArgs e)
        {

            txt_search_academy_specific_month.Enabled = false;
            txt_search_academy_specific_date.Enabled = false;

            txt_search_academy_specific_date.SelectedIndex = 31;
            txt_search_academy_specific_month.SelectedIndex = 12;
            txt_search_academy_specific_year.SelectedIndex = 0;
            txt_search_std_name.SelectedIndex = 0;
            txt_search_std_id.SelectedIndex = 0;

            dt = cls_income.Academyincomedatasortbyname();
            count = dt.Rows.Count;

            get_academy_UC();
        }

        private void txt_search_std_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_std_name.Text == "Student Name")
            {
                return;

            }


            dt = cls_income.Academydatashowbyname(txt_search_std_name.Text);
            count = dt.Rows.Count;

            get_academy_UC();
        }

        private void txt_search_std_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_std_id.Text == "Student ID")
            {
                return;
            }

            dt = cls_income.Academydatashowbyids(txt_search_std_id.Text);
            count = dt.Rows.Count;

            get_academy_UC();

        }

        private void txt_search_academy_specific_date_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_academy_specific_date.Text == "Day")
            {
                return;
            }

            dt = cls_income.searchinAcademyIncomebyspecific_day(txt_search_academy_specific_year.Text, txt_search_academy_specific_month.Text , txt_search_academy_specific_date.Text);
            count = dt.Rows.Count;

            get_academy_UC();

        }

        private void txt_search_academy_specific_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_academy_specific_month.Text == "Month")
            {
                return;
            }

            txt_search_academy_specific_date.Enabled = true;

            dt = cls_income.searchinAcademyIncomebyspecific_month(txt_search_academy_specific_year.Text, txt_search_academy_specific_month.Text);
            count = dt.Rows.Count;

            get_academy_UC();

        }

        private void txt_search_academy_specific_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_academy_specific_year.Text == "Year")
            {
                return;
            }

            txt_search_academy_specific_month.Enabled = true;
            txt_search_academy_specific_date.Enabled = false;

            dt = cls_income.searchAcademyIncomebyspecific_year(txt_search_academy_specific_year.Text);
            count = dt.Rows.Count;

            get_academy_UC();

        }

        private void btn_sort_by_date_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_academy_specific_month.Enabled = false;
            txt_search_academy_specific_date.Enabled = false;

            txt_search_academy_specific_date.SelectedIndex = 31;
            txt_search_academy_specific_month.SelectedIndex = 12;
            txt_search_academy_specific_year.SelectedIndex = 0;
            txt_search_std_name.SelectedIndex = 0;
            txt_search_std_id.SelectedIndex = 0;

            dt = cls_income.AcademydatasortbyDATE();
            count = dt.Rows.Count;

            get_academy_UC();

        }


        private void label_add_projectincome_Click(object sender, EventArgs e)
        {
            modify = new Add_Update_Income_Form(this);
            modify.Function_Name = "Add";
            modify.Income_Type = "Project";
            modify.Show();
        }

        private void label_add_academyincome_Click(object sender, EventArgs e)
        {
            modify = new Add_Update_Income_Form(this);
            modify.Function_Name = "Add";
            modify.Income_Type = "Academy";
            modify.Show();
        }

        private void picture_add_academyincome_Click(object sender, EventArgs e)
        {
            modify = new Add_Update_Income_Form(this);
            modify.Function_Name = "Add";
            modify.Income_Type = "Academy";
            modify.Show();
        }

        private void picture_add_projectincome_Click(object sender, EventArgs e)
        {
            modify = new Add_Update_Income_Form(this);
            modify.Function_Name = "Add";
            modify.Income_Type = "Project";
            modify.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel_Academy_Income_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_add_student_Click(object sender, EventArgs e)
        {
            panel_add_student.Show();
        }

        private void picture_add_student_Click(object sender, EventArgs e)
        {
            panel_add_student.Show();
        }


        Model_Students cls_student;


        private void btn_add_student_Click(object sender, EventArgs e)
        {
            cls_student = new Model_Students();
            cls_student.AddStudent(txt_student_name.Text);
        }

        private void txt_search_project_specific_year_Click(object sender, EventArgs e)
        {
            txt_search_project_specific_month.Enabled = false;
            txt_search_project_specific_date.Enabled = false;

            txt_search_project_specific_date.SelectedIndex = 31;
            txt_search_project_specific_month.SelectedIndex = 12;
            txt_search_pro_id.SelectedIndex = 0;
            txt_search_pro_name.SelectedIndex = 0;

        }

        private void txt_search_project_specific_month_Click(object sender, EventArgs e)
        {
            txt_search_project_specific_date.Enabled = false;

            txt_search_project_specific_date.SelectedIndex = 31;
            txt_search_pro_id.SelectedIndex = 0;
            txt_search_pro_name.SelectedIndex = 0;

        }

        private void txt_search_project_specific_date_Click(object sender, EventArgs e)
        {
            txt_search_pro_id.SelectedIndex = 0;
            txt_search_pro_name.SelectedIndex = 0;

        }

        private void txt_search_pro_name_Click(object sender, EventArgs e)
        {
            txt_search_project_specific_month.Enabled = false;
            txt_search_project_specific_date.Enabled = false;

            txt_search_project_specific_date.SelectedIndex = 31;
            txt_search_project_specific_month.SelectedIndex = 12;
            txt_search_project_specific_year.SelectedIndex = 0;
            txt_search_pro_id.SelectedIndex = 0;

        }

        private void txt_search_pro_id_Click(object sender, EventArgs e)
        {
            txt_search_project_specific_month.Enabled = false;
            txt_search_project_specific_date.Enabled = false;

            txt_search_project_specific_date.SelectedIndex = 31;
            txt_search_project_specific_month.SelectedIndex = 12;
            txt_search_project_specific_year.SelectedIndex = 0;
            txt_search_pro_name.SelectedIndex = 0;

        }

        private void txt_search_std_name_Click(object sender, EventArgs e)
        {

            txt_search_academy_specific_month.Enabled = false;
            txt_search_academy_specific_date.Enabled = false;

            txt_search_academy_specific_date.SelectedIndex = 31;
            txt_search_academy_specific_month.SelectedIndex = 12;
            txt_search_academy_specific_year.SelectedIndex = 0;
            txt_search_std_id.SelectedIndex = 0;

        }

        private void txt_search_std_id_Click(object sender, EventArgs e)
        {

            txt_search_academy_specific_month.Enabled = false;
            txt_search_academy_specific_date.Enabled = false;

            txt_search_academy_specific_date.SelectedIndex = 31;
            txt_search_academy_specific_month.SelectedIndex = 12;
            txt_search_academy_specific_year.SelectedIndex = 0;
            txt_search_std_name.SelectedIndex = 0;

        }

        private void txt_search_academy_specific_year_Click(object sender, EventArgs e)
        {
            txt_search_academy_specific_month.Enabled = false;
            txt_search_academy_specific_date.Enabled = false;

            txt_search_academy_specific_date.SelectedIndex = 31;
            txt_search_academy_specific_month.SelectedIndex = 12;
            txt_search_std_name.SelectedIndex = 0;
            txt_search_std_id.SelectedIndex = 0;

        }

        private void txt_search_academy_specific_month_Click(object sender, EventArgs e)
        {
            txt_search_academy_specific_date.Enabled = false;

            txt_search_academy_specific_date.SelectedIndex = 31;
            txt_search_std_name.SelectedIndex = 0;
            txt_search_std_id.SelectedIndex = 0;

        }

        private void txt_search_academy_specific_date_Click(object sender, EventArgs e)
        {

            txt_search_std_name.SelectedIndex = 0;
            txt_search_std_id.SelectedIndex = 0;

        }
    }
}

