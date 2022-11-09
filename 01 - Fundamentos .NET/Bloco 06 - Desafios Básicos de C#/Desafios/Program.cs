using System.Globalization;

static void MultiplicacaoSimples()
{
  /*
  Desafio 1

  Você receberá dois valores inteiros. Faça a leitura e em seguida calcule o produto entre estes dois valores.
  Atribua esta operação à variável PROD, mostrando esta de acordo com a mensagem de saída esperada (exemplo abaixo).

  Entrada:
  A entrada contém 2 valores inteiros.

  Saída:
  Exiba a variável PROD conforme exemplo abaixo, tendo obrigatoriamente um espaço em branco antes e depois da igualdade.

  Exemplos de entrada:          Exemplos de saída:
  3                             PROD = 27
  9

  -30                           PROD = -300
  10

  0                             PROD = 0
  9
  */

  int a = Convert.ToInt32(Console.ReadLine());
  int b = Convert.ToInt32(Console.ReadLine());
  int calc = a * b;

  Console.WriteLine($"PROD = {calc}");
}

MultiplicacaoSimples();

static void PinkECerebro()
{
  /*
  Desafio 2

  Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo da pandemia.
  Para passar o tempo, Pink cria problemas matemáticos para Cérebro resolver, o último deles foi uma lista de números
  com a seguinte pergunta: quantos números da lista são múltiplos de 2, 3, 4 e 5?
  Apesar de parecer simples, porém, quando a lista contém muitos números, Cérebro se confunde e acaba errando alguns cálculos.
  Ajude Cérebro a resolver o desadio de Pink.

  Entrada:
  A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), representando a quantidade de números na lista de Pink.
  A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando os números da lista de Pink.

  Saída:
  Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes na lista.
  Observe a formatação da saída nos exemplos, pois ela deve ser seguida rigorosamente.

  Exemplo de entrada:
  5
  2 5 4 20 10

  Exemplo de saída:
  4 Multiplo(s) de 2
  0 Multiplo(s) de 3
  2 Multiplo(s) de 4
  3 Multiplo(s) de 5
  */

  int numberQuantity = Convert.ToInt32(Console.ReadLine());
  string[] numbers = Console.ReadLine()!.Split(' ');

  int multiplo2 = 0;
  int multiplo3 = 0;
  int multiplo4 = 0;
  int multiplo5 = 0;

  for (int counter = 0; counter < numberQuantity; counter++)
  {
      if ((int.Parse(numbers[counter]) % 2) == 0) multiplo2++;
      if ((int.Parse(numbers[counter]) % 3) == 0) multiplo3++;
      if ((int.Parse(numbers[counter]) % 4) == 0) multiplo4++;
      if ((int.Parse(numbers[counter]) % 5) == 0) multiplo5++;
  }

  Console.WriteLine($"{multiplo2} Multiplo(s) de 2");
  Console.WriteLine($"{multiplo3} Multiplo(s) de 2");
  Console.WriteLine($"{multiplo4} Multiplo(s) de 2");
  Console.WriteLine($"{multiplo5} Multiplo(s) de 2");
}

PinkECerebro();

static void Esfera()
{
  /*
  Desafio 3

  Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
  A fórmula para calcular o volume é: (4/3) * pi * R³ . Considere (atribua) para pi o valor 3.14159.

  Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++),
  assumem que o resultado da divisão entre dois inteiros é outro inteiro.

  Entrada:
  O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

  Saída:
  A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade.
  O valor deverá ser apresentado com 3 casas após o ponto.

  Exemplos de entrada:          Exemplos de saída:
  3                             VOLUME = 113.097

  15                            VOLUME = 14137.155

  1523                          VOLUME = 14797486501.627
  
  */

  double PI, raio, volume;

  PI = 3.14159;
  raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
  volume = PI * (4.0/3.0) * Math.Pow(raio, 3);
  
  Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
}

Esfera();