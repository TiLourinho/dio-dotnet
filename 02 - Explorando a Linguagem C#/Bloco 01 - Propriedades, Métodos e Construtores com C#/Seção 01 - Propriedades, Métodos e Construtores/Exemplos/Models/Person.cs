using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Person
    {
        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        private string _name;
        private int _age;

        public string Name
        {
            get => _name;

            set
            {
                if (value == "" || value.Length < 2)
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                _name = value;
            }
        }

        public string LastName { get; set; }
        public string FullName => $"{Name} {LastName}";

        public int Age
        {
            get => _age;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than zero");
                }

                _age = value;
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"My name is {FullName} and I am {Age} years old.");
        }
    }
}