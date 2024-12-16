using static _09OOPSNotebookApk.NotePad;
using static _09OOPSNotebookApk.SpellCheckerFactory;

namespace _09OOPSNotebookApk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notepad notepad1 = new Notepad(null);

            SpellCheckerFactory factory = new SpellCheckerFactory();
            ISpellChecker someChecker = factory.getSpellChecker("gr");
            Notepad notepad2 = new Notepad(someChecker);
            notepad2.SpellCheck();


            //Notepad notepad1 = new Notepad("hindi");
            //HindiSpellChecker hindiChecker = new HindiSpellChecker();
            //Notepad notepad1 = new Notepad(hindiChecker);
            //notepad1.SpellCheck();
        }
    }

    public class NotePad
    {
        public class Notepad
        {
            ISpellChecker _checker;
            SpellCheckerFactory factory = new SpellCheckerFactory();
            public Notepad(ISpellChecker checker) //Constructor Dependency Injection
            {
                if (checker == null)
                {
                    _checker = factory.getSpellChecker("en");
                }
                else
                {
                    _checker = checker;
                }
            }

            #region  language based dependency 
            //ISpellChecker checker;
            //SpellChekerFactory factory = new SpellChekerFactory();
            //public Notepad(string lang)
            //{
            //    if (lang == null)
            //    {
            //        checker = factory.GetSomeSpellChecker("en");
            //    }
            //    else
            //    {
            //        checker = factory.GetSomeSpellChecker(lang);
            //    }
            //} 
            #endregion

            public void SpellCheck()
            {
                _checker.doSpellCheck();
            }
            public void cut()
            {
                //some code here
            }
            public void copy()
            {
                //some code here
            }
            public void paste()
            {
                //some code here
            }
            public void duplicate()
            {
                //some code here
            }
        }
    }

    public interface ISpellChecker
    {
        public void doSpellCheck();
    }

    public class SpellCheckerFactory
    {
        public ISpellChecker getSpellChecker(string lang)
        {
            switch (lang)
            {
                case "en":
                    return new EnglishSpellChecker();

                case "hindi":
                    return new HindiSpellChecker();

                case "gr":
                    return new GermanSpellChecker();

                case "sp":
                    return new SpanishSpellChecker();

                default:
                    return new EnglishSpellChecker();

            }
        }

        public class HindiSpellChecker : ISpellChecker
        {
            public void doSpellCheck()
            {
                Console.WriteLine("Hindi spell checker implementation");
            }
        }

        public class EnglishSpellChecker : ISpellChecker
        {
            public void doSpellCheck()
            {
                Console.WriteLine("English spell checker implementation");
            }
        }

        public class GermanSpellChecker : ISpellChecker
        {
            public void doSpellCheck()
            {
                Console.WriteLine("German spell checker implementation");
            }
        }

        public class SpanishSpellChecker : ISpellChecker
        {
            public void doSpellCheck()
            {
                Console.WriteLine("Spanish spell checker implementation");
            }
        }

    }

}
