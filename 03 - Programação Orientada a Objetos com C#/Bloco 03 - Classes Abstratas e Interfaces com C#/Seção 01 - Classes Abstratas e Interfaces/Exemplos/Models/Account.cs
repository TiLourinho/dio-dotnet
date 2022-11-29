using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public abstract class Account
    {
        protected decimal balance;

        public abstract void Credit(decimal value);

        public void Statement()
        {
            Console.WriteLine($"Your balance is: {balance:C}");
        }
    }
}