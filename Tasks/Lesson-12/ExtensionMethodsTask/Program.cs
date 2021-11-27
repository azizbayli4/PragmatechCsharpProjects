using System;
using System.Collections.Generic;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string password = "adssddds202";
            int number = 25;
            My.NoteOutput($"Resault => {password.IsContainsDigit()}");
            My.NoteOutput($"Resault => {number.IsOdd()}");
            My.NoteOutput($"Resault => {number.IsEven()}");
            foreach (var item in password.GetValueIndexes('d'))
            {
                My.NoteOutput($"Resault => {item}");
            }

            List<int> numbs = new List<int>
            {
                5,
                6,
                5,
                7,
                5
            };


            foreach (var item in numbs.GetValueIndexes(5))
            {
                My.NoteOutput($"Resault => {item}");
            }



        }
    }
    class IsNotZeroCountException : Exception
    {
        private readonly string _message;
        public IsNotZeroCountException(string message)
        {
            this._message = message;
        }

        public override string Message => this._message;
    }
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int number) => number % 2 == 1;
        public static bool IsEven(this int number) => number % 2 == 0;

        public static List<int> GetValueIndexes(this List<int> number_list, int number)
        {
            List<int> num_lists = new List<int>();

            for (int i = 0; i < number_list.Count; i++)
            {
                if (number_list[i] == number)
                {
                    num_lists.Add(i);
                }
            }

            return num_lists;
        }

        public static List<int> GetValueIndexes(this string str, char ch)
        {
            List<int> number_list = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    number_list.Add(i);
                }
            }

            return number_list;
        }

        public static bool IsContainsDigit(this string str)
        {
            bool isContainDigit = false;
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                {
                    isContainDigit = true;
                    break;
                }

            }

            return isContainDigit;
        }


    }
    public static class My
    {
        public static int ConsInputInt()
        {
            int number = 0;
            bool break_loop;
            do
            {
                try
                {
                    Console.Write("Input a number : <<<<<< : ");
                    number = Convert.ToInt32(Console.ReadLine());
                    break_loop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("You don't use full number and don't use number !");
                    break_loop = true;
                }

            } while (break_loop);

            return number;
        }

        public static string ConsInputString()
        {
            Console.Write("Input text : <<<<<< : ");
            string str = Console.ReadLine();

            return str;
        }

        public static bool IsContinueLoop()
        {
            bool is_continue;
            Console.Write("<<<<<< Are you continue or exit => (Any case / n ) <<< : ");
            string str = Console.ReadLine();
            if (str == "n")
            {
                is_continue = true;
            }
            else
            {
                is_continue = false;
            }

            return is_continue;
        }

        public static void NoteHead(string str)
        {
            Console.WriteLine($"\n---------- >>>>>>>>>> {str} <<<<<<<<<<< ----------");
        }
        public static void NoteInput(string str)
        {
            Console.WriteLine($"<<<<<<<<<<<<< : {str}");
        }
        public static void NoteOutput(string str)
        {
            Console.WriteLine($">>>>>>> : {str}");
        }

    }
}