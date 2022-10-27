using System;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int classNumber;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNumber) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public override string Introduce()
        {
            return this.classNumber != 0 ?
               base.Introduce() + $" I am a student of class {classNumber}." :
               base.Introduce() + " I am a student.";
        }
    }
}