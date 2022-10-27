namespace OOStepByStep
{
    public class Student : Person
    {
        private int classNo;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNo) : base(name, age)
        {
            this.classNo = classNo;
        }

        public string Introduce()
        {
            return this.classNo != 0 ?
                base.Introduce() + $" I am a student of class {this.classNo}." :
                base.Introduce() + " I am a student.";
        }
    }
}