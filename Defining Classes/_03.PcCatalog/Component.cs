namespace _03.PcCatalog
{
    using System;

    public class Component
    {
        private string name;
        private decimal? price;


        public Component(string name, decimal? price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public string Details { get; set; }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be a positive number!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return this.Name + ", " + (this.Details != null ? this.Details + ", " : "") + this.Price + " BGN";
        }
    }
}
