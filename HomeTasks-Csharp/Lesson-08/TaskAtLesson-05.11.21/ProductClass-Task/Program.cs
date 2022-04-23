using System;

namespace ProductClass_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milk1 = new Milk("Milla");
            milk1.Price = 10;
            milk1.Count = 12;
            milk1.Sell(1);
            milk1.Sell(5);
            milk1.Sell(15);
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        private double InCome { get; set; }

        public Product(string name)
        {
            this.Name = name;
        }

        public void Sell(int productCount)
        {
            if (Count != 0 && Count >= productCount)
            {
                Count -= productCount;
                double resultPrice = productCount * Price;
                InCome += resultPrice;
                Console.WriteLine($"Selled {productCount} product and Total income is {InCome}");
                Console.WriteLine("Remain product count:" + Count);
            }
            else
                Console.WriteLine("There is no product");
        }
    }
    public class Milk : Product
    {
        public double Volume { get; set; }
        public string FatRate { get; set; }

        public Milk(string name) : base(name)
        {

        }
    }
}

