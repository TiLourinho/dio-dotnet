/* Formas de declarar um Array */

int[] array1 = new int[4]; // Instância de um array com 4 valores fixos
int[] array2 = new int[] {42, 75, 74, 61, 87}; // Instanciando um array de int e já passando 5 valores
string[] strings = {"Jan", "Fev", "Mar"}; // Sem instanciar e já passando os valores desejados

/* Implementando um Array de inteiros */

int[] integerArray = new int[3];

integerArray[0] = 72;
integerArray[1] = 64;
integerArray[2] = 50;

// Percorrendo o array com o For
for (int counter = 0; counter < integerArray.Length; counter++)
{
  Console.WriteLine($"Posição nº {counter}: {integerArray[counter]}");
}

// Percorrendo o array com o Foreach
int foreachCounter = 0;

foreach(int value in integerArray)
{
  Console.WriteLine($"Posição nº {foreachCounter}: {value}");
  foreachCounter++;
}

/* Redimensionando um Array */

int[] newArray = new int[2];

newArray[0] = 20;
newArray[1] = 15;

Array.Resize(ref newArray, 4);

Console.WriteLine(newArray.Length);

/* Copiando um Array para outro */

int[] newArrayCopy = new int[4];
Array.Copy(newArray, newArrayCopy, newArray.Length);

foreach (int value in newArrayCopy)
{
  Console.WriteLine(value);
}

/* Listas */

List<string> stringList = new ();
stringList.Add("DF");
stringList.Add("CE");
stringList.Add("MA");

for (int counter = 0; counter < stringList.Count; counter++)
{
  
}