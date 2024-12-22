
using Microsoft.Data.SqlClient;

namespace _31ConnectedArchitectureDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True";

            #region CRUD Application with Console.WriteLine

            #region select Query
            //SqlConnection con = new SqlConnection(conStr);
            //string selectQuery = "select * from Employee";
            //SqlCommand cmd = new SqlCommand(selectQuery, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader["ID"]);
            //    string? name = Convert.ToString(reader["Name"]);
            //    string? address = Convert.ToString(reader["Address"]);
            //    Console.WriteLine($"ID : {id}, Name : {name}, Address : {address}");
            //}
            //con.Close();
            #endregion

            #region Insert Query
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Name : ");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter Address : ");
            //string add = Console.ReadLine();
            //string insertQuery = $"insert into Employee values('{nm}', '{add}')";
            //SqlCommand cmd = new SqlCommand(insertQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if(n > 0)
            //    Console.WriteLine("Data inserted successfully.");
            //else
            //    Console.WriteLine("Data not inserted.");
            //con.Close(); 
            #endregion

            #region Update Query
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter id : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Name : ");
            //string? nm = Console.ReadLine();
            //Console.WriteLine("Enter Address : ");
            //string? add = Console.ReadLine();
            //string updateQuery = $"update Employee set Name = '{nm}', Address = '{add}' where Id = {id}";
            //SqlCommand cmd = new SqlCommand(updateQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //    Console.WriteLine("Data updated successfully.");
            //else
            //    Console.WriteLine("Data not updated.");
            //con.Close(); 
            #endregion

            #region Delete Query
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter id : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //string deleteQuery = $"delete from Employee where Id = {id}";
            //SqlCommand cmd = new SqlCommand(deleteQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //    Console.WriteLine("Data deleted successfully.");
            //else
            //    Console.WriteLine("Data not deleted.");
            //con.Close(); 
            #endregion 

            #endregion


        }
    }
}
