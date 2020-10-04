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
    class Model_Attendance
    {

        public DataTable ShowAtt(string q)
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
        public DataTable TodayMarkedAttendenceShow()
        {
            return ShowAtt("exec ProcMarkedAttendenceShow");
        }
        public DataTable TodayUnmarkedAttendenceShow()
        {
            return ShowAtt("exec ProcUnmarkedAttendenceShow");
        }

        public DataTable Countmarkedattendance()
        {
            return ShowAtt("exec  markedattendance");
        }

        public DataTable Countunmarkedattendance()
        {
            return ShowAtt("exec unmarkedattendance");
        }
        public DataTable Countpresentattendance()
        {
            return ShowAtt("exec presentattendance");
        }
        public DataTable Countabsentattendance()
        {
            return ShowAtt("exec absentattendance");
        }
        public DataTable Countlateattendance()
        {
            return ShowAtt("exec lateattendance");
        }
        public DataTable Countleaveattendance()
        {
            return ShowAtt("exec leaveattendance");
        }
        public DataTable WholeDataOfAttendanceTable()
        {
            return ShowAtt("exec datashowfromattendance");
        }
        public DataTable MonthlyDataOfAttendance()
        {
            return ShowAtt("exec datashowofattendanceofdate");
        }
        public void InsertAttendancedata()
        {
            DataTable dt = ShowAtt("select E_ID from EmployeeTable");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                  string sq = @"insert into AttendanceTable values("+Convert.ToInt32(dt.Rows[i][0].ToString())+",'"+DateTime.Now.ToShortDateString()+"',NULL,NULL,1)";
               // string sq = "insert into AttendanceTable values(2,'2020-08-12',NULL,NULL,1)";
                SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);

                Database_Connection.con.Open();
                try
                {
                    dbCommand.ExecuteNonQuery();

                    if (i == dt.Rows.Count - 1)
                    {
                        MessageBox.Show("Attendance Generated","Generating Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                catch (SqlException sqlex)
                {
                    ErrorHandling rh = new ErrorHandling();
                    rh.GetError(sqlex.Number);
                    MessageBox.Show("Generating Attendance Failed", "Generating Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    Database_Connection.con.Close();
                }
            }
        }

        public void MarkingAttendence(int id,string status)
        {
            string sq = @"exec ProcMarkingAttendence @New1,@New2";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", id);
            dbCommand.Parameters.AddWithValue("@New2", status);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Attendance Marked", "Mark In Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Marking Attendance Failed", "Mark In Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }



        public void MarkOutAttendence(int id)
        {
            string sq = @"exec ProcMarkOutAttendance @New1";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", id);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Marked Out","Mark Out Attendance",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Marking Out Failed","Mark Out Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }





        public DataTable countmarkedattendancesearchbyname(string name)
        {
            string sq = @"exec countmarkedattendancesearchbyname @name = @New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
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
        public DataTable countunmarkedattendancesearchbyname(string name)
        {
            string sq = @"exec countunmarkedattendancesearchbyname @name = @New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
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

        public DataTable datashowfromattendancebyname(string name)
        {
            string sq = @"exec datashowfromattendancebyname @name = @New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
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
        public DataTable wholedatashowfromattendancebyname(string name)
        {
            string sq = @"exec wholedatashowfromattendancebyname @name = @New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
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
        public DataTable countmarkedattendancesearchbyid(int ID)
        {
            string sq = @"exec countmarkedattendancesearchbyid @id = @New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", ID);
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
        public DataTable wholedatashowfromattendancebyid(int ID)
        {
            string sq = @"exec wholedatashowfromattendancebyid @id = @New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", ID);
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

        public DataTable datashowfromattendancebyid(int ID)
        {
            string sq = @"exec datashowfromattendancebyid @id = @New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", ID);
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



        public DataTable datashowfromattendancebyattid(int ID)
        {
            string sq = @"exec datashowfromattendancebyattid @id = @New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", ID);
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




        public DataTable countunmarkedattendancesearchbyid(int ID)
        {
            string sq = @"exec countunmarkedattendancesearchbyid @id=@New1 ";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", ID);
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
        public DataTable AttendenceShowBySpecific_Day(string Year, string Month, string day)
        {
            string sq = @"exec ProcAttendenceShowBySpecific_Day @year=@NewYear,@month =@NewMonth,@day=@NewDay";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewYear", Year);
            dbCommand.Parameters.AddWithValue("@NewMonth", Month);
            dbCommand.Parameters.AddWithValue("@NewDay", day);
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

        public DataTable AttendenceShowBySpecific_Month(string Year, string Month)
        {
            string sq = @"exec ProcAttendenceShowBySpecific_Month @year=@NewYear,@month =@NewMonth";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewYear", Year);
            dbCommand.Parameters.AddWithValue("@NewMonth", Month);
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

        public DataTable AttendenceShowBySpecific_Year(string Year)
        {
            string sq = @"exec ProcAttendenceShowBySpecific_Year @year=@NewYear";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewYear", Year);
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


        public void UpdateAttendance(int id, string intime, string outtime, string status)
        {

            string sq = @"exec ProcUpdateAttendance @New1,@New4,@New5,@New6";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", id);
            dbCommand.Parameters.AddWithValue("@New4", intime);
            dbCommand.Parameters.AddWithValue("@New5", outtime);
            dbCommand.Parameters.AddWithValue("@New6", status);
            Database_Connection.con.Open();

            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated");

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed");

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }


    }
}
