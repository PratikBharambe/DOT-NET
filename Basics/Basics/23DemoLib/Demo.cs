using _22ComapanyLib;

namespace _23DemoLib
{
    [Serializable]
    [Company(CompanyName ="KPGC", DeveloperName ="Pratik Bharambe")]
    public class Demo
    {
        public void SayHii()
        {
            Console.WriteLine("Hello from Demo class.");
        }
    }
}
