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
    public partial class Attendance_Form : Form
    {
        public Attendance_Form()
        {
            InitializeComponent();
        }



        int count;
        UC_Modify modify_UC;
        DataTable dt = new DataTable();
        UC_Attendance_Month_Data month_UC;
        UC_Attendance_Marked_Data marked_UC;
        UC_Attendance_Unmarked_Data unmarked_UC;
        Add_Update_Attendance_Form modify_attendance;
        Model_Attendance cls_attendance = new Model_Attendance();


        private void Attendance_Form_Load(object sender, EventArgs e)
        {

            btn_view_today_attendance.Checked = true;
            btn_view_unmarked_attendance.Checked = true;
            Refresh();
        }


        public void get_combobox_data()
        {

            txt_search_EmpName.Items.Add("Employee Name");
            txt_search_EmpID.Items.Add("Employee ID");
            txt_search_specific_year.Items.Add("Year");
            txt_search_specific_month.Items.Add("Month");
            txt_search_specific_day.Items.Add("Day");


            dt = cls_attendance.ShowAtt("select Name from EmployeeTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_EmpName.Items.Add(dr["Name"].ToString());

            dt = cls_attendance.ShowAtt("select Employee_ID from EmployeeTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_EmpID.Items.Add(dr["Employee_ID"].ToString());

            dt = cls_attendance.ShowAtt("select distinct YEAR(Date) as AttYear from  AttendanceTable");
            foreach (DataRow dr in dt.Rows)
                txt_search_specific_year.Items.Add(dr["AttYear"].ToString());

        }


        public void clear_combobox()
        {

            txt_search_EmpName.Items.Clear();
            txt_search_EmpID.Items.Clear();
            txt_search_specific_year.Items.Clear();

        }

        public void Refresh()
        {

            clear_combobox();
            get_combobox_data();
            txt_search_specific_month.Enabled = false;
            txt_search_specific_day.Enabled = false;


            txt_search_EmpName.SelectedIndex = 0;
            txt_search_EmpID.SelectedIndex = 0;
            txt_search_specific_year.SelectedIndex = 0;
            txt_search_specific_month.SelectedIndex = 12;
            txt_search_specific_day.SelectedIndex = 31;


            if (btn_view_today_attendance.Checked)
            {

                panel_today.BringToFront();

                if (btn_view_marked_attendance.Checked)
                {
                    dt = cls_attendance.TodayMarkedAttendenceShow();
                    count = dt.Rows.Count;
                    get_UC_Marked();
                }

                else if (btn_view_unmarked_attendance.Checked)
                {
                    dt = cls_attendance.TodayUnmarkedAttendenceShow();
                    count = dt.Rows.Count;
                    get_UC_Unmarked();
                }

                dt = cls_attendance.Countmarkedattendance();
                label_count_marked.Text = "Marked : " + dt.Rows[0][0].ToString();

                dt = cls_attendance.Countunmarkedattendance();
                label_count_unmarked.Text = "Unmarked : " + dt.Rows[0][0].ToString();

                dt = cls_attendance.Countpresentattendance();
                label_count_present.Text = "Present : " + dt.Rows[0][0].ToString();

                dt = cls_attendance.Countabsentattendance();
                label_count_absent.Text = "Absent : " + dt.Rows[0][0].ToString();

                dt = cls_attendance.Countlateattendance();
                label_count_late.Text = "Late : " + dt.Rows[0][0].ToString();

                dt = cls_attendance.Countleaveattendance();
                label_count_leave.Text = "Leave : " + dt.Rows[0][0].ToString();
            }


            else if (btn_view_month_attendance.Checked)
            {

                panel_month_overall.BringToFront();
                panel_month_data.BringToFront();
                groupBox_SearchByDate.Hide();

                dt = cls_attendance.MonthlyDataOfAttendance();
                count = dt.Rows.Count;
                get_UC_Month();

            }

            else if (btn_view_overall_attendance.Checked)
            {
                panel_month_overall.BringToFront();
                panel_overall_data.BringToFront();
                groupBox_SearchByDate.Show();

                dt = cls_attendance.WholeDataOfAttendanceTable();
                count = dt.Rows.Count;
                get_UC_Month();

            }

        }

        public void get_UC_Unmarked()
        {

            int j = 0;
            var Top = 10;
            var Left = 200;

            panel_today_data_unmarked.BringToFront();
            panel_today_data_unmarked.Controls.Clear();

            for (int i = 0; i < count; i++)
            {

                unmarked_UC = new UC_Attendance_Unmarked_Data();

                unmarked_UC.label_Attendance_EmpName.Text = dt.Rows[i][j++].ToString();
                unmarked_UC.label_Attendance_EmpID.Text = dt.Rows[i][j++].ToString();
                unmarked_UC.label_Attendance_Date.Text = (Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy"));
                unmarked_UC.txt_status_attendance.SelectedIndex = 0;

                unmarked_UC.Width = 600;
                unmarked_UC.Height = 30;
                unmarked_UC.Left = 0;
                unmarked_UC.Top = Top;

                panel_today_data_unmarked.Controls.Add(unmarked_UC);


                Top += 30;
                j = 0;

                unmarked_UC.btn_markin_attendance.Click += new EventHandler(btn_markin_attendance_Click);
            }


        }


        private void btn_markin_attendance_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            var mod = (UC_Attendance_Unmarked_Data)btn.Parent;

            cls_attendance.MarkingAttendence(Convert.ToInt32(mod.label_Attendance_EmpID.Text), mod.txt_status_attendance.Text );
            Refresh();

        }














        public void get_UC_Marked()
        {

            int j = 0;
            var Top = 10;
            var Left = 200;

            panel_today_data_marked.BringToFront();
            panel_today_data_marked.Controls.Clear();

            for (int i = 0; i < count; i++)
            {

                marked_UC = new UC_Attendance_Marked_Data();

                marked_UC.label_Attendance_EmpName.Text = dt.Rows[i][j++].ToString();
                marked_UC.label_Attendance_EmpID.Text = dt.Rows[i][j++].ToString();
                marked_UC.label_Attendance_Date.Text = (Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy"));
                marked_UC.label_Attendance_Status.Text = dt.Rows[i][(j++)+2].ToString();


                marked_UC.Width = 600;
                marked_UC.Height = 30;
                marked_UC.Left = 0;
                marked_UC.Top = Top;

                panel_today_data_marked.Controls.Add(marked_UC);


                Top += 30;
                j = 0;

                marked_UC.btn_markout_attendance.Click += new EventHandler(btn_markout_attendance_Click);
            }

        }



        private void btn_markout_attendance_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var mod = (UC_Attendance_Marked_Data)btn.Parent;

            cls_attendance.MarkOutAttendence(Convert.ToInt32(mod.label_Attendance_EmpID.Text));
        }













        public void get_UC_Month()
        {


            int j = 1;
            var Top = 10;
            var Left = 200;

            panel_month_data.BringToFront();
            panel_month_data.Controls.Clear(); 

            for (int i = 0; i < count; i++)
            {

                month_UC = new UC_Attendance_Month_Data();

                month_UC.label_Attendance_EmpName.Text = dt.Rows[i][j++].ToString();
                month_UC.label_Attendance_EmpID.Text = dt.Rows[i][j++].ToString();
                month_UC.label_Attendance_Date.Text = (Convert.ToDateTime(dt.Rows[i][j++].ToString()).ToString("dd/MMM/yyyy"));
                month_UC.label_Attendance_Intime.Text = dt.Rows[i][j++].ToString();
                month_UC.label_Attendance_Outtime.Text = dt.Rows[i][j++].ToString();
                month_UC.label_Attendance_Status.Text = dt.Rows[i][j++].ToString();

                month_UC.Width = 700;
                month_UC.Height = 30;
                month_UC.Left = 0;
                month_UC.Top = Top;

                panel_month_data.Controls.Add(month_UC);


                modify_UC = new UC_Modify();
                modify_UC.Width = 30;
                modify_UC.Height = 30;
                modify_UC.Left = Left + 500;
                modify_UC.Top = Top + 3;

                modify_UC.value = dt.Rows[i][0].ToString();

                panel_month_data.Controls.Add(modify_UC);

                Top += 30;
                j = 1;


                modify_UC.pic_update.Click += new EventHandler(pic_update_attendance_Click);

            }

        }




        private void pic_update_attendance_Click(object sender, EventArgs e)
        {

            modify_attendance = new Add_Update_Attendance_Form(this);
            modify_attendance.btn_update_attendance.BringToFront();

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_attendance.datashowfromattendancebyattid(Convert.ToInt32(mod.value));

            modify_attendance.txt_attendance_id.Text = dt.Rows[0][0].ToString();
            modify_attendance.txt_attendance_empid.Text = dt.Rows[0][1].ToString();
            modify_attendance.txt_attendance_empname.Text = dt.Rows[0][2].ToString();
            modify_attendance.txt_attendance_date.Text = Convert.ToDateTime(dt.Rows[0][3].ToString()).ToString("dd/MMM/yyyy");
            modify_attendance.txt_attendance_intime.Text = dt.Rows[0][4].ToString();
            modify_attendance.txt_attendance_outtime.Text = dt.Rows[0][5].ToString();
            modify_attendance.txt_attendance_status.Text = dt.Rows[0][6].ToString();

            modify_attendance.txt_attendance_id.ReadOnly = true;
            modify_attendance.txt_attendance_empid.ReadOnly = true;
            modify_attendance.txt_attendance_empname.ReadOnly = true;
            modify_attendance.txt_attendance_date.Enabled = false;


            modify_attendance.Show();


        }



        private void btn_view_marked_attendance_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_view_unmarked_attendance_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_view_today_attendance_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_view_month_attendance_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txt_search_EmpName_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (txt_search_EmpName.Text == "Employee Name")
            {
                return;
            }

            if (btn_view_month_attendance.Checked)
            {
                dt = cls_attendance.wholedatashowfromattendancebyname(txt_search_EmpName.Text);
                count = dt.Rows.Count;
                get_UC_Month();
            }

            else if (btn_view_overall_attendance.Checked)
            {
                dt = cls_attendance.datashowfromattendancebyname(txt_search_EmpName.Text);
                count = dt.Rows.Count;
                get_UC_Month();
            }
        }

        private void txt_search_EmpID_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (txt_search_EmpID.Text == "Employee ID")
            {
                return;
            }


            if (btn_view_month_attendance.Checked)
            {
                dt = cls_attendance.wholedatashowfromattendancebyid(Convert.ToInt32(txt_search_EmpID.Text));
                count = dt.Rows.Count;
                get_UC_Month();
            }

            else if (btn_view_overall_attendance.Checked)
            {
                dt = cls_attendance.datashowfromattendancebyid(Convert.ToInt32(txt_search_EmpID.Text));
                count = dt.Rows.Count;
                get_UC_Month();

            }
        }

        private void txt_search_specific_year_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_specific_year.Text == "Year")
            {
                return;
            }

            txt_search_specific_month.Enabled = true;
            txt_search_specific_day.Enabled = false;

            dt = cls_attendance.AttendenceShowBySpecific_Year(txt_search_specific_year.Text);
            count = dt.Rows.Count;
            get_UC_Month();
        }

        private void txt_search_specific_month_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (txt_search_specific_month.Text == "Month")
            {
                return;
            }

            txt_search_specific_day.Enabled = true;

            dt = cls_attendance.AttendenceShowBySpecific_Month(txt_search_specific_year.Text, txt_search_specific_month.Text);
            count = dt.Rows.Count;
            get_UC_Month();

        }

        private void txt_search_specific_day_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_search_specific_day.Text == "Day")
            {
                return;
            }

            dt = cls_attendance.AttendenceShowBySpecific_Day(txt_search_specific_year.Text, txt_search_specific_month.Text, txt_search_specific_day.Text);
            count = dt.Rows.Count;
            get_UC_Month();

        }


        private void btn_generate_attendance_Click(object sender, EventArgs e)
        {

            dt = cls_attendance.ShowAtt("select * from AttendanceTable where Date = (select convert(varchar, getdate(), 23))");

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Generated Earlier", "Generating Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cls_attendance.InsertAttendancedata();
            Refresh();
        }

        private void txt_search_EmpName_Click(object sender, EventArgs e)
        {
            txt_search_EmpID.SelectedIndex = 0;
            txt_search_specific_year.SelectedIndex = 0;
            txt_search_specific_month.SelectedIndex = 12;
            txt_search_specific_day.SelectedIndex = 31;

            txt_search_specific_month.Enabled = false;
            txt_search_specific_day.Enabled = false;

        }

        private void txt_search_EmpID_Click(object sender, EventArgs e)
        {
            txt_search_EmpName.SelectedIndex = 0;
            txt_search_specific_year.SelectedIndex = 0;
            txt_search_specific_month.SelectedIndex = 12;
            txt_search_specific_day.SelectedIndex = 31;

            txt_search_specific_month.Enabled = false;
            txt_search_specific_day.Enabled = false;

        }

        private void txt_search_specific_year_Click(object sender, EventArgs e)
        {
            txt_search_specific_month.SelectedIndex = 12;
            txt_search_specific_day.SelectedIndex = 31;
            txt_search_EmpName.SelectedIndex = 0;
            txt_search_EmpID.SelectedIndex = 0;

        }

        private void txt_search_specific_month_Click(object sender, EventArgs e)
        {
            txt_search_specific_day.SelectedIndex = 31;
        }
    }
}
