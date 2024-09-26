namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class OOTest
    {
        [Fact]
        public void Should_return_message_when_given_name_age()
        {
            //give
            People people = new People("Tom", 21);
            //when
            string message = people.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", message);
        }

        [Fact]
        public void Should_return_message_when_given_student_information()
        {
            //give
            Student student = new Student("Tom", 18);
            //when
            string message = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old.I am a student.", message);
        }

        [Fact]
        public void Should_return_message_when_given_teacher_information()
        {
            //give
            Teacher teacher = new Teacher("Amy", 30);
            //when
            string message = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old.I am a teacher.", message);
        }

        [Fact]
        public void Should_return_message_when_given_student_in_calss()
        {
            //give
            Student student = new Student("Tom", 18, 2);
            //when
            string message = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old.I am a student of class 2.", message);
        }

        [Fact]
        public void Should_return_message_when_given_teacher_in_calss()
        {
            //give
            Teacher teacher = new Teacher("Sam", 38, 5);
            //when
            string message = teacher.Introduce();
            //then
            Assert.Equal("My name is Sam. I am 38 years old. I am a teacher of class 5.", message);
        }

        [Fact]
        public void Should_return_message_when_student_see_newstudent_in_calss()
        {
            //give
            Student student = new Student("Tom", 18, 2);
            Student newstudent = new Student("Marry", 16, 2);
            //when
            string message = student.WelcomeNewStudent(newstudent);
            //then
            Assert.Equal("My name is Tom. I am 18 years old.I am a student of class 2.Welcome Marry join class 2.", message);
        }

        [Fact]
        public void Should_return_message_when_teacher_see_newstudent_in_calss()
        {
            //give
            Teacher teacher = new Teacher("Sam", 38, 5);
            Student newstudent = new Student("Bob", 16, 5);
            //when
            string message = teacher.WelcomeNewStudent(newstudent);
            //then
            Assert.Equal("My name is Sam. I am 38 years old. I am a teacher of class 5.Welcome Bob join class 5.", message);
        }
    }
}
