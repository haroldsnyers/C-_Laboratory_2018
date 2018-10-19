using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3_Test_Unitaire
{
    class Program
    {   
        public static void Main(string[] args)
        {
            var alphabet = new Dictionary<string, string>
            {
                { "(", ")" },
                { "[", "]" },
                { "{", "}" }
            };
            Console.WriteLine(Dyck.IsDyckString("((()))"));
            Console.WriteLine(IsDickStringMain.IsDyckString("()", alphabet));
         
        }
    }
}
