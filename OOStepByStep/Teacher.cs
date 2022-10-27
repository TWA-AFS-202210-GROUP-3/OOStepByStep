using System;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public string TeacherIntroduce()
        {
            return Introduce() + " I am a teacher.";
        }
    }
}