using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : People
    {
        private string classno;
        private string newstudentname;
        public Teacher(string name, int age, string classno, string newstudentname) : base(name, age)
        {
            this.classno = classno;
            this.newstudentname = newstudentname;
        }

        public override string Introduce()
        {
            if (classno == string.Empty && newstudentname == string.Empty)
            {
                return base.Introduce() + "I am a teacher.";
            }
            else if (classno != string.Empty && newstudentname == string.Empty)
            {
                return base.Introduce() + $"I am a teacher of {classno}";
            }
            else
            {
                return base.Introduce() + $"I am a teacher of {classno}." + $"Welcome {newstudentname} join {classno}.";
            }
        }
    }
}
