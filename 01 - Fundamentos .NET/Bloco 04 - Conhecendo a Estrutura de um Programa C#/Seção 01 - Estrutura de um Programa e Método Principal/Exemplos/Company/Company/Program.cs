using System.Globalization;

using Individual.Models;

Employee employee = new();

Console.Write("Nome: ");
employee.name = Console.ReadLine();
Console.Write("Salário bruto: ");
employee.grossSalary = Convert.ToDouble(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
employee.tax = Convert.ToDouble(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.WriteLine($"\nFuncionário: {employee.name}, R$ {employee.NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("\nDigite a porcentagem para aumentar o salário: ");
double percentage = Convert.ToDouble(Console.ReadLine()!, CultureInfo.InvariantCulture);

employee.IncreaseSalary(percentage);

Console.WriteLine($"\nDados atualizados: {employee.name}, R$ {employee.NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");
