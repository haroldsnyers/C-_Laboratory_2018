using computer;
using System;

namespace Adder
{
    public class Adder : Computer
    {
        public string Name
        {
            get { return " Adder "; }
        }

        public double Compute(params double[] values)
        {
            double result = 0;
            // adds up each element of the array value
            Array.ForEach(values, value => result += value );
            return result ;
        }
    }
}
