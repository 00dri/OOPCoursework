namespace _04.CompanyHierarchy
{
    using System;

    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2:C0}", this.ProductName, this.Date, this.Price);
        }
    }
}
