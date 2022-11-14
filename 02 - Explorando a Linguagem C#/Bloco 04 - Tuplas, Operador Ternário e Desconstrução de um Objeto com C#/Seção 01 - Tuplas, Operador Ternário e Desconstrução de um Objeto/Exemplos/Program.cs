using Exemplos.Models;
using System.Globalization;

/* Tuplas */

(int Id, string Name, string Surname, decimal Height) person1 = (1, "Alex", "Green", 1.85M);
Console.WriteLine($"Id: {person1.Id}\nName: {person1.Name}\nSurname: {person1.Surname}\nHeight: {person1.Height.ToString(CultureInfo.InvariantCulture)} m\n");

/* Tuplas: outras sintaxes */

ValueTuple<int, string, string, decimal> person2 = (2, "Beth", "Gray", 1.62M);
Console.WriteLine($"Id: {person2.Item1}\nName: {person2.Item2}\nSurname: {person2.Item3}\nHeight: {person2.Item4.ToString(CultureInfo.InvariantCulture)} m\n");

var person3 = Tuple.Create(3, "Olga", "Fischer", 1.76M);
Console.WriteLine($"Id: {person3.Item1}\nName: {person3.Item2}\nSurname: {person3.Item3}\nHeight: {person3.Item4.ToString(CultureInfo.InvariantCulture)} m\n");

Files document = new();
var (isSuccessful, rows, quantityRows) = document.ReadFile("Files/onMyWay.txt");

if (isSuccessful)
{
    Console.WriteLine($"Rows quantity: {quantityRows}\n");
    foreach (string row in rows)
    {
        Console.WriteLine(row);
    }
}
else
{
    Console.WriteLine("Could not read file!");
}

/* Descarte de informações */

// Substituir a variável por underline
var (successful, columns, _) = document.ReadFile("Files/onMyWay.txt");

/* Desconstrutor */

Person individual1 = new Person("Heather", "Becker", 43);
Person individual2 = new Person("Cyrus", "Jordan", 41);

(string firstName1, string lastName1, int age1) = individual1;
(string firstName2, string lastName2, int age2) = individual2;

Console.WriteLine($"\nName: {firstName1} {lastName1} - Age: {age1}");
Console.WriteLine($"Name: {firstName2} {lastName2} - Age: {age2}\n");

/* Ternário */

int number = 20;

if (number % 2 == 0)
{
    Console.WriteLine($"Number {number} is even!");
}
else
{
    Console.WriteLine($"Number {number} is odd!");
}

string condition = number % 2 == 0 ? "even" : "odd";
Console.WriteLine($"Number {number} is {condition}!");