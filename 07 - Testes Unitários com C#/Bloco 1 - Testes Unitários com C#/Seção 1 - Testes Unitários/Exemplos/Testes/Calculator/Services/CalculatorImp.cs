using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class CalculatorImp
    {
        public int Sum(int num1, int num2)
        {
            int calculation = num1 + num2;

            return calculation;
        }

        public int Subtraction(int num1, int num2)
        {
            int calculation = num1 - num2;

            return calculation;
        }

        public int Multiplication(int num1, int num2)
        {
            int calculation = num1 * num2;

            return calculation;
        }

        public int Division(int num1, int num2)
        {
            int calculation = num1 / num2;

            return calculation;
        }
    }
}