using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Bank_Account
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
    }
}
