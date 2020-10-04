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
    public partial class Withdrawl_form : Form
    {
        public Withdrawl_form()
        {
            InitializeComponent();
        }




        UC_Withdrawal_Data Withdrawal_UC;
        UC_Modify modify_UC;
        Add_Update_Withdrawal_Form modify_withdrawal;

        Model_Withdrawal cls_withdrawal = new Model_Withdrawal();
        DataTable dt = new DataTable();

        RichTextBox txt_rich;
        int count = 0;



        private void Withdrawl_form_Load(object sender, EventArgs e)
        {
            txt_search_withdrawal_name.Items.Add("Name");
            txt_search_withdrawal_specific_date.Items.Add("Day");
            txt_search_withdrawal_specific_month.Items.Add("Month");
            txt_search_withdrawal_specific_year.Items.Add("Year");


            Refresh();
        }


        public void get_combobox_data()
        {

            dt = cls_withdrawal.ShowWith("select Name from Withdrawal");
            foreach (DataRow dr in dt.Rows)
                txt_search_withdrawal_name.Items.Add(dr["Name"].ToString());


            dt = cls_withdrawal.ShowWith("select distinct Year(Date) as WithYear from Withdrawal");
            foreach (DataRow dr in dt.Rows)
                txt_search_withdrawal_specific_year.Items.Add(dr["WithYear"].ToString());

        }


        public void clear_combobox()
        {

            txt_search_withdrawal_name.Items.Clear();
            txt_search_withdrawal_specific_year.Items.Clear();


        }


        public void Refresh()
        {

            clear_combobox();
            get_combobox_data();


            txt_search_withdrawal_specific_year.SelectedIndex = 0;
            txt_search_withdrawal_specific_month.SelectedIndex = 12;
            txt_search_withdrawal_specific_date.SelectedIndex = 31;
            txt_search_withdrawal_name.SelectedIndex = 0;

            txt_search_withdrawal_specific_month.Enabled = false;
            txt_search_withdrawal_specific_date.Enabled = false;

            dt = cls_withdrawal.ProcWithdrawalDatailShow();
            count = dt.Rows.Count;

            get_UC();
        }



        public void get_UC()
        {
            panel_data.Controls.Clear();
            panel_data.Show();


            label_amount_available.Text = cls_withdrawal.ProcAvailableAmountOfCompany().ToString();
            label_total_withdrawal.Text = cls_withdrawal.ProcTotalWithdrawalOfCompany().ToString();


            int j = 1;
            var Top = 10;
            var Left = 200;

            for (int i = 0; i < count; i++)
            {
                Withdrawal_UC = new UC_Withdrawal_Data();
                Withdrawal_UC.Width = 400;
                Withdrawal_UC.Height = 25;


                Withdrawal_UC.label_withdrawal_name.Text = dt.Rows[i][j++].ToString();
                Withdrawal_UC.label_withdrawal_amount.Text = dt.Rows[i][j++].ToString();
                Withdrawal_UC.label_withdrawal_date.Text = (Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy"));


                Withdrawal_UC.Left = 0;
                Withdrawal_UC.Top = Top;
                panel_data.Controls.Add(Withdrawal_UC);

                modify_UC = new UC_Modify();
                modify_UC.Width = 60;
                modify_UC.Height = 30;
                modify_UC.value = dt.Rows[i][0].ToString();
                modify_UC.Top = Top;
                modify_UC.Left = Left + 210;
                panel_data.Controls.Add(modify_UC);


                txt_rich = new RichTextBox();
                txt_rich.Top = Top;
                txt_rich.Height = 30;
                txt_rich.Width = 200;
                txt_rich.Left = Left + 300;
                txt_rich.Text = dt.Rows[i][j++].ToString();
                txt_rich.Enabled = false;
                panel_data.Controls.Add(txt_rich);

                j = 1;

                Top += 60;

                modify_UC.pic_update.Click += new EventHandler(pic_update_withdrawal_Click);
                modify_UC.pic_delete.Click += new EventHandler(pic_delete_withdrawal_Click);

            }

        }


        private void pic_update_withdrawal_Click(object sender, EventArgs e)
        {

            modify_withdrawal = new Add_Update_Withdrawal_Form(this);

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_withdrawal.ProcWithdrawalDatailShowById(mod.value.ToString());

            modify_withdrawal.txt_withdrawal_id.Text = dt.Rows[0][0].ToString();
            modify_withdrawal.txt_withdrawal_name.Text = dt.Rows[0][1].ToString();
            modify_withdrawal.txt_withdrawal_amount.Text = dt.Rows[0][2].ToString();
            modify_withdrawal.txt_withdrawal_date.Text = Convert.ToDateTime(dt.Rows[0][3].ToString()).ToShortDateString();
            modify_withdrawal.txt_withdrawal_note.Text = dt.Rows[0][4].ToString();

            modify_withdrawal.label_Withdrawal.Text = "Update Withdrawal";
            modify_withdrawal.btn_Update_Withdrawal.BringToFront();
            modify_withdrawal.txt_withdrawal_id.ReadOnly = true;
            modify_withdrawal.txt_withdrawal_date.Enabled = false;

            modify_withdrawal.Show();

        }


        private void pic_delete_withdrawal_Click(object sender, EventArgs e)
        {

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            cls_withdrawal.ProcDeleteWithdrawal(mod.value.ToString());
            Refresh();
        }


        private void txt_search_withdrawal_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_withdrawal_name.Text == "Name")
            {
                return;
            }

            dt = cls_withdrawal.WithdrawalDatailSearchByNames(txt_search_withdrawal_name.Text);
            count = dt.Rows.Count;
            get_UC();

        }

        private void txt_search_withdrawal_specific_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search_withdrawal_specific_year.Text == "Year")
            {
                return;
            }

            txt_search_withdrawal_specific_month.Enabled = true;
            txt_search_withdrawal_specific_date.Enabled = false;

            dt = cls_withdrawal.WithdrawalDatailSearchBySpecific_Year(txt_search_withdrawal_specific_year.Text);
            count = dt.Rows.Count;
            get_UC();
        }

        private void txt_search_withdrawal_specific_month_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_withdrawal_specific_month.Text == "Month")
            {
                return;
            }

            txt_search_withdrawal_specific_date.Enabled = true;

            dt = cls_withdrawal.WithdrawalDatailSearchBySpecific_Month(txt_search_withdrawal_specific_year.Text, txt_search_withdrawal_specific_month.Text);
            count = dt.Rows.Count;
            get_UC();
        }

        private void txt_search_withdrawal_specific_date_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_withdrawal_specific_date.Text == "Day")
            {
                return;
            }

            dt = cls_withdrawal.WithdrawalDatailSearchBySpecific_Day(txt_search_withdrawal_specific_year.Text, txt_search_withdrawal_specific_month.Text, txt_search_withdrawal_specific_date.Text);
            count = dt.Rows.Count;
            get_UC();
        }

        private void btn_sort_withdrawal_name_CheckedChanged(object sender, EventArgs e)
        {
            dt = cls_withdrawal.WithdrawalDatailSortByNames();
            count = dt.Rows.Count;
            get_UC();
        }

        private void btn_sort_withdrawal_amount_CheckedChanged(object sender, EventArgs e)
        {
            dt = cls_withdrawal.WithdrawalDatailSortByAmount();
            count = dt.Rows.Count;
            get_UC();
        }

        private void label_add_Withdrawal_Click(object sender, EventArgs e)
        {
            modify_withdrawal = new Add_Update_Withdrawal_Form(this);

            modify_withdrawal.txt_withdrawal_name.Text = "";
            modify_withdrawal.txt_withdrawal_amount.Text = "";
            modify_withdrawal.txt_withdrawal_note.Text = "";
            modify_withdrawal.txt_withdrawal_date.Text = DateTime.Now.ToShortDateString();
            modify_withdrawal.txt_withdrawal_id.ReadOnly = true;

            modify_withdrawal.btn_Add_Withdrawal.BringToFront();
            modify_withdrawal.label_Withdrawal.Text = "Add Withdrawal";
            modify_withdrawal.txt_withdrawal_date.Enabled = false;

            modify_withdrawal.Show();

        }

        private void txt_search_withdrawal_name_Click(object sender, EventArgs e)
        {
            txt_search_withdrawal_specific_month.Enabled = false;
            txt_search_withdrawal_specific_date.Enabled = false;

            txt_search_withdrawal_specific_year.SelectedIndex = 0;
            txt_search_withdrawal_specific_month.SelectedIndex = 12;
            txt_search_withdrawal_specific_date.SelectedIndex = 31;

        }

        private void txt_search_withdrawal_specific_year_Click(object sender, EventArgs e)
        {
            txt_search_withdrawal_specific_date.Enabled = false;
            txt_search_withdrawal_specific_month.Enabled = false;

            txt_search_withdrawal_specific_month.SelectedIndex = 12;
            txt_search_withdrawal_specific_date.SelectedIndex = 31;
            txt_search_withdrawal_name.SelectedIndex = 0;

        }

        private void txt_search_withdrawal_specific_month_Click(object sender, EventArgs e)
        {
            txt_search_withdrawal_specific_date.SelectedIndex = 31;
            txt_search_withdrawal_name.SelectedIndex = 0;

        }

        private void txt_search_withdrawal_specific_date_Click(object sender, EventArgs e)
        {
            txt_search_withdrawal_name.SelectedIndex = 0;
        }
    }
}
