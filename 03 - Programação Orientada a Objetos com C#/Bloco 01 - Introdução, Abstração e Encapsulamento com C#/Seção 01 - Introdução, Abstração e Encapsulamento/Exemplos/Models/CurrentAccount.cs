using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class CurrentAccount
    {
        public CurrentAccount(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            balance = initialBalance;
        }

        public int AccountNumber { get; set; }
        private decimal balance;

        public void Withdraw(decimal value)
        {
            if (balance >= value)
            {
                balance -= value;
                Console.WriteLine("Succesfull withdraw!");
            }
            else
            {
                Console.WriteLine("Desired amount is greater than available balance!");
            }
        }

        public void Statement()
        {
            Console.WriteLine($"Your available balance is: {balance:C}");
        }
    }
}