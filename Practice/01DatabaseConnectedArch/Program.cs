using Microsoft.Data.SqlClient;

namespace _01DatabaseConnectedArch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Normal Flow
            //string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AudioBook;Integrated Security=True";

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

            #region update Query
            //Console.WriteLine("Enter Id of the Book : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter New Book Name : ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Enter New Book Author : ");
            //string? auther = Console.ReadLine();
            //Console.WriteLine("Enter New Book Narrator : ");
            //string? narrator = Console.ReadLine();

            //string updateQuery = $"update Books set Name = '{name}', Author = '{auther}', Narrator = '{narrator}' where Id = {id}";
            //SqlConnection con = new SqlConnection(conStr);
            //SqlCommand cmd = new SqlCommand(updateQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //con.Close();
            //if(n > 0)
            //    Console.WriteLine("Audio Book Updated successfully.");
            //else
            //    Console.WriteLine("Error in audio book updation.");
            #endregion

            #region Delete Query
            //Console.WriteLine("Enter Id of the Book : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //SqlConnection con = new SqlConnection(conStr);
            //string deleteQuery = $"delete from Books where Id = {id}";
            //SqlCommand cmd = new SqlCommand(deleteQuery, con);
            //con.Open();
            //int data = cmd.ExecuteNonQuery();
            //con.Close();
            //if(data > 0 )
            //    Console.WriteLine("Audio Book Deleted Successsfully.");
            //else
            //    Console.WriteLine("Error in audio book deletion.");
            #endregion

            #endregion

            

        }
    }
}
