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
        public void Should_return_self_introduction_when_introduce_given_student_name_age()
        {
            // given
            Student student = new Student("Tom", 21, "student");

            // when
            string intro = student.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", intro);
        }

        [Fact]
        public void Should_return_self_introduction_when_introduce_given_teacher_name_age()
        {
            // given
            Teacher teacher = new Teacher("Amy", 30, "teacher");

            // when
            string intro = teacher.Introduce();

            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", intro);
        }
    }
}
