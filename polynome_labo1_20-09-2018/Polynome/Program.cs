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
                    Console.WriteLine("Ceci n'est pas un réel");
                }
            }
            return x;

        }
        static void Main(string[] args)
        {                             
            List<double> termsList = new List<double>();
            Console.WriteLine("Ajouter Polynome? Y/N");
            string response = Console.ReadLine();
            Console.WriteLine("Entrée les nombres dans l'ordre");
            while (response == "Y")
            {
                double tmpNbr = Valors();
                termsList.Add(tmpNbr);
                Console.WriteLine("Encore un nombre? Y/N");
                response = Console.ReadLine();
            }

            Polynomial p = new Polynomial(termsList);

            Console.WriteLine(p.Degree);
            Console.WriteLine(p);
            Console.WriteLine("Entrée le chiffre avec lequel vous voulez évaluez la fonction");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(p.Evaluate(2));

        }
    }

    class Polynomial
    {
        public int Degree = 0;
        List<double> a = new List<double>();

        // method to determine the degree of the polynomial
        public Polynomial (List<double> termList)
        {
            foreach (double elem in termList)
            {
                a.Add(elem);
            }
            this.Degree = a.Count - 1;
            
        }
        
        // method to evaluate the polynome with some value we assign in the main
        public double Evaluate(double value)
        {
            double resultat = 0;
            for (int i = Degree; i >= 0; i--)
            {
                double resultatx = a[a.Count - (i + 1)] * Math.Pow(value, i);
                resultat += resultatx;
            }
            return resultat; 
        }

        // transforms the function we call in the Main to print p in a polynomial form, otherwise it prints the type
        public override string ToString()
        {
            string result = "";
            int n = Degree;

            // loop to display elements of a list
            StringBuilder builder = new StringBuilder();
            foreach (int safePrime in a)
            {
                // Append each int to the StringBuilder overload.
                builder.Append(safePrime).Append(" ");
            }
            string resultString = builder.ToString();
            Console.WriteLine("these are the elements of list  : [" + resultString + "]");

            for (int i = 0; i <= Degree; i++)
            {
                if (a[i] == 0) // number equals 0, there is no x for that degree
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
