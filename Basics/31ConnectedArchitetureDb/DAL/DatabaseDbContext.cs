using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _31ConnectedArchitetureDb.Model;
using Microsoft.Data.SqlClient;

namespace _31ConnectedArchitetureDb.DAL
{
    internal class DatabaseDbContext
    {

        //Conection String

        const string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Pooling=False;Trust Server Certificate=False";

        //Function to get all Employees

        public List<Employee> getAllEmployee()
        {
            List<Employee> emplist = new List<Employee>();
            SqlConnection con = new SqlConnection(conStr);
            string selectquery = "select * from Employee";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                emplist.Add(new Employee()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Address = Convert.ToString(reader["Address"])
                });
            }
            con.Close();
            return emplist;
        }

        //Function to get all the employee by id 
        public Employee getEmployeeById(int Id)
        {
            SqlConnection con = new SqlConnection(conStr);
            string selectByIdQuery = $"select * from Employee where Id ={Id}";
            SqlCommand cmd = new SqlCommand(selectByIdQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Employee? emp = null;
            if (reader.Read())
            {
                emp = new Employee()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Address = Convert.ToString(reader["Address"])
                };
            }
            con.Close();
            if (emp != null)
                return emp;
            else
                return null;
        }

        // Function to insert new employee details in database
        internal bool InsertNewEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection(conStr);
            string insertQuery = $"insert into Employee values({emp.Id}, '{emp.Name}', '{emp.Address}') ";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            return n > 0;
        }

        //Function to update employee details
        internal bool updateEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection(conStr);
            string UpdateQuery = $"update into Employee set Name ='{emp.Name}', Address = '{emp.Address}') where Id= {emp.Id}";
            SqlCommand cmd = new SqlCommand(UpdateQuery, con);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            return n > 0;
        }

        //Function to delete the employee details
        internal bool deleteEmployee(int Id)
        {
            SqlConnection con = new SqlConnection();
            string deleteQuery = $"delete from Employee where Id = {Id}";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            return n > 0;

        }

    }

}
