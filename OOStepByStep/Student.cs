using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Student : People
    {
        public Student(string name, int age, string classno) : base(name, age, classno)
        {
        }

        public override string Introduce()
        {
            if (Classno == string.Empty)
            {
                return base.Introduce() + " I am a student.";
            }
            else
            {
                return base.Introduce() + " I am a student of " + Classno;
            }
        }
    }
}
