namespace _12Delegate
{

    public delegate void MyDelegate();
    public delegate void MyDelegate1(String name);
    public delegate string MyDelegate2();

    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(sayHi);
            del.Invoke();
            MyDelegate1 del1 = new MyDelegate1(sayHi);
            del1.Invoke("Pratik Bharambe");

            AnnualFunction obj = new AnnualFunction();
            MyDelegate annualDelegate = new MyDelegate(obj.func1);
            annualDelegate += obj.func2;
            annualDelegate += obj.func3; // coupling operator

            Console.WriteLine("should we Procced for celebrity : ");
            bool isProceed = Convert.ToBoolean(Console.ReadLine());
            if (isProceed)
            {
                annualDelegate -= obj.func3; //de-coupling operator
            }

            annualDelegate();

            Console.WriteLine(".............. after some time ..............");
            MyDelegate del2 = new MyDelegate(obj.func4);
            del2();

            MyDelegate2 delObj = new MyDelegate2(obj.func5);
            string msg = delObj();
            Console.WriteLine(msg);


        }

        public static void sayHi()
        {
            Console.WriteLine("Hello!");
        }
        public static void sayHi(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

    }

    public class AnnualFunction
    {
        public void func1()
        {
            Console.WriteLine("Welcome speech.");
        }
        public void func2()
        {
            Console.WriteLine("Guest speech.");
        }
        public void func3()
        {
            Console.WriteLine("Invite all for dinner party.");
        }
        public void func4()
        {
            Console.WriteLine("pack up.");
        }
        public string func5()
        {
            return "Bye! Good Night everyone.";
        }
    }

}
