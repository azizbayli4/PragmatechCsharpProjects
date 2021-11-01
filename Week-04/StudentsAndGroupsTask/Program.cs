using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndGroupsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            bool check = true;
            //int choice;
            while (check)
            {
                Console.WriteLine(
                "\n1 - Create new student" +
                "\n2 - Create new Group" +
                "\n3 - Show all students" +
                "\n4 - Show all groups" +
                "\n5 - Add student in a group" +
                "\n6 - Show student from selected group" +
                "\n7 - Exit\n");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        operations.CreateStudent();
                        break;
                    case "2":
                        operations.CreateGroup();
                        break;
                    case "3":
                        operations.ShowAllStudents();
                        break;
                    case "4":
                        operations.ShowAllGroups();
                        break;
                    case "5":
                        operations.AddStudentToGroup();
                        break;
                    case "6":
                        operations.ShowStudentsFromGroup();
                        break;
                    case "7":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }

    public class Student
    {
        public string studentName;
        public string studentSurname;
        public static int no = 0;
        public int studentID;

        public Student(string name, string surname)
        {
            studentName = name;
            studentSurname = surname;
            studentID = ++no;
        }
    }

    public class Group
    {
        public string groupName;
        public int groupID;
        public static int no = 100;
        public int groupCapacity;
        public readonly List<Student> students = new List<Student>();

        public Group(string name, int capacity)
        {
            groupName = name;
            groupCapacity = capacity;
            groupID = ++no;
        }

        public void AddStudent(Student student)
        {
            Console.WriteLine("\nPlease, enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("\nPlease, enter student surname");
            string surname = Console.ReadLine();
            if(String.IsNullOrEmpty(name) ||String.IsNullOrEmpty(surname))
            {
                Console.WriteLine($"{name} or {surname} is null or emty");
            }

            if (students.Count < groupCapacity)
            {
                //Student student = new Student(name,surname);
                //students.Add(student);
                students.Add(new Student(name, surname));
                Console.WriteLine("New student added");
            }
            else
            {
                Console.WriteLine("Group is full \nDo you want increase group capacity? (y/n)");
                string choice = Console.ReadLine().ToLower().Trim();

                while (choice != "y" || choice != "n" || String.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("Please, enter 'y' or 'n'!");
                }
                if (choice == "y")
                {
                    students.Add(new Student(name, surname));
                    Console.WriteLine("New student added");
                }
            }
        }
    }
    public class Operations
    {
        List<Student> students = new List<Student>();
        List<Group> groups = new List<Group>();

        public void CreateStudent()
        {
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student surname");
            string surname = Console.ReadLine();
            students.Add(new Student(name, surname));

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Name or Surname is null or emty. Try again!");
            }
        }

        public void CreateGroup()
        {
            Console.WriteLine("Enter group name");
            string name = Console.ReadLine();
            int capasity = 0;
            Console.WriteLine("Enter group capasity");
            while (true)
            {
                try
                {
                    capasity = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, enter only digit!");
                }
            }
            groups.Add(new Group(name, capasity));
        }

        public void ShowAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("There is no student \nPlease, add a student");
            }
            else
            {
                foreach (var item in students)
                {
                    Console.WriteLine($"\n{item.studentID}. {item.studentSurname} {item.studentName}");
                }
            }

        }

        public void ShowAllGroups()
        {
            if (groups.Count == 0)
            {
                Console.WriteLine("There is no any group to show \nPlease, create a new group");
            }
            else
            {
                foreach (var item in groups)
                {
                    Console.WriteLine($"{item.groupID}. {item.groupName} \nCapacity:{item.groupCapacity} \nStatus{groups.Count}/{item.groupCapacity}");
                }
            }
        }

        public void AddStudentToGroup()
        {
            int groupNumber;
            int studentNumber;
            Student student = null;
            Group group = null;

            while (true)
            {
                Console.WriteLine("Please enter group ID to choose");
                groupNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter student ID to add");
                studentNumber = Convert.ToInt32(Console.ReadLine());
                if (Convert.ToString(groupNumber) != null || Convert.ToString(studentNumber) != null)
                {
                    Console.WriteLine("Null input");
                    break;
                }
            }

            foreach (var item in groups)
            {
                if (item.groupID == groupNumber)
                {
                    group = item;
                    break;
                }

            }
            foreach (var item in students)
            {
                if (item.studentID == studentNumber)
                {
                    student = item;
                    break;
                }
            }
            if (group == null)
            {
                Console.WriteLine("The group ID you entered doesn't exist");
            }
            else if (student == null)
            {
                Console.WriteLine("The student ID you entered doesn't exist");
            }
            else
            {
                bool flag = true;
                for (int i = 0; i < groups.Count; i++)
                {
                    for (int j = 0; j < groups[i].students.Count; j++)
                    {
                        if (groups[i].students[j].studentID == studentNumber)
                        {
                            flag = false;
                            Console.WriteLine("The student that you want to add is exsist in other group");
                            break;
                        }
                    }
                }
                if (flag)
                {
                    group.AddStudent(student);
                }
            }
        }
        public void ShowStudentsFromGroup()
        {
            Console.WriteLine("Enter group ID to show students in it");
            int groupNumber = Convert.ToInt32(Console.ReadLine());
            if (Convert.ToString(groupNumber) != null)
            {
                Group group = null;
                foreach (var item in groups)
                {
                    if (item.groupID == groupNumber)
                    {
                        group = item;
                        break;
                    }
                }
                if (group != null)
                {
                    foreach (var item in group.students)
                    {
                        Console.WriteLine($"{item.studentID}. {item.studentSurname} {item.studentName}");
                    }
                }
                else
                {
                    Console.WriteLine("Your group did not find!");
                }
            }
            else
            {
                Console.WriteLine("Enter correct data");
            }
        }
    }
}


