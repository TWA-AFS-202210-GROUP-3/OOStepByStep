namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classNo;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNo) : base(name, age)
        {
            this.classNo = classNo;
        }

        public int ClassNo
        {
            get { return classNo; }
        }

        public string Introduce()
        {
            return this.classNo != 0 ?
                base.Introduce() + $" I am a teacher of class {this.classNo}." :
                base.Introduce() + " I am a teacher.";
        }

        public string WelcomeNewStudent(Student student)
        {
            return this.classNo == student.ClassNo ?
                base.Introduce() + $" I am a teacher of class {this.classNo}. Welcome {student.Name} join class {this.classNo}." :
                " ";
        }
    }
}