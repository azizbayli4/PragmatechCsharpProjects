using System;

namespace DelegateTask_MonthAndSeasonName_21._11._21_
{
    class Program
    {
        //Delegate
        public delegate void Checker(int n);

        static void Main(string[] args)
        {
            Checker check = new(CheckerEvenOrOdd);
            check += CheckerPositiveOrNegative;
            check += CheckerDivisibleFive;

            //Anonymous
            check += delegate (int n)
            {
                Console.WriteLine($"Number {n} is {(n > 100 ? "greater than 100" : "smaller than 100")}");
            };

            //Invoke
            check.Invoke(15);

            //Methods
            static void CheckerEvenOrOdd(int n)
            {
                Console.WriteLine($"Number {n} is {(n % 2 == 0 ? "even" : "odd")}");
            }
            static void CheckerPositiveOrNegative(int n)
            {
                Console.WriteLine($"Number {n} is {(n > 0 && n != 0 ? "positive" : "negative")}");
            }
            static void CheckerDivisibleFive(int n)
            {
                Console.WriteLine($"Number {n} is {(n % 5 == 0 ? "dvisible by 5" : "not divisible 5")}");
            }
        }
    }
}
