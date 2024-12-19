namespace GenericCollections
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Generic List
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            #endregion

            
            Customer cobj1 = new Customer();
            cobj1.ID = 21;
            cobj1.Name = "Bean";
            cobj1.Address = "UK";
            Customer cobj2 = new Customer();
            cobj2.ID = 28;
            cobj2.Name = "Pink Panther";
            cobj2.Address = "USA";
            Customer cobj3 = new Customer();
            cobj3.ID = 5;
            cobj3.Name = "Tony Stark";
            cobj3.Address = "USA";

            #region Generic Customer List
            List<Customer> clist = new List<Customer>();
            clist.Add(cobj1);
            clist.Add(cobj2);
            clist.Add(cobj3);
            foreach (Customer cust in clist)
            {
                Console.WriteLine($"ID: {cust.ID},Name: {cust.Name}, Address: {cust.Address}");
            }
            #endregion

            #region Dictionary
            Dictionary<int, Customer> dt = new Dictionary<int, Customer>();
            dt.Add(1, cobj1);
            dt.Add(2, cobj2);
            dt.Add(3, cobj3);
            dt.Remove(2);
            foreach (var key in dt.Keys)
            {
                Customer cust = dt[key];
                Console.WriteLine($"ID: {cust.ID},Name: {cust.Name}, Address: {cust.Address}");
            } 
            #endregion
        }



    }

    public class Customer
    {
        private int cID;
        private String cName;
        private String cAddress;

        public String Address
        {
            get { return cAddress; }
            set { cAddress = value; }
        }


        public String Name
        {
            get { return cName; }
            set { cName = value; }
        }


        public int ID
        {
            get { return cID; }
            set { cID = value; }
        }


    }

}
