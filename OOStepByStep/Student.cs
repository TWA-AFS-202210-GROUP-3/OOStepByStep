using System;

namespace OOStepByStepTest
{
    public class Student : Person
    {
        private string stuclass;

        public Student(string name, string age) : base(name, age)
        {
        }

        public Student(string name, string age, string stuclass) : base(name, age)
        {
            this.stuclass = stuclass;
        }

        public override string Message()
        {
            if (stuclass == null)
            {
                return base.Message() + " I am a student.";
            }
            else
            {
                return base.Message() + " I am a student" + $" of class {stuclass}.";
            }
        }

        public override string Welcome(Person person)
        {
            if (stuclass == person.Stuclass)
            {
                return Message() + base.Welcome(person);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
