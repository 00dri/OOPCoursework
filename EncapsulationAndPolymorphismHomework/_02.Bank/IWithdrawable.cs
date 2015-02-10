namespace _02.Bank
{
    public interface IWithdrawable
    {
        DepositAccount Withdraw(decimal amount);
    }
}