using System;

namespace Task01_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ali", "Aliyev", 38);
            Student student1 = new Student("Lale", "Velili", 52);
            Student student3 = new Student("Lale2", "Velili", 25);
            Student student4 = new Student("Lale3", "Velili", 44);
            Student.Counter();
        }
    }

    class Student
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        private static int num;

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

            ++num;
        }
        public static void Counter()
        {
            Console.WriteLine($"Initialized {num} time(s)");
        }
    }
}
