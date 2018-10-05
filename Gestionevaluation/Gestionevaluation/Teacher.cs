using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    public class Teacher : Person
    {
        public int Salary = 0;

        public Teacher(string Lname, string Fname, int Tsalary) : base (Fname, Lname)
        {
            this.Salary = Tsalary;
        }
    }
}
