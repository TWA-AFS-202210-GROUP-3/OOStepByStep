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
        private string classno;

        public People(string name, int age, string classno)
        {
            this.name = name;
            this.age = age;
            this.classno = classno;
        }

        public string Name
        {
            get { return name; } set { name = value; }
        }

        public int Age
        {
            get { return age; } set { age = value; }
        }

        public string Classno
        {
            get { return classno; } set { classno = value; }
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}
