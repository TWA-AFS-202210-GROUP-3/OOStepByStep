using System;

namespace OOStepByStepTest
{
    public class TeacherWelcome : Teacher
    {
        private string name;
        private string age;
        private string stuclass;

        private Student student = new Student(name);

        public TeacherWelcome(string name, string age, string stuclass) : base(name, age, stuclass)
        {
        }
    }
}
