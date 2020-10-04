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
    public partial class Add_Update_Income_Form : Form
    {
        Income_form income;

        public Add_Update_Income_Form(Income_form inc)
        {
            InitializeComponent();
            income = inc;
        }

        public DataTable dt = new DataTable();
        public DataTable dt1 = new DataTable();
        Model_Income cls_income = new Model_Income();

        public string Function_Name = "";
        public string Income_Type = "";
        int count = 0;


        public void get_combobox_data()
        {

            dt1 = cls_income.ShowIncome("select Std_ID from StudentsTable");
            foreach (DataRow dr in dt1.Rows)
            {
                txt_academyincome_stdid_add.Items.Add(dr["Std_ID"].ToString());
                txt_academyincome_stdid_update.Items.Add(dr["Std_ID"].ToString());
            }

            dt1 = cls_income.ShowIncome("select Pro_ID from ProjectTable");
            foreach (DataRow dr in dt1.Rows)
            {
                txt_projectincome_projectid_add.Items.Add(dr["Pro_ID"].ToString());
                txt_projectincome_projectid_update.Items.Add(dr["Pro_ID"].ToString());
            }

        }


        private void Add_Update_Income_Form_Load(object sender, EventArgs e)
        {

            get_combobox_data();

            txt_academyincome_date.Enabled = false;
            txt_projectincome_date.Enabled = false;
            txt_academyincome_id.ReadOnly = true;
            txt_projectincome_id.ReadOnly = true;

            if (Income_Type == "Project" && Function_Name == "Add")
            {
                label_function_name.Text = "Add Project Income"; 
                txt_projectincome_projectid_add.BringToFront();
                panel_modify_projectincome.BringToFront();
                btn_add_projectincome.BringToFront();
                clear_texts();
                txt_projectincome_date.Text = DateTime.Now.ToShortDateString();
                txt_projectincome_date.Enabled = false;

            }

            else if (Income_Type == "Academy" && Function_Name == "Add")
            {
                label_function_name.Text = "Add Academy Income";
                txt_academyincome_stdid_add.BringToFront();
                panel_modify_academyincome.BringToFront();
                btn_add_academyincome.BringToFront();
                clear_texts();
                txt_academyincome_date.Text = DateTime.Now.ToShortDateString();
                txt_academyincome_date.Enabled = false;
            }


            if (Income_Type == "Project" && Function_Name == "Update")
            {
                label_function_name.Text = "Update Project Income";
                txt_projectincome_projectid_update.BringToFront();
                panel_modify_projectincome.BringToFront();
                btn_update_projectincome.BringToFront();
                count = dt.Rows.Count;

                txt_projectincome_id.Text = dt.Rows[0][0].ToString();
                txt_projectincome_projectid_update.Text = dt.Rows[0][2].ToString();
                txt_projectincome_amount.Text = dt.Rows[0][3].ToString();
                txt_projectincome_date.Text = Convert.ToDateTime(dt.Rows[0][4].ToString()).ToShortDateString();
                txt_projectincome_note.Text = dt.Rows[0][5].ToString();

                txt_projectincome_id.ReadOnly = true;
                txt_projectincome_date.Enabled = false;
                txt_projectincome_projectid_update.Enabled = false;

            }

            else if (Income_Type == "Academy" && Function_Name == "Update")
            {
                label_function_name.Text = "Update Academy Income";
                txt_academyincome_stdid_update.BringToFront();
                panel_modify_academyincome.BringToFront();
                btn_update_academyincome.BringToFront();
                count = dt.Rows.Count;

                txt_academyincome_id.Text = dt.Rows[0][0].ToString();
                txt_academyincome_stdid_update.Text = dt.Rows[0][1].ToString();
                txt_academyincome_amount.Text = dt.Rows[0][3].ToString();
                txt_academyincome_date.Text = Convert.ToDateTime(dt.Rows[0][4].ToString()).ToShortDateString();
                txt_academyincome_note.Text = dt.Rows[0][5].ToString();

                txt_academyincome_id.ReadOnly = true;
                txt_academyincome_date.Enabled = false;
                txt_academyincome_stdid_update.Enabled = false;
            }


        }

        public void clear_texts()
        {

            txt_projectincome_projectid_add.Text = "";
            txt_projectincome_projectid_update.Text = "";
            txt_projectincome_amount.Text = "";
            txt_projectincome_date.Text = "";
            txt_projectincome_note.Text = "";

            txt_academyincome_stdid_add.Text = "";
            txt_academyincome_stdid_update.Text = "";
            txt_academyincome_amount.Text = "";
            txt_academyincome_note.Text = "";
            txt_academyincome_date.Text = "";

               
        }


        private void btn_add_academyincome_Click(object sender, EventArgs e)
        {
            cls_income.Addincome(txt_academyincome_stdid_add.Text, txt_academyincome_amount.Text, txt_academyincome_note.Text);
            income.Refresh();
        }

        private void btn_update_academyincome_Click(object sender, EventArgs e)
        {
            cls_income.ProcUpdateAcademyIncome(Convert.ToInt32(txt_academyincome_id.Text), Convert.ToInt32(txt_academyincome_stdid_update.Text), txt_academyincome_amount.Text, txt_academyincome_note.Text, txt_academyincome_date.Text);
            income.Refresh();
        }

        private void btn_add_projectincome_Click(object sender, EventArgs e)
        {
            cls_income.Addprojectincome(txt_projectincome_projectid_add.Text , txt_projectincome_amount.Text , txt_projectincome_note.Text);
            income.Refresh();
        }

        private void btn_update_projectincome_Click(object sender, EventArgs e)
        {
            cls_income.ProcUpdateProjectIncome(Convert.ToInt32(txt_projectincome_id.Text), Convert.ToInt32(txt_projectincome_projectid_update.Text), txt_projectincome_amount.Text, txt_projectincome_note.Text, txt_projectincome_date.Text);
            income.Refresh();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_modify_academyincome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_projectincome_note_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_academyincome_stdid_add_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
