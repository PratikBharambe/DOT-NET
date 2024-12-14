namespace _05OOPSInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1. SQL Server");
                Console.WriteLine("2. Oracle Server");
                Console.WriteLine("3. MySql Server");
                Console.WriteLine("Enter you choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                DatabaseFactory factory = new DatabaseFactory();
                IDatabase db = factory.GetDatabase(choice);

                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                Console.WriteLine("Enter you choice : ");
                int operationChoice = Convert.ToInt32(Console.ReadLine());

                switch (operationChoice)
                {
                    case 1:
                        db.Insert();
                        break;
                    case 2:
                        db.Update();
                        break;
                    case 3:
                        db.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid choice !!!!!");
                        break;
                }

                Console.WriteLine("Do you want to continue (y/n) ....");
                String ch = Console.ReadLine();
                if(ch == "n")
                {
                    break;
                }

            } while (true);
        }
    }

    #region Database Factory Class Defination
    public class DatabaseFactory
    {
        public IDatabase GetDatabase(int choice)
        {
            IDatabase db = null;
            switch (choice)
            {
                case 1:
                    db = new SQL();
                    break;
                case 2:
                    db = new Oracle();
                    break;
                case 3:
                    db = new MySql();
                    break;
                default:
                    db = null;
                    break;
            }
            return db;
        }
    }
    #endregion

    #region IDatabase Interface
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }
    #endregion

    #region SQL Class Defination
    public class SQL : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Delete done in SQL Server database");
        }

        public void Insert()
        {
            Console.WriteLine("Insert done in SQL Server database");
        }

        public void Update()
        {
            Console.WriteLine("Update done in SQL Server database");
        }
    }
    #endregion

    #region Oracle Class Defination
    public class Oracle : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Delete done in Oracle Server database");
        }

        public void Insert()
        {
            Console.WriteLine("Insert done in Oracle Server database");
        }

        public void Update()
        {
            Console.WriteLine("Update done in Oracle Server database");
        }
    }
    #endregion

    #region MySql Class Defination
    public class MySql : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Delete done in MySql Server database");
        }

        public void Insert()
        {
            Console.WriteLine("Insert done in MySql Server database");
        }

        public void Update()
        {
            Console.WriteLine("Update done in MySql Server database");
        }
    }
    #endregion

}
