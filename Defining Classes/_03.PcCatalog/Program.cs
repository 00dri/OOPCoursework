using System.Collections.Generic;
using System.Linq;

namespace _03.PcCatalog
{
    using System;

    public class Program
    {
        static void Main()
        {
            var hdd = new Component("HDD Seagate", 119m, "1TB");
            var ram = new Component("Corsair Vengeance", 211m, "8GB");
            var gpu = new Component("GeForce GTX970", 780.70m, "4096MB");
            var motherboard = new Component("GA-Z97X", 269m, "Intel Z97 Express Chipset");
            var monitor = new Component("Asus VG248QE", 596m, "24 inch");
            var processor = new Component(" Intel Core i7", 764m, "4Ghz");

            var components1 = new List<Component>
            {
                hdd, ram, gpu, motherboard, monitor, processor
            };

            var components2 = new List<Component>
            {
                hdd, gpu, motherboard, processor
            };

            var components3 = new List<Component>
            {
                ram, gpu, monitor, processor
            };

            var pc1 = new Computer("Asus", components1);
            var pc2 = new Computer("Lenovo", components2);
            var pc3 = new Computer("Toshiba", components3);

            var computers = new List<Computer>
            {
                pc1, pc2, pc3
            };

            var sortedComputers = computers.OrderBy(computer => computer.Price).ToList();

            foreach (var sortedComputer in sortedComputers)
            {
                sortedComputer.PrintConfiguration();
                Console.WriteLine();
            }
        }
    }
}
