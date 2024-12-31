using _01DatabaseConnectedArch.DAL;
using _01DatabaseConnectedArch.Models;
using Microsoft.Data.SqlClient;

namespace _01DatabaseConnectedArch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Normal Flow
            //string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AudioBook;Integrated Security=True";

            #region Select Query
            //SqlConnection con = new SqlConnection(conStr);
            //string selectQuery = "select * from Books";
            //SqlCommand cmd = new SqlCommand(selectQuery, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader["Id"]);
            //    string? name = reader["Name"].ToString();
            //    string? auther = reader["Author"].ToString();
            //    string? narrator = reader["Narrator"].ToString();
            //    Console.WriteLine($"Id : {id}, Name : {name}, Author : {auther}, Narrator : {narrator}");
            //}
            //con.Close();
            #endregion

            #region Insert Query
            //Console.WriteLine("Enter Book Name : ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Enter Book Author : ");
            //string? auther = Console.ReadLine();
            //Console.WriteLine("Enter Book Narrator : ");
            //string? narrator = Console.ReadLine();

            //string insertQuery = $"insert into Books values('{name}', '{auther}', '{narrator}')";

            //SqlConnection con = new SqlConnection(conStr);
            //SqlCommand cmd = new SqlCommand(insertQuery, con);
            //con.Open();
            //int data = cmd.ExecuteNonQuery();
            //con.Close();
            //if(data > 0 )
            //    Console.WriteLine("Audio Book Added successfully.");
            //else
            //    Console.WriteLine("Error in audio book insertion.");
            #endregion

            #region update Query
            //Console.WriteLine("Enter Id of the Book : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter New Book Name : ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Enter New Book Author : ");
            //string? auther = Console.ReadLine();
            //Console.WriteLine("Enter New Book Narrator : ");
            //string? narrator = Console.ReadLine();

            //string updateQuery = $"update Books set Name = '{name}', Author = '{auther}', Narrator = '{narrator}' where Id = {id}";
            //SqlConnection con = new SqlConnection(conStr);
            //SqlCommand cmd = new SqlCommand(updateQuery, con);
            //con.Open();
            //int n = cmd.ExecuteNonQuery();
            //con.Close();
            //if(n > 0)
            //    Console.WriteLine("Audio Book Updated successfully.");
            //else
            //    Console.WriteLine("Error in audio book updation.");
            #endregion

            #region Delete Query
            //Console.WriteLine("Enter Id of the Book : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //SqlConnection con = new SqlConnection(conStr);
            //string deleteQuery = $"delete from Books where Id = {id}";
            //SqlCommand cmd = new SqlCommand(deleteQuery, con);
            //con.Open();
            //int data = cmd.ExecuteNonQuery();
            //con.Close();
            //if(data > 0 )
            //    Console.WriteLine("Audio Book Deleted Successsfully.");
            //else
            //    Console.WriteLine("Error in audio book deletion.");
            #endregion

            #endregion

            #region Layered Achitecture

            int choice = 0;

            AudioBookDbContext db = new AudioBookDbContext();

            do
            {
                Console.WriteLine("\n1. Get All Audio Books details.");
                Console.WriteLine("2. Get Audio Book details by id.");
                Console.WriteLine("3. Add new audio book.");
                Console.WriteLine("4. Update audio book details.");
                Console.WriteLine("5. Delete audio book.");
                Console.WriteLine("6. Exit.");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        List<Book> books = db.GetAllBooks();
                        if (books != null)
                            foreach (var b in books)
                                Console.WriteLine($"Id : {b.Id}, Name : {b.Name}, Author : {b.Author}, Narrator : {b.Narrator}");
                        else
                            Console.WriteLine("No data present in table.");
                        break;

                    case 2:
                        Console.WriteLine("Enter Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Book book = db.getBookById(id);
                        if (book != null)
                            Console.WriteLine($"Id : {book.Id}, Name : {book.Name}, Author : {book.Author}, Narrator : {book.Narrator}");
                        else
                            Console.WriteLine("No data present in table.");
                        break;

                    case 3:
                        Console.WriteLine("Enter name : ");
                        string? name = Console.ReadLine();
                        Console.WriteLine("Enter anthor : ");
                        string? author = Console.ReadLine();
                        Console.WriteLine("Enter narrator : ");
                        string? narrator = Console.ReadLine();
                        Book book1 = new Book() { Name = name, Author = author, Narrator = narrator };
                        bool isDone = db.insertBook(book1);
                        if (isDone)
                            Console.WriteLine("Insertion done.");
                        else
                            Console.WriteLine("Error in insertion.");
                        break;

                    case 4:
                        Console.WriteLine("Enter Id : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name : ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter anthor : ");
                        author = Console.ReadLine();
                        Console.WriteLine("Enter narrator : ");
                        narrator = Console.ReadLine();
                        book1 = new Book() { Id = id, Name = name, Author = author, Narrator = narrator };
                        isDone = db.updateBook(book1);
                        if (isDone)
                            Console.WriteLine("Updation done.");
                        else
                            Console.WriteLine("Error in updation.");
                        break;

                    case 5:
                        Console.WriteLine("Enter Id : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        isDone = db.deleteBook(id);
                        if (isDone)
                            Console.WriteLine("Deletion done.");
                        else
                            Console.WriteLine("Error in deletion.");
                        break;

                    case 6:
                        Console.WriteLine("Thanks for visiting !!!\nBye Bye ..........");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            }
            while (choice != 6);

            #endregion

        }
    }
}
