using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class StepByStepTest
    {
        [Fact]
        public void Should_return_name_and_age_when_given_person_with_name_and_age()
        {
            //given
            Person person = new Person("Tom", 21);
            //when
            string res = person.Speak();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", res);
        }

        [Fact]
        public void Should_return_name_and_age_and_type_when_given_student_with_name_and_age()
        {
            //given
            Student student = new Student("Tom", 18);
            //when
            string res = student.Speak();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", res);
        }
    }
}
