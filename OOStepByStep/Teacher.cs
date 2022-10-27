namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
            ClassName = string.Empty;
        }

        public string ClassName { get; set; }

        public override string Introduce()
        {
            return base.Introduce() + " I am a teacher" + (ClassName.Length == 0 ? "." : $" of {ClassName}.");
        }

        public void BelongTo(Class teacherClass)
        {
            ClassName = teacherClass.Name;
            teacherClass.Teacher = this;
        }
    }
}