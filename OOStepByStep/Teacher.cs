using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : People
    {
        private int classno;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classno) : base(name, age)
        {
            this.classno = classno;
        }

        public string WelcomeNewStudent(Student student)
        {
            return classno == student.Classno ? base.Introduce() + $" I am a teacher of class {classno}.Welcome {student.Name} join class {classno}." : " ";
        }

        public override string Introduce()
        {
            return classno != 0 ?
                base.Introduce() + $" I am a teacher of class {classno}." :
                base.Introduce() + "I am a teacher.";
            //if (classno == string.Empty && newstudentname == string.Empty)
            //{
            //    return base.Introduce() + "I am a student.";
            //}
            //else if (classno != string.Empty && newstudentname == string.Empty)
            //{
            //    return base.Introduce() + $"I am a student of {classno}";
            //}
            //else
            //{
            //    return base.Introduce() + $"I am a student of {classno}." + $"Welcome {newstudentname} join {classno}.";
            //}
        }
    }
}
