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
    class Model_Expenses
    {

        DataTable ShowExp(string q)
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

        public DataTable ProjectExpenseDetailShowSortByProjectName()
        {
            return ShowExp("exec ProcProjectExpenseDetailShowSortByProjectName");
        }
        public DataTable ProjectExpenseDetailShowSortByEmployeeName()
        {
            return ShowExp("exec ProcProjectExpenseDetailShowSortByEmployeeName");
        }

        public DataTable ProjectExpenseDetailShowSortByDate()
        {
            return ShowExp("exec ProcProjectExpenseDetailShowSortByDate");
        }

        public DataTable ProjectExpenseDetailShow()
        {
            return ShowExp("exec ProcProjectExpenseDetailShow");
        }
        public DataTable RegularExpenseDetailShow()
        {
            return ShowExp("exec ProcRegularExpenseDetailShow");
        }

        public DataTable RegularExpenseDetailShowSortByAmountASC()
        {
            return ShowExp("exec ProcRegularExpenseDetailShowSortByAmountASC");
        }
        public DataTable RegularExpenseDetailShowSortByAmountDesc()
        {
            return ShowExp("exec ProcRegularExpenseDetailShowSortByAmountDesc");
        }
        public DataTable RegularExpenseDetailShowSortByDateAsc()
        {
            return ShowExp("exec ProcRegularExpenseDetailShowSortByDateAsc");
        }
        public DataTable EmployeeSalariesDetailShow()
        {
            return ShowExp("exec ProcEmployeeSalariesDetailShow");
        }
        public DataTable EmployeeSalariesDetailShowSortByE_Name()
        {
            return ShowExp("exec ProcEmployeeSalariesDetailShowSortByE_Name");
        }
        public DataTable employeeSalariesDetailShowSortByAmountAsc()
        {
            return ShowExp("exec ProcEmployeeSalariesDetailShowSortByAmountAsc");
        }
        public DataTable EmployeeSalariesDetailShowSortByAmountDesc()
        {
            return ShowExp("exec ProcEmployeeSalariesDetailShowSortByAmountDesc");
        }




        public DataTable RegularExpenseDetailShowByRegularExpenseID(string RegExp_ID)
        {
            string sq = @"exec ProcRegularExpenseDetailShowByRegularExpenseID @id = @NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", RegExp_ID);
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


        public DataTable ProjectExpenseDetailShowByProjectExpenseId(string ProjectExpense_Id)
        {
            string sq = @" exec ProcProjectExpenseDetailShowByProjectExpenseId @id=@NewId";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewId", ProjectExpense_Id);
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

        public DataTable EmployeeSalaryDetailShowByEmpSalaryId(string EmpSalary_Id)
        {
            string sq = @" exec ProcEmployeesSalariesDetailSearchByEmpSalaryId @id=@NewId";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewId", EmpSalary_Id);
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





        public DataTable ProjectExpenseDetailShowByProjectName(string ProjectName)
        {
            string sq = @"exec ProcProjectExpenseDetailShowByProjectName @name=@NewName";
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
        public DataTable EmployeeSalariesDetailSearchByName(string Name)
        {
            string sq = @"exec ProcEmployeeSalariesDetailSearchByName @name=@NewName";
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
        public DataTable EmployeesSalariesDetailSearchById(string ID)
        {
            string sq = @"exec ProcEmployeesSalariesDetailSearchById @id=@NewID";
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

        public DataTable ProjectExpenseDetailShowByProjectId(string Project_Id)
        {
            string sq = @" exec ProcProjectExpenseDetailShowByProjectId @id=@NewId";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewId", Project_Id);
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

        public DataTable ProjectExpenseDetailShowBySpecificYear(string Year)
        {
            string sq = @"exec ProcProjectExpenseDetailShowBySpecificYear @year=@NewYear";
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

        public DataTable RegularExpenseDetailSearchBySpecificYear(string Year)
        {
            string sq = @"exec ProcRegularExpenseDetailSearchBySpecificYear @year=@NewYear";
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
        public DataTable EmployeeSalariesDetailSearchBySpecific_Year(string Year)
        {
            string sq = @"exec ProcEmployeeSalariesDetailSearchBySpecific_Year @year=@NewYear";
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

        public DataTable ProjectExpenseDetailShowBySpecificMonth(string Year,string Month)
        {
            string sq = @"exec ProcProjectExpenseDetailShowBySpecificMonth @year=@NewYear,@month =@NewMonth";
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


        public DataTable RegularExpenseDetailSearchBySpecificMonth(string Year, string Month)
        {
            string sq = @"exec ProcRegularExpenseDetailSearchBySpecificMonth @year=@NewYear,@month =@NewMonth";
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

        public DataTable EmployeeSalariesDetailSearchBySpecific_Month(string Year, string Month)
        {
            string sq = @"exec ProcEmployeeSalariesDetailSearchBySpecific_Month @year=@NewYear,@month =@NewMonth";
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

        public DataTable AllExpenseAmountSum(string Year, string Month)
        {
            string sq = @"exec AllExpenseAmountSum @year=@NewYear,@month =@NewMonth";
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
        public DataTable ProjectExpenseDetailShowBySpecificDay(string Year, string Month,string day)
        {
            string sq = @"exec ProcProjectExpenseDetailShowBySpecificDay @year=@NewYear,@month =@NewMonth,@day=@NewDay";
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

        public DataTable RegularExpenseDetailSearchBySpecificDay(string Year, string Month, string day)
        {
            string sq = @"exec ProcRegularExpenseDetailSearchBySpecificDay @year=@NewYear,@month =@NewMonth,@day=@NewDay";
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


        public DataTable EmployeeSalariesDetailSearchBySpecific_Day(string Year, string Month, string day)
        {
            string sq = @"exec ProcEmployeeSalariesDetailSearchBySpecific_Day @year=@NewYear,@month =@NewMonth,@day=@NewDay";
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



        public void ProcAddProjectExpense(string Projectname, string Employeename, string Amount,string date,string Note)
        {
            string sq = @"exec ProcAddProjectExpense @pname=@New1,@ename=@New2,@amount=@New3,@date=@New4,@note=@New5";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Projectname);
            dbCommand.Parameters.AddWithValue("@New2", Employeename);
            dbCommand.Parameters.AddWithValue("@New3", Amount);
            dbCommand.Parameters.AddWithValue("@New4", date);
            dbCommand.Parameters.AddWithValue("@New5", Note);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Project Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Project Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }

        public void ProcUpdateProjectExpense(int ProExp_ID, string Projectname, string Employeename, string Amount, string date, string Note)
        {
            string sq = @"exec ProcUpdateProjectExpense @id=@New0, @pname=@New1,@ename=@New2,@amount=@New3,@date=@New4,@note=@New5";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New0", ProExp_ID);
            dbCommand.Parameters.AddWithValue("@New1", Projectname);
            dbCommand.Parameters.AddWithValue("@New2", Employeename);
            dbCommand.Parameters.AddWithValue("@New3", Amount);
            dbCommand.Parameters.AddWithValue("@New4", date);
            dbCommand.Parameters.AddWithValue("@New5", Note);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Project Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Project Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }

        public void ProcDeleteProjectExpense(string ProjectId)
        {
            string sq = @"exec ProcDeleteProjectExpense @id=@New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", ProjectId);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted", "Deleting Project Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Deletion Failed", "Deleting Project Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database_Connection.con.Close();
            }


        }






        public void ProcAddRegularExpense(string Amount, string date, string description)
        {
            string sq = @"exec ProcInsertRegularExpense @amount = @New1, @description = @New2, @date=@New3";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Amount);
            dbCommand.Parameters.AddWithValue("@New2", description);
            dbCommand.Parameters.AddWithValue("@New3", date);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Regular Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Regular Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }



        public void ProcUpdateRegularExpense(int RE_Id, string Amount, string date, string description)
        {
            string sq = @"exec ProcUpdateRegularExpense @id = @New0, @amount = @New1, @description = @New2, @date=@New3";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New0", RE_Id);
            dbCommand.Parameters.AddWithValue("@New1", Amount);
            dbCommand.Parameters.AddWithValue("@New2", description);
            dbCommand.Parameters.AddWithValue("@New3", date);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Regular Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Regular Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }



        public void ProcDeleteRegularExpense(string RE_Id)
        {
            string sq = @"exec ProcDeleteRegularExpense @id=@New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", RE_Id);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted", "Deleting Regular Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Deletion Failed", "Deleting Project Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }





        public DataTable today_regular_expense(string date)
        {
            string sq = @"exec today_regular_expense @New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", date);
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

        public DataTable today_project_expense(string date)
        {
            string sq = @"exec today_project_expense @New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", date);
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






        public DataTable ProcMonthlyProjectExpenses(string Year, string Month)
        {
            string sq = "exec ProcMonthlyProjectExpenses @year=@NewYear, @month=@NewMonth";
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
        public DataTable ProcYearlyProjectExpense(string Year)
        {
            string sq = @"exec ProcYearlyProjectExpense @year=@NewYear";
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
        public DataTable ProcMonthlyRegularExpense(string Year, string Month)
        {
            string sq = "exec ProcMonthlyRegularExpense @year=@NewYear, @month=@NewMonth";
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
        public DataTable ProcYearlyRegularExpense(string Year)
        {
            string sq = @"exec ProcYearlyRegularExpense @year=@NewYear";
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
        public DataTable ProcTodayEmployeeSalaries(string date)
        {
            string sq = @"exec ProcTodayEmployeeSalaries @date = @NewDate";
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
        public DataTable ProcMonthlyEmployeeSalaries(string Year, string Month)
        {
            string sq = "exec ProcMonthlyEmployeeSalaries @year=@NewYear, @month=@NewMonth";
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
        public DataTable ProcYearlyEmployeeSalaries(string Year)
        {
            string sq = @"exec ProcYearlyEmployeeSalaries @year=@NewYear";
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
