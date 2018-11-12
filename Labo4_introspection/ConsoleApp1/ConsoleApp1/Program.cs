using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("ConsoleApp1.Item");
            MethodInfo[] infoMethod = type.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
            // DeclareOnly returns all heritage
            FieldInfo[] infoField = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            ConstructorInfo[] infoConstructor = type.GetConstructors(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
            
            if (infoMethod == null | infoField == null)
            {
                Console.WriteLine("problem");
            }
            else
            {
                foreach (MethodInfo info in infoMethod)
                {
                    //Console.WriteLine("methodinfo returntype " + info.ReturnType.ToString());
                    Console.WriteLine("methodinfo " + info.ToString());
                }
                foreach (FieldInfo info in infoField)
                {
                    Console.WriteLine("fieldinfo " + info.ToString());
                }
                foreach (ConstructorInfo info in infoConstructor)
                {
                    Console.WriteLine("constructorinfo " + info.ToString());
                }
            }  
        }
    }
}
