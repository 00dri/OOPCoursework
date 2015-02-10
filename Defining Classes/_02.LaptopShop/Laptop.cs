namespace _02.LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double price;

        public Laptop(string model, double price, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, Battery battery)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;  
        }

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public string Model 
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public string Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return "Laptop model: " + model + "\n" + "Laptop price: " + price;
        }
    }
}
