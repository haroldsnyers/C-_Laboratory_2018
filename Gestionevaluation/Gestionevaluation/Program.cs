using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person("Timothy", "Naber");
            p.Displayname();

            Student s = new Student("Timoty", "naber");
            

            Teacher T = new Teacher("jpse", "ghdgfe", 3000);

            Activity A = new Activity(T, 3, "math", "BE300");


            Cote c = new Cote(16, A);

            s.AddEvaluation(c);
            s.Bulletin();
            
        }
    }
}
