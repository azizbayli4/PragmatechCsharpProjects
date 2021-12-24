using System;
using System.Collections.Generic;

namespace QueueTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> strQ = new Queue<string>();

            strQ.Enqueue("Abc1");
            strQ.Enqueue("Abc2");
            strQ.Enqueue("Abc3");
            strQ.Enqueue("Abc4");
            strQ.Enqueue("Abc5");
            strQ.Enqueue("Abc6");
            strQ.Enqueue("Abc7");
            strQ.Enqueue("Abc8");
            strQ.Enqueue("Abc9");
            strQ.Enqueue("Abc10");

            foreach (var item in strQ)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n##################################################\n");

            AddQueue("abc11");


            foreach (var item in strQ)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n##################################################\n");


            AddQueue("abc12");


            foreach (var item in strQ)
            {
                Console.WriteLine(item);
            }


            void AddQueue(string item)
            {
                if (strQ.Count < 10)
                {
                    strQ.Enqueue(item);
                }
                else
                {
                    RemoveLast(strQ);
                    strQ.Enqueue(item);
                }
            }

            string RemoveLast(Queue<string> q)
            {
                string first = q.Peek();
                string current;
                while (true)
                {
                    current = q.Dequeue();
                    if (q.Peek() == first)
                    {
                        break;
                    }
                    q.Enqueue(current);
                }
                return current;
            }
        }
    }
}
