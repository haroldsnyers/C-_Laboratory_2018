using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    public class Cote : Evaluation
    {
        public int Note; 

        public Cote(int Note1, Activity A) //: base(A)
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
