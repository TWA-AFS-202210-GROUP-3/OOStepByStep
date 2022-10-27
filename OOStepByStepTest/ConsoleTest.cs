using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Should_return_message_when_given_person()
        {
            Student student = new Student();

            string message = student.Message();

            Assert.Equal("My name is Tom. I am 18 years old.", message);
        }

        [Fact]
        public void Should_return_message_when_given_student()
        {
            Student student = new Student();

            string message = student.Message();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student", message);
        }

        [Fact]
        public void Should_return_message_when_given_teacher()
        {
            Teacher teacher = new Teacher();

            string message = teacher.Message();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", message);
        }
    }
}
