namespace _19FileIOSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("");
            string filepath = @"C:\Users\IET\Desktop\MS DOT NET Lab\Basics\Basics\19FileIOSerialization\bin\Files\Data.txt";
            FileStream fs = null;

            #region Write mode
            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            //}

            ////pen
            //StreamWriter writer = new StreamWriter(fs);
            //Console.WriteLine("Hello from Visual Studio");
            //String inputstr = Console.ReadLine();
            //writer.WriteLine(inputstr);
            //writer.Flush();
            //writer.Close();
            //fs.Close();
            //Console.WriteLine("Done..!");
            #endregion

            #region Read Mode

            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //}
            //else 
            //{
            //    Console.WriteLine("File Does not exist...");
            //}
            //StreamReader reader = new StreamReader(fs);
            //String outputStr = reader.ReadToEnd();
            //reader.Close();

            //Console.WriteLine(outputStr);
            //fs.Close();
            #endregion

            #region Write Emp Data on txt file
            if (File.Exists(filepath)) 
            {
                fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                
                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            }

            //pen
            StreamWriter writer = new StreamWriter(fs);

            Emp emp = new Emp();
            Console.WriteLine("Enter Emp Id");
            emp.EId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Emp Name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Emp Address");
            emp.Address = Console.ReadLine();

            writer.Write(emp);
            writer.Flush();
            writer.Close();
            fs.Close();
            Console.WriteLine("Done ..!!");

            #endregion


        }

    }
    public class Book
    {
        private String _BookName;

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }

        //Attributes
        //[Serialization]
    }
        public class Emp
        {
            private int _EId;
            private String _EmpName;
            //[Unserialization]
            private String _EAddress;

            public string Address
            {
                get { return _EAddress; }
                set { _EAddress = value; }
            }

            public String Name
            {
                get { return _EmpName; }
                set { _EmpName = value; }
            }
            public int EId
            {
                get { return _EId; }
                set { _EId = value; }


            }

        }
    }

