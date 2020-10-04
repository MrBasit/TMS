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
    class Model_Consultant
    {

        public DataTable ShowCons(string q)
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

        public DataTable ConsultantDetail()
        {
            return ShowCons("exec ProcConsultantDetail");
        }


        public DataTable ConsultantAllDetailsByCons_ID(string Cons_ID)
        {
            string sq = @"exec ConsultantdetailsbyUniqueId  @id= @NewId";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewId", Cons_ID);
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
       
        public DataTable ConsultantSomeDetailsByCons_ID(string Cons_ID)
        {
            string sq = @"exec  serachconsultantbyuid  @id= @NewId";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewId", Cons_ID);
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

        public DataTable ConsultantSomeDetailsByName(string Name)
        {
            string sq = @"exec  searchconsultantbyuname  @name=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", Name);
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

        public DataTable ConsultantOngoingProject(string Cons_ID)
        {
            string sq = @"exec ConsultantOngoingProject @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", Cons_ID);
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

        public DataTable ConsultantCompletedProject(string Cons_ID)
        {
            string sq = @"exec ConsultantCompletedProject @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", Cons_ID);
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

        public DataTable ConsultantEarning(string Cons_ID)
        {
            string sq = @"exec ConsultantExpectedEarning @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", Cons_ID);
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

        public DataTable ConsultantexpectedEarnings(string Cons_ID)
        {
            string sq = @"exec ConsultantEarning  @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", Cons_ID);
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
        public void DeleteFromConsultantTable(string Cons_ID)
        {
            string sq = @"execute ProcDeleteFromConsultantTable @NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", Cons_ID);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted","Deleting Consultant", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Deletion Failed", "Deleting Consultant", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }
        public void Addconsultant(string Name, string FatherName, string Date_Of_Birth,string Gender,string Address,string Phone1,string Phone2,string Consultant_ID)
        {
            string sq = @"exec addconsultant @New1,@New2,@New3,@New4,@New5,@New6,@New7,@New8";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Name);
            dbCommand.Parameters.AddWithValue("@New2", FatherName);
            dbCommand.Parameters.AddWithValue("@New3", Date_Of_Birth);
            dbCommand.Parameters.AddWithValue("@New4", Gender);
            dbCommand.Parameters.AddWithValue("@New5", Address);
            dbCommand.Parameters.AddWithValue("@New6", Phone1);
            dbCommand.Parameters.AddWithValue("@New7", Phone2);
            dbCommand.Parameters.AddWithValue("@New8", Consultant_ID);

            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Consultant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Consultant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database_Connection.con.Close();
            }
        }

        public void UpdateConsultact(string Name, string FatherName, string Date_Of_Birth, string Gender, string Address, string Phone1, string Phone2, string Consultant_ID)
        {
            string sq = @"execute ProcUpdateConsultact @New1,@New2,@New3,@New4,@New5,@New6,@New7,@New8";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Name);
            dbCommand.Parameters.AddWithValue("@New2", FatherName);
            dbCommand.Parameters.AddWithValue("@New3", Date_Of_Birth);
            dbCommand.Parameters.AddWithValue("@New4", Gender);
            dbCommand.Parameters.AddWithValue("@New5", Address);
            dbCommand.Parameters.AddWithValue("@New6", Phone1);
            dbCommand.Parameters.AddWithValue("@New7", Phone2);
            dbCommand.Parameters.AddWithValue("@New8", Consultant_ID);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Consultant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Update Failed", "Updating Consultant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database_Connection.con.Close();
            }
        }

    }
}
