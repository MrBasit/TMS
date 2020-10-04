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
    public partial class Consultants_Form : Form
    {
        UC_Modify modify_UC;
        UC_Consultant_Data cons_UC;
        DataTable dt = new DataTable();
        Model_Consultant cls_consultant = new Model_Consultant();
        int count = 0;


        public Consultants_Form()
        {
            InitializeComponent();
        }


        private void Consultants_Form_Load(object sender, EventArgs e)
        {


            Refresh();
        }


        public void get_combobox_data()
        {

            txt_search_cons_name.Items.Add("Consultant Name");
            txt_search_cons_id.Items.Add("Consultant ID");


            dt = cls_consultant.ShowCons("Select Name from ConsultantTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_cons_name.Items.Add(dr["Name"].ToString());

            dt = cls_consultant.ShowCons("select Cons_ID from ConsultantTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_cons_id.Items.Add(dr["Cons_ID"].ToString());

        }


        public void clear_combobox()
        {

            txt_search_cons_name.Items.Clear();
            txt_search_cons_id.Items.Clear();


        }

        public void Refresh()
        {

            clear_combobox();
            get_combobox_data();

            txt_search_cons_name.SelectedIndex = 0;
            txt_search_cons_id.SelectedIndex = 0;

            update_Btn.Hide();
            panel_data.Left = 0;
            disabletextboxes();
            panel_consl_info_modify.Hide();

            dt = cls_consultant.ConsultantDetail();
            count = dt.Rows.Count;

            get_UC();

        }


        public void get_UC()
        {
            panel_data.Controls.Clear();
            panel_data.Show();
            panel_consl_info_modify.Hide();


            int j = 0;
            var Top = 10;
            var Left = 200;

            for (int i = 0; i < count; i++)
            {
                cons_UC = new UC_Consultant_Data();
                cons_UC.Width = 550;
                cons_UC.Height = 25;

                cons_UC.label_cons_id.Text = dt.Rows[i][j++].ToString();
                cons_UC.label_cons_name.Text = dt.Rows[i][j++].ToString();
                cons_UC.label_cons_phone1.Text = dt.Rows[i][j++].ToString();
                cons_UC.label_cons_phone2.Text = dt.Rows[i][j++].ToString();

                j = 0;

                cons_UC.Left = 5;
                cons_UC.Top = Top;
                panel_data.Controls.Add(cons_UC);

                modify_UC = new UC_Modify();
                modify_UC.Width = 90;
                modify_UC.Height = 30;
                modify_UC.value = dt.Rows[i][0].ToString();
                modify_UC.Top = Top;
                modify_UC.Left = Left + 370;
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
            groupBox_income.Hide();

            label_function_name.Text = "Update Consultant";
            add_Btn.Hide();
            panel_consl_info_modify.Show();
            update_Btn.Show();
            enabletextboxes();
            edit_BTn.Hide();

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_consultant.ConsultantAllDetailsByCons_ID(mod.value.ToString());

            txt_cons_id.Text = dt.Rows[0][0].ToString();
            txt_cons_name.Text = dt.Rows[0][1].ToString();
            txt_cons_father.Text = dt.Rows[0][2].ToString();
            txt_cons_dob.Text = Convert.ToDateTime(dt.Rows[0][3].ToString()).ToShortDateString();
            txt_cons_gender.Text = dt.Rows[0][4].ToString();
            txt_cons_address.Text = dt.Rows[0][5].ToString();
            txt_cons_phone1.Text = dt.Rows[0][6].ToString();
            txt_cons_phone2.Text = dt.Rows[0][7].ToString();

            txt_cons_id.ReadOnly = true;


        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            cls_consultant.DeleteFromConsultantTable(mod.value.ToString());

            Refresh();
        }

        private void pic_info_Click(object sender, EventArgs e)
        {

            groupBox_Active_Projects.Show();
            groupBox_Completed_Projects.Show();
            groupBox_income.Show();


            label_function_name.Text = "Consultant Info";
            add_Btn.Hide();
            edit_BTn.Show();
            update_Btn.Hide();
            panel_consl_info_modify.Show();
            disabletextboxes();

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_consultant.ConsultantAllDetailsByCons_ID(mod.value.ToString());

            txt_cons_id.Text = dt.Rows[0][0].ToString();
            txt_cons_name.Text = dt.Rows[0][1].ToString();
            txt_cons_father.Text = dt.Rows[0][2].ToString();
            txt_cons_dob.Text = Convert.ToDateTime(dt.Rows[0][3].ToString()).ToShortDateString();
            txt_cons_gender.Text = dt.Rows[0][4].ToString();
            txt_cons_address.Text = dt.Rows[0][5].ToString();
            txt_cons_phone1.Text = dt.Rows[0][6].ToString();
            txt_cons_phone2.Text = dt.Rows[0][7].ToString();

            dt = cls_consultant.ConsultantEarning(mod.value.ToString());

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == "")
                {
                    txt_cons_earn_income.Text = "0";
                }
                else
                {
                    txt_cons_earn_income.Text = dt.Rows[0][0].ToString();
                }
            }
            else
            {
                txt_cons_earn_income.Text = "0";
            }



            dt = cls_consultant.ConsultantexpectedEarnings(mod.value.ToString());

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == "")
                {
                    txt_cons_exp_income.Text = "0";
                }
                else
                {
                    txt_cons_exp_income.Text = dt.Rows[0][0].ToString();
                }
            }

            else
            {
                txt_cons_exp_income.Text = "0";
            }


            dt = cls_consultant.ConsultantOngoingProject(mod.value.ToString());

            panel_active_projects.Controls.Clear();

            var Top = 20;
            Label newlabel;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                newlabel = new Label();
                newlabel.Left = 20;
                newlabel.Height = 15;
                newlabel.Top = Top;
                newlabel.Text = dt.Rows[i][1].ToString();
                panel_active_projects.Controls.Add(newlabel);
                Top += 20;
            }


            dt = cls_consultant.ConsultantCompletedProject(mod.value.ToString());

            panel_completed_projects.Controls.Clear();

            Top = 20;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                newlabel = new Label();
                newlabel.Left = 20;
                newlabel.Height = 15;
                newlabel.Top = Top;
                newlabel.Text = dt.Rows[i][1].ToString();
                panel_completed_projects.Controls.Add(newlabel);
                Top += 20;
            }

        }


        private void enabletextboxes()
        {
            txt_cons_id.ReadOnly = false;
            txt_cons_name.ReadOnly = false;
            txt_cons_father.ReadOnly = false;
            txt_cons_dob.Enabled = true;
            txt_cons_address.ReadOnly = false;
            txt_cons_phone1.ReadOnly = false;
            txt_cons_phone2.ReadOnly = false;
            txt_cons_name.ReadOnly = false;
            txt_cons_id.ReadOnly = false;
        }

        private void disabletextboxes()
        {
            txt_cons_id.ReadOnly = true;
            txt_cons_name.ReadOnly = true;
            txt_cons_father.ReadOnly = true;
            txt_cons_dob.Enabled = false;
            txt_cons_address.ReadOnly = true;
            txt_cons_phone1.ReadOnly = true;
            txt_cons_phone2.ReadOnly = true;
            txt_cons_name.ReadOnly = true;
            txt_cons_id.ReadOnly = true;

        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            groupBox_Active_Projects.Hide();
            groupBox_Completed_Projects.Hide();
            groupBox_income.Hide();

            label_function_name.Text = "Update Consultant";
            edit_BTn.Hide();
            update_Btn.Show();
            add_Btn.Hide();
            enabletextboxes();
            txt_cons_id.ReadOnly = true;
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            cls_consultant.UpdateConsultact(txt_cons_name.Text, txt_cons_father.Text, txt_cons_dob.Text, txt_cons_gender.Text, txt_cons_address.Text, txt_cons_phone1.Text, txt_cons_phone2.Text, txt_cons_id.Text);
            Refresh();
        }

        private void txt_search_cons_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_cons_name.Text == "Consultant Name")
            {
                return;
            }

            dt = cls_consultant.ConsultantSomeDetailsByName(txt_search_cons_name.Text);
            count = dt.Rows.Count;
            get_UC();
        }

        private void txt_search_cons_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_cons_id.Text == "Consultant ID")
            {
                return;
            }

            dt = cls_consultant.ConsultantSomeDetailsByCons_ID(txt_search_cons_id.Text);
            count = dt.Rows.Count;
            get_UC();

        }


        public void clear_texts()
        {
            txt_cons_id.Text = "";
            txt_cons_name.Text = "";
            txt_cons_father.Text = "";
            txt_cons_dob.Text = "";
            txt_cons_gender.Text = "";
            txt_cons_address.Text = "";
            txt_cons_phone1.Text = "";
            txt_cons_phone2.Text = "";
            txt_cons_exp_income.Text = "";
            txt_cons_earn_income.Text = "";

        }


        public void add_click()
        {
            groupBox_Active_Projects.Hide();
            groupBox_Completed_Projects.Hide();
            groupBox_income.Hide();

            label_function_name.Text = "Add Consultant";
            edit_BTn.Hide();
            panel_consl_info_modify.Show();
            enabletextboxes();
            update_Btn.Hide();
            add_Btn.Show();
            clear_texts();
        }

        private void label_add_employee_Click(object sender, EventArgs e)
        {
            add_click();  
        }

        private void picture_add_employee_Click(object sender, EventArgs e)
        {
            add_click();
        }


        private void add_Btn_Click(object sender, EventArgs e)
        {
            cls_consultant.Addconsultant(txt_cons_name.Text,txt_cons_father.Text,txt_cons_dob.Text,txt_cons_gender.Text,txt_cons_address.Text,txt_cons_phone1.Text,txt_cons_phone2.Text,txt_cons_id.Text);
            Refresh();
        }

        private void txt_search_cons_name_Click(object sender, EventArgs e)
        {
            txt_search_cons_id.SelectedIndex = 0;
        }

        private void txt_search_cons_id_Click(object sender, EventArgs e)
        {
            txt_search_cons_name.SelectedIndex = 0;
        }
    }
}
