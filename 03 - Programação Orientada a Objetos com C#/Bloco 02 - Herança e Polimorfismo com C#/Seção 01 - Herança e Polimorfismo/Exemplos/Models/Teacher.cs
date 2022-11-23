using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Teacher : Person
    {
        public decimal Wage { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name}, I'm {Age} years old, I'm a teacher and my monthly salary is {Wage:C}!");
        }
    }
}