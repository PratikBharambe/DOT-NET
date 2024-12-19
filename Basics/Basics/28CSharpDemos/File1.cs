using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28CSharpDemos
{

    public class AdvMath
    {
        public void sayHii()
        {
            Console.WriteLine("Hello World");
        }
    }
    public partial class CMath : AdvMath
    {
        public int add(int x, int y)
        {
            return x + y;
        }

    }
}
