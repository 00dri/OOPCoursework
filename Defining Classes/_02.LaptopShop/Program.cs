namespace _02.LaptopShop
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var laptop = new Laptop("Toshiba", 120.99);
            Console.WriteLine(laptop);
        }
    }
}
