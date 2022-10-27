using System;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classNumber;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNumber) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public string TeacherIntroduce()
        {
            return this.classNumber != 0 ?
                    Introduce() + $" I am a teacher of class {classNumber}." :
                    Introduce() + " I am a teacher.";
        }
    }
}