namespace _28CSharpDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cMath = new CMath();
            Console.WriteLine($"Add : {cMath.add(10, 20)}");
            Console.WriteLine($"Add : {cMath.sub(10, 20)}");
            cMath.sayHii();
        }
    }
}
