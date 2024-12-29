using _13ConnectedMVC.Models;
using Microsoft.Data.SqlClient;

namespace _13ConnectedMVC.DAL
{
    public class TestDbContext
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True";

        public List<Emp> GetAllEMployees()
        {
            List<Emp> empList = new List<Emp>();
            SqlConnection con = new SqlConnection(constr);
            string selectQuery = "select * from Employee";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Emp emp = new Emp();
                emp.Id = Convert.ToInt32(reader["id"]);
                emp.Name = Convert.ToString(reader["Name"]);
                emp.Address = Convert.ToString(reader["Address"]);
                empList.Add(emp);
            }
            return empList;
        }

    }
}
