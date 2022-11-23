using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old!");
        }
    }
}