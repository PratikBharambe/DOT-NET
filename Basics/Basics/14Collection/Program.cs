using System.Collections;

namespace _14Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int array[]
            //int[] array = new int[5];
            //array[0] = 1;
            //array[1] = 2;
            //array[2] = 3;
            //array[3] = 4;
            //array[4] = 5;

            //for (int i = 0; i < array.Length; i++) 
            //{
            //    Console.WriteLine(array[i]);            
            //}
            #endregion

            #region String array[]
            //string[] array2 = new string[4];
            //array2[0] = "Rohit";
            //array2[1] = "Mohit";
            //array2[2] = "Lalit";
            //array2[3] = "Vinit";

            //foreach (string str in array2)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region Emp []
            //Emp emp1 = new Emp();
            //emp1.Eid = 47;
            //emp1.Ename = "Mrunal";
            //emp1.EAddress = "Pune";
            //Emp emp2 = new Emp();
            //emp2.Eid = 16;
            //emp2.Ename = "Divya";
            //emp2.EAddress = "Pune";


            //Emp[] empArr = new Emp[2];
            //empArr[0] = emp1;
            //empArr[1] = emp2;

            //foreach (Emp emp in empArr) 
            //{
            //    string result = string.Format("Eid = {0}, Ename = {1}, EAddress = {2}" , emp.Eid, emp.Ename, emp.EAddress);
            //    Console.WriteLine(result);
            //}

            //foreach (var emp in empArr)
            //{
            //    String result = string.Format("Eid = {0}, Ename = {1}, EAddress ={2}", emp.Eid, emp.Ename, emp.EAddress);
            //    Console.WriteLine(result);
            //}
            #endregion

            Emp emp1 = new Emp();
            emp1.Eid = 96;
            emp1.Ename = "Vaishani";
            emp1.EAddress = "Balewadi HighStreert";

            Book book = new Book();
            book.BookName = "Yaani";
            book.BookAuthor = "Jaun Elia";

            #region Object []
            //Object[] obj = new Object[5];
            //obj[0]=500; //Boxing
            //obj[1]= 36.36;
            //obj[2]= emp1; // Type-casting
            //obj[3]="Yogita ";
            //obj[4]=book;

            //foreach (object item in obj)
            //{
            //    if (item is int)
            //    {
            //        int i = Convert.ToInt32(item); //Unboxing
            //        Console.WriteLine(i.ToString());
            //    }
            //    if (item is double)
            //    {
            //        double d = Convert.ToDouble(item);
            //        Console.WriteLine(d.ToString());
            //    }
            //    if (item is string)
            //    {
            //        string str = item.ToString();
            //        Console.WriteLine(str);
            //    }
            //    if (item is Emp)
            //    {
            //        Emp emp = item as Emp;
            //        string result = string.Format("Id = {0}, Name = {1}, Address = {2}",
            //        emp.Eid, emp.Ename, emp.EAddress);
            //        Console.WriteLine(result);
            //    }
            //    if (item is Book)
            //    {
            //        Book book1 = item as Book;
            //        string result = string.Format("Book Name = {0}, Author = {1}",
            //                                            book.BookName, book.BookAuthor);
            //        Console.WriteLine(result);
            //    }
            //}

            #endregion


            #region Hashtable
            //Hashtable ht = new Hashtable();
            //ht.Add(1, 100);
            //ht.Add(2, "Yogita Mahajan");
            //ht.Add(3, emp1);
            //ht.Add(4, 77.77);

            //foreach (var key in ht.Keys)
            //{
            //    //Console.WriteLine(ht[key]);
            //    if (ht[key] is int)
            //    {
            //        int i = Convert.ToInt32(ht[key]);
            //        Console.WriteLine("Key ={0}, Value = {1}", key, i);
            //    }
            //    if (ht[key] is string)
            //    {
            //        string str = Convert.ToString(ht[key]);
            //        Console.WriteLine("Key ={0}, Value = {1}", key, str);
            //    }
            //    if (ht[key] is double)
            //    {
            //        double d = Convert.ToDouble(ht[key]);
            //        Console.WriteLine("Key ={0}, Value = {1}", key, d);
            //    }
            //    if (ht[key] is Emp)
            //    {
            //        Emp emp = ht[key] as Emp;
            //        string result = string.Format(" [Id = {0}, Name = {1}, Address = {2}]",
            //                emp.Eid, emp.Ename, emp.EAddress);
            //        Console.WriteLine("Key ={0}, Value = {1}", key, result);
            //    }
            //}


            #endregion

            #region Stack
            //Stack st = new Stack();
            //st.Push(10);
            //st.Push(20);
            //st.Push(30);
            //st.Pop();
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



        }
    }

    public class Book
    {
        private string _BookName;
        private string _BookAuthor;

        public string BookName
        {
            set { _BookName = value; }
            get { return _BookName; }

        }

        public string BookAuthor
        {
            set { _BookAuthor = value; }
            get { return _BookAuthor; }
        }
    }

    public class Emp
    {
        private int _Eid;
        private string _Ename;
        private string _EAddress;

        public int Eid
        {
            set { _Eid = value; }
            get { return _Eid; }

        }

        public string Ename
        {
            set { _Ename = value; }
            get { return _Ename; }

        }

        public string EAddress
        {
            set { _EAddress = value; }
            get { return _EAddress; }
        }
    }
}