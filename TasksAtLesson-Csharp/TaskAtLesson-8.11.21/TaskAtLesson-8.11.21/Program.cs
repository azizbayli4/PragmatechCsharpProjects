using System;

namespace TaskAtLesson_8._11._21
{
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }
    public class Person
    {
        protected int age;

        public virtual void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {this.age} years old");
        }
    }
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}
