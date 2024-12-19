using System.Reflection;
using _25DBAttributeLib;

namespace _27ReflectionCreateTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"C:\Users\IET\Desktop\MS DOT NET Lab\Basics\Basics\26EmployeeLib\bin\Debug\net6.0\26EmployeeLib.dll";
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type[] types = assembly.GetTypes();
            String createTableQuery = "create table ";
            foreach (Type type in types)
            {

                if (type.IsPublic)
                {
                    Attribute[] classAttributes = type.GetCustomAttributes().ToArray();
                    foreach (Attribute attributeOfClasses in classAttributes)
                    {
                        if (attributeOfClasses is Table)
                        {
                            Table table = attributeOfClasses as Table;
                            createTableQuery += $"{table.TableName} (";
                        }
                    }

                    PropertyInfo[] propertyAttributes = type.GetProperties();
                    for (int i = 0; i < propertyAttributes.Length; i++)
                    {
                        PropertyInfo propertyInfo = propertyAttributes[i];
                        Attribute[] attributes = propertyInfo.GetCustomAttributes().ToArray();
                        foreach (Attribute attributeOfAttribute in attributes)
                        {
                            if (attributeOfAttribute is Column)
                            {
                                Column column = attributeOfAttribute as Column;
                                createTableQuery += $" {column.ColumnName} {column.ColumnType},";
                            }
                        }
                    }
                }

            }

            createTableQuery = createTableQuery.TrimEnd(',') + " );";
            Console.WriteLine(createTableQuery);

            string filePath = @"C:\Users\IET\Desktop\MS DOT NET Lab\Basics\Basics\27MySqlQuery\MySQLQuery\sqlQuery.sql";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(createTableQuery);
            }
            Console.Write("Mysql script writing task done.!");

        }
    }
}
