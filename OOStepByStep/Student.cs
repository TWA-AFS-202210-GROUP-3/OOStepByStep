namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
            ClassName = string.Empty;
        }

        public string ClassName { get; set; }

        public override string Introduce()
        {
            return base.Introduce() + " I am a student" + (ClassName.Length == 0 ? "." : $" of {ClassName}.");
        }

        public void BelongTo(Class studentClass)
        {
            ClassName = studentClass.Name;
            studentClass.Students.Add(this);
        }
    }
}