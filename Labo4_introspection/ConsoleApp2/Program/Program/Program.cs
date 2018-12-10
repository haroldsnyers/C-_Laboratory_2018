using computer;
using System;
using System.Reflection;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // --using class Adder--
            // loading dll of class Adder
            Assembly dllAdder = Assembly.LoadFile(@"C:\Users\harold\Dropbox\BA3\Q1\conception_et_programmation_orienté_objet\labo\git_labo\C-_Laboratory_2018\Labo4_introspection\ConsoleApp2\Program\Adder\bin\Debug\netstandard2.0\Adder.dll");
            Type typeAdder = dllAdder.GetExportedTypes()[0];
            Console.WriteLine(typeAdder);
            
            // creates instance of type Computer using class Adder
            Computer oAdder = (Computer) Activator.CreateInstance(typeAdder);
            // use of method Compute of the Class Adder
            double result = oAdder.Compute(4, 5);
            Console.WriteLine(result);

            Assembly dllMultiplier = Assembly.LoadFile(@"C:\Users\harold\Dropbox\BA3\Q1\conception_et_programmation_orienté_objet\labo\git_labo\C-_Laboratory_2018\Labo4_introspection\ConsoleApp2\Program\Multiplier\bin\Debug\netstandard2.0\Multiplier.dll");
            Type typeMultiplier = dllMultiplier.GetExportedTypes()[0];
            Console.WriteLine(typeMultiplier);

            Computer oMultiplier = (Computer)Activator.CreateInstance(typeMultiplier);
            double resultMultiplier = oMultiplier.Compute(4, 5);
            Console.WriteLine(resultMultiplier);
        }
    }
}
