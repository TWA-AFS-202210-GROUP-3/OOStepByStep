using System;

namespace OOStepByStepTest
{
    public class Teacher : Person
    {
        private string stuclass;

        public Teacher(string name, string age) : base(name, age)
        {
        }

        public Teacher(string name, string age, string stuclass) : base(name, age)
        {
            this.stuclass = stuclass;
        }

        public override string Message()
        {
            if (stuclass == null)
            {
                return base.Message() + " I am a teacher.";
            }
            else
            {
                return base.Message() + " I am a teacher" + $" from class {stuclass}.";
            }
        }
    }
}