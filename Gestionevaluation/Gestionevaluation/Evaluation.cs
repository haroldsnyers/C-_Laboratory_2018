using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    // we set this class to abstract so we can call the methode Score from the class Cote

    public abstract class Evaluation
    {
        public Activity A;

        public abstract int Score();
        
            
        
    }
}
