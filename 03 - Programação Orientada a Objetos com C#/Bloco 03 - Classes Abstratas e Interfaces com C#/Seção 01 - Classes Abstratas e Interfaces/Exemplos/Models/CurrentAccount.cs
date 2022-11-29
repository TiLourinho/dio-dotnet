using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class CurrentAccount : Account
    {
        public override void Credit(decimal value)
        {
            balance += value;
        }
    }
}