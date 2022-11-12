using Exemplos.Models;

/* Try / Catch */

try
{
    string[] rows = File.ReadAllLines("Files/readFile.txt");

    foreach (string row in rows)
    {
        Console.WriteLine(row);
    }
}
catch(FileNotFoundException ex)
{
    Console.WriteLine($"While reading the file an error occurred! File not found! {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"While reading the file an error occurred! Directory not found! {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"A generic exception occurred! {ex.Message}");
}
finally
{
    // O finally sempre é executado! Com erros ou não
    Console.WriteLine($"Got here!");
}

/* Throw */

new ExceptionExample().Method1();

/* Filas */

Queue<int> intQueue = new();

intQueue.Enqueue(2);
intQueue.Enqueue(4);
intQueue.Enqueue(6);
intQueue.Enqueue(8);

foreach (int item in intQueue)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removing element: {intQueue.Dequeue()}");
intQueue.Enqueue(10);

foreach (int item in intQueue)
{
    Console.WriteLine(item);
}

Console.Write(string.Join(", ", intQueue));

/* Pilhas */

Stack<int> intStack = new();

intStack.Push(4);
intStack.Push(6);
intStack.Push(8);
intStack.Push(10);

foreach (int item in intStack)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removing element: {intStack.Pop()}");
intStack.Push(12);

foreach (int item in intStack)
{
    Console.WriteLine(item);
}

/* Dicionários */

Dictionary<string, string> states = new();

states.Add("DF", "Distrito Federal");
states.Add("BA", "Bahia");
states.Add("MG", "Minas Gerais");
states.Add("SP", "São Paulo");

Console.WriteLine(states["DF"]);

foreach (KeyValuePair<string, string> item in states)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("-----------");
states.Remove("SP");
states["BA"] = "Nova Bahia";

foreach (KeyValuePair<string, string> item in states)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Verificando a existência de uma chave
string key = "BA";
Console.WriteLine($"Element check: {key}");

if (states.ContainsKey(key))
{
    Console.WriteLine($"Key already exists: {key}");
}
else
{
    Console.WriteLine($"Key doesn't exists. It's safe to add: {key}");
}