
using System.Collections;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security;

namespace _28CSharpDemos
{
    internal class Program
    {

        public delegate bool MyDelegate(int number);

        #region Main method
        static void Main(string[] args)
        {

            #region Partial Classes
            //CMath cMath = new CMath();
            //Console.WriteLine($"Add : {cMath.add(10, 20)}");
            //Console.WriteLine($"Add : {cMath.sub(10, 20)}");
            //cMath.sayHii();
            #endregion

            #region Nullable Types
            ////int i = 10;
            ////Nullable<int> i = null; // Old syntax for declaring nullable objects
            //int? i = null; // new syntax for declaring nullable object
            //// we declare '?' after datatype to declare it as nullable as per new syntax
            //if (i.HasValue)
            //{
            //    Console.WriteLine($"The value of i is {i}");
            //}
            //else
            //{
            //    Console.WriteLine("The value of i is null");
            //}

            //if (i == null)
            //{
            //    Console.WriteLine("The value of i is null");
            //}

            //Emp emp = new Emp();   
            //emp.Id = 1;
            //emp.Name = "Pratik";
            //emp.Dept = "Information Technology";
            //emp.Sal = null;
            ////emp.Sal = 2300.12;
            //Console.WriteLine($"Employee details ------ \nId : {emp.Id}, \nName : {emp.Name}, \nDepartment : {emp.Dept}, \nSalary : {emp.Sal}.");
            #endregion

            #region Anonymous method

            #region Normal Way of calling a normal method
            // Mornal way of calling a noraml method
            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool result = check(num);
            //if (result)
            //{
            //    Console.WriteLine($"{num} is greater that 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is less that 10");
            //} 
            #endregion

            #region Calling method using delegate
            // Calling normal method using delegate
            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //MyDelegate del = new MyDelegate(check);
            //bool result = del(num);
            //if (result)
            //{
            //    Console.WriteLine($"{num} is greater that 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is less that 10");
            //}
            #endregion

            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //// This is method without name - Anonymous method
            //// Caled by using delegate
            //MyDelegate del = delegate (int i)
            //{
            //    return i > 10;
            //};
            //bool result = del(num);
            //if (result)
            //{
            //    Console.WriteLine($"{num} is greater that 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is less that 10");
            //}

            #endregion

            #region Lambda Expression
            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //// This is method without name - Anonymous method
            //// Caled by using delegate
            ////MyDelegate del = (i) =>
            ////{
            ////    return i > 10;
            ////};
            ////MyDelegate del = (i) => { return i > 10; };
            //MyDelegate del = i => i > 10;
            //bool result = del(num);
            //if (result)
            //{
            //    Console.WriteLine($"{num} is greater that 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is less that 10");
            //} 
            #endregion

            #region Predicate Delegate
            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //// Predicate deleate generic whose return type id boolean
            //Predicate<int> del = i => i > 10;
            //bool result = del(num);
            //if (result)
            //{
            //    Console.WriteLine($"{num} is greater that 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is less that 10");
            //} 
            #endregion

            #region Iterator

            ////int[] numbers = new int[3];
            //ArrayList arr = new ArrayList();
            ////foreach (var item in arr)
            ////{

            ////}

            // using weeks class for tesing iterator
            //Weeks weeks = new Weeks();
            //foreach (string day in weeks)
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Implicit Type

            //int i = 52;
            //var kp; // we have to give defination at the time of declartion otherwise it will thorw ans error
            //var kp = 46; // definatio of var i.e implicite type
            //Console.WriteLine(kp.GetType().ToString());

            //Emp v = new Emp();
            //var v1 = new Emp();
            ////var? v2 = 201.5285; // we cannot make implicit type as nullable
            ////Nullable<var> i = null;

            //Console.WriteLine("Enter a number : ");
            //var choice = Convert.ToInt32(Console.ReadLine());
            //var result = GetMeSomething(choice);
            //if (result is int)
            //    Console.WriteLine($"The result is of type {result.GetType().ToString()}");
            //if (result is Emp)
            //    Console.WriteLine($"The result is of type {result.GetType().ToString()}");

            #endregion

            #region Object Initializer

            #region Constructor Overloading
            //Customer c1 = new Customer();
            //Console.WriteLine($"Id {c1.Id}, Name : {c1.Name}, Address : {c1.Address}");
            //Customer c2 = new Customer(2, "Lalit Kamble");
            //Console.WriteLine($"Id {c1.Id}, Name : {c1.Name}, Address : {c2.Address}");
            //Customer c3 = new Customer("Lalit kamble", "Pune");
            //Console.WriteLine($"Id {c3.Id}, Name : {c3.Name}, Address : {c3.Address}"); 
            #endregion

            //Customer c1 = new Customer() { Id = 1, Name = "Sura", Address = "Kund Khurd" };
            //Console.WriteLine($"Id {c1.Id}, Name : {c1.Name}, Address : {c1.Address}");
            //Customer c2 = new Customer() { Name = "Lalit", Address = "Pune" };
            //Console.WriteLine($"Id {c2.Id}, Name : {c2.Name}, Address : {c2.Address}");
            //Customer c3 = new Customer() { Id = 3, Name = "Vaishu", Address = "parbhani" };
            //Console.WriteLine($"Id {c3.Id}, Name : {c3.Name}, Address : {c3.Address}");

            #endregion

            #region Auto - Properties
            //Student s1 = new Student();
            //s1.Id = 1;
            //s1.Name = "Pratik";
            //s1.Address = "KKD";
            //Console.WriteLine($"Id {s1.Id}, Name : {s1.Name}, Address : {s1.Address}");
            #endregion

            #region Anonymous Type
            //var v1 = new { Id = 12, Name = "Sura" };
            //Console.WriteLine($"ID : {v1.Id}, Name : {v1.Name}");
            //Console.WriteLine(v1.GetType().ToString());
            #endregion

            #region Extension Methods

            //MyClass mc = new MyClass();
            string str = "ab@cd.com";
            //bool result = mc.checkForValidEmail(str);
            bool result = str.checkForValidEmail();
            if (result)
            {
                Console.WriteLine("Email Validation Successfully.");
            }
            else
            {
                Console.WriteLine("Please check email id given.");
            }

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            List<int> list = arr.MapToList();
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }

