using Exemplos.Models;
using Newtonsoft.Json;

/* Tipos Nulos */

bool? wantToReceiveEmails = null;

if (wantToReceiveEmails.HasValue && wantToReceiveEmails.Value)
{
    Console.WriteLine("The user opted in to receive emails");
}
else
{
    Console.WriteLine("The user did not respond or opted out of receiving emails");
}

string contentFile = File.ReadAllText("Files/cars.json");
List<Car> carsList = JsonConvert.DeserializeObject<List<Car>>(contentFile);

foreach (Car car in carsList)
{
    string discountCondition = car.Discount.HasValue ? $"\nDiscount: {car.Discount}" : "";
    Console.WriteLine($"\nId: {car.Id},\nName: {car.Name},\nBranch: {car.Branch},\nReleaseYear: {car.ReleaseYear},\nPrice: {car.Price:C}{discountCondition}");
}

/* Tipos Anônimos */

var anonymousType = new { Name = "Josh", Surname = "Talbot", Height = "1.85" };

Console.WriteLine($"\nName: {anonymousType.Name}\nSurname: {anonymousType.Surname}\nHeight: {anonymousType.Height}\n");

/* Tipos Anônimos em Coleção */

var anonymousList = carsList.Select(x => new { x.Name, x.Price });

foreach (var car in anonymousList)
{
    Console.WriteLine($"Name: {car.Name}, Price: {car.Price}");
}

/* Tipo Dinâmico */

dynamic dynamicVariable = 4;
Console.WriteLine($"\nVariable type: {dynamicVariable.GetType()}, Valor: {dynamicVariable}");

dynamicVariable = "String here";
Console.WriteLine($"Variable type: {dynamicVariable.GetType()}, Valor: {dynamicVariable}");

dynamicVariable = true;
Console.WriteLine($"Variable type: {dynamicVariable.GetType()}, Valor: {dynamicVariable}");

dynamicVariable = 10.50M;
Console.WriteLine($"Variable type: {dynamicVariable.GetType()}, Valor: {dynamicVariable}");

dynamicVariable = 21.53;
Console.WriteLine($"Variable type: {dynamicVariable.GetType()}, Valor: {dynamicVariable}\n");

/* Classe Genérica */

// A classe MyArray é genérica e suporta qualquer tipo

MyArray<int> intArr = new();
intArr.AddElement(30);
Console.WriteLine(intArr[0]);

MyArray<string> stringArr = new();
stringArr.AddElement("Array");
Console.WriteLine(stringArr[0]);

MyArray<double> doubleArr = new();
doubleArr.AddElement(25.50);
Console.WriteLine(doubleArr[0]);

/* Métodos de Extensão */

int number = 20;
bool isEven = false;

// EvenOrOdd é um método de extensão
isEven = number.EvenOrOdd();
string condition = isEven ? "even" : "odd";

Console.WriteLine($"\nThe number {number} is {condition}");