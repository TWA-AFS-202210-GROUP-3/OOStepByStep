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
    }
}
