namespace OOStepByStep
{
    public class Student : Person
    {
        private int classNo;
        private string name;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNo) : base(name, age)
        {
            this.classNo = classNo;
            this.name = name;
        }

        public int ClassNo
        {
            get { return classNo; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Introduce()
        {
            return this.classNo != 0 ?
                base.Introduce() + $" I am a student of class {this.classNo}." :
                base.Introduce() + " I am a student.";
        }

        public string WelcomeNewStudent(Student student)
        {
            return this.classNo == student.ClassNo ?
                base.Introduce() + $" I am a student of class {this.classNo}. Welcome {student.Name} join class {this.classNo}." :
                " ";
        }
    }
}