using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2)Reverse algoritmi qurun: input: hello, output: olleh

            Console.WriteLine("Enter a Word: ");
            string str = Console.ReadLine();
           
            Console.WriteLine($"Reverse word is: \n{Reverse(str)}");
        }

        static string Reverse(string inputStr)
        {
            string reverseStr = "";
            int length = 0;
            length = inputStr.Length - 1;
            while (length >= 0)
            {
                reverseStr +=  inputStr[length];
                length--;
            }
            return reverseStr;
        }
    }
}
