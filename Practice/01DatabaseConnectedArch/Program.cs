using Microsoft.Data.SqlClient;

namespace _01DatabaseConnectedArch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AudioBook;Integrated Security=True";

            #region Select Query
            //SqlConnection con = new SqlConnection(conStr);
            //string selectQuery = "select * from Books";
            //SqlCommand cmd = new SqlCommand(selectQuery, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader["Id"]);
            //    string? name = reader["Name"].ToString();
            //    string? auther = reader["Author"].ToString();
            //    string? narrator = reader["Narrator"].ToString();
            //    Console.WriteLine($"Id : {id}, Name : {name}, Author : {auther}, Narrator : {narrator}");
            //}
            //con.Close();
            #endregion

            #region Insert Query
            //Console.WriteLine("Enter Book Name : ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Enter Book Author : ");
            //string? auther = Console.ReadLine();
            //Console.WriteLine("Enter Book Narrator : ");
            //string? narrator = Console.ReadLine();

            //string insertQuery = $"insert into Books values('{name}', '{auther}', '{narrator}')";

            //SqlConnection con = new SqlConnection(conStr);
            //SqlCommand cmd = new SqlCommand(insertQuery, con);
            //con.Open();
            //int data = cmd.ExecuteNonQuery();
            //con.Close();
            //if(data > 0 )
            //    Console.WriteLine("Audio Book Added successfully.");
            //else
            //    Console.WriteLine("Error in audio book insertion.");
            #endregion

        }
    }
}
