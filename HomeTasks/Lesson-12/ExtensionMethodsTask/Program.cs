using System;
using System.Collections.Generic;

namespace ExtensionMethodsTask
{
    static class ExtentioMethods
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] arr = { 1, 2, 3, 4, 5, 56, 1, 5, 1, 2, 1 };
                string str = "sldlsdlsld";

                foreach (var item in arr.GetValueIndexes(1))
                {
                    Console.Write(item + ",");
                }

                Console.WriteLine("\n#####################################");

                foreach (var item in str.GetValueIndexes('l'))
                {
                    Console.Write(item +",");
                }
                Console.WriteLine("\n#####################################");
                
                Console.WriteLine(IsOdd(1));
                Console.WriteLine("#####################################");

                Console.WriteLine(IsEven(1));
                Console.WriteLine("#####################################");

                Console.WriteLine(IsContainsDigit("sa12lam"));
            }
        }

        public static bool IsOdd(this int number)
        {
            if (number % 2 != 0 && number != 0)
                return true;
            else
                return false;
        }

        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        public static bool IsContainsDigit(this string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Convert.ToInt32(text[i]) > 47 && Convert.ToInt32(text[i]) < 58)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<int> GetValueIndexes(this string givenStr, char givenChr)
        {
            List<int> indexes = new();
            for (int i = 0; i < givenStr.Length; i++)
            {
                if (givenStr[i] == givenChr)
                {
                    indexes.Add(i);
                }
            }
            if (indexes.Count != 0)
                return indexes;
            return null;
        }

        public static List<int> GetValueIndexes(this int[] arr, int num)
        {
            List<int> indexes = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    indexes.Add(i);
                }
            }
            if (indexes.Count != 0)
                return indexes;
            return null;
        }
    }
}