using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    // Cote extends from Evaluation
    public class Cote : Evaluation
    {
        public int Note; 

        public Cote(int Note1, Activity A) // Evaluation is-made-of an Activity, 
                                           // Cote receives the Activity with the extension
        {
            this.Note = Note1;
            base.A = A;
        }

        public override int Score()
        {
            return Note;
        }

        public void SetScore(int N)
        {
            this.Note = N;
        }
    }
}
