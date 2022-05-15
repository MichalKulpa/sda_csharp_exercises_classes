using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new();
            account.IncreaseBalance(100);
            SavingAccount savingAccount = new();
            savingAccount.IncreaseBalance(200);
            savingAccount.IncreaseInterests(0.20M);
            Bank bank = new();
            bank.AddAccount(account);
            bank.AddAccount(savingAccount);
            Console.WriteLine($"Łącznie posiadamy: {bank.GetTotalAmount()}");

            BasicAccount basicAccount1 = new();
            basicAccount1.IncreaseBalance(100);
            BasicAccount basicAccount2 = new();
            basicAccount2.IncreaseBalance(200);
            basicAccount2.IncreaseInterests(0.20M);
            BasicBank basicBank = new();
            basicBank.AddAccount(basicAccount1);
            basicBank.AddAccount(basicAccount2);
            Console.WriteLine($"Łącznie posiadamy: {basicBank.GetTotalAmount()}");
        }
    }
}
