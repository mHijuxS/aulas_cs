using ExPropException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPropException.Entities
{
    internal class Account
    {
        public string Holder { get; set; }

        public int Number { get; set; }

        public double Balance { get; set; }

        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(string holder, int number, double balance, double withdrawLimit)
        {
            Holder = holder;
            Number = number;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }else if (Balance < amount)
            {
                throw new DomainException("Not enouh balance");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
