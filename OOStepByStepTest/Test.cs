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
        public void Should_return_introduce_message_when_given_a_teacher_with_classNo()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30, 2);
            //when
            string introduceMessage = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", introduceMessage);
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

        [Fact]
        public void Should_return_introduce_message_when_given_a_student_with_classNo()
        {
            //given
            Student student = new Student("Tom", 18, 2);
            //when
            string introduceMessage = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", introduceMessage);
        }

        [Fact]
        public void Should_return_teacher_welcome_message_when_given_a_student_with_same_classNo()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30, 2);
            Student newstudent = new Student("Jim", 20, 2);
            //when
            string welcomeMessage = teacher.Welcome(newstudent);
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.", welcomeMessage);
        }

        [Fact]
        public void Should_return_student_welcome_message_when_given_a_student_with_same_classNo()
        {
            //given
            Student student = new Student("Tom", 18, 2);
            Student newstudent = new Student("Jim", 20, 2);
            //when
            string welcomeMessage = student.Welcome(newstudent);
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.", welcomeMessage);
        }
    }
}
