namespace _02_OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent Reference and Child Object
            Library l = new Section();
            Console.WriteLine("Library l = new Section()");
            l.display();
            l.show();
            Console.WriteLine("library---library: 10,20: " + l.add(10, 20));

            //Child Reference and Parent Object
            //Section s1 = new Library();
            //s1.display();

            //Child Reference and Child Object
            Section s2 = new Section();
            Console.WriteLine("\n Section s2 = new Section()");
            s2.display();
            s2.show();
            Console.WriteLine("section---section: 20,30: " + s2.add(20, 30));

            //Parent Reference and Parent Object
            Library l2 = new Library();
            Console.WriteLine("\n Library l2 = new Library()");
            l2.display();
            l2.show();
            Console.WriteLine("library---library: 30,40: " + s2.add(30, 40));
        }
    }
    //Base Class
    public class Library
    {
        public void show()
        {
            Console.WriteLine("In Library Parent show()");
        }
        //virtual
        public virtual void display()
        {
            Console.WriteLine("In Library Parent display()");
        }
        //virtual
        public virtual int add(int a, int b)
        {
            return a + b;
        }
    }
    //Derived class
    public class Section : Library
    {
        //Shadowing
        public new void show()
        {
            Console.WriteLine("Shadowing if you have to override method in child class");
            Console.WriteLine("In Section Child show()");
        }
        //override
        public override void display()
        {
            Console.WriteLine("In Section Child display()");
        }

        //Wrapping methods
        public override int add(int a, int b)
        {
            Console.WriteLine("In child class");
            int result = base.add(a, b);
            return result;
        }
    }
}

