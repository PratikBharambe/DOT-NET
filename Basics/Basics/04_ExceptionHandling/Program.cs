namespace _04_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number:");
                int x = Convert.ToInt32(Console.ReadLine());
          
                Console.WriteLine("Enter second number:");
                int y = Convert.ToInt32(Console.ReadLine());

                int result = x / y;
                Console.WriteLine("Div  = " + result.ToString());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block...");
            }

        }
    }
}
