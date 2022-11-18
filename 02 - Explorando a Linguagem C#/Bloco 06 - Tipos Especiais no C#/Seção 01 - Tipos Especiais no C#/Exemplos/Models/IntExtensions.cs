using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public static class IntExtensions
    {
        // O "this" neste caso possibilita que todo int terá o método EvenOrOdd extendido à ele
        public static bool EvenOrOdd(this int number)
        {
            return number % 2 == 0;
        }
    }
}