using computer;
using System;


namespace Multiplier
{
    public class Multiplier : Computer
    {
        public string Name
        {
            get { return " Multiplier "; }
        }

        public double Compute(params double[] values)
        {
            double result = 1;
            Array.ForEach(values, value => result *= value);
            return result;
        }
    }
}
