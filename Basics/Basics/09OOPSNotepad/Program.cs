using System.Diagnostics;

namespace _09OOPSNotepad
{
    internal class Program
    {
        static void Main(string[] args)
        {

          SpellCheckFactory spellCheckerFactory = new SpellCheckFactory();
            ISpellChecker someSpellChecker = spellCheckerFactory.GetIspellChecker("en");
            Notepad notepad2 = new Notepad(someSpellChecker);
            notepad2.Spellcheck();
        }
    }


}
public class Notepad
{
    ISpellChecker _checker;
    SpellCheckFactory factory = new SpellCheckFactory();
    public Notepad(ISpellChecker checker) //Constructor  dependency injection 
    {
        if (checker == null)
        {
            _checker = factory.GetIspellChecker("en");
        }
        else
        {

            _checker = checker;

        }


    }


    public void Spellcheck()
    {
        _checker.DoSpellCheck();
    }
    public void cut()
    {
        //code here
    }
    public void copy()
    {
        //code here
    }
    public void past()
    {
        //code here
    }

}

public interface ISpellChecker
{
    void DoSpellCheck();
}

public class SpellCheckFactory
{
    public ISpellChecker GetIspellChecker(string lang)
    {
        switch (lang)
        {
            case "en":
                return new EnglishSpellCheck();
            case "gr":
                return new GremanSPellCheck();

            case "sp":
                return new SpanishSpellCheck();

            default:
                return new EnglishSpellCheck();

        }
    }


}

public class HindiSpellChecker : ISpellChecker
{
    public void DoSpellCheck()
    {
        Console.WriteLine("Hindi Spell Check Done");
    }

}

public class EnglishSpellCheck : ISpellChecker
{
    public void DoSpellCheck()
    {
        Console.WriteLine("English Spell Check  Done");
    }
}

public class GremanSPellCheck : ISpellChecker
{
    public void DoSpellCheck()
    {
        Console.WriteLine("German Spell Check Done");
    }
}

public class SpanishSpellCheck : ISpellChecker
{
    public void DoSpellCheck()
    {
        Console.WriteLine("Spanish Spell Check Done");
    }
}


