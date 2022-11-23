using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Student : Person
    {
        public double Grade { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name}, I'm {Age} years old and I'm a grade {Grade} student!");
        }
    }
}