using System;
using System.Collections;

namespace Task_2._01
{
    class Program
    {
        static void Main(string[] args)
        {
            static int StudentsCount(string groupNumber, Student[] students)
            {
                int sum = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    if (groupNumber == students[i].groupNo)
                    {
                        sum++;
                    }
                }
                return sum;
            }

            Console.Write("Enter how many students you wanna add: ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student details\n");
            Student[] students = new Student[studentCount];
            ArrayList students1 = new ArrayList();
            try
            {
                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine("Enter fullname: ");
                    string fullName = Console.ReadLine();
                    Console.WriteLine("Enter group number: ");
                    string groupNumber = Console.ReadLine();
                    Console.WriteLine("Enter age: ");
                    byte age = Convert.ToByte(Console.ReadLine());

                    Student student = new Student(fullName, groupNumber, age);
                    students[i] = student;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You entered invalid data");
            }


            Console.Write("\n\nEnter the group number to get count of students: ");
            string groupNo = Console.ReadLine();
            Console.WriteLine($"In group {groupNo } studies {StudentsCount(groupNo, students)} student(s)");

            Console.Write("\n\nWhich student you wanna get birth year, eneter full name: ");
            string enteredStudent = Console.ReadLine();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].fullName == enteredStudent)
                {
                    Console.WriteLine($"{students[i].fullName}'s birthyear is {students[i].GetBirthYear()}");
                }
            }
        }
    }

    public class Student
    {
        public string fullName;
        public string groupNo;
        public int age;
        public Student(string fullName, string groupNo, int age)
        {
            this.fullName = fullName;
            this.groupNo = groupNo;
            this.age = age;
        }
        public int GetBirthYear()
        {
            DateTime date = DateTime.Today;
            return date.Year - this.age;
        }
    }

}

