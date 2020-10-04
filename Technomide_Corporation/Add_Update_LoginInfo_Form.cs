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
    public partial class Add_Update_LoginInfo_Form : Form
    {
        Login_form login;
        DataTable dt = new DataTable();
        Model_LoginInfo cls_login = new Model_LoginInfo();


        public Add_Update_LoginInfo_Form(Login_form log)
        {
            InitializeComponent();
            login = log;
        }

        private void Add_Update_LoginInfo_Form_Load(object sender, EventArgs e)
        {

            dt = cls_login.ShowLogs("select RoleName from RoleTable");
            foreach (DataRow dr in dt.Rows)
                txt_LoginInfo_UserRole.Items.Add(dr["RoleName"].ToString());

        }

        private void btn_Add_LoginInfo_Click(object sender, EventArgs e)
        {
            cls_login.insertdatainlogintabless(txt_LoginInfo_Username.Text,txt_LoginInfo_Password.Text,txt_LoginInfo_UserRole.Text);
            login.Refresh();
        }

        private void btn_Update_LoginInfo_Click(object sender, EventArgs e)
        {
            cls_login.updatelogininfotabless(txt_LoginInfo_Username.Text, txt_LoginInfo_Password.Text, txt_LoginInfo_UserRole.Text);
            login.Refresh();
        }
    }
}
