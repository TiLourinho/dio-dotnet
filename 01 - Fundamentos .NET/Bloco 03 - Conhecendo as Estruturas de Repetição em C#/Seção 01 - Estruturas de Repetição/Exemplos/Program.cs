/* FOR */

int number = 5;

for (int counter = 0; counter <= 10; counter++)
{
  Console.WriteLine($"{number} x {counter} = {number * counter}");
}

/* WHILE */

int multipleTable = 5;
int counterNumber = 0;

while (counterNumber <= 10)
{
  Console.WriteLine($"{multipleTable} x {counterNumber} = {multipleTable * counterNumber}");
  counterNumber++;
}

/* DO WHILE */

int sum = 0;
int integer = 0;

do
{
  Console.WriteLine("Enter a number (Zero to stop):");
  integer = Convert.ToInt32(Console.ReadLine());

  sum += integer;

} while(integer != 0);

Console.WriteLine($"Total sum of numbers entered is: {sum}");

// Para debuggar códigos que usam o "Console.ReadLine" o "console" do arquivo /.vscode/launch.json deve ser
// alterado para "integratedTerminal".

/* Construindo um Menu Interativo */

string option;
bool menu = true;

while(menu)
{
  Console.Clear();
  Console.WriteLine("Enter your option:");
  Console.WriteLine("1 - Register customer");
  Console.WriteLine("2 - Search customer");
  Console.WriteLine("3 - Delete customer");
  Console.WriteLine("4 - Exit");

  option = Console.ReadLine()!;

  switch(option)
  {
    case "1":
      Console.WriteLine("Customer registration");
      break;

    case "2":
      Console.WriteLine("Customer search");
      break;

    case "3":
      Console.WriteLine("Customer deletion");
      break;

    case "4":
      Console.WriteLine("Exit");
      menu = false; // Sai do loop
      // Environment.Exit(0); // Sai do programa
      break;

    default:
      Console.WriteLine("Invalid option!");
      break;
  }
}