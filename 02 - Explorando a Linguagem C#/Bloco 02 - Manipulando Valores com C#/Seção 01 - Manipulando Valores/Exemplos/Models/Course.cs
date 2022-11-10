using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Course
    {
        public Course(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetNumberOfEnrolledStudents()
        {
            int studentsQuantity = Students.Count;
            return studentsQuantity;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void ListStudents()
        {
            Console.WriteLine($"\n{Name} students:");

            for (int counter = 0; counter < Students.Count; counter++)
            {
                Console.WriteLine($"{counter + 1} - {Students[counter].FullName}.");
            }
        }
    }
}