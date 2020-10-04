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
    class Model_Income
    {

        string startMonth = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + "01";
        string endMonth = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString();

        public DataTable ShowIncome(string q)
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

        public DataTable ProjectIncomeSum_Month()
        {
            return ShowIncome("exec ProcProjectIncomeSum_Month");
        }

        public DataTable ProjectIncomeSum_Year()
        {
            return ShowIncome("exec ProcProjectIncomeSum_Year");
        }

        public DataTable Get_AcademyIncome()
        {
            return ShowIncome("exec Academy_Income_Month '" + startMonth + "', '" + endMonth + "'");

        }

        public DataTable Allprojectdatashow()
        {
            return ShowIncome("exec Allprojectdatashow");
        }

        public DataTable SortingAmountAscending()
        {
            return ShowIncome("exec SortingAmountAscending");
        }

        public DataTable SortingAmountdescending()
        {
            return ShowIncome("exec SortingAmountdescending");
        }
        public DataTable SortingName()
        {
            return ShowIncome("exec SortingName");
        }

        public DataTable AllAcademydatashow()
        {
            return ShowIncome("exec AllAcademydatashow");
        }

        public DataTable Academydatasortbyname()
        {
            return ShowIncome("exec Academydatasortbyname");
        }
        public DataTable AcademydatasortbyDATE()
        {
            return ShowIncome("exec AcademydatasortbyDATE");
        }

        public DataTable Academyincomedatasortbyname()
        {
            return ShowIncome("exec Academyincomedatasortbyname");
        }
        public DataTable AcademyIncomeSum_Month()
        {
            return ShowIncome("exec ProcAcademyIncomeSum_Month");
        }
        public DataTable AcademyIncomeSum_Year()
        {
            return ShowIncome("exec ProcAcademyIncomeSum_Year");
        }

        public void ProcUpdateAcademyIncome(int AI_ID, int studentid, string amount, string note, string date)
        {
            string sq = @"exec ProcUpdateAcademyIncome @Ai_id=@New1,@stdid=@New2,@amount=@New3,@note=@New4,@date=@New5";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", AI_ID);
            dbCommand.Parameters.AddWithValue("@New2", studentid);
            dbCommand.Parameters.AddWithValue("@New3", amount);
            dbCommand.Parameters.AddWithValue("@New4", note);
            dbCommand.Parameters.AddWithValue("@New5", date);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Academy Income", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Academy Income", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }
        public void ProcUpdateProjectIncome(int Pi_id, int projid, string amount, string note, string date)
        {
            string sq = @"exec  ProcUpdateProjectIncome @Pi_id=@New1,@projid=@New2,@amount=@New3,@note=@New4,@date=@New5";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Pi_id);
            dbCommand.Parameters.AddWithValue("@New2", projid);
            dbCommand.Parameters.AddWithValue("@New3", amount);
            dbCommand.Parameters.AddWithValue("@New4", note);
            dbCommand.Parameters.AddWithValue("@New5", date);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Project Income", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Project Income", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }

        public DataTable SearchbyProjectName(string ProjectName)
        {
            string sq = @"exec SearchbyProjectName @name=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", ProjectName);
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

        public DataTable SearchbyProjectIncomeid(string IncomeID)
        {
            string sq = @"exec [Searchbyprojectincomeid] @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", IncomeID);
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

        public DataTable SearchbyProjectid(string ProjectID)
        {
            string sq = @"exec SearchbyProjectid @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", ProjectID);
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

        public DataTable Academydatashowbyname(string StudentName)
        {
            string sq = @"exec Academydatashowbyname @name=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", StudentName);
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

        public DataTable Academydatashowbyids(string StudentID)
        {
            string sq = @"exec Academydatashowbyids @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", StudentID);
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


        public DataTable Academydatashowbyacademyincomeid(string IncomeID)
        {
            string sq = @"exec Academydatashowbyacademyincomeid @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", IncomeID);
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

        public DataTable today_academy_income_Sum(string Date)
        {
            string sq = @"exec today_academy_income_Sum '"+Date+"'";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
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

        public DataTable today_Proj_income_Sum(string Date)
        {
            string sq = @"exec today_Proj_income_Sum '"+Date+"'";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
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

        public void Addincome(string StudentName, string amount,string note)
        {
            string sq = @"exec addincome @stdid=@NewName,@amount=@NewAmount,@note=@NewNote,@date='" + DateTime.Now.ToString()+"'";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", StudentName);
            dbCommand.Parameters.AddWithValue("@NewAmount", amount);
            dbCommand.Parameters.AddWithValue("@NewNote", note);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Academy Income", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Academy Income", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }

        public void Addprojectincome(string Name, string amount, string note)
        {
            string sq = @"exec addprojectincome @pro_id=@NewName,@amount=@NewAmount,@note=@NewNote,@date=@NewDate";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", Name);
            dbCommand.Parameters.AddWithValue("@NewAmount", amount);
            dbCommand.Parameters.AddWithValue("@NewNote", note);
            dbCommand.Parameters.AddWithValue("@NewDate", DateTime.Now.ToShortDateString());

            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Project Income", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Project Income", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }
        }

        public DataTable SearchBy_specific_month_ProjectIncome(string Year,string Month)
        {
            string sq = @"exec specific_month @year=@NewYear, @month=@NewMonth";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewMonth", Month);
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
        public DataTable SearchBy_specific_Year_ProjectIncome(string Year)
        {
            string sq = @"exec specific_year @date=@NewYear";
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

        public DataTable SearchBy_specific_Date_ProjectIncome(string Year,string Month,string day)
        {
            string sq = @"exec specific_day @year=@NewYear, @month=@NewMonth,@day=@NewDay";
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

        public DataTable searchinAcademyIncomebyspecific_day(string Year, string Month, string day)
        {
            string sq = @"exec searchinAcademyIncomebyspecific_day @year=@NewYear, @month=@NewMonth,@day=@NewDay";
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

        public DataTable searchinAcademyIncomebyspecific_month(string Year,string Month)
        {
            string sq = "exec searchinAcademyIncomebyspecific_month @year=@NewYear, @month=@NewMonth";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewMonth", Month);
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

        public DataTable searchAcademyIncomebyspecific_year(string Year)
        {
            string sq = @"exec searchAcademyIncomebyspecific_year @year=@NewYear";
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

      
    }
}
