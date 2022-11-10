using Exemplos.Models;
using System.Globalization;

List<Person> people = new();

Person person1 = new(firstName: "Alex", lastName: "Green", age: 29);
person1.Introduce();
people.Add(person1);

Person person2 = new(firstName: "Beth", lastName: "Grey", age: 25);
person2.Introduce();
people.Add(person2);

Person person3 = new(firstName: "Cyrus", lastName: "Jordan", age: 41);
person3.Introduce();
people.Add(person3);

Person person4 = new(firstName: "Heather", lastName: "Becker", age: 43);
person4.Introduce();
people.Add(person4);

Person person5 = new(firstName: "Olga", lastName: "Fischer", age: 26);
person5.Introduce();
people.Add(person5);

Course englishCourse = new(name: "Flying Hawk");
englishCourse.Students = new List<Person>();

foreach (Person student in people)
{
    englishCourse.AddStudent(student);
}

Console.WriteLine($"\n{englishCourse.Name} number of enrolled students: {englishCourse.GetNumberOfEnrolledStudents()}.");
englishCourse.ListStudents();

/* Formatando valores monetários */

decimal monetaryValue = 82.40M;

Console.WriteLine(monetaryValue); // 82,40

// Formatando :C (Currency). Atualiza na "cultura" da região configurada no sistema automaticamente
Console.WriteLine($"{monetaryValue:C}"); // R$ 82,40

/* Alterando a localização do código */

// using System.Globalization
CultureInfo.DefaultThreadCurrentCulture = new("pt-BR");

Console.WriteLine($"{monetaryValue:C}");

/* Alterando a localização da cultura */

Console.WriteLine(monetaryValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

/* Formatação personalizada */

Console.WriteLine(monetaryValue.ToString("C1")); // R$ 82,4
Console.WriteLine(monetaryValue.ToString("C3")); // R$ 82,400
Console.WriteLine(monetaryValue.ToString("N2")); // 82.40

/* Representando porcentagem */

double percentage = .3421;
Console.WriteLine(percentage.ToString("P")); // 34,21%

int number = 123456;
Console.WriteLine(number.ToString("##-##-##"));

int cellNumber = 988543002;
Console.WriteLine(cellNumber.ToString("#####-####"));

/* Formatando o tipo DateTime */

DateTime data = DateTime.Now;
Console.WriteLine(data);

Console.WriteLine($"Day: {data.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Hour: {data.ToString("HH")}h{data.ToString("mm")}");

/* Formatando data e hora */

Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime formatData = DateTime.Parse("10/11/22 17:10");
Console.WriteLine(formatData);

/* DateTime com TryParse */

string dataString = "2022-11-10 17:15";

bool dataCheck = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime newData);
Console.WriteLine(newData);

DateTime stringToData = DateTime.Parse(dataString);
Console.WriteLine(stringToData);

/* Validando o retorno do TryParse */

if (dataCheck)
{
    Console.WriteLine($"Successful conversion! Data: {newData}");
}
else
{
    Console.WriteLine($"Invalid data! Data: {dataString}");
}
