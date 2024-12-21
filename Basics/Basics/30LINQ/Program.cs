namespace _30LINQ
{

    public delegate bool MyDelegate(Emp emp, String str);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Employee data list collection
            List<Emp> employees = new List<Emp>() {
                new Emp(){Id = 11, Name="Ganesh", Address="Pune"},
                new Emp(){Id = 12, Name="Gajanan", Address="Punjab"},
                new Emp(){Id = 13, Name="Divyansh", Address="Mumbai"},
                new Emp(){Id = 14, Name="Anup", Address="Pune"},
                new Emp(){Id = 15, Name="Deepali", Address="Patna"},
                new Emp(){Id = 16, Name="Aman", Address="Mumbai"},
                new Emp(){Id = 17, Name="Gunjan", Address="Pune"},
                new Emp(){Id = 18, Name="Abhiraj", Address="Indore"},
                new Emp(){Id = 19, Name="Aishwarya", Address="Kolhapur"}
            }; 
            #endregion

            #region MyWhere method with MyDlegate function Pointer
            //MyDelegate pointer = new MyDelegate(ConditionalCheck);
            //var filteredCollection = myWhere(employees, pointer);
            //foreach (Emp emp in filteredCollection)
            //{
            //    Console.WriteLine($"{emp.Id}, {emp.Name}, {emp.Address}");
            //} 
            #endregion

            #region Action Delegate
            //Action<int, int> action = (x, y) => Console.WriteLine(x + y);
            //action(10, 25); 
            #endregion

            #region FUNC Delegate
            //Func<int, int, int> func = (x, y) => x * y;
            //int multi = func(5, 8);
            //Console.WriteLine($"Multiplication is : {multi.ToString()}");
            #endregion
        }

        #region myWhere Mehthod Defination
        public static List<Emp> myWhere(IEnumerable<Emp> empList, MyDelegate pointer)
        {
            Console.WriteLine("Enter the name of the city : ");
            string city = Console.ReadLine();

            List<Emp> filteredCollection = new List<Emp>();
            foreach (Emp emp in empList)
            {
                if (pointer(emp, city))
                {
                    filteredCollection.Add(emp);
                }
            }
            return filteredCollection;
        }
        #endregion

        #region ConditionalCheck Method Defination
        public static bool ConditionalCheck(Emp emp, string city)
        {
            return (emp.Address.ToLower() == city.ToLower()) ? true : false;
        } 
        #endregion

    }

    #region Emp class Defination
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    } 
    #endregion

}
