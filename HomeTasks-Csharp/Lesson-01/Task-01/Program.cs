using System;

namespace _11._10._21_Hometasks_Pragmatech_Csharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Numerical Avarage

            //1)5 ədədin orta qiymətinin tapılması algoritmi qurun;
            Console.WriteLine("\nPlease, enter 5 number to calculate numerical avarage: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The numeric avarage of {x},{y},{z},{k},{j} is {NumericAvarage(x, y, z, k, j)}");

            #endregion
            Console.WriteLine("\n################################################################\n");
            #region Perimeter&Area

            //2)Düzbucaqlının sahə və perimetrini tapan algoritmi qurun;
            Console.WriteLine("Please enter the length & width of rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Perimeter of {length},{width} sized rectangle is {PerimeterOfRectangle(length, width)} \nArea of {length},{width} sized rectangle is {AreaOfRectangle(length, width)} ");

            #endregion
            Console.WriteLine("\n################################################################\n");
            #region TheMultiplicationTable

            //3)Daxil edilən ədədin vurma cədvəlini yazdiran algoritmi qurun;
            Console.Write("Please, enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            MultiplicationTable(num);

            #endregion
            Console.WriteLine("\n################################################################\n");
            #region task-4

            ////4)1 le verilmis eded arasinda kvadratlari cemi algoritmini qurun;
            Console.Write("Please, enter limit number: ");
            int limNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Total of squares of numbers from 1 to {limNum} is {SumOfSquare(limNum)}");

            #endregion
            Console.WriteLine("\n################################################################\n");
            #region Task-5

            //5)0 la verilmiş ədəd arasındaki ədədlərin hasili ilə cəminin fərqini hesablayan algoritmi qurun;
            Console.Write("Please, enter limit number: ");
            int tillNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Subtraction of multiplication and sum of numbers from 0 till {tillNum} is {SubtractionOfNums(tillNum)}");

            #endregion
        }

        static float NumericAvarage(int a, int b, int c, int d, int e)
        {
            float avrg = (a + b + c + d + e) / 5;
            return avrg;
        }

        static int PerimeterOfRectangle(int a, int b)
        {
            return (a + b) * 2;
        }
        static int AreaOfRectangle(int a, int b)
        {
            return a * b;
        }

        static void MultiplicationTable(int _num)
        {
            for (int i = 0; i <= 10; i++)
            {
                int result = i * _num;
                Console.WriteLine($"{_num} * {i} = {result}");
            }
        }

        static int SumOfSquare(int _limNum)
        {
            int result = 0;
            for (int i = 1; i < _limNum; i++)
            {
                result += i * i;
            }
            return result;
        }

        static int SubtractionOfNums(int _tillNum)
        {
            int addTotal = 0;
            int mulpTotal = 1;

            for (int i = 1; i < _tillNum; i++)
            {
                mulpTotal *= i;
                addTotal += i;
            }
            int difference = mulpTotal - addTotal;
            return difference;

        }
    }
}
