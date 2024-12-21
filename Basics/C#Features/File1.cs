using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Features
{
    public class superBase
    {
        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }
    public partial class CMath : superBase
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
