using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double Valors()
        {
            double x;
            while (true)
            {  
                Console.WriteLine("entrée réel");
                string sx = Console.ReadLine();
                 
                try
                {
                    x = Convert.ToDouble(sx);
                    Console.WriteLine("prochains");
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ceci n'est pas un réel");
                }
            }
            return x;
        }
         
        static void Main(string[] args)
        {
            // Program which searches for roots of second degree trinome of the form ax^2 + bx + c
            // Author : Harold
            // Version : 27 september 2018

            // assigning entered valors 
            double a = Valors();
            double b = Valors();
            double c = Valors();

            // calculation of discriminant 
            double delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"Discriminant : {delta}");

            //test of the 3 possible outcomes
            switch(delta)
            {
                case 0:
                    // case double roots
                    double x = -b / (2 * a);
                    Console.WriteLine("une racine réelle double: {0}", x);
                    break;

                default:
                    // case no roots
                    if (delta < 0)
                    {
                        Console.WriteLine("pas de racine réelle");
                    }
                    // case 2 different roots
                    else
                    {
                        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("deux racines réelles distinctes: {0} et {1}", x1, x2);                     
                    }
                    break; 
            }







        }


    }
}
