namespace _02.Bank
{
    using System;

    class Program
    {
        static void Main()
        {
            var pesho = new IndividualCustomer("2wsxsw2", "Pesho", "Peshev");
            var peshoCo = new CompanyCustomer("3edcde3", "Pesho&Co");

            var peshoAccount = new DepositAccount(pesho, 900m, 0.01m);
            var peshoCoAccount = new LoanAccount(peshoCo, 9000m, 0.02m);

            Console.WriteLine(peshoCoAccount);
            Console.WriteLine();
            Console.WriteLine(peshoAccount);
            
            Console.WriteLine("\nInterest calculations before and after deposit: ");
            var calculatePeshoInterest = peshoAccount.CalculateInterest(30);
            Console.WriteLine("Interest at {0:C0}: {1:C0}",peshoAccount.Balance,calculatePeshoInterest);
            peshoAccount.Deposit(800);
            //Console.WriteLine(peshoAccount);
            var calculatePeshoInterestAfterDeposit = peshoAccount.CalculateInterest(30);
            Console.WriteLine("Interest at {0:C0}: {1:C0}", peshoAccount.Balance, calculatePeshoInterestAfterDeposit);
            peshoAccount.Withdraw(300);
            var calculatePeshoInterestAfterWithdraw = peshoAccount.CalculateInterest(30);
            Console.WriteLine("Interest at {0:C0}: {1:C0}", peshoAccount.Balance, calculatePeshoInterestAfterWithdraw);
        }
    }
}
