using Calculator.Services;

CalculatorImp calculator = new();

int num1 = 10;
int num2 = 5;

Console.WriteLine("Sum:");
Console.WriteLine($"{num1} + {num2} = {calculator.Sum(num1, num2)}\n");
Console.WriteLine("Subtraction:");
Console.WriteLine($"{num1} - {num2} = {calculator.Subtraction(num1, num2)}\n");
Console.WriteLine("Multiplication:");
Console.WriteLine($"{num1} * {num2} = {calculator.Multiplication(num1, num2)}\n");
Console.WriteLine("Division:");
Console.WriteLine($"{num1} / {num2} = {calculator.Division(num1, num2)}");