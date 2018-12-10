using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {
            // creation new person Arno
            DateTime birthday = new DateTime(1996, 2, 18);
            Person arno = new Person("Arno Feelters", birthday);
            Console.WriteLine(arno.ToString());
            Console.WriteLine(arno);

            // creation new employee flémal
            Employee flemal = new Employee("C. Flemal", new DateTime(1992, 4, 21), 3200);
            Console.WriteLine(flemal.ToString()); // with override -> C. Marchand, without override -> C. Marchand
            flemal.name = "Bullshit";
            Console.WriteLine(flemal.ToString()); // with override -> C. Marchand, without override -> C. Marchand
            Console.WriteLine(flemal);            // with override -> C. Marchand, without override -> BullShit (21-04-92 00:00:00)

        }
    }
}
