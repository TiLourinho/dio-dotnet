using Exemplos.Models;
using Newtonsoft.Json;

/* Instalando o Newtonsoft.Json */

// dotnet add package Newtonsoft.Json

/* Serialização */

DateTime currentDate = DateTime.Now;

Sale sale1 = new(1, "Office suplies", 237.31M, currentDate);
string sale1Serialized = JsonConvert.SerializeObject(sale1, Formatting.Indented);
File.WriteAllText("Files/sale1.json", sale1Serialized);

Sale sale2 = new(2, "Office cup groceries", 47.79M, currentDate);
string sale2Serialized = JsonConvert.SerializeObject(sale2, Formatting.Indented);
File.WriteAllText("Files/sale2.json", sale2Serialized);

Sale sale3 = new(3, "Software license", 599.00M, currentDate);
string sale3Serialized = JsonConvert.SerializeObject(sale3, Formatting.Indented);
File.WriteAllText("Files/sale3.json", sale3Serialized);

Console.WriteLine(sale1Serialized);
Console.WriteLine(sale2Serialized);
Console.WriteLine(sale3Serialized);

/* Serialização de coleções */

List<Sale> salesList = new();

salesList.Add(sale1);
salesList.Add(sale2);
salesList.Add(sale3);

string salesListSerialized = JsonConvert.SerializeObject(salesList, Formatting.Indented);
File.WriteAllText("Files/allSales.json", salesListSerialized);

Console.WriteLine($"\n{salesListSerialized}\n");

/* DateTime em Json */

// O DateTime trabalha as datas no formato ISO 8601

/* Deserialização */

string contentFile = File.ReadAllText("Files/cars.json");

List<Car> carsList = JsonConvert.DeserializeObject<List<Car>>(contentFile);

foreach (Car car in carsList)
{
    Console.WriteLine($"Id: {car.Id},\nName: {car.Name},\nBranch: {car.Branch},\nReleaseYear: {car.ReleaseYear},\nPrice: {car.Price:C}\n");
}

/* Atributos */

// Se a propriedade lida não tiver o mesmo nome na classe feita para a deserialização, usa-se o atributo [JsonProperty("Nome_Lido")]
// antes de declarar a propriedade na classe.