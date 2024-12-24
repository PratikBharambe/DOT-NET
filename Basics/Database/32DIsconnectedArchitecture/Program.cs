using System.Data;
using Microsoft.Data.SqlClient;

namespace _32DIsconnectedArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Pooling=False;Trust Server Certificate=False";

            #region Disconnected Architechture select query
            SqlConnection con = new SqlConnection(conStr);
            string selectQuery = "select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(selectQuery, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            DataTable dt = new DataTable();
            da.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine($"ID : {dr["Id"]}, Name : {dr["Name"]}, Address : {dr["Address"]}");
            //} 
            #endregion


            #region Disconnected Architechture insert query
            //Console.WriteLine("Enter Name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Address : ");
            //string address = Console.ReadLine();
            //DataRow row = dt.NewRow();
            //row["Name"] = name;
            //row["Address"] = address;
            //dt.Rows.Add(row);
            //da.Update(dt); 
            #endregion


            #region Disconnected Architechture update query
            //Console.WriteLine("Enter ID : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //DataRow roempToBeEdited = dt.Rows.Find(id);
            //if (roempToBeEdited != null)
            //{
            //    Console.WriteLine("Enter Name : ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter Address : ");
            //    string address = Console.ReadLine();
            //    roempToBeEdited["Name"] = name;
            //    roempToBeEdited["Address"] = address;
            //    da.Update(dt);
            //    Console.WriteLine("Employee details updated successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Employee is not present in database.");
            //} 
            #endregion

            #region Disconnected Architechture delete query
            //Console.WriteLine("Enter ID : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //DataRow? empToBeDeleted = dt.Rows.Find(id);
            //Console.WriteLine("Employee details deleted successfully.");
            //if (empToBeDeleted != null )
            //{
            //    empToBeDeleted.Delete();
            //    da.Update(dt);
            //}
            //else
            //{
            //    Console.WriteLine("Employee is not present in database.");
            //}
            #endregion

        }
    }
}
