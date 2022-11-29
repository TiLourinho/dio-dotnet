using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplos.Interfaces;

namespace Exemplos.Models
{
    public class Calculator : ICalculator
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}