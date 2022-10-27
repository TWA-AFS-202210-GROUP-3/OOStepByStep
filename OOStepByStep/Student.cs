using System;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public string StudentIntroduce()
        {
            return Introduce() + " I am a student.";
        }
    }
}