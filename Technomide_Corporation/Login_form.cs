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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }


        UC_Login_Info_Data login_UC;
        UC_Modify modify_UC;

        Model_LoginInfo cls_login = new Model_LoginInfo();
        DataTable dt = new DataTable();

        Add_Update_LoginInfo_Form modify_login;

        int count = 0;

        private void Login_form_Load(object sender, EventArgs e)
        {
            Refresh();
        }


        public void Refresh()
        {
            dt = cls_login.LoginInfoDetail();
            count = dt.Rows.Count;

            get_UC();
        }



        public void get_UC()
        {
            panel_data.Controls.Clear();
            panel_data.Show();


            int j = 0;
            var Top = 10;
            var Left = 200;

            for (int i = 0; i < count; i++)
            {
                login_UC = new UC_Login_Info_Data();
                login_UC.Width = 630;
                login_UC.Height = 25;


                login_UC.label_login_id.Text = dt.Rows[i][j++].ToString();
                login_UC.label_login_username.Text = dt.Rows[i][j++].ToString();
                login_UC.label_login_password.Text = dt.Rows[i][j++].ToString();
                login_UC.label_login_userrole.Text = dt.Rows[i][j++].ToString();


                j = 0;

                login_UC.Left = 0;
                login_UC.Top = Top;
                panel_data.Controls.Add(login_UC);

                modify_UC = new UC_Modify();
                modify_UC.Width = 60;
                modify_UC.Height = 30;
                modify_UC.value = dt.Rows[i][1].ToString();
                modify_UC.Top = Top;
                modify_UC.Left = Left + 450;
                panel_data.Controls.Add(modify_UC);

                Top += 30;

                modify_UC.pic_update.Click += new EventHandler(pic_update_login_acoount_Click);
                modify_UC.pic_delete.Click += new EventHandler(pic_delete_login_acoount_Click);

            }

        }


        private void pic_update_login_acoount_Click(object sender, EventArgs e)
        {
            modify_login = new Add_Update_LoginInfo_Form(this);
            modify_login.label_LoginInfo.Text = "Update Login Info";            

            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            dt = cls_login.LoginInfoDetailByUsername(mod.value.ToString());
            modify_login.btn_Update_LoginInfo.BringToFront();

            modify_login.txt_LoginInfo_Username.Text = dt.Rows[0][0].ToString();
            modify_login.txt_LoginInfo_Password.Text = dt.Rows[0][1].ToString();
            modify_login.txt_LoginInfo_UserRole.Text = dt.Rows[0][2].ToString();

            modify_login.txt_LoginInfo_Username.ReadOnly = true;

            modify_login.Show();

        }


        private void pic_delete_login_acoount_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            UC_Modify mod = (UC_Modify)pic.Parent;

            cls_login.deletelogininfotabless(mod.value.ToString());

            Refresh();
        }


        public void AddLoginInfo()
        {
            modify_login = new Add_Update_LoginInfo_Form(this);
            modify_login.label_LoginInfo.Text = "Add Login Info";

            modify_login.txt_LoginInfo_Username.Text = "";
            modify_login.txt_LoginInfo_Password.Text = "";
            modify_login.txt_LoginInfo_UserRole.Text = "";

            modify_login.Show();
        }

        private void label_add_login_account_Click(object sender, EventArgs e)
        {
            AddLoginInfo();
        }

        private void picture_add_login_account_Click(object sender, EventArgs e)
        {
            AddLoginInfo();
        }
    }
}
