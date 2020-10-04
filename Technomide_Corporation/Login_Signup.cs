using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Technomide_Corporation
{
    public partial class Login_Signup : Form
    {
        public Login_Signup()
        {
            InitializeComponent();
        }

        Database_Connection DBcon;
        SqlCommand cmd;

        Owner_Form own = new Owner_Form();


        string conString;
        string ServerName = Environment.MachineName;
        SqlConnection FinalCon = new SqlConnection();
        public static string State;
        public static bool LogOutStatus;
        public static string UserName;
        public static string FinalConString;


        public bool CheckDBExists(string conString)
        {
            SqlConnection Con = new SqlConnection(conString);

            try
            {
                Con.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
        }

        //private void btn_signup_Click(object sender, EventArgs e)
        //{

        //    DBcon.con.Open();



        //    cmd.ExecuteNonQuery();
        //    DBcon.con.Close();


        //}

        private void Login_Signup_Load(object sender, EventArgs e)
        {
            LogOutStatus = false;

            panel_login.Hide();
            Signup_panel.Hide();

            //Data Source=DESKTOP-0VTF41Q\SQLEXPRESS;Initial Catalog=TheProject;Integrated Security=True

            conString = "Data Source=" + ServerName + "\\SQLEXPRESS" + ";Initial Catalog=TheProject;Integrated Security=True";

            if (!CheckDBExists(conString))
            {
                Signup_panel.Show();
            }

            else
            {
                conString = "Data Source=" + ServerName + "\\SQLEXPRESS" + ";Initial Catalog=TheProject;Integrated Security=True";
                FinalCon.ConnectionString = conString;
                panel_login.Show();
            }
        }

     

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            string username = textBox_username_signup.Text;
            string pass = textBox_pass_signup.Text;
            string repass = textBox_conPass_signup.Text;

            if (pass != repass)
            {
                label_Status_signup.ForeColor = Color.Red;
                label_Status_signup.Text = "Password Not Matched";
                return;
            }


            conString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS" + ";Initial Catalog=;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(conString);
            string script = File.ReadAllText(@"script.sql");

            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            Connection.Open();
            foreach (string commandString in commandStrings)
            {
                if (!string.IsNullOrWhiteSpace(commandString.Trim()))
                {
                    using (var command = new SqlCommand(commandString, Connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }

            Connection.Close();
            conString = "Data Source=" + ServerName + "\\SQLEXPRESS" + ";Initial Catalog=TheProject;Integrated Security=True";
            FinalCon.ConnectionString = conString;

            //if (pass == repass)
            {
                string sq = @"insert into LoginInfoTable values(@NewName,@NewPass,1)";

                SqlCommand dbCommand = new SqlCommand(sq, FinalCon);
                dbCommand.Parameters.AddWithValue("@NewName", username);
                dbCommand.Parameters.AddWithValue("@NewPass", pass);

                // SqlCommand cmd1 = new SqlCommand();
                //   cmd1.Connection = FinalCon;
                //   cmd1.CommandText = "'" + username + "','" + pass + "',1)";
                FinalCon.Open();
                dbCommand.ExecuteNonQuery();
                FinalCon.Close();

                //    cmd1.CommandText = "insert into LoginInfoTable values('" + username + "','" + pass + "',1)";
                //    FinalCon.Open();
                //   cmd1.ExecuteNonQuery();
                //   FinalCon.Close();

                Signup_panel.Hide();
                panel_login.Show();
                label_Status_signup.ForeColor = Color.Green;
                label_Status_signup.Text = "Registered Successfully";
                
            }

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            FinalConString = conString;
            Database_Connection conlast = new Database_Connection();
            string user = textbox_username_login.Text;
            string pass = textbox_pass_login.Text;
            string sq = @"SELECT Count(*) FROM LoginInfoTable WHERE Username=@NewName AND Password=@NewPass";
            try
            {
                SqlCommand dbCommand = new SqlCommand(sq, FinalCon);
                dbCommand.Parameters.AddWithValue("@NewName", user);
                dbCommand.Parameters.AddWithValue("@NewPass", pass);


                FinalCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(dbCommand);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                FinalCon.Close();

                if (dt.Rows[0][0].ToString() == "1")
                {

                    FinalCon.Open();
                    sq = "select * from LoginInfoTable where Username = '" + user + "' ";
                    sda = new SqlDataAdapter(sq,FinalCon);

                    dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show(dt.Rows[0][3].ToString());

                    int roleid = Convert.ToInt32(dt.Rows[0][3]);

                    sq = "select RoleName from RoleTable where Role_ID = "+roleid+" ";
                    sda = new SqlDataAdapter(sq,FinalCon);
                    DataTable dt1 = new DataTable();
                    sda.Fill(dt1);

                    State = dt1.Rows[0][0].ToString();

                    FinalCon.Close();

                    UserName = dt.Rows[0][1].ToString();
                    this.Close();


                    label_Status_Login.ForeColor = Color.Green;
                    label_Status_Login.Text = "Login Success";

                }


            }
            catch (Exception ex)
            {
                label_Status_Login.ForeColor = Color.Red;
                label_Status_Login.Text = "Login Failed";
            }


        }
    }
}
