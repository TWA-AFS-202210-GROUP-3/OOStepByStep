using System;

namespace OOStepByStepTest
{
    public class Person
    {
        private string name;
        private string age;

        public Person(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Message()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}