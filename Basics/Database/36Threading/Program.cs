using System.Diagnostics;

namespace _36Threading
{
    internal class Program
    {

        #region Time taken One By One
        // Time taken = 33474719
        // Time taken = 1770055
        // Time taken = 263063
        // Time taken = 264759
        // Time taken = 254424
        // Time taken = 530133 
        #endregion
        static void Main(string[] args)
        {
            #region Normal Method Call
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    DoSometing();
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"Time taken = {stopwatch.ElapsedTicks}"); 
            #endregion

            #region Thread
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread t1 = new Thread(new ThreadStart(DoSometing));
            //    t1.Start();
            //    Console.WriteLine($"Current thread Id : {t1.ManagedThreadId}");
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"Time taken = {stopwatch.ElapsedTicks}"); 
            #endregion

            #region Explicit Parallel Programming - Multiple Tasks
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Task t1 = new Task(new Action(DoSometing));
            //    t1.Start();
            //    Console.WriteLine($"Current thread ID : {t1.Id.ToString()}");
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"Time taken = {stopwatch.ElapsedTicks}"); 
            #endregion

            #region Parallel.Foreach - Implicit Parallel Prog.
            //// Time taken = 264759
            //Stopwatch stopwatch = new Stopwatch();
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //stopwatch.Start();
            //Parallel.ForEach(arr, (number) =>
            //{
            //    Console.WriteLine($"Number : {number}, Task Id : {Task.CurrentId}, Thread id : {Thread.CurrentThread.ManagedThreadId}");
            //});
            //stopwatch.Stop();
            //Console.WriteLine($"Time taken = {stopwatch.ElapsedTicks}"); 
            #endregion

            #region MaxDegreeOfParallelism
            //// Time taken = 254424
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };
            //Parallel.ForEach(arr, options, (number) =>
            //{
            //    Console.WriteLine($"Number : {number}, Task Id: {Task.CurrentId}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //}); 
            //watch.Stop();
            //Console.WriteLine($"Time taken = {watch.ElapsedTicks}");
            #endregion

            #region Exception Handling Using Parrllel.Foreach 
            //// Time taken = 530133
            //Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //try
            //{
            //    Parallel.ForEach(numbers, number =>
            //    {
            //        Console.WriteLine($"Number = {number}, Task Id: {Task.CurrentId}");
            //        if (number == 3)
            //            throw new Exception("Simulated Exception");

            //    });
            //}
            //catch (AggregateException ex)
            //{
            //    foreach (var innerExp in ex.InnerExceptions)
            //    {
            //        {
            //            Console.WriteLine($"Exception : {innerExp.Message} ");
            //        }
            //    }
            //    Console.WriteLine("Parallel Foreach with exception Handling is complete");
            //}
            //sw.Stop();
            //Console.WriteLine($"Time taken = {sw.ElapsedTicks}"); 
            #endregion

            #region LINQ Parallel
            //// Time taken = 934092
            //Stopwatch sw = Stopwatch.StartNew();
            //List<Emp> allEmployees = new List<Emp>() {
            // new Emp(){ ID =11,Name ="Jignesh", Address ="Patna"},
            // new Emp(){ ID =12,Name ="Prathamesh", Address ="Nashik"},
            // new Emp(){ ID =13,Name ="Devendra", Address ="Nagpur"},
            // new Emp(){ ID =14,Name ="Kalpesh", Address ="Kerla"},
            // new Emp(){ ID =15,Name ="kushendra", Address ="Indore"}
            //};

            //sw.Start();
            //var result = (from emp in allEmployees.AsParallel()
            //              where emp.Address.StartsWith("N")
            //              select emp).ToList();
            //sw.Stop();
            //foreach (var emp in result)
            //{
            //    Console.WriteLine($"Name: {emp.Name}, Address: {emp.Address}");
            //}
            //Console.WriteLine($"Time taken = {sw.ElapsedTicks}"); 
            #endregion

            #region Task, Async, Await 
            //Console.WriteLine("Fetching Data....");
            //var result = FetchDataAsync().GetAwaiter().GetResult();
            //Console.WriteLine($"Data Fetched : {result}");
            #endregion

        }

        public static async Task<string> FetchDataAsync()
        {
            await Task.Delay(2000);
            return "Hello EveryOne!!!";
        }

        public class Emp
        {
            public int ID { get; set; }
            public string? Name { get; set; }
            public string? Address { get; set; }
        }

        public static void DoSometing()
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    // Does nothing ..........
                }
            }
        }

    }
}
