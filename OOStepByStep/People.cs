using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class People
    {
        private string name;
        private int age;
        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Introduce()
        {
            // return name + ": speed up " + speed.ToString() + " " + "km/h";
            return $"My name is {name}. I am {age} years old.";
        }
    }
}
