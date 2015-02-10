namespace _02.Bank
{
    public interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
        Account Deposit(decimal amount);
        decimal CalculateInterest(decimal months);
    }
}