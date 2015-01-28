using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Account
    {
        public string name;
        public string number;
        public double balance=0;

        public double DepositAmount(double amount)
        {
            balance += amount;
            return balance;
        }

        public double WithdrawAmount(double amount)
        {
            balance -= amount;
            return balance;
        }

        public string GetReport()
        {
            string message = name + ", your account number is: "+ number+ " and it's balance is: " + balance;
            return message;
        }
    }
}