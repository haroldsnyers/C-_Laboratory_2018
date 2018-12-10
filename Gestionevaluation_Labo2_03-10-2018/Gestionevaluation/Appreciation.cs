using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    public class Appreciation : Evaluation
    {
        public string appreciation; 

        public Appreciation(string Apprec, Activity A) 
        {
            this.appreciation = Apprec;
            base.A = A;
        }

        // Score from extended class is overriden 
        public override int Score()
        {
            switch (appreciation)
            {
                case "A": return 20; 
                case "B": return 16;
                case "C": return 12;
                case "D": return 8;
                case "E": return 4;
            }
            return 0;
        }

        // set a new score 
        public void SetAppreciation(string Anote)
        {
            this.appreciation = Anote;
        }
    }
}
