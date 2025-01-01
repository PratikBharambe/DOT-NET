using _04EntityFrameworkDatabaseFirstApproach.Models;

namespace _04EntityFrameworkDatabaseFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            AudioBookContext dbContest = new AudioBookContext();

            do
            {
                Console.WriteLine("1. Get all Users.");
                Console.WriteLine("2. Add new user.");
                Console.WriteLine("3. Update user details.");
                Console.WriteLine("4. Delete user.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("Enter your choice : .");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        List<User> users = dbContest.Users.ToList();
                        if(users != null)
                            users.ForEach(u => Console.WriteLine($"Id : {u.Id}, Username : {u.Username}, Password : {u.Password}"));
                        break;

                    case 2:
                        User user = new User();
                        Console.WriteLine("Enter Username : ");
                        user.Username = Console.ReadLine();
                        Console.WriteLine("Enter Password : ");
                        user.Password = Console.ReadLine();
                        dbContest.Users.Add(user);
                        dbContest.SaveChanges();
                        Console.WriteLine("User added successfully.");
                        break;

                    case 3:
                        Console.WriteLine("Enter id : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        user = dbContest.Users.Find(id);
                        if(user != null)
                        {
                            Console.WriteLine("Enter Username : ");
                            user.Username = Console.ReadLine();
                            Console.WriteLine("Enter Password : ");
                            user.Password = Console.ReadLine();
                            dbContest.SaveChanges();
                            Console.WriteLine("User information updated.");
                        }
                        else
                        {
                            Console.WriteLine("Error occured.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter id : ");
                        id = Convert.ToInt32(Console.ReadLine());

                        user = dbContest.Users.Find(id);
                        if(user != null)
                        {
                            dbContest.Users.Remove(user);
                            dbContest.SaveChanges();
                            Console.WriteLine("User deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error occured.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Thanks for visiting !!!\nBye Bye .........");
                        break;

                    default:
                        Console.WriteLine("invalid choice.");
                        break;
                }
            }
            while (choice != 5);
        }
    }
}
