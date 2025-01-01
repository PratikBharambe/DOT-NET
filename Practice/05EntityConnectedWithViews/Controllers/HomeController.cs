using _05EntityConnectedWithViews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace _05EntityConnectedWithViews.Controllers
{
    public class HomeController : Controller
    {

        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True";
        public IActionResult Index()
        {
            List<Emp> emps = new List<Emp>();
            SqlConnection con = new SqlConnection(constr);
            string query = "select * from Emp";
            SqlCommand cmd = new SqlCommand(query, con);    
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Emp emp = new Emp();
                emp.Id = Convert.ToInt32(reader["Id"]);
                emp.Name = reader["Name"].ToString();
                emp.Address = reader["Address"].ToString();
                emps.Add(emp);
            }
            return View(emps);
        }
    }
}
