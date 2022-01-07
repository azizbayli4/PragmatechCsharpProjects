using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("baker", 20, 15);
            Console.WriteLine(product.name);
            Console.WriteLine(product.code);
            Console.WriteLine(product.TotalPrice());
            Product product2 = new Product("cake", 30, 25);
            Console.WriteLine(product2.name);
            Console.WriteLine(product2.code);
            Console.WriteLine(product2.TotalPrice());
        }
    }
    public class Product
    {
        public string name;
        public int price;
        public int disCountedPrice;
        public string code;
        public static int num=1000;

        public Product(string name, int price, int disCountedPrice)
        {
            this.name = name;
            this.price = price;
            this.disCountedPrice = disCountedPrice;
            code = this.name.Remove(1) + Convert.ToString(num++);        
        }

        public int TotalPrice()
        {
            int totalPrice = this.disCountedPrice + this.price;
            return totalPrice;
        }
    }
}