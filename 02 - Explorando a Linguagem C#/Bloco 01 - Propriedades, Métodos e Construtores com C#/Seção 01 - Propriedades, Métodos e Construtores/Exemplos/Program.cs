using Exemplos.Models;

Person person1 = new(name: "Alex", lastName: "Green", age: 29);
person1.Introduce();

Person person2 = new(name: "Beth", lastName: "Grey", age: 25);
person2.Introduce();

Person person3 = new(name: "Cyrus", lastName: "Jordan", age: 41);
person3.Introduce();

Course englishCourse = new(name: "Flying Hawk");
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(person1);
englishCourse.AddStudent(person2);
englishCourse.AddStudent(person3);
Console.WriteLine($"\n{englishCourse.Name} number of enrolled students: {englishCourse.GetNumberOfEnrolledStudents()}.");
englishCourse.ListStudents();