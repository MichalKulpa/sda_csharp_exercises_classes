using System;

namespace sda_csharp_exercises_classes
{
    class BasicBank
    {
        private const int MAX_ACCOUNTS = 10;
        private BasicAccount[] accounts;
        public BasicBank()
        {
            accounts = new BasicAccount[MAX_ACCOUNTS];
        }
        public void AddAccount(BasicAccount account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] is null)
                {
                    accounts[i] = account;
                    return;
                }
            }
            Console.WriteLine("Bank is full");
        }
        public decimal GetTotalAmount()
        {
            decimal sum = 0;
            foreach (var account in accounts)
            {
                if (account is not null)
                {
                    sum += account.Amount;
                }
            }
            return sum;
        }
    }
}
