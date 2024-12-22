
using System.Net.WebSockets;
using _31ConnectedArchitectureDatabase.DAL;
using _31ConnectedArchitectureDatabase.Model;

namespace _31ConnectedArchitectureDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region CRUD Application with Console.WriteLine

            //string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True";

            #region select Query
            //SqlConnection con = new SqlConnection(conStr);
            //string selectQuery = "select * from Employee";
            //SqlCommand cmd = new SqlCommand(selectQuery, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader["ID"]);
            //    string? name = Convert.ToString(reader["Name"]);
            //    string? address = Convert.ToString(reader["Address"]);
            //    Console.WriteLine($"ID : {id}, Name : {name}, Address : {address}");
            //}
            //con.Close();
            #endregion

            #region Insert Query
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Name : ");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter Address : ");
            //string add = Console.ReadLine();
            //string insertQuery = $"insert into Employee values('{nm}', '{add}')";
            //SqlCommand cmd = new SqlCommand(insertQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if(n > 0)
            //    Console.WriteLine("Data inserted successfully.");
            //else
            //    Console.WriteLine("Data not inserted.");
            //con.Close(); 
            #endregion

            #region Update Query
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter id : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Name : ");
            //string? nm = Console.ReadLine();
            //Console.WriteLine("Enter Address : ");
            //string? add = Console.ReadLine();
            //string updateQuery = $"update Employee set Name = '{nm}', Address = '{add}' where Id = {id}";
            //SqlCommand cmd = new SqlCommand(updateQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //    Console.WriteLine("Data updated successfully.");
            //else
            //    Console.WriteLine("Data not updated.");
            //con.Close(); 
            #endregion

            #region Delete Query
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter id : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //string deleteQuery = $"delete from Employee where Id = {id}";
            //SqlCommand cmd = new SqlCommand(deleteQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //    Console.WriteLine("Data deleted successfully.");
            //else
            //    Console.WriteLine("Data not deleted.");
            //con.Close(); 
            #endregion

            #endregion

            #region CRUD Application with DAL Layer
            int choice = 0;
            TestDbContext testDbContext = new TestDbContext();

            do
            {
                Console.WriteLine("1. Get all employees details.");
                Console.WriteLine("2. Get employee details by id.");
                Console.WriteLine("3. Add new employee.");
                Console.WriteLine("4. Update employee details.");
                Console.WriteLine("5. Delete employee.");
                Console.WriteLine("6. Exit.");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    // case 01 to get all employess details
                    case 1:
                        List<Employee> empList = testDbContext.getAllEmployees();
                        if (empList != null)
                            empList.ForEach(emp => Console.WriteLine($"ID : {emp.id}, Name : {emp.name}, Address : {emp.address}"));
                        else
                            Console.WriteLine("Employee Table is empty.");
                        break;

                    // case 02 to get details of employee by it's id
                    case 2:
                        Console.WriteLine("Enter id of the employee : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee emp = testDbContext.getEmployeeById(id);
                        if (emp != null)
                            Console.WriteLine($"ID : {emp.id}, Name : {emp.name}, Address : {emp.address}");
                        else
                            Console.WriteLine("Employee Details are not present.");
                        break;

                    // case 3 to insert new employeww details
                    case 3:
                        Console.WriteLine("Enter name of Employee : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter address of Employee : ");
                        string address = Console.ReadLine();
                        emp = new Employee() { name = name, address = address };
                        bool status = testDbContext.InsertNewEmployee(emp);
                        if (status)
                            Console.WriteLine("Employee deatils inserted successfully.");
                        else
                            Console.WriteLine("Employee details not inserted.");
                        break;

                    // case 4 to update employeww details
                    case 4:
                        Console.WriteLine("Enter id of the employee : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new name of Employee : ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter new address of Employee : ");
                        address = Console.ReadLine();
                        emp = new Employee() { id = id, name = name, address = address };
                        status = testDbContext.updateEmployee(emp);
                        if (status)
                            Console.WriteLine("Employee deatils updated successfully.");
                        else
                            Console.WriteLine("Employee details not updated.");
                        break;

                    // case 5 to delete employeww details
                    case 5:
                        Console.WriteLine("Enter id of the employee : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        status = testDbContext.deleteEmployee(id);
                        if (status)
                            Console.WriteLine("Employee deatils deleted successfully.");
                        else
                            Console.WriteLine("Employee details not deleted.");
                        break;

                    // case 6 to terminate execution
                    case 6:
                        Console.WriteLine("Thanks for visting .............\nBye Bye");
                        break;

                    // default case to handle invalid choice entered by user
                    default:
                        Console.WriteLine("Invalid choice !!!");
                        break;
                }
            }
            while (choice != 6); 
            #endregion
        }
    }
}
