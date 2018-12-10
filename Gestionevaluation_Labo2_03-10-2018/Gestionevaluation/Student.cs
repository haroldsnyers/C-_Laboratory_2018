using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    // Student extends from the class Person
    public class Student : Person
    {
        // a student can have more than 1 evaluation
        private List<Evaluation> cours = new List<Evaluation>();

        public Student(string Fname, string Lname) : base (Fname, Lname)
        {
             
        }

        public void AddEvaluation(Evaluation E)
        {
            cours.Add(E);
        }

        public double Average(float Average)
        {
            //Average += 
            return 0;
        }

        public void Bulletin()
        {
            foreach (Evaluation e in cours)
            {
                // e for the evaluation, A is how we named an Activity in the evaluation
                Console.WriteLine("{0}({1}: Teacher: {2}; Crédit: {3}", e.A.Name, e.A.Code, e.A.T, e.A.ECTS);
                Console.WriteLine(e.Score());
            }
            
        }
    }

    
}
