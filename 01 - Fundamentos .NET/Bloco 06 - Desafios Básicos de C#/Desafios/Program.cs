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