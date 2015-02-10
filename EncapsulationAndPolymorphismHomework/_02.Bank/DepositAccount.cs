namespace _02.Bank
{
    public class DepositAccount : Account, IWithdrawable
    {
        private const int MinBalance = 0;
        private const int MaxBalance = 1000;

        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public DepositAccount Withdraw(decimal amount)
        {
            this.Balance -= amount;

            return this;
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (MinBalance < this.Balance && this.Balance < MaxBalance)
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }

        public override string ToString()
        {
            return string.Format("Deposit Account of {0}", base.ToString());
        }
    }
}
