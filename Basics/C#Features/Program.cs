using Microsoft.VisualBasic;

namespace C_Features
{
    public delegate bool MyDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial classes

            //CMath obj = new CMath();
            //Console.WriteLine($"Add={obj.Add(10, 20)}");
            //Console.WriteLine($"sub={obj.sub(10, 20)}");
            //obj.sayHi(); 
            #endregion

            #region Nullable Type
            ////int? i = null; //Nullable Syntax
            ////int? i = 10;
            //Nullable<int> i = 10;
            //if (i.HasValue)
            //{

            //    Console.WriteLine($"value of i = {i}");
            //}
            //else
            //{
            //    Console.WriteLine("value of i is null.!");
            //}

            //if (i == null)
            //{
            //    Console.WriteLine("value of i = null");
            //}

            //Emp obj = new Emp();
            //obj.Id = 3;
            //obj.Name = "Rohan";
            //obj.sal = null;
            //obj.Dept = "IT"; 
            #endregion

            #region Anonymous Methods
            ////Normal Call To Method
            //Console.WriteLine("Enter a Number : ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //bool result = Check(input);
            //Console.WriteLine($"{input} is greater than 10 = {result}");

            ////Calling a method usinf Delegate
            //Console.WriteLine("Enter a Number : ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //MyDelegate del = new MyDelegate(Check);
            //bool result = del(input);
            //Console.WriteLine($"{input} is greater than 10= {result}");

            ////This Method is without Name  - Anonymous Method
            //Console.WriteLine("Enter a Number : ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //MyDelegate del = delegate (int i)
            //{
            //    return i > 10;
            //};
            //bool result = del(input);
            //Console.WriteLine($"{input} is greater than 10= {result}"); 
            #endregion

            #region Lambada Expression 
            //Console.WriteLine("Enter a value ");
            //int input = Convert.ToInt32(Console.ReadLine());
            ////MyDelegate del = (i)=>
            ////                    {
            ////                        return i > 10;
            ////                    };

            ////MyDelegate del = (i) => { return i > 10;};
            //MyDelegate del = i => i > 10;

            //bool result = del(input);
            //Console.WriteLine($" {input} is greater than 10 = {result}");
            #endregion





        }



        public static bool Check (int i) 
            {
            return i > 10;
            }
        public class Emp
        {


            private int _Id;
            private string _Name;
            private string _Dept;
            //private double _Sal;    
            private Nullable<double> _Sal;

            public double? sal
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
    }
}