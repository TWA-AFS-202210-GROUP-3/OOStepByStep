using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int classNo;
        public Student(string name, int age, int classNo) : base(name, age)
        {
            this.classNo = classNo;
        }

        public override string Introduce()
        {
            return base.Introduce() + $" I am a student of class {classNo}.";
        }
    }
}
