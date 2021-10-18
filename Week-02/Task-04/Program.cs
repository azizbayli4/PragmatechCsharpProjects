using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4)Remove duplicate data algoritmini yazin input: csharpcorner, output: csharpone c
            Console.WriteLine("Enter a Word: ");
            string str = Console.ReadLine();

            //str=str.ToLower(); 

            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            { 
                if (!str2.Contains(str[i]))
                {
                    str2 += str[i];
                }
            }
            Console.WriteLine(str2);
        }
    }
}
