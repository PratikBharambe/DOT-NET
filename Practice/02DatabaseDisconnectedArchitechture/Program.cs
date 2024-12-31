using Microsoft.Data.SqlClient;

namespace _02DatabaseDisconnectedArchitechture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AudioBook;Integrated Security=True";

            SqlConnection conn = new SqlConnection(constr);
            string selecrQuery = "select * from Books";
            SqlDataAdapter da = new SqlDataAdapter();

        }
    }
}
