﻿using _34EntityFramework.DAL;
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
                Console.WriteLine("1. Select");
                Console.WriteLine("2. Insert");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
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
                        Console.WriteLine("Thanks for visiting ..............\nBye Bye");
                        break;

                    default:
                        Console.WriteLine("Invalid choice !!!!!");
                        break;
                }
            }
            while (choice != 5);
        }
    }
}
