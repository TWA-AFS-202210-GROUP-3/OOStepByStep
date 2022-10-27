using System;

namespace OOStepByStepTest
{
    public class Teacher
    {
        private string name;
        private string age;

        public Teacher(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public string Message()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}