using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
                    break;
                }
                catch (Exception e)
                {

                }
            }
            return x;

        }
        static void Main(string[] args)
        {
            Polynomial p = new Polynomial(new double[] { 1, 0, -2 });
            
            Console.WriteLine(p.Degree);
            Console.WriteLine(p);
            Console.WriteLine(p.Evaluate(2));

            Polynomial m = new Polynomial(new double[]);
        }
    }

    class Polynomial
    {
        public int Degree = 0;
        double[] a;

        // method to determine the degree of the polynomial
        public Polynomial (double [] pa)
        {
            a = pa;
            this.Degree = a.Length - 1;
            
        }
        
        // method to evaluate the polynome with some value we assign in the main
        public double Evaluate(double value)
        {
            double resultat = 0;
            for (int i = Degree; i >= 0; i--)
            {
                double resultatx = a[a.Length-(i+1)] * Math.Pow(value, i);
                resultat += resultatx;
                // Console.WriteLine($"degree {i} : {resultat} et {resultatx}");
            }
            return resultat; 
        }

        // transforms the function we call in the Main to print p in a polynomial form, otherwise it prints the type
        public override string ToString()
        {
            string result = "";
            int n = Degree; 
            for (int i = 0; i <= Degree; i++)
            {
                if (a[i] == 0)
                {
                    result += "";
                }
                else
                {
                    if (n == Degree) // to assign the first value of the list to the highest exponent
                    {
                        result += a[i] + "x^" + n;
                    }
                    else if (n > 0) // assign the other values to exponents != from 0
                    {
                        result += "+ " + a[i] + "x^" + n;
                    }
                    else if (n == 0) // asign the last value to the exponent 0
                    {
                        result += "+ " + a[i];
                    }
                }
                n--; // to go through all the different degrees to 0
            }
            return result;
        }
    }
}
