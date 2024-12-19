using System.Collections;
using System.Net.Sockets;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int[]
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

            #region String[]
            String[] Sarr = new String[2];
            Sarr[0] = "Yash";
            Sarr[1] = "Mrunal";
            foreach (String str in Sarr)
            {
                Console.WriteLine(str);
            }
            #endregion

            Emp eobj = new Emp();
            eobj.Id = 12;
            eobj.Name = "Mrunal";
            eobj.Addr = "Pune";
            Emp eobj1 = new Emp();
            eobj1.Id = 13;
            eobj1.Name = "Yash";
            eobj1.Addr = "Pune";
            Book bobj = new Book();
            bobj.BookName = "The palace of illusion";
            bobj.Author = "Chitra Banarjee";

            #region Emp[]

            Emp[] earr = new Emp[2];
            earr[0] = eobj;
            earr[1] = eobj1;

            foreach (Emp emp in earr)
            {
                String result = string.Format("id : {0}, Name : {1}, Address : {2}", emp.Id, emp.Name, emp.Addr);
                Console.WriteLine(result);
            }
            #endregion

            #region Object[]
            Object[] oarr = new object[5];
            oarr[0] = 12;  //boxing
            oarr[1] = 12.23;
            oarr[2] = "STRONG";
            oarr[3] = eobj; //typecasting
            oarr[4] = bobj;

            foreach (Object obj in oarr)
            {
                if (obj is int)
                {
                    int i = Convert.ToInt32(obj);
                    Console.WriteLine(i.ToString());
                }
                if (obj is string)
                {
                    string str = Convert.ToString(obj);
                    Console.WriteLine(str);
                }
                if (obj is double)
                {
                    double d = Convert.ToDouble(obj);
                    Console.WriteLine(d.ToString());
                }
                if (obj is Emp)
                {
                    Emp emp = obj as Emp;  //typecasting
                    String result = string.Format("id : {0}, Name : {1}, Address : {2}", emp.Id, emp.Name, emp.Addr);
                    Console.WriteLine(result);
                }
                if (obj is Book)
                {
                    Book book = bobj as Book;
                    String result = string.Format("Name :{0},Author :{1}", book.BookName, book.Author);
                    Console.WriteLine(result);
                }
            }
            #endregion

            #region ArrayList
            ArrayList arrlst = new ArrayList();
            arrlst.Add(21);
            arrlst.Add(23.45);
            arrlst.Add("MRU");
            arrlst.Add("Yash");
            arrlst.Add(eobj);
            arrlst.Add(bobj);
            arrlst.Remove(eobj);

            foreach (Object obj in arrlst)
            {
                if (obj is int)
                {
                    int i = Convert.ToInt32(obj);
                    Console.WriteLine(i.ToString());
                }
                if (obj is string)
                {
                    string str = Convert.ToString(obj);
                    Console.WriteLine(str);
                }
                if (obj is double)
                {
                    double d = Convert.ToDouble(obj);
                    Console.WriteLine(d.ToString());
                }
                if (obj is Emp)
                {
                    Emp emp = obj as Emp;  //typecasting
                    String result = string.Format("id : {0}, Name : {1}, Address : {2}", emp.Id, emp.Name, emp.Addr);
                    Console.WriteLine(result);
                }
                if (obj is Book)
                {
                    Book book = bobj as Book;
                    String result = string.Format("Name :{0},Author :{1}", book.BookName, book.Author);
                    Console.WriteLine(result);
                }
            }
            #endregion

            #region HashTable
            Hashtable ht = new Hashtable();
            ht.Add(1, 28);
            ht.Add(2, 21.56);
            ht.Add(3, "TOM JERRY");
            ht.Add(4, eobj);
            ht.Add(5, bobj);

            foreach (var key in ht.Keys)
            {
                if (ht[key] is int)
                {
                    int i = Convert.ToInt32(ht[key]);
                    Console.WriteLine(i.ToString());
                }
                if (ht[key] is double)
                {
                    double d = Convert.ToDouble(ht[key]);
                    Console.WriteLine(d.ToString());
                }
                if (ht[key] is string)
                {
                    string str = Convert.ToString(ht[key]);
                    Console.WriteLine(str);
                }
                if (ht[key] is Emp)
                {
                    Emp emp = ht[key] as Emp;  //typecasting
                    String result = string.Format("[id : {0}, Name : {1}, Address : {2}]", emp.Id, emp.Name, emp.Addr);
                    Console.WriteLine("key : {0}, value : {1}", key, result);
                }
                if (ht[key] is Book)
                {
                    Book book = ht[key] as Book;
                    String result = string.Format("Name :{0},Author :{1}", book.BookName, book.Author);
                    Console.WriteLine("key : {0}, value : {1}", key, result);
                }
            }
            #endregion

            #region Stack
            Stack st = new Stack();
            st.Push(12);
            st.Push(13);
            st.Push(14);
            st.Pop();
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Queue
            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Indices and range
            int[] arr1 = new int[5];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;
            arr1[3] = 4;
            arr1[4] = 5;

            //with indices
            Console.WriteLine("Last Element is:{0}", arr1[^1]);
            Console.WriteLine("Second Last Element is:{0}", arr1[^2]);

            //with region
            string str2 = string.Join(",", arr1);
            Console.WriteLine(str2);

            int[] subarr = arr1[1..3];
            Console.WriteLine("SubArr between range arr1[1..3] : " + String.Join(",", subarr));

            int[] subarr1 = arr1[..3];
            Console.WriteLine("SubArr between range arr1[..3] : " + String.Join(",", subarr1));
            #endregion

            #region Tuples
            var Person = Display(28, "Yash", "Jalgoan");
            Console.WriteLine(Person);
            Console.WriteLine(Person.name); 
            #endregion
        }
        #region Tupples -> No need of class
        public static (int id, String name, String Address) Display(int Id, string Name, string Addr)
        {
            int id = Id;
            string name = Name;
            string Address = Addr;
            return (id, name, Address);
        } 
        #endregion

        #region Book class
        public class Book
        {
            private string _BookName;
            private string _BookAuthor;

            public String BookName
            {
                get { return _BookName; }
                set { _BookName = value; }
            }

            public String Author
            {
                get { return _BookAuthor; }
                set { _BookAuthor = value; }
            }

        }

        #endregion

        #region Emp class
        public class Emp
        {
            private int Eid;
            private String Ename;
            private String Address;

            public String Addr
            {
                get { return Address; }
                set { Address = value; }
            }


            public String Name
            {
                get { return Ename; }
                set { Ename = value; }
            }

            public int Id
            {
                get { return Eid; }
                set { Eid = value; }
            }

        } 
        #endregion
    }
}
