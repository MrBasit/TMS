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
    class Model_Withdrawal
    {

        DataTable dt;

        public DataTable ShowWith(string q)
        {
            
            dt = new DataTable();

            try
            {
                SqlCommand dbCommand = new SqlCommand(q, Database_Connection.con);
                Database_Connection.con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(dbCommand);
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

        public DataTable ProcWithdrawalDatailShow()
        {
            return ShowWith("exec ProcWithdrawalDatailShow");
        }
        public DataTable WithdrawalDatailSortByNames()
        {
            return ShowWith("exec ProcWithdrawalDatailSortByNames");
        }
        public DataTable WithdrawalDatailSortByAmount()
        {
            return ShowWith("exec ProcWithdrawalDatailSortByAmount");
        }
        public DataTable withdrawals()
        {
            return ShowWith("exec withdrawals");
        }
        public DataTable WithdrawalShowDistinctName()
        {
            return ShowWith("exec ProcWithdrawalShowDistinctName");
        }

        public float ProcAvailableAmountOfCompany()
        {
            dt =  ShowWith("exec ProcTotalExpenseOfCompany");
            float totalExpense = float.Parse(dt.Rows[0][0].ToString());

            dt = ShowWith("exec ProcTotalIncomeOfCompany");
            float totalIncome = float.Parse(dt.Rows[0][0].ToString());

            dt = ShowWith("exec ProcTotalWithdrawalOfCompany");
            float totalWithdrawal = float.Parse(dt.Rows[0][0].ToString());

            return totalIncome - totalExpense - totalWithdrawal;
        }


        public float ProcTotalWithdrawalOfCompany()
        {
            dt = ShowWith("exec ProcTotalWithdrawalOfCompany");

            float totalExpense = float.Parse(dt.Rows[0][0].ToString());

            return totalExpense;
        }


        public DataTable WithdrawalDatailSearchByNames(string Name)
        {
            //   string sq = "SELECT Name,Amount,Date,Note FROM Withdrawal where Name=@NewName";
            string sq = @"exec ProcWithdrawalDatailSearchByNames @name=@NewName";
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



        public DataTable ProcWithdrawalDatailShowById(string Id)
        {
            string sq = @"exec ProcWithdrawalDatailShowById @id=@NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", Id);
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



        public DataTable WithdrawalDatailSearchBySpecific_Year(string Year)
        {
            
            string sq = @"exec ProcWithdrawalDatailSearchBySpecific_Year @year=@NewYear";
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

        public DataTable WithdrawalDatailSearchBySpecific_Month(string Year, string Month)
        {
            string sq = @"exec ProcWithdrawalDatailSearchBySpecific_Month @year=@NewYear,@month =@NewMonth";
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

        public DataTable WithdrawalDatailSearchBySpecific_Day(string Year, string Month, string day)
        {
            string sq = @"exec ProcWithdrawalDatailSearchBySpecific_Day @year=@NewYear,@month =@NewMonth,@day=@NewDay";
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









        public void ProcInsertWithdrawal(string Name, string Amount, string date, string Note)
        {
            string sq = @"exec ProcInsertWithdrawal @Name=@New2, @date=@New3, @amount=@New4, @note=@New5";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);

            dbCommand.Parameters.AddWithValue("@New2", Name);
            dbCommand.Parameters.AddWithValue("@New3", date);
            dbCommand.Parameters.AddWithValue("@New4", Amount);
            dbCommand.Parameters.AddWithValue("@New5", Note);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }







        public void ProcUpdateWithdrawal(int With_ID, string Name, string Amount, string date, string Note)
        {
            string sq = @"exec ProcUpdateWithdrawal @id=@New1, @Name=@New2, @date=@New3, @amount=@New4, @note=@New5";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);

            dbCommand.Parameters.AddWithValue("@New1", With_ID);
            dbCommand.Parameters.AddWithValue("@New2", Name);
            dbCommand.Parameters.AddWithValue("@New3", date);
            dbCommand.Parameters.AddWithValue("@New4", Amount);
            dbCommand.Parameters.AddWithValue("@New5", Note);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }




        public void ProcDeleteWithdrawal(string With_ID)
        {
            string sq = @"exec ProcDeleteWithdrawal @id=@New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);

            dbCommand.Parameters.AddWithValue("@New1", With_ID);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted", "Deleting Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Deleted Failed", "Deleting Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }


    }
}
