using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3)Verilmis sozun palindrome oldugunu yoxlayan algoritm mes: input: ana, output: ana(soldan ve sagdan eyni oxunur)
            //First try
            Console.WriteLine("Enter a Word: ");
            string str = Console.ReadLine();
            Palindrome(str);

        }
        static string Reverse(string inputStr)
        {
            string reverseStr = "";
            int length = 0;
            length = inputStr.Length - 1;
            while (length >= 0)
            {
                reverseStr += inputStr[length];
                length--;
            }
            return reverseStr;
        }

        static void Palindrome(string inputStr)
        {
            string reverseStr = Reverse(inputStr);
            if (inputStr.ToLower() == reverseStr.ToLower())
            {
                Console.WriteLine($"{inputStr} is palindrome");
            }
            else
                Console.WriteLine($"{inputStr} is not palindrome");
        }
    }
}
