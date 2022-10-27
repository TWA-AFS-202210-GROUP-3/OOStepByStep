using System;
using System.IO;
using System.Text;
using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class IntroductionTest
    {
        [Fact]
        public void Should_return_self_introduction_when_introduce_given_name_age()
        {
            // given
            Student student = new Student("Tom", 21);

            // when
            string intro = student.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 21 years old.", intro);
        }
    }
}
