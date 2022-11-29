using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Interfaces
{
    public interface ICalculator
    {
        // Métodos que não tem "corpo" serão obrigados a serem implementados na classe que implementará a interface. Caso contrário é opcional.

        int Sum(int number1, int number2);
        int Subtract(int number1, int number2);
        int Multiply(int number1, int number2);
        int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}