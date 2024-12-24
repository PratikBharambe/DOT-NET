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
            SqlConnection con = new SqlConnection(conStr);
            String selectQuery = "select * from Emp";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                int id = Convert.ToInt32(reader["Id"]);
                string? Name = Convert.ToString(reader["Name"]);
                string? Address = Convert.ToString(reader["Address"]);
                Console.WriteLine($"Id : {id}, Name :{Name}, Address:{Address}");
            }
            con.Close();

            #endregion Insert Query



            #region 

            #endregion
            #endregion
        }
    }
}
