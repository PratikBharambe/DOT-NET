using Microsoft.Data.SqlClient;

namespace _31ConnectedArchitetureDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Application with Console.WriteLine
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Pooling=False;Trust Server Certificate=False";

            #region Select Query
            //SqlConnection con = new SqlConnection(conStr);
            //String selectQuery = "select * from Emp";
            //SqlCommand cmd = new SqlCommand(selectQuery, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read()) 
            //{
            //    int id = Convert.ToInt32(reader["Id"]);
            //    string? Name = Convert.ToString(reader["Name"]);
            //    string? Address = Convert.ToString(reader["Address"]);
            //    Console.WriteLine($"Id : {id}, Name :{Name}, Address:{Address}");
            //}
            //con.Close();

            #endregion

            #region Insert Query
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Id");
            //String id = Console.ReadLine();
            //Console.WriteLine("Enter Name");
            //String nm = Console.ReadLine();
            //Console.WriteLine("Enter Address");
            //String add = Console.ReadLine();
            //String insertQuery = $"insert into Emp values('{id}','{nm}','{add}')";
            //SqlCommand cmd = new SqlCommand(insertQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    Console.WriteLine("Data inserted Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Data not inserted");
            //}
            //con.Close();
            #endregion

            #region Update Query
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Id");
            //String id = Console.ReadLine();
            //Console.WriteLine("Enter Name");
            //String nm = Console.ReadLine();
            //Console.WriteLine("Enter Address");
            //String add = Console.ReadLine();
            //String updateQuery = $"update  Emp set Name='{nm}',Address='{add}' where Id ='{id}' ";
            //SqlCommand cmd = new SqlCommand(updateQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    Console.WriteLine("Data updated Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Data not updated");
            //}
            //con.Close();

            #endregion

            #region Delete Query

            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Id: ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //String DeleteQuery = $" delete from Emp where ID ={id}";
            //SqlCommand cmd = new SqlCommand(DeleteQuery,con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    Console.WriteLine("Data deleted Succesfully");
            //}
            //else
            //    {
            //    Console.WriteLine("Data deleted Succesfully");
            //}
            //con.Close();

            #endregion

            #endregion

        }
    }
}
