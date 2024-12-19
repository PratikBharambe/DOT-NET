namespace _17MyLib01

{
    public class Demo
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Addition = {0}", x + y);
        }
        private void Sub(int x, int y)
        {
            Console.WriteLine("Substraction = {0}", x - y);
        }
        protected void Mult(int x, int y)
        {
            Console.WriteLine("Multiplication = {0}", x * y);
        }
        protected internal void Div(int x, int y)
        {
            Console.WriteLine("Division = {0}", x / y);
        }
        internal void square(int x, int y)
        {
            Console.WriteLine("Square ={0}", x * x);
        }

    }
}

