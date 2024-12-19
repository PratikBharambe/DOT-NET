
using MyLib;

namespace HostApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoLib dobj= new DemoLib();
            dobj.Add(12, 12);
            CheckClass cobj= new CheckClass();
            cobj.Add(13, 13);
            cobj.WrapperMethod();
        }
    }

    public class CheckClass:DemoLib
    { 
        public void WrapperMethod()
        {
            base.Mult(10, 12);
            base.Div(20, 10);
        }
    }

}
