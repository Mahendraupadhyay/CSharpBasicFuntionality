using System;
using System.Data;
using System.Data.SqlClient;
using ClassLibrary.DataBase_Operations;


namespace ClassLibrary
{
public class ManagerClass : IManager
    {
       public int AddEmployeeDetails(int empId, string empFName, string empLName, double empSalary, string empGender,int deptId)
        {

            DBUtility dBUtility = new DBUtility();
            int rowAffected = 0;
            using (SqlConnection con = dBUtility.SqlConnection())
            {
                SqlCommand command = new SqlCommand("sp_AddEmployee", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@FirstName", empFName);
                command.Parameters.AddWithValue("@LastName", empLName);
                command.Parameters.AddWithValue("@Gender", empGender);
                command.Parameters.AddWithValue("@Salary", empSalary);
                command.Parameters.AddWithValue("@DepartmentId", deptId);
                command.Parameters.AddWithValue("@Id", 0);

                con.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            return rowAffected;
        }
    }
}
