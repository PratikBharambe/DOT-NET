using System.ComponentModel.DataAnnotations;

namespace _29LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List of employees
            List<Emp> employees = new List<Emp>() {
            new Emp() { Id = 1, Name = "Ganesh", Address = "Pune" },
            new Emp() { Id = 2, Name = "Gajanan", Address = "Punjab" },
            new Emp() { Id = 3, Name = "Divyansh", Address = "Mumbai" },
            new Emp() { Id = 4, Name = "Anup", Address = "Pune" },
            new Emp() { Id = 5, Name = "Deepali", Address = "Patna" },
            new Emp() { Id = 6, Name = "Aman", Address = "Manipur" },
            new Emp() { Id = 7, Name = "Gunjan", Address = "Pune" },
            new Emp() { Id = 8, Name = "Abhiraj", Address = "Indor" },
            new Emp() { Id = 9, Name = "Aishwarya", Address = "Kolhapur" },
            };
            #endregion

            #region Normal condition base filteration on List Collection
            //Console.WriteLine("Enter name of the city : ");
            //string? city = Console.ReadLine();

            //var filteredCollection = new List<Emp>();
            //foreach (var emp in employees)
            //{
            //    if (emp.Address.ToLower() == city.ToLower())
            //        filteredCollection.Add(emp);
            //}
            //foreach (var emp in filteredCollection)
            //{
            //    Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address}");
            //}  
            #endregion

            #region Normal LINQ Query
            //Console.WriteLine("Enter name of the city : ");
            //string? city = Console.ReadLine();

            ////var filteredCollection = (from emp in employees
            ////                          select emp);
            //var filteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp);
            //foreach (var emp in filteredCollection)
            //{
            //    Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address}");
            //} 
            #endregion

            #region Using LINQ Filteration
            //Console.WriteLine("Enter name of the city : ");
            //string? city = Console.ReadLine();

            ////var filteredCollection = (from emp in employees
            ////                          select emp);
            ////var filteredCollection = (from emp in employees
            ////                          where emp.Address.ToLower() == city.ToLower()
            ////                          select emp);
            //var filteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp).ToList(); // here tolist method will fire the query

            //employees.Add(new Emp()
            //{
            //    Id = 10,
            //    Name = "hello",
            //    Address = "Pune"
            //});
            //employees.Add(new Emp()
            //{
            //    Id = 11,
            //    Name = "world",
            //    Address = "mumbai"
            //});

            //foreach (var emp in filteredCollection)
            //{
            //    Console.WriteLine($"Id : {emp.Id}, Name : {emp.Name}, Address : {emp.Address}");
            //} 
            #endregion

            #region LINQ filetration based on city and name of Emp
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp.Name).ToList();


            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Filtered collection based on {0} city: \n", city);
            //foreach (var name in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //    Console.WriteLine($"Name = {name}");
            //}
            ////foreach (Emp emp in FilteredCollection)
            ////{
            ////    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            ////    Console.WriteLine($"Name = {emp.Name}, Address = {emp.Address}");
            ////} 
            #endregion

            #region LINQ filteration based on multiple return values using Holder class
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select new Holder()
            //                          { HName = emp.Name, HAddress = emp.Address })
            //                          .ToList();

            //Console.WriteLine("Filtered collection based on {0} city: \n", city);
            //foreach (Holder obj in FilteredCollection)
            //{
            //    Console.WriteLine($"Name = {obj.HName}, Address = {obj.HAddress}");
            //} 
            #endregion

            #region LINQ filteration based on Anonymous Type
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select new { nm = emp.Name, add = emp.Address })
            //                          .ToList();

            //foreach (var obj in FilteredCollection)
            //{
            //    Console.WriteLine($"Name = {obj.nm}, Address = {obj.add}");
            //} 
            #endregion

        }
    }

    #region Holder class Defination
    public class Holder
    {
        public int HId { get; set; }
        public string HName { get; set; }
        public string HAddress { get; set; }
    } 
    #endregion

    #region Employee class defination
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    #endregion

}
