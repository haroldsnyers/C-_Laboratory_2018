using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("ConsoleApp1.Item");

            // gets info of all the methods of ConsoleApp1 which corresponds to one of the criteria inside GetMethods
            // DeclareOnly returns all heritage
            MethodInfo[] infoMethod = type.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly | 
                BindingFlags.Instance);

            // gets info of all the variables declared directly in the class of ConsoleApp1 which corresponds to 
            // one of the criteria inside GetMethods
            FieldInfo[] infoField = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            // gets info of all constructors inside ConsoleApp1 (constructor usually has the same name as the class
            // and it usually where we initialize the data members of the new object
            ConstructorInfo[] infoConstructor = type.GetConstructors(BindingFlags.Public | 
                BindingFlags.DeclaredOnly | BindingFlags.Instance);
            
            // didn't find any constructor or method or field
            if (infoMethod == null | infoField == null | infoConstructor == null)
            {
                Console.WriteLine("problem");
            }
            else
            {
                foreach (MethodInfo info in infoMethod)
                {            
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
