namespace _04.CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private int netPurchaseAmount;

        public Customer(string id, string firstName, string lastName, int netPurchaseAmount) 
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public int NetPurchaseAmount
        {
            get { return netPurchaseAmount; }
            set { netPurchaseAmount = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1:C}", base.ToString(), this.NetPurchaseAmount);
        }
    }
}
