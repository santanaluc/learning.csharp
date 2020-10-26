using Exercicio12.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio12.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
             Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (WithDrawLimit < amount)
            {
                throw new DomainException("Withdraw error: The amount exceedss withdraw limit.");
            } 
            if (Balance < amount)
            {
                throw new DomainException("Withdraw error: Not enough balance.");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2");
        }
    }
}
