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
        public void Should_return_self_introduction_when_introduce_given_a_name_age()
        {
            // given
            Person person = new Person("Tom", 21);

            // when
            string intro = person.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 21 years old.", intro);
        }

        [Fact]
        public void Should_return_self_introduction_when_introduce_given_student_name_age()
        {
            // given
            Student student = new Student("Tom", 21);

            // when
            string intro = student.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", intro);
        }

        [Fact]
        public void Should_return_self_introduction_when_introduce_given_teacher_name_age()
        {
            // given
            Teacher teacher = new Teacher("Amy", 30);

            // when
            string intro = teacher.Introduce();

            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", intro);
        }

        [Fact]
        public void Should_return_self_introduction_when_introduce_given_student_name_age_class()
        {
            // given
            Student student = new Student("Tom", 21, 2);

            // when
            string intro = student.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 2.", intro);
        }

        [Fact]
        public void Should_return_self_introduction_when_introduce_given_teacher_name_age_class()
        {
            // given
            Teacher teacher = new Teacher("Amy", 30, 2);

            // when
            string intro = teacher.Introduce();

            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", intro);
        }
    }
}
