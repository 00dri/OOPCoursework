namespace _02.LaptopShop
{
    public class Battery
    {
        private string batteryType;
        private string batteryLife;

        public Battery(string batteryType, string batteryLife)
        {
            this.batteryType = batteryType;
            this.batteryLife = batteryLife;
        }

        public Battery(string batteryType)
            : this(batteryType, null)
        { 
        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public string BatteryLife
        {
            get { return this.batteryLife; }
            set { this.batteryLife = value; }
        }
    }
}
