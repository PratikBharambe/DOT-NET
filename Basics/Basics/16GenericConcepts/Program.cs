using System.Diagnostics.CodeAnalysis;

namespace GenericConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Swap 
            cMath obj = new cMath();
            string s1 = "Mrunal";
            string s2 = "Yash";
            Console.WriteLine("Before swap:{0} and {1}", s1, s2);
            obj.swap<String>(ref s1, ref s2);
            Console.WriteLine("After swap:{0} and {1}", s1, s2);

            Demo1<int> obj1 = new Demo1<int>();
            int num1 = 21;
            int num2 = 28;
            Console.WriteLine("Before swap:{0} and {1}", num1, num2);
            obj1.swap1(ref num1, ref num2);
            Console.WriteLine("After swap:{0} and {1}", num1, num2);
            #endregion

            #region Dynamic type
            int sum, prod;
            Demo1<int> obj2 = new Demo1<int>();
            obj2.Calculate(12, 12, out sum, out prod);
            //string literals
            Console.WriteLine($"Sum: {sum} ,Product: {prod}");
            #endregion


            #region Multiple parameter generics
            Test<int, string, double, bool> TestObj = new Test<int, string, double, bool>();
            double d = TestObj.Display(100, "Parameters: ", 23.333, true);
            Console.WriteLine("T3 is holding value : {0}", d); 
            #endregion
        }
    }

    public class Test<T1, T2, T3, T4>
    {
        public T3 Display(T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return p3;
        }
    }

    public class cMath
    {
        //generic method in non generic class
        public void swap<T>(ref T x,ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
    public class Demo1<T>
    {
        //generic class and generic method
        public void swap1(ref T x,ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        public void Calculate(T x,T y, out T Sum, out T Product)
        {
            //At runtime by CLR
            dynamic para1 = x;
            dynamic para2 = y;

            Sum=para1 + para2;
            Product=para1 * para2;
        }

    }

}
