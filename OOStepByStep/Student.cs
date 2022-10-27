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

        public string StudentIntroduce()
        {
            return this.classNumber != 0 ?
                Introduce() + " I am a student." :
                Introduce() + $" I am a student of class{classNumber}.";
        }
    }
}