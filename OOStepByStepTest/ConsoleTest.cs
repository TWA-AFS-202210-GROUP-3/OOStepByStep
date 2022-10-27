using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Should_return_message_when_given_person()
        {
            Person student = new Person("Tom", "18");

            string message = student.Message();

            Assert.Equal("My name is Tom. I am 18 years old.", message);
        }

        [Fact]
        public void Should_return_message_when_given_student()
        {
            Person student = new Student("Tom", "18");

            string message = student.Message();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", message);
        }

        [Fact]
        public void Should_return_message_when_given_teacher()
        {
            Teacher teacher = new Teacher("Amy", "30");

            string message = teacher.Message();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", message);
        }

        [Fact]
        public void Should_return_message_when_given_student_have_class()
        {
            Person student = new Student("Tom", "18", "2");

            string message = student.Message();

            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", message);
        }

        [Fact]
        public void Should_return_message_when_given_teacher_have_class()
        {
            Teacher teacher = new Teacher("Amy", "30", "2");

            string message = teacher.Message();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher from class 2.", message);
        }

        [Fact]
        public void Should_return_message_when_given_student_have_class_and_welcome_new()
        {
            Student student = new Student("Tom", "18", "2");
            Person person = new Person("Jim", "18", "2");

            string message = student.Welcome(person);

            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.", message);
        }

        [Fact]
        public void Should_return_message_when_given_student_have_class_and_welcome_new_null()
        {
            Student student = new Student("Tom", "18", "2");
            Person person = new Person("Jim", "18", "3");

            string message = student.Welcome(person);

            Assert.Equal(string.Empty, message);
        }

        [Fact]
        public void Should_return_message_when_given_teacher_have_class_and_welcome_new()
        {
            Teacher teacher = new Teacher("Amy", "30", "2");
            Person person = new Person("Jim", "18", "2");

            string message = teacher.Welcome(person);

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher from class 2. Welcome Jim join class 2.", message);
        }

        [Fact]
        public void Should_return_message_when_given_teacher_have_class_and_welcome_new_null()
        {
            Teacher teacher = new Teacher("Amy", "30", "2");
            Person person = new Person("Jim", "18", "3");

            string message = teacher.Welcome(person);

            Assert.Equal(string.Empty, message);
        }
    }
}
