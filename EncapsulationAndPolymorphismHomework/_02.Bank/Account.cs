namespace _02.Bank
{
    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public Account Deposit(decimal amount)
        {
            this.Balance += amount;
            return this;
        }

        public virtual decimal CalculateInterest(decimal months)
        {
            if (!(months > 0))
            {
                return 0;
            }
            return this.Balance * this.InterestRate * months;
        }

        public override string ToString()
        {
            return string.Format("{0} \nBalance: {1:C0} \nInterest rate: {2:P}", this.Customer, this.Balance, this.InterestRate);
        }
    }
}
