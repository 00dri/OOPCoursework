namespace _02.Bank
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer is IndividualCustomer)
            {
                return base.CalculateInterest(months - 6);
            }
            if (this.Customer is CompanyCustomer)
            {
                return base.CalculateInterest(Math.Min(months, 12) / 2 + Math.Max(months - 12, 0));
            }
            return base.CalculateInterest(months);
        }

        public override string ToString()
        {
            return string.Format("Mortgage Account of {0}", base.ToString());
        }
    }
}
