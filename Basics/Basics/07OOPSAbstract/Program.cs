using System.Xml.Serialization;

namespace _07OOPSAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. PDF");
                Console.WriteLine("2. DOCX");
                Console.WriteLine("3. TXT");
                Console.WriteLine("4. XML");
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                ReportFactory rf = new ReportFactory();
                IReport report = rf.GetReport(choice);
                report.GenerateReport();
                Console.WriteLine("Do you want to continue (y/n) ....");
                String s = Console.ReadLine();
                if (s == "n")
                {
                    break;
                }
            }
        }
    }

    public class ReportFactory
    {
        public Report report;

        public Report GetReport(int choice)
        {
            switch (choice)
            {
                case 1:
                    report = new PDF();
                    break;

                case 2:
                    report = new DOCX();
                    break;

                case 3:
                    report = new TXT();
                    break;

                case 4:
                    report = new XML();
                    break;

                default:
                    report = null;
                    break;
            }
            return report;
        }
    }

    public interface IReport
    {
        void GenerateReport();
    }

    public abstract class Report : IReport
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();
        }
    }

    public abstract class SpecialReport : Report
    {
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }

    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Parsed PDF.");
        }

        protected override void Save()
        {
            Console.WriteLine("Saved PDF.");
        }

        protected override void Validate()
        {
            Console.WriteLine("Validated PDF.");
        }
    }

    public class DOCX : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Parsed DOCX.");
        }

        protected override void Save()
        {
            Console.WriteLine("Saved DOCX.");
        }

        protected override void Validate()
        {
            Console.WriteLine("Validated DOCX.");
        }
    }

    public class TXT : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Parsed TXT.");
        }

        protected override void Save()
        {
            Console.WriteLine("Saved TXT.");
        }

        protected override void Validate()
        {
            Console.WriteLine("Validated TXT.");
        }
    }

    public class XML : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("Parsed XML.");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("Re-Validate XML.");
        }

        protected override void Save()
        {
            Console.WriteLine("Saved XML.");
        }

        protected override void Validate()
        {
            Console.WriteLine("Validated XML.");
        }
    }

}
