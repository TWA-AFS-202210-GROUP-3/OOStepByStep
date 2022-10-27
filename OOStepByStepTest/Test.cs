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
    }
}
