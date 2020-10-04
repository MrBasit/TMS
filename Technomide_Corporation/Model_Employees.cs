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
    class Model_Employees
    {

        public DataTable ShowEmp(string q)
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


        public DataTable SortByName()
        {
            return ShowEmp("select Name,Employee_ID, TypeTable.TypeName,Salary from EmployeeTable left join TypeTable on EmployeeTable.T_ID=TypeTable.T_ID order by Name");
        }

        public DataTable SortByType()
        {
            return ShowEmp("select Name,Employee_ID, TypeTable.TypeName,Salary from EmployeeTable left join TypeTable on EmployeeTable.T_ID=TypeTable.T_ID Order by TypeTable.T_ID");
        }

        public DataTable ShowEmployeeSkills(string id)
        {

            string sq = @"exec ProcShowEmployeeSkillById @id = @NewName";
            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@NewName", id);
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





        public DataTable SearchByName(string Name)
        {
            string sq = @"exec employee_name @name = @NewName";
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

        public DataTable SearchById(string ID)
        {
            string sq = @"exec employee_id @id= @NewId";
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

        bool CheckEmpHavingActiveProject(string ID)
        {
            string sq = @"select pat.Pro_ID,pat.E_ID from  ProjectAssignedTable pat join EmployeeTable et on et.E_ID = pat.E_ID join ProjectTable pt on pat.Pro_ID = pt.Pro_ID where et.Employee_ID = @NewId";
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

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;

        }

        public string DeleteEmployeeById(string ID)
        {

            if (!(CheckEmpHavingActiveProject(ID)))
            {
                string sq = @"delete from EmployeeTable where Employee_ID = @NewId";
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
                return "Successfully Deleted";
            }
            else
                return "Sorry Employee Have Active Project";
        }

        public void AddEmployeeData(string name, string fname, string cnic, string dob
            , string address, string agrement, string typename, string gendername, string postname,
            string qualificationname, string phone1, string phone2, string empid, string salary)
        {
            string sq = @"exec Insert_EmployeesRecord @v_name =@New1, @v_FName =@New2, @v_CNIC = @New3 , 
@v_DOB =@New4, @v_address = @New5, @v_agreement =@New6, @typename =@New7, @gendername =@New8, @postname =@New9, 
@qualificationname = @New10, @phone1 =@New11, @phone2 = @New12, @employeeid = @New13, @salary= @New14";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
            dbCommand.Parameters.AddWithValue("@New2", fname);
            dbCommand.Parameters.AddWithValue("@New3", cnic);
            dbCommand.Parameters.AddWithValue("@New4", dob);
            dbCommand.Parameters.AddWithValue("@New5", address);
            dbCommand.Parameters.AddWithValue("@New6", agrement);
            dbCommand.Parameters.AddWithValue("@New7", typename);
            dbCommand.Parameters.AddWithValue("@New8", gendername);
            dbCommand.Parameters.AddWithValue("@New9", postname);
            dbCommand.Parameters.AddWithValue("@New10", qualificationname);
            dbCommand.Parameters.AddWithValue("@New11", phone1);
            dbCommand.Parameters.AddWithValue("@New12", phone2);
            dbCommand.Parameters.AddWithValue("@New13", empid);
            dbCommand.Parameters.AddWithValue("@New14", salary);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }


        public void UpdateEmployeeData(string name, string fname, string cnic, string dob
            , string address, string agrement, string typename, string gendername, string postname,
            string qualificationname, string phone1, string phone2, string empid, string salary)
        {
            string sq = @"exec Update_Employee  @v_name =@New1, @v_FName =@New2, @v_CNIC = @New3 , 
@v_DOB =@New4, @v_address = @New5, @v_agreement =@New6, @typename =@New7, @gendername =@New8, @postname =@New9, 
@qualificationname = @New10, @phone1 =@New11, @phone2 = @New12, @employeeid = @New13, @salary= @New14";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
            dbCommand.Parameters.AddWithValue("@New2", fname);
            dbCommand.Parameters.AddWithValue("@New3", cnic);
            dbCommand.Parameters.AddWithValue("@New4", dob);
            dbCommand.Parameters.AddWithValue("@New5", address);
            dbCommand.Parameters.AddWithValue("@New6", agrement);
            dbCommand.Parameters.AddWithValue("@New7", typename);
            dbCommand.Parameters.AddWithValue("@New8", gendername);
            dbCommand.Parameters.AddWithValue("@New9", postname);
            dbCommand.Parameters.AddWithValue("@New10", qualificationname);
            dbCommand.Parameters.AddWithValue("@New11", phone1);
            dbCommand.Parameters.AddWithValue("@New12", phone2);
            dbCommand.Parameters.AddWithValue("@New13", empid);
            dbCommand.Parameters.AddWithValue("@New14", salary);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }


        public DataTable SearchEmpById(string ID)
        {
            string sq = @"exec searchemployeebyid @id=@NewId";
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


        public DataTable Search_completed_project_names(string ID)
        {
            string sq = @"exec completed_project_names @id=@NewId";
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


        public DataTable Search_ongoing_project_names(string ID)
        {
            string sq = @"exec ongoing_project_names @id=@NewId";
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



        public void ProcDeleteEmployeeSalaries(string ProjectId)
        {
            string sq = @"exec ProcDeleteEmployeeSalaries @id=@New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", ProjectId);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted", "Deleting Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Deletion Failed", "Deleting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }

        public void ProcUpdateEmplyeeSalaries(int EmpID, string EmpName, string Amount, string date, string Note)
        {
            string sq = @"exec ProcUpdateEmplyeeSalaries @id=@New1, @ename='Ali',@amount=@New3,@date=@New4,@note=@New5";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", EmpID);
            dbCommand.Parameters.AddWithValue("@New2", EmpName);
            dbCommand.Parameters.AddWithValue("@New3", Amount);
            dbCommand.Parameters.AddWithValue("@New4", date);
            dbCommand.Parameters.AddWithValue("@New5", Note);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Updated", "Updating Employee Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Updation Failed", "Updating Employee Salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Database_Connection.con.Close();
            }
        }

        public void ProcInsertEmplyeeSalaries(string Employeename, string Amount, string date, string Note)
        {
            string sq = @"exec ProcInsertEmplyeeSalaries  @ename=@New1,@amount=@New2,@date=@New3,@note=@New4";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", Employeename);
            dbCommand.Parameters.AddWithValue("@New2", Amount);
            dbCommand.Parameters.AddWithValue("@New3", date);
            dbCommand.Parameters.AddWithValue("@New4", Note);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Employee Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Employee Salary", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }





        public DataTable ShowAllDesignations()
        {

            string sq = @"exec ProcShowAllDesignations";
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




        public void ProcInsertDesignation(string name)
        {
            string sq = @"exec ProcAddDesignation  @name=@New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Designation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Designation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }








        public DataTable ShowAllEmpTypes()
        {

            string sq = @"exec ProcShowAllEmpTypes";
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


        public void ProcInsertEmpType(string name)
        {
            string sq = @"exec ProcAddEmpType  @name=@New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }









        public DataTable ShowAllSkills()
        {

            string sq = @"exec ProcShowAllSkills";
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


        public void ProcInsertSkills(string name)
        {
            string sq = @"exec ProcInsertSkills  @name=@New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Skills", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Skills", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }














        public DataTable ShowAllQualification()
        {

            string sq = @"exec ProcShowAllQualifications";
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


        public void ProcInsertQualification(string name)
        {
            string sq = @"exec ProcAddQualification  @name=@New1";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", name);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Qualification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Qualification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }










        public DataTable ShowAllEmpSkills()
        {

            string sq = @"exec ProcShowAllEmpSkills";
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


        public void ProcInsertEmpSkills(int EmpId , string Skillname)
        {
            string sq = @"exec ProcAddEmpSkill  @EmpId = @New1, @Skillname = @New2";

            SqlCommand dbCommand = new SqlCommand(sq, Database_Connection.con);
            dbCommand.Parameters.AddWithValue("@New1", EmpId);
            dbCommand.Parameters.AddWithValue("@New2", Skillname);
            Database_Connection.con.Open();
            try
            {
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted", "Inserting Employee Skill", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException sqlex)
            {
                ErrorHandling rh = new ErrorHandling();
                rh.GetError(sqlex.Number);
                MessageBox.Show("Insertion Failed", "Inserting Employee Skill", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Database_Connection.con.Close();
            }


        }




    }
}