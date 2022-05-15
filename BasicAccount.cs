namespace sda_csharp_exercises_classes
{
    class BasicAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        public virtual void IncreaseBalance(decimal increase)
        {
            balance += increase;
        }       
        private decimal interests;
        public decimal Interests
        {
            get
            {
                return interests;
            }
        }
        public void IncreaseInterests(decimal increase)
        {
            interests += increase;
        }
        public decimal Amount
        {
            get
            {
                if (interests == 0)
                {
                    return balance;
                }
                else
                {
                    return balance * (1 + interests);
                }
            }
        }
    }
}
