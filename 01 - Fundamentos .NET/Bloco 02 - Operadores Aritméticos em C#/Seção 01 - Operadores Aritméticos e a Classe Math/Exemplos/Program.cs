using Examples;

/* Operadores Aritméticos */

Calculator calc = new ();

calc.Addition(20, 5);
calc.Subtraction(10, 8);
calc.Multiplication(15, 3);
calc.Division(30, 3);
calc.Power(3, 3);
calc.Sine(30);
calc.Cosine(30);
calc.Tangent(30);
calc.SquareRoot(9);

/* Incremento e Decremento */

int numberInc = 10;

Console.WriteLine("\nNumber");
Console.WriteLine(numberInc);
Console.WriteLine("Increasing number");
numberInc++;
Console.WriteLine(numberInc);

int numberDec = 20;

Console.WriteLine("\nNumber");
Console.WriteLine(numberDec);
Console.WriteLine("Increasing number");
numberDec--;
Console.WriteLine(numberDec);