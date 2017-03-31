using System;

namespace Betterspecs.Demo.Model
{
    internal class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public void Credit(decimal value)
        {
            Balance += value;
        }

        public void Debit(decimal value)
        {
            if (Balance <= 0)
                throw new InvalidOperationException();

            Balance -= value;
        }
    }
}
