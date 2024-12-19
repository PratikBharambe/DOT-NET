using System.Runtime.InteropServices;

namespace _13Events
{
    public delegate void resultDelegate(int i);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            resultDelegate resultpass = new resultDelegate(student.OnSuccess);
            student.pass += resultpass;
            
            
            resultDelegate resultfail = new resultDelegate(student.OnFailure);
            student.fail += resultfail;


            Console.WriteLine("Enter marks of a student");
            student.Marks = Convert.ToInt32(Console.ReadLine());
        }
    }

    public class Student
    {
        public event resultDelegate pass;
        public event resultDelegate fail;


        private int _marks;
        public int Marks
        {
            set
            {
                _marks = value;
                if (_marks >= 20)
                {
                    pass(_marks);
                }
                else
                {
                    fail(_marks);
                }
            }

            get
            {
                return _marks;
            }
        }

        public void OnSuccess(int marks)
        {
            Console.WriteLine("Congratulations !! You passed with {0} marks", marks);
        }

        public void OnFailure(int marks)
        {
            Console.WriteLine("Congratulations !! You failed with {0} marks", marks);

        }
    }
}
