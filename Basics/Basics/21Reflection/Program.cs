
using System.Reflection;

namespace _21Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"C:\Users\IET\Desktop\MS DOT NET Lab\Basics\Basics\20CMathLib\bin\Debug\net6.0\20CMathLib.dll";

            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type[] types = assembly.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];

                object dynamicallyCreatedObject = assembly.CreateInstance(type.FullName);

                string methodSignature = null;

                MethodInfo[] methodInfos = type.GetMethods();
                for (int j = 0; j < methodInfos.Length; j++)
                {
                    MethodInfo method = methodInfos[j];

                    methodSignature = $"{method.ReturnType} {method.Name} (";

                    ParameterInfo[] parameterInfos = method.GetParameters();

                    Object[] inputParameters = new Object[parameterInfos.Length];

                    for (int k = 0; k < parameterInfos.Length; k++)
                    {
                        ParameterInfo parameter = parameterInfos[k];
                        methodSignature += $" {parameter.ParameterType} {parameter.Name},";
                    }

                    for (int k = 0; (k < inputParameters.Length); k++)
                    {
                        Console.WriteLine("Enter value for {0} of type {1} : ",
                            parameterInfos[k].Name, parameterInfos[k].ParameterType.ToString());
                        object val = Convert.ChangeType(Console.ReadLine(), parameterInfos[k].ParameterType);
                        inputParameters[k] = val;
                    }

                    methodSignature = methodSignature.TrimEnd(',') + " )";
                    Console.WriteLine(methodSignature);
                    object? result = type.InvokeMember(method.Name, 
                        BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                        null,
                        dynamicallyCreatedObject,
                        inputParameters);

                    Console.WriteLine("The result of {0} is : {1}", method.Name, result);

                }
                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if (attr is SerializableAttribute)
                    {
                        Console.WriteLine($"Type: {type.Name} class is Serializable");
                    }
                }
            }

        }
    }
}
