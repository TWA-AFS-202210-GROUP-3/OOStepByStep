using OOStepByStep;
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
            string res = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", res);
        }

        [Fact]
        public void Should_return_name_and_age_and_type_when_given_student_with_name_and_age()
        {
            //given
            Student student = new Student("Tom", 18);
            //when
            string res = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", res);
        }

        [Fact]
        public void Should_return_name_and_age_and_type_when_given_teacher_with_name_and_age()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30);
            //when
            string res = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", res);
        }

        [Fact]
        public void Should_return_name_and_age_and_type_and_class_when_given_student_with_name_and_age_and_class()
        {
            //given
            Student student = new Student("Tom", 18, 2);
            //when
            string res = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", res);
        }

        [Fact]
        public void Should_return_name_and_age_and_type_and_class_when_given_teacher_with_name_and_age_and_class()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30, 2);
            //when
            string res = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", res);
        }
    }
}
