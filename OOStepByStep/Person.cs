using System;

namespace OOStepByStepTest
{
    public class Person
    {
        private string name;
        private string age;
        public string Stuclass;

        public Person(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, string age, string stuclass)
        {
            this.name = name;
            this.age = age;
            this.Stuclass = stuclass;
        }

        public virtual string Message()
        {
            return $"My name is {name}. I am {age} years old.";
        }

        public virtual string Welcome(Person person)
        {
            return $" Welcome {person.name} join class {person.Stuclass}.";
        }
    }
}