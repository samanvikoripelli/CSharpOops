using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal initialbalance = 0)
        {
            balance= initialbalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}.new balance {balance} ");
            }
            else 
            {
                Console.WriteLine("Deposited amount is sufficient");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount is insufficient");
            }
            else if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal {amount}.new balance {balance}");
            }
            else
            {
                Console.WriteLine("sufficient balance");
            }
        }
        public decimal GetBalance()
        {
            return balance;
        }

    }

}
