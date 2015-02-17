using System;

namespace Customer
{
    public class Payment : ICloneable
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public object Clone()
        {
            var payment = new Payment(this.ProductName, this.Price);
            return payment;
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
