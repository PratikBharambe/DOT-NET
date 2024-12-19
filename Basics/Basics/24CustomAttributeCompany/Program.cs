using System.Reflection;
using _22ComapanyLib;

namespace _24CustomAttributeCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"C:\Users\IET\Desktop\MS DOT NET Lab\Basics\Basics\23DemoLib\bin\Debug\net6.0\23DemoLib.dll";

            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type[] types = assembly.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                Attribute[] attributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < attributes.Length; j++)
                {
                    Attribute attr = attributes[j];
                    if (attr is Company)
                    {
                        Company comp = attr as Company;
                        Console.WriteLine($"The Type : {type.Name} belongs to {comp.CompanyName} and developed by {comp.DeveloperName} Developer.");
                    }
                }
            }
        }
    }
}
