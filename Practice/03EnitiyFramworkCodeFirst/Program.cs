using _03EnitiyFramworkCodeFirst.DAL;
using _03EnitiyFramworkCodeFirst.Models;

namespace _03EnitiyFramworkCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            TestDbContext testDbContext = new TestDbContext();

            do
            {
                Console.WriteLine("1. Get all audio Books.");
                Console.WriteLine("2. Add new audio Book.");
                Console.WriteLine("3. Update audio books details.");
                Console.WriteLine("4. Delete audio book.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        List<AudioBooks> books = testDbContext.Books.ToList();
                        if (books.Count > 0)
                        {
                            books.ForEach(b =>
                            {
                                Console.WriteLine($"ID : {b.Id}, Name : {b.Name}, Author : {b.Author}, Narrator : {b.Narrator}");
                            });
                        }
                        else
                        {
                            Console.WriteLine("There is no data in table.");
                        }
                        break;

                    case 2:
                        AudioBooks bookToBeAdded = new AudioBooks();

                        Console.WriteLine("Enter name : ");
                        bookToBeAdded.Name = Console.ReadLine();
                        Console.WriteLine("Enter author : ");
                        bookToBeAdded.Author = Console.ReadLine();
                        Console.WriteLine("Enter narrator : ");
                        bookToBeAdded.Narrator = Console.ReadLine();

                        testDbContext.Books.Add(bookToBeAdded);
                        testDbContext.SaveChanges();
                        Console.WriteLine("Audio book added successsfully.");
                        break;

                    case 3:
                        Console.WriteLine("Enter book id : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        AudioBooks book = testDbContext.Books.Find(id);
                        if (book != null)
                        {
                            Console.WriteLine("Enter name : ");
                            book.Name = Console.ReadLine();
                            Console.WriteLine("Enter author : ");
                            book.Author = Console.ReadLine();
                            Console.WriteLine("Enter narrator : ");
                            book.Narrator = Console.ReadLine();
                            testDbContext.SaveChanges();
                            Console.WriteLine("Audio book updated successsfully.");
                        }
                        else
                        {
                            Console.WriteLine("No book found");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter book id : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        book = testDbContext.Books.Find(id);
                        if (book != null)
                        {
                            testDbContext.Books.Remove(book);
                            testDbContext.SaveChanges();
                            Console.WriteLine("Book deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Thanks for visiting!!!\nBye Bye ...........");
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
