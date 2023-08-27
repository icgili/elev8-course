using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace EmployeeForm
{
    class EmployeeInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfEmployment { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

        //Create a connection string to SQLite
        private const string connString = "Data Source=C:\\Users\\icgili\\Documents\\ctrl+future\\elev8-course\\step-8\\day-3\\EmployeeForm\\employeeDb.db;Version=3;";

        //CRUD OPERATIONS
        public int CreateEmployee(EmployeeInfo employee)
        {
            try
            {
                var dbConnection = new SQLiteConnection(connString);
                dbConnection.Open();

                string query = "INSERT INTO employees(name, date_of_employment, department, role) VALUES(@name, @dateOfEmployment, @department, @role)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, dbConnection))
                {
                    cmd.Parameters.AddWithValue("@name", employee.Name);
                    cmd.Parameters.AddWithValue("@dateOfEmployment", employee.DateOfEmployment);
                    cmd.Parameters.AddWithValue("@department", employee.Department);
                    cmd.Parameters.AddWithValue("@role", employee.Role);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                
            }

            return -1;
        }
        public int UpdateEmployee(EmployeeInfo employee)
        {
            try
            {
                var dbConnection = new SQLiteConnection(connString);
                dbConnection.Open();

                string query = "UPDATE employees SET name=@name, date_of_employment=@dateOfEmployment, department=@department, role=@role WHERE id=@id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, dbConnection))
                {
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@name", employee.Name);
                    cmd.Parameters.AddWithValue("@dateOfEmployment", employee.DateOfEmployment);
                    cmd.Parameters.AddWithValue("@department", employee.Department);
                    cmd.Parameters.AddWithValue("@role", employee.Role);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

            }

            return -1;
        }
        public int DeleteEmployee(int id)
        {
            try
            {
                var dbConnection = new SQLiteConnection(connString);
                dbConnection.Open();

                string query = "DELETE FROM employees WHERE id=@id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, dbConnection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

            }

            return -1;
        }
        public DataSet GetEmployees()
        {
            try
            {
                var dbConnection = new SQLiteConnection(connString);
                dbConnection.Open();

                SQLiteDataAdapter da = new SQLiteDataAdapter("Select * From employees", dbConnection);
                DataSet ds = new DataSet();
                da.Fill(ds, "employees");
                return ds;
            }
            catch (Exception e)
            {

            }
            return null;
        }
    }
}
