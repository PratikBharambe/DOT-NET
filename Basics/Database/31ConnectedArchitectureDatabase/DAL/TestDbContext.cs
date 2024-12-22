using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _31ConnectedArchitectureDatabase.Model;
using Microsoft.Data.SqlClient;

namespace _31ConnectedArchitectureDatabase.DAL
{
    internal class TestDbContext
    {

        // Connection String
        const string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True";

        // Function to get all employee
        internal List<Employee> getAllEmployees()
        {
            List<Employee> empList = new List<Employee>();
            SqlConnection con = new SqlConnection(conStr);
            string selectQuery = "select * from Employee";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                empList.Add(new Employee()
                {
                    id = Convert.ToInt32(reader["Id"]),
                    name = Convert.ToString(reader["Name"]),
                    address = Convert.ToString(reader["Address"])
                });
            }
            con.Close();
            return empList;
        }

        // Function to get all employee by id
        internal Employee getEmployeeById(int id)
        {
            SqlConnection con = new SqlConnection(conStr);
            string selectByIdQuery = $"select * from Employee where Id = {id}";
            SqlCommand cmd = new SqlCommand(selectByIdQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp = null;
            if (reader.Read())
            {
                emp = new Employee()
                {
                    id = Convert.ToInt32(reader["Id"]),
                    name = Convert.ToString(reader["Name"]),
                    address = Convert.ToString(reader["Address"])
                };
            }
            con.Close();
            return emp;
        }

        // Function to insert new employee deatils in database
        internal bool InsertNewEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection(conStr);
            string insertQuery = $"insert into Employee values('{emp.name}', '{emp.address}')";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            return n > 0;
        }

        // Functopn to update empployess details
        internal bool updateEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection(conStr);
            string updateQuery = $"update Employee set Name = '{emp.name}', Address = '{emp.address}' where Id = {emp.id}";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            return n > 0;
        }

        // Functopn to delete empployess details
        internal bool deleteEmployee(int id)
        {
            SqlConnection con = new SqlConnection(conStr);
            string deleteQuery = $"delete from Employee where Id = {id}";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            return n > 0;
        }
    }
}
