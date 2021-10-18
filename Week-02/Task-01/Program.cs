using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)String Substring algorithmini qurun;

            //original
            string myName = "My name is Javad Azizbayli";
            string myName1 = "My name is Javad Azizbayli";

            Console.WriteLine($"The original string is: \n{myName}");

            myName = myName.Substring(7, 15);
            myName1 = myName1.Substring(7);

            Console.WriteLine("\nAfter Substring: ");
            Console.WriteLine($"\nWith both start index(7) and length(15): {myName}");
            Console.WriteLine($"With only start index(7): {myName1}");


            //try-01
            string myName2 = "My name is Javad Azizbayli";
            Console.Write("\nEnter start index: ");
            int startIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter length (if you don't wanna enter length enter 0): ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length == 0)
            {
                myName2 = myName2.Remove(0, startIndex);
            }
            else
            {
                myName2 = myName2.Remove(0, startIndex);
                myName2 = myName2.Remove(length, myName2.Length - length);
            }
            Console.WriteLine(myName2);
        }
    }
}
