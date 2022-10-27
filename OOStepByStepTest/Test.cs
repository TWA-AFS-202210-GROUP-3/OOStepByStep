namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class Test
    {
        [Fact]
        public void Should_return_introduce_message_when_given_a_person()
        {
            //given
            Person person = new Person("Tom", 21);
            //when
            string introduceMessage = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduceMessage);
        }

        [Fact]
        public void Should_return_introduce_message_when_given_a_teacher()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30);
            //when
            string introduceMessage = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introduceMessage);
        }

        [Fact]
        public void Should_return_introduce_message_when_given_a_student()
        {
            //given
            Student student = new Student("Tom", 18);
            //when
            string introduceMessage = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduceMessage);
        }
    }
}
