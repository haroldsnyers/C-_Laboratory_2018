using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    // Teacher extends from the class Person
    public class Teacher : Person
    {
        public int Salary = 0;

        // adding salary in addition to name
        public Teacher(string Lname, string Fname, int Tsalary) : base (Fname, Lname)
        {
            this.Salary = Tsalary;
        }
    }
}
