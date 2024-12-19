namespace _12Delegate


{

    public delegate void MyDelegate();
    public delegate void MyDelegate1(string str);
    public delegate String MyDelegate2();
    internal class Program
    {
        static void Main(string[] args)
        {
            AnnualFunction obj = new AnnualFunction();
            //dek is a multicast delegate
            MyDelegate del = new MyDelegate(obj.Func1);
            del += obj.Func2; // coupling operator
            del += obj.Func3;
            del += obj.Func4;
            Console.WriteLine("Should We Proceed For Celebrity--");
            bool isProceed = Convert.ToBoolean(Console.ReadLine());
            if (isProceed) {
                del -= obj.Func3; //decoupling operator
            }

            del();
            Console.WriteLine("---after sometime---");
            MyDelegate del2 = new MyDelegate(obj.Func4);
            del2();

            MyDelegate2 delObj = new MyDelegate2(obj.Func5);
            string msg = delObj();
            Console.WriteLine(msg);

        }
        public static void SayHi()
        {
            Console.WriteLine("Hello!");
        }
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }

    public class AnnualFunction
    {
        public void Func1()
        {
            Console.WriteLine("Wel-come Speech");
        }

        public void Func2()
        {
            Console.WriteLine("Guest Speech");

        }

        public void Func3()
        {
            Console.WriteLine("Invite all for dinner");
        }

        public void Func4()
        {
            Console.WriteLine("Pack up..!");
        }

        public String Func5()
        {
            return "Bye Bye Goodnight Everyone.";
        }
    }
}