            #endregion

        }
        #endregion

        #region GetMeSomething method defination for testing Imlicite type
        public static object GetMeSomething(int choice)
        {
            if (choice > 10)
            {
                return choice * 10;
            }
            else
            {
                return new Emp();
            }
        } 
        #endregion

        #region Check Method for testing anonymous method
        //public static bool check(int i)
        //{
        //    return i > 10;
        //} 
        #endregion

    }

    #region MyClass Defination
    // class for testing extension methods
    public static class MyClass
    {
        public static bool checkForValidEmail(this string str)
        {
            return (str.Contains("@")) ? true : false;
        }

        public static List<int> MapToList(this int[] arr)
        {
            Console.WriteLine("Inside MapToList function.");
            return arr.ToList();
        }
    } 
    #endregion

    #region Student Class Defination
    // Student class for testing auto properties
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    } 
    #endregion

    #region Customer class defination
    // class for testing object initializer
    public class Customer
    {
        private int _Id;
        private string _Name;
        private string _Address;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        #region Constructor Overloading
        //public Customer()
        //{
        //    this.Id = 1;
        //    this.Name = "Pratik Bharambe";
        //    this.Address = "Pune";
        //}

        //public Customer(int Id, string Name)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //}

        //public Customer(string Name, string Address)
        //{
        //    this.Name = Name;
        //    this.Address = Address;
        //} 
        #endregion

    } 
    #endregion

    #region Weeks class Defination
    // class for testing Iterator
    public class Weeks : IEnumerable
    {
        private string[] days = new string[] 
        { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                string day = days[i];
                yield return day; // yield keyword maintains last index value
            }
        }
    } 
    #endregion

    #region Emp class defination
    // Class for testing nullable types
    public class Emp
    {
        private int _Id;
        private string _Name;
        private string _Dept;
        private double? _Sal;

        // To make an property of class as nullable we need to make
        // nullable the variable as well as the property as nullable as shown 

        public double? Sal
        {
            get { return _Sal; }
            set { _Sal = value; }
        }


        public string Dept
        {
            get { return _Dept; }
            set { _Dept = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

    }
    #endregion

}
