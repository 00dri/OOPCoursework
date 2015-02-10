namespace _03.PcCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Computer
    {
        private string name;
        private List<Component> components;
        private decimal? price;


        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.components = components;
            this.Price = CalculatePrice(this.components);
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name not given!");
                }
                this.name = value;
            }
        }

        public decimal? Price { get; set; }

        private static decimal? CalculatePrice(IEnumerable<Component> comps)
        {
            return comps.Aggregate<Component, decimal?>(0m, (current, comp) => current + comp.Price);
        }

        public void PrintConfiguration()
        {
            string configuration = "PC name: " + this.Name + "\n";
            configuration = this.components.Aggregate(configuration, (current, component) => current + (component.ToString() + "\n"));
            configuration += "Total price: " + this.Price;
            Console.WriteLine(configuration);
        }
    }
}