using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class Employee : Person
    {
        private double salary;

        public Employee(string name, DateTime birthday, double salary) : base(name,
        birthday)
        {
            this.name = "bullshit";
            this.salary = salary;
        }

        public double GetSalary()
        {
            return this.salary;
        }

        public string ToString() // -> we use this method only if called, otherwise we use Tostring from extended class
        // public override string ToString() -> completely replaces the method ToString of Person
        {
            return "C. Marchand ";
        }
    }
}
