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
    class Model_Project
    {
        public DataTable ShowProj(string q)
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

        public DataTable ShowAllProjectDates()
        {
            return ShowProj("exec showprojectdates"); 
        }

        public DataTable ShowAllProjectNames()
        {
            return ShowProj("exec showprojectnames");
        }
        public DataTable SortByStatus()
        {
            return ShowProj("exec sortbystatus");
        }
        public DataTable SortByName()
        {
            return ShowProj("exec sortbyname");
        }
     

        public DataTable ProjectSearchByID(string ID)
        {
            string sq = @"exec  datashowfromprojectid @id=@NewId";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewId", ID);
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
        public DataTable ProjectSearchByName(string Name)
        {
            string sq = @"exec showprojectbyName @name=@NewName";
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

        public DataTable ProjectSearchByDate(string date)
        {
            string sq = @"exec showprojectbydate @date=@NewDate";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewDate", date);
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
        public DataTable EmployeesAssigentToProjectID(int ID)
        {
            string sq = @"exec assignedprojectEmployee @id=@NewID";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewID", ID);
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

        public void AddProjectData(string dateofstart, string name, string description, string C_Name
            , string amount, string dateofcomplitaion, string dateofdelivery, string projectdate)
        {
            string sq = @"exec Insert_ProjectDetail @v_dateofstart =@New1, @v_name =@New2, @v_description = @New3 , 
@v_cname =@New4, @v_amount = @New5, @v_dateofcompletion =@New6, @v_dateofdelivery =@New7, @v_projectdate =@New8";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", dateofstart);
            dbCommand.Parameters.AddWithValue("@New2", name);
            dbCommand.Parameters.AddWithValue("@New3", description);
            dbCommand.Parameters.AddWithValue("@New4", C_Name);
            dbCommand.Parameters.AddWithValue("@New5", amount);
            dbCommand.Parameters.AddWithValue("@New6", dateofcomplitaion);
            dbCommand.Parameters.AddWithValue("@New7", dateofdelivery);
            dbCommand.Parameters.AddWithValue("@New8", projectdate);

            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Project", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Project", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


       
        }

        public void UpdateProjectData(int ID,string dateofstart, string name, string description, string C_Name
           , string amount, string dateofcomplitaion, string dateofdelivery, string projectdate)
        {
            string sq = @"exec Update_ProjectDetail @id=@New9, @v_dateofstart =@New1, @v_name =@New2, 
@v_description = @New3 , @v_cname =@New4, @v_amount = @New5, @v_dateofcompletion =@New6, 
@v_dateofdelivery =@New7, @v_projectdate =@New8";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", dateofstart);
            dbCommand.Parameters.AddWithValue("@New2", name);
            dbCommand.Parameters.AddWithValue("@New3", description);
            dbCommand.Parameters.AddWithValue("@New4", C_Name);
            dbCommand.Parameters.AddWithValue("@New5", amount);
            dbCommand.Parameters.AddWithValue("@New6", dateofcomplitaion);
            dbCommand.Parameters.AddWithValue("@New7", dateofdelivery);
            dbCommand.Parameters.AddWithValue("@New8", projectdate);
            dbCommand.Parameters.AddWithValue("@New9", ID);

            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Project", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Project", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }


        public void DeleteProjectByID(int ID)
        {
            string sq = @"exec ProcProjectTableDelete @id=@NewId";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewId", ID);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted", "Deleting Project", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Deletion Failed", "Deleting Project", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }

        }

    }
}
