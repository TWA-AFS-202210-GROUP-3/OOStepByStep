using System.Collections.Generic;

namespace OOStepByStep
{
    public class Class
    {
        public Class(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public Teacher Teacher { get; set; }
    }
}