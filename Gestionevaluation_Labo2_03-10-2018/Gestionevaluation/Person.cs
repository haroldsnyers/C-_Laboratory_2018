using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    // Model class for a person -> Teacher, Student, 
    public class Person
    {
        public string Firstname;
        public string Lastname;

        public Person(string Fname, string Lname)
        {
            this.Firstname = Lname;
            this.Lastname = Fname;
        }

        public void Displayname()
        {
            Console.WriteLine("{0} {1}", Lastname, Firstname);
        }
    }


}
