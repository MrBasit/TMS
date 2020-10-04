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
    public partial class Manage_EmployeeSkills_Form : Form
    {
        public Manage_EmployeeSkills_Form()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        UC_EmployeeSkills_Data empskill_UC;
        Model_Employees cls_employee = new Model_Employees();

        int count = 0;

        private void Manage_EmployeeSkills_Form_Load(object sender, EventArgs e)
        {

            get_ComboBox_Data();
            Refresh();

        }

        public void get_ComboBox_Data()
        {

            dt = cls_employee.ShowEmp("select Employee_ID from EmployeeTable");
            foreach (DataRow dr in dt.Rows)
                txt_Employee_ID.Items.Add(dr["Employee_ID"].ToString());

            dt = cls_employee.ShowEmp("select SkillName from SkillsTable");
            foreach (DataRow dr in dt.Rows)
                txt_Skill_Name.Items.Add(dr["SkillName"].ToString());

        }




        public void Refresh()
        {
            dt = cls_employee.ShowAllEmpSkills();
            count = dt.Rows.Count;

            get_UC();
        }

        public void get_UC()
        {

            panel_data.Controls.Clear();

            int j = 0;
            var Top = 10;
            var Left = 200;

            for (int i = 0; i < count; i++)
            {
                empskill_UC = new UC_EmployeeSkills_Data();
                empskill_UC.Width = 340;
                empskill_UC.Height = 25;


                empskill_UC.label_employee_name.Text = dt.Rows[i][j++].ToString();
                empskill_UC.label_skill_name.Text = dt.Rows[i][j++].ToString();


                j = 0;

                empskill_UC.Left = 0;
                empskill_UC.Top = Top;
                panel_data.Controls.Add(empskill_UC);

                //modify_UC = new UC_Modify();
                //modify_UC.Width = 90;
                //modify_UC.Height = 30;
                //modify_UC.value = dt.Rows[i][1].ToString();
                //modify_UC.Top = Top;
                //modify_UC.Left = Left + 350;
                //panel_data.Controls.Add(modify_UC);

                Top += 30;

                //modify_UC.pic_update.Click += new EventHandler(pic_update_Click);
                //modify_UC.pic_delete.Click += new EventHandler(pic_delete_Click);
                //modify_UC.pic_info.Click += new EventHandler(pic_info_Click);

            }



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cls_employee.ProcInsertEmpSkills(Convert.ToInt32(txt_Employee_ID.Text), txt_Skill_Name.Text);
            Refresh();
        }
    }
}
