
using System.Collections.Generic;
using _01DatabaseConnectedArch.Models;
using Microsoft.Data.SqlClient;

namespace _01DatabaseConnectedArch.DAL
{
    internal class AudioBookDbContext
    {

        const string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AudioBook;Integrated Security=True";

        public List<Book> GetAllBooks()
        {
            List<Book> list = new List<Book>();
            SqlConnection con = new SqlConnection(conStr);
            string selectQuery = "select * from Books";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Narrator = Convert.ToString(reader["Narrator"]),
                };
                list.Add(book);
            }
            return list;
        }

        public Book getBookById(int id)
        {
            Book? book = null;
            SqlConnection con = new SqlConnection(conStr);
            string selectByIdQuery = $"select * from Books where Id = {id}";
            SqlCommand cmd = new SqlCommand(selectByIdQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                book = new Book()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Author = Convert.ToString(reader["Author"]),
                    Narrator = Convert.ToString(reader["Narrator"]),
                };
            }
            return book;
        }

        public bool insertBook(Book book)
        {
            SqlConnection con = new SqlConnection(conStr);
            string insertQuery = $"insert into Books values('{book.Name}', '{book.Author}', '{book.Narrator}')";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            con.Open();
            int data = cmd.ExecuteNonQuery();
            con.Close();
            return (data > 0) ? true : false;
        }

        public bool updateBook(Book book)
        {
            SqlConnection con = new SqlConnection(conStr);
            string updateQuery = $"update Books set Name = '{book.Name}', Author = '{book.Author}', Narrator = '{book.Narrator}' where Id = {book.Id}";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            con.Open();
            int data = cmd.ExecuteNonQuery();
            con.Close();
            return (data > 0) ? true : false;
        }

        public bool deleteBook(int id)
        {
            SqlConnection con = new SqlConnection(conStr);
            string deleteQuery = $"delete from Books where Id = {id}";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            con.Open();
            int data = cmd.ExecuteNonQuery();
            con.Close();
            return (data > 0) ? true : false;
        }

    }
}
