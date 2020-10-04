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
    public partial class Manage_EmployeeType_Form : Form
    {

        DataTable dt = new DataTable();
        UC_Designation_Data design_UC;
        Model_Employees cls_employee = new Model_Employees();

        int count = 0;

        public Manage_EmployeeType_Form()
        {
            InitializeComponent();
        }

        private void Manage_EmployeeType_Form_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {

            dt = cls_employee.ShowAllEmpTypes();
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
                design_UC = new UC_Designation_Data();
                design_UC.Width = 340;
                design_UC.Height = 25;


                design_UC.label_designation_id.Text = dt.Rows[i][j++].ToString();
                design_UC.label_designation_name.Text = dt.Rows[i][j++].ToString();


                j = 0;

                design_UC.Left = 0;
                design_UC.Top = Top;
                panel_data.Controls.Add(design_UC);

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
            cls_employee.ProcInsertEmpType(txt_type_name.Text);
            Refresh();

        }
    }
}
