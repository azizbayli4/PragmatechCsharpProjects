using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string> { "tea", "falcon", "book", "sky" };

            Console.WriteLine("Before:");
            words.ForEach(System.Console.WriteLine);

            //for (int i = 0; i < words.Count; i++)
            //{
            //    if (words.Contains("tea"))
            //    {
            //        words.Remove("tea");
            //    }
            //}
            //Console.WriteLine("After1:");
            //words.ForEach(System.Console.WriteLine);


            //foreach (var item in words.ToList())
            //{
            //    if (words.Contains("book"))
            //    {
            //        words.Remove("book");
            //    }
            //}
            //Console.WriteLine("After2:");
            //words.ForEach(System.Console.WriteLine);

            Console.WriteLine("--------------********************--------------");
            words.ForEach(delegate (string word) {
                Console.WriteLine(word);
            });
           
        }

        //public static List<string> StringFilter(string ls, StringFilterDelegate del)
        //{
        //    // Funksiya aşağıdakı əməlyatları yerinə yetirə bilməlidir
        //    // List daxilindəki sözlərdən hərf sayı 5-dən böyük olanlar
        //    // Daxilində ən az bir ədəd böyük hərf olanlar
        //    // Baş hərfi böyük olanlar
        //    // Daxilində ə hərfi olanlar
        //}
    }
}
