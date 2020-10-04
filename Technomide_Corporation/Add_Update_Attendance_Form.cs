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
    public partial class Add_Update_Attendance_Form : Form
    {
        Attendance_Form attform;
        public Add_Update_Attendance_Form(Attendance_Form att)
        {
            InitializeComponent();
            attform = att;
        }

        DataTable dt = new DataTable();
        Model_Attendance cls_attendance = new Model_Attendance();

        private void btn_update_attendance_Click(object sender, EventArgs e)
        {

            cls_attendance.UpdateAttendance(Convert.ToInt32(txt_attendance_id.Text), txt_attendance_intime.Text, txt_attendance_outtime.Text, txt_attendance_status.Text);

            attform.Refresh();
        }

        public void get_combobox_data()
        {

            dt = cls_attendance.ShowAtt("select Name from StatusTable");
            foreach (DataRow dr in dt.Rows)
                txt_attendance_status.Items.Add(dr["Name"].ToString());

        }


        private void Add_Update_Attendance_Form_Load(object sender, EventArgs e)
        {
            get_combobox_data();
        }
    }
}
