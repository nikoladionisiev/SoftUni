﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Test_Client
{
    class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.Id}, balance {this.Balance:F2}";
        }
    }
}
