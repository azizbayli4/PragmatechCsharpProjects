using System;

namespace QuizTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ANumber mynumber = new ANumber(3);
            Console.WriteLine(mynumber);
        }
    }
    public class ANumber
    {
        private int _number = 7;
        public ANumber()
        {

        }
        public ANumber(int number)
        {
            _number = number;
        }
    }
}
