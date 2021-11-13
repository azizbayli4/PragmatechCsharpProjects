using System;

namespace Task01_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ali", "Aliyev", 38);
            student.Counter();
            Console.WriteLine("---------------");
            Student student1 = new Student("Lale", "Velili", 52);
            student1.Counter();
        }
    }

    class Student
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public static int num;
        private int Total;

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

            Total = ++num;
        }
        public void Counter()
        {
            Console.WriteLine($"Initialized {Total} time(s)");
        }
    }
}
