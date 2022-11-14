using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }

        private string _firstName;
        private string _lastName;
        private int _age;

        public string FirstName
        {
            get => _firstName;

            set
            {
                if (value == "" || value.Length < 2)
                {
                    throw new ArgumentException("First name cannot be empty");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;

            set
            {
                if (value == "" || value.Length < 2)
                {
                    throw new ArgumentException("Last name cannot be empty");
                }

                _lastName = value;
            }
        }

        public string FullName => $"{FirstName} {LastName}";

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