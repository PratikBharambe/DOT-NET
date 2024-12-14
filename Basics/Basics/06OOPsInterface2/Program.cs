namespace _06OOPsInterface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Normal Flow
            //CMath cMath = new CMath();
            //cMath.Add(3, 7);
            //cMath.Multi(3, 7);
            //cMath.Sub(3, 7); 
            #endregion

            IX ix = new CMath();
            ix.Add(21, 3);
            ix.Sub(21, 3);

            IY iy = new CMath();
            iy.Add(21, 3);
            iy.Multi(21, 3);
        }
    }

    public interface IX
    {
        void Add(int x, int y);
        void Sub(int x, int y);
    }
    public interface IY
    {
        void Add(int x, int y);
        void Multi(int x, int y);
    }

    public class CMath : IX, IY
    {
        void IX.Add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Addition is : " + result.ToString());
        }

        void IY.Add(int x, int y)
        {
            int result = x + y + 100;
            Console.WriteLine("Addition is : " + result.ToString());
        }

        void IY.Multi(int x, int y)
        {
            int result = x * y * 2;
            Console.WriteLine("Multiplication is : " + result.ToString());
        }

        void IX.Sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Substraction is : " + result.ToString());
        }
    }

    #region Implicit Way for overriding
    //public class CMath : IX, IY
    //{
    //    public void Add(int x, int y)
    //    {
    //        int result = x + y;
    //        Console.WriteLine("Addition is : " + result.ToString());
    //    }

    //    public void Multi(int x, int y)
    //    {
    //        int result = x * y;
    //        Console.WriteLine("Multiplication is : " + result.ToString());
    //    }

    //    public void Sub(int x, int y)
    //    {
    //        int result = x - y;
    //        Console.WriteLine("Substraction is : " + result.ToString());
    //    }
    //} 
    #endregion


}
