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
        private string classno;
        private string newstudentname;
        public Student(string name, int age, string classno, string newstudentname) : base(name, age)
        {
            this.classno = classno;
            this.newstudentname = newstudentname;
        }

        public override string Introduce()
        {
            if (classno == string.Empty && newstudentname == string.Empty)
            {
                return base.Introduce() + "I am a student.";
            }
            else if (classno != string.Empty && newstudentname == string.Empty)
            {
                return base.Introduce() + $"I am a student of {classno}";
            }
            else
            {
                return base.Introduce() + $"I am a student of {classno}" + $"Welcome {newstudentname} join {classno} ";
            }
        }
    }
}
