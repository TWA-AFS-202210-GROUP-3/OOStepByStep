using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : People
    {
        public Teacher(string name, int age, string classno) : base(name, age, classno)
        {
        }

        public override string Introduce()
        {
            if (Classno == string.Empty)
            {
                return base.Introduce() + "I am a teacher.";
            }
            else
            {
                return base.Introduce() + "I am a teacher." + " I am a teacher of" + Classno;
            }
        }
    }
}
