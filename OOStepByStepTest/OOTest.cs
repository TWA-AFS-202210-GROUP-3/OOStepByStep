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
    }
}
