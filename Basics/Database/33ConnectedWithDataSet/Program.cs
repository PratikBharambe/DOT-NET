using System.Data;
using Microsoft.Data.SqlClient;

namespace _33ConnectedWithDataSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True";

            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();

            DataColumn col1 = new DataColumn("Id", typeof(int));
            DataColumn col2 = new DataColumn("Name", typeof(string));
            DataColumn col3 = new DataColumn("Address", typeof(string));

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.PrimaryKey = new DataColumn[] { col1 };

            SqlConnection con = new SqlConnection(conStr);
            string selectQuery = "select * from Employee";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["Id"] = Convert.ToInt32(reader["Id"]);
                row["Name"] = Convert.ToString(reader["Name"]);
                row["Address"] = Convert.ToString(reader["Address"]);
                dt.Rows.Add(row);
            }

            con.Close();

            dataSet.Tables.Add(dt);
            dataSet.WriteXml(@"D:\IET\Dot NET\Basics\Database\33ConnectedWithDataSet\XML_File\EmployeeData.xml");
            Console.WriteLine("Data Insertion in XML File completed.");

        }
    }
}
