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
        private int classNo = 0;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNo) : base(name, age)
        {
            this.classNo = classNo;
        }

        public int GetClassNo()
        {
            return classNo;
        }

        public override string Introduce()
        {
            if (classNo == 0)
            {
                return base.Introduce() + " I am a student.";
            }
            else
            {
                return base.Introduce() + $" I am a student of class {classNo}.";
            }
        }

        public string Welcome(Student newComer)
        {
            if (classNo == newComer.GetClassNo())
            {
                return base.Introduce() + $" I am a student of class {classNo}. Welcome {newComer.GetName()} join class {classNo}.";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
