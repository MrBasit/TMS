using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technomide_Corporation;
using System.Windows.Forms;

namespace ConsoleApplication3
{
    class Model_LoginInfo
    {

        public DataTable ShowLogs(string q)
        {
            SqlCommand dbCommand = new SqlCommand(q, Database_Connection.con);
            Database_Connection.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(dbCommand);

            DataTable dt = new DataTable();
            try
            {
                sda.Fill(dt);
            }
            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
            }
            finally
            {
                Database_Connection.con.Close();
            }

            return dt;
        }

        public DataTable LoginInfoDetail()
        {
            return ShowLogs("exec  datashowoflogininfotable");
        }




        public DataTable LoginInfoDetailByUsername(string username)
        {
            string sq = @"exec datashowoflogininfobyusername @username=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", username);
            Database_Connection.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(dbCommand);
            DataTable dt = new DataTable();
            try
            {
                sda.Fill(dt);
            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
            }
            finally
            {
                Database_Connection.con.Close();
            }
            return dt;
        }


        public void insertdatainlogintabless(string Name,string Password,string role)
        {
            string sq = @"exec  insertdatainlogintabless @username=@New1, @password = @New2, @rolename = @New3";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Name);
            dbCommand.Parameters.AddWithValue("@New2", Password);
            dbCommand.Parameters.AddWithValue("@New3", role);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Login Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Login Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }

        public void updatelogininfotabless(string Name, string Password, string role)
        {
            string sq = @"exec  updatelogininfotabless @password = @New1, @rolename=@New2 , @username = @New3";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Password);
            dbCommand.Parameters.AddWithValue("@New2", role);
            dbCommand.Parameters.AddWithValue("@New3", Name);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Login Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Login Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }

        public void deletelogininfotabless(string Name)
        {
            string sq = @"exec  deletelogininfotabless @username = @New1";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Name);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted", "Deleting Login Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Deletion Failed", "Deleting Login Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }

    }
}
