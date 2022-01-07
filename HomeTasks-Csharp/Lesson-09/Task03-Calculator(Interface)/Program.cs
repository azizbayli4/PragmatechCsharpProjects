using System;

namespace Task03_Calculator_Interface_
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine($"Sum of 3,5,6 is :{calculator.Sum(3,5,6)}");
            Console.WriteLine(calculator.Difference(35,8,7));
            Console.WriteLine(calculator.Multiply(4,5,3));
            Console.WriteLine(calculator.Divide(20,5,2));
        }

        interface ISum
        {
            public double Sum(params double[] list);
        }
        interface IMultiply
        {
            public double Multiply(params double[] list);
        }
        interface IDifference
        {
            public double Difference(params double[] list);
        }
        interface IDivide
        {
            public double Divide(params double[] list);
        }


        class Calculator : ISum, IMultiply, IDifference, IDivide
        {
            public double Sum(params double[] list)
            {
                double sum = 0;
                for (int i = 0; i < list.Length; i++)
                {
                    sum += list[i];
                }
                return sum;
            }

             public double Difference(params double[] list)
            {
                double difference = list[0];
                for (int i = 1; i < list.Length; i++)
                {
                    difference -= list[i];
                }
                return difference;
            }

            public double Multiply(params double[] list)
            {
                double multiply = 1;
                for (int i = 0; i < list.Length; i++)
                {
                    multiply *= list[i];
                }
                return multiply;
            }

            public double Divide(params double[] list)
            {
                double divide = list[0];
                for (int i = 1; i < list.Length; i++)
                {
                    divide /= list[i];
                }
                return divide;
            }
        }
    }
}

