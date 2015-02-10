namespace _02.Bank
{
    public abstract class Customer : ICustomer
    {
        private string id;

        public Customer(string id)
        {
            this.Id = id;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public abstract override string ToString();
    }
}
