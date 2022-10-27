namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_message_when_person_introduce_oneself_given_name_Tom_and_age_21()
        {
            //given
            Person person = new Person("Tom", 21);

            //when
            var message = person.Introduce();

            //then
            Assert.Equal("My name is Tom. I am 21 years old.", message);
        }

        [Fact]
        public void Should_return_message_when_student_introduce_oneself_given_name_Tom_and_age_21()
        {
            //given
            Student student = new Student("Tom", 21);

            //when
            var message = student.Introduce();

            //then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", message);
        }
    }
}
