using System.Data;
using Microsoft.Data.SqlClient;

namespace _02DatabaseDisconnectedArchitechture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AudioBook;Integrated Security=True";


            #region Select Query

            SqlConnection conn = new SqlConnection(constr);
            string selectQuery = "select * from Books";
            SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            DataTable dt = new DataTable();
            da.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //    Console.WriteLine($"Id : {dr["Id"]}, Name : {dr["Name"]}, Author : {dr["Author"]}, Narrator : {dr["Narrator"]}");

            #endregion


            #region Insert Query

            //Console.WriteLine("Enter name : ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Enter author name : ");
            //string? author = Console.ReadLine();
            //Console.WriteLine("Enter narrator name : ");
            //string? narrator = Console.ReadLine();

            //DataRow dr = dt.NewRow();
            //dr["Name"] = name;
            //dr["Author"] = author;
            //dr["Narrator"] = narrator;

            //dt.Rows.Add(dr);
            //da.Update(dt);

            #endregion

            #region Update Query

            //Console.WriteLine("Enter id : ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //DataRow? bookToBeEdited = dt.Rows.Find(id);

            //if (bookToBeEdited != null)
            //{
            //    Console.WriteLine("Enter name : ");
            //    bookToBeEdited["Name"] = Console.ReadLine();
            //    Console.WriteLine("Enter author name : ");
            //    bookToBeEdited["Author"] = Console.ReadLine();
            //    Console.WriteLine("Enter narrator name : ");
            //    bookToBeEdited["Narrator"] = Console.ReadLine();
            //    da.Update(dt);
            //}
            //else
            //{
            //    Console.WriteLine("Book is not present.");
            //}

            #endregion

            #region Delete Query

            Console.WriteLine("Enter id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow? bookToBeDeleted = dt.Rows.Find(id);
            if (bookToBeDeleted != null)
            {
                dt.Rows.Remove(bookToBeDeleted);
                bookToBeDeleted.Delete();
                da.Update(dt);
            }
            else
            {
                Console.WriteLine("Book is not present.");
            }
            #endregion

        }
    }
}
