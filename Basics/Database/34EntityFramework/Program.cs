using _34EntityFramework.DAL;
using _34EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace _34EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDbContext testDbContext = new TestDbContext();
            int choice = 0;
            do
            {
                Console.WriteLine("1. Get all employee details.");
                Console.WriteLine("2. Add new employee.");
                Console.WriteLine("3. Update emplyee deatls.");
                Console.WriteLine("4. Delete employee.");
                Console.WriteLine("5. Get employee by id by calling stored procedure.");
                Console.WriteLine("6. Get employee details who's address starts with character.");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        var allEmployees = testDbContext.Employees.ToList();
                        if (allEmployees.Count > 0)
                        {
                            allEmployees.ForEach(emp => Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address}"));
                        }
                        else
                        {
                            Console.WriteLine("Data is not present in table.");
                        }
                        break;

                    case 2:
                        Employee empRecordToBeInserted = new Employee();
                        Console.WriteLine("Enter Name:");
                        empRecordToBeInserted.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empRecordToBeInserted.Address = Console.ReadLine();

                        testDbContext.Employees.Add(empRecordToBeInserted);
                        int n = testDbContext.SaveChanges();
                        if (n > 0)
                        {
                            Console.WriteLine("Employee added Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error in employee insertion.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Employee? empRecordToBeUpdated = testDbContext.Employees.Find(id);
                        if (empRecordToBeUpdated != null)
                        {
                            Console.WriteLine("Enter Name:");
                            empRecordToBeUpdated.Name = Console.ReadLine();
                            Console.WriteLine("Enter Address:");
                            empRecordToBeUpdated.Address = Console.ReadLine();
                            n = testDbContext.SaveChanges();
                            if (n > 0)
                            {
                                Console.WriteLine("Employee updated Successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Error in employee updation.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Employee not found with id : {0}", id);
                        }

                        break;

                    case 4:
                        Console.WriteLine("Enter Id");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Employee? empToBeDeleted = testDbContext.Employees.Find(id1);
                        if (empToBeDeleted != null)
                        {
                            testDbContext.Employees.Remove(empToBeDeleted);
                            n = testDbContext.SaveChanges();
                            if (n > 0)
                            {
                                Console.WriteLine("Employee deleted Successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Error in employee deletion.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Employee not found with id : {0}", id1);
                        }
                        break;

                    case 5:
                        Console.WriteLine("Enter employee id : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Employee emp = testDbContext.GetEmployeeById(id);
                        if (emp != null)
                        {
                            Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address}");
                        }
                        else
                        {
                            Console.WriteLine($"Employee with {id} is not preset.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Enter the first letter of address of employees : ");
                        string? firstLetter = Console.ReadLine();
                        if (firstLetter != null)
                        {
                            List<Employee> empList = testDbContext.GetEmployeesByAddressStartsWith(firstLetter);
                            if(empList != null)
                            {
                                empList.ForEach(emp => Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address}"));
                            }else
                            {
                                Console.WriteLine($"There is no employee who's address starts with '{firstLetter}'");
                            }
                        }else
                        {
                            Console.WriteLine("Please enter first letter.");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Thanks for visiting ..............\nBye Bye");
                        break;

                    default:
                        Console.WriteLine("Invalid choice !!!!!");
                        break;
                }
            }
            while (choice != 7);
        }
    }
}
