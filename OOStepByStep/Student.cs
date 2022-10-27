namespace OOStepByStepTest
{
    public class Student : Person
    {
        private string name;
        private int age;

        public Student(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public string Speak()
        {
            return $"My name is {this.Name}. I am {this.Age} years old. I am a student.";
        }
    }
}