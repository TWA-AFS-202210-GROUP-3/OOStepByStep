using System.Xml.Linq;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;
        private string role;
        public Person(string name, int age, string role)
        {
            this.name = name;
            this.age = age;
            this.role = role;
        }

        public string Introduce()
        {
            return $"My name is {name}. I am {age} years old. I am a {role}.";
        }
    }
}