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
        private int classno;
        private string name;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classno) : base(name, age)
        {
            this.classno = classno;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Classno
        {
            get { return classno; }
            set { classno = value; }
        }

        public string WelcomeNewStudent(Student student)
        {
            return classno == student.classno ? base.Introduce() + $"I am a student of class {classno}.Welcome {student.name} join class {classno}." : " ";
        }

        public override string Introduce()
        {
            return classno != 0 ?
                base.Introduce() + $"I am a student of class {classno}." :
                base.Introduce() + "I am a student.";
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
