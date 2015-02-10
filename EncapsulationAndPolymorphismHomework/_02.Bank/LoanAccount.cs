namespace _02.Bank
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer is IndividualCustomer)
            {
                return base.CalculateInterest(months - 3);
            }
            if (this.Customer is CompanyCustomer)
            {
                return base.CalculateInterest(months - 2);
            }
            return base.CalculateInterest(months);
        }

        public override string ToString()
        {
            return string.Format("Loan Account of {0}", base.ToString());
        }
    }
}
