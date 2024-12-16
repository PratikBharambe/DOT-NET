namespace _10Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioBook book = new AudioBook();
            Console.WriteLine("Enter audio book id : ");

            #region Setter method getting called
            book.id = Convert.ToInt32(Console.ReadLine());
            #endregion

            Console.WriteLine("Enter audio book title : ");

            #region Setter method getting called
            book.title = Console.ReadLine();
            #endregion

            #region Getter method gettting called
            Console.WriteLine("The id entered by user is : {0}", book.id);
            Console.WriteLine("The title entered by user is : {0}", book.title);
            #endregion
        }
    }

    public class Episode
    {
        public void episode()
        {
            // Epiosde retrival code
            Console.WriteLine("All epiosde related functionality is present here");
        }
    }


    public class AudioBook
    {
        private int _id;
        private string _title;
        private string _description;
        private Episode _episode;

        #region Getter and Setter
        public int id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        #endregion

        public string title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }

        public string description
        {
            set
            {
                _description = value;
            }
            get
            {
                return _description;
            }
        }

        #region Object releted getter and setter
        public Episode episode
        {
            set
            {
                _episode = value;
            }
            get
            {
                return _episode;
            }
        }
        #endregion

    }


}
