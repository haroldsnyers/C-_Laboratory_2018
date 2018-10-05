using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionevaluation
{
    public class Activity
    {
        public int ECTS = 0;
        public string Name;
        public string Code;
        public Teacher T;

        public Activity(Teacher T, int credit, string CourseName, string Code)
        {
            this.T = T;
            this.ECTS = credit;
            this.Name = CourseName;
            this.Code = Code;
        }

    }
}
