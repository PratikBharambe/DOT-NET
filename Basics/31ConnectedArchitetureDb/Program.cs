using _31ConnectedArchitetureDb.DAL;
using _31ConnectedArchitetureDb.Model;
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

            #region CRUD Application with DAL Layer
            int choice = 0;
            DatabaseDbContext databaseDbContext = new DatabaseDbContext();

            do
            {
                Console.WriteLine("1. Get All Employees Details.");
                Console.WriteLine("2. Get Employees Details By ID.");
                Console.WriteLine("3. Add New Employee Details.");
                Console.WriteLine("4. Update Empolyee Details.");
                Console.WriteLine("5. Delete Empolyee Details.");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 

                {
                    //case1 to get all employees details
                    case 1:
                        List<Employee> emplist = databaseDbContext.getAllEmployee();
                        if(emplist != null)
                        emplist.ForEach(emp => Console.WriteLine($"ID : {emp.Id}, Name : {emp.Name}, Address : {emp.Address}"));
                        else
                            Console.WriteLine("Employee table is empty");
                        break;

                    //case2 to get employee details by id
                    case 2:
                        Console.WriteLine("Enter id of the employee");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee emp = databaseDbContext.getEmployeeById(id);
                        if(emp != null)
                        {
                            Console.WriteLine($"ID : {emp.Id}, Name : {emp.Name}, Address : {emp.Address}");
                        }
                           

                        break;

                    //case3
                    case 3:

                        break;

                    //case4
                    case 4:

                        break;

                    //case5
                    case 5:

                        break;

                    //case 6 to terminate  execution
                    case 6:
                        Console.WriteLine("Thanks for Visiting...! \n Bye Bye");
                        break;

                    //default case to handel invalid choice entered by user
                    default:
                        Console.WriteLine("Invalid choice !!!!!");
                        break;
                        }

            }
            while (choice != 6);
            #endregion

        }
    }
}
