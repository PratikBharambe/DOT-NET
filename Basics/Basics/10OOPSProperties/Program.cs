using System.Threading.Channels;

namespace _10OOPSProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Dept = "TestDemo";
            string deptname = emp.Dept;
            Console.WriteLine(deptname);
        }
    }


    public class Employee {
        private int _Eid;
        private string _Ename;
        private logger _logger;

        private string _Dept;

        public string Dept
        {
            get { return _Dept; }
            set { _Dept = value; }
        }


        public int Eid { 

            set { _Eid = value; }
            get { return _Eid; }    

        }
        public string Ename {
            set { _Ename = value; }
            get { return _Ename; }
        
        }

        public logger logger
        {
            set { _logger = value; }
            get { return _logger; }

        }
    }

    public class logger
    {
        public void log() { 
        
       Console.WriteLine("Logger method output");
        }
    }
}
