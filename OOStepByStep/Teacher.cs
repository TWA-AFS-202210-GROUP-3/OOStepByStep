using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classNo = 0;

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNo) : base(name, age)
        {
            this.classNo = classNo;
        }

        public override string Introduce()
        {
            if (classNo == 0)
            {
                return base.Introduce() + " I am a teacher.";
            }
            else
            {
                return base.Introduce() + $" I am a teacher of class {classNo}.";
            }
        }
    }
}
