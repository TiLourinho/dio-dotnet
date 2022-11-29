static void MaiorEPosicao()
{
    /*
    Desafio 1

    Você recebeu o desafio de ler 10 valores inteiros. Apresente então o maior valor lido e a posição dentre os 10 valores lidos.

    Entrada:
    O arquivo de entrada contém 10 números inteiros, positivos e distintos.

    Saída:
    Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

    Exemplos de entrada:          Exemplos de saída:
    2                             34565
    113                           4
    45
    34565
    6
    786
    1091
    11897
    459
    23851
    */

    int input;
    int maior = 0;
    int posicao = 0;

    for (int i = 1; i <= 10; i++)
    {
        input = Convert.ToInt32(Console.ReadLine());

        if (input > maior)
        {
            maior = input;
            posicao = i;     
        } 
    }

    Console.WriteLine($"\nO maior número é: {maior}");
    Console.WriteLine($"Sua posição é: {posicao}");
}

MaiorEPosicao();

static void Media2()
{
    /*
    Desafio 2

    Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno,
    sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5.
    Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

    Entrada:
    O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

    Saída:
    Imprima a variável MEDIA conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade.

    Exemplos de entrada:          Exemplos de saída:
    5                             MEDIA = 6,3
    6                             
    7

    5                             MEDIA = 9,0
    10
    10

    10                            MEDIA = 7,5
    10
    5
    */

    double A, B, C;
      
    A = Convert.ToDouble(Console.ReadLine());
    B = Convert.ToDouble(Console.ReadLine());
    C = Convert.ToDouble(Console.ReadLine());
    
    double calc = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);

    Console.WriteLine($"MEDIA = {calc}");
}

Media2();

static void DividindoXPorY()
{
    /*
    Desafio 3

    Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo.
    Caso não for possível, mostre a mensagem “divisao impossivel” para os valores em questão.

    Entrada:
    A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

    Saída:
    Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

    Exemplos de entrada:          Exemplos de saída:
    3                             
    3 -2                          -1,5                             
    -8 0                          divisao impossivel
    0 8                           0,0
    */

    int limit = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < limit; i++) 
    {
        string[] line = Console.ReadLine().Split(" ");

        double X = double.Parse(line[0]);
        double Y = double.Parse(line[1]);

        if (Y != 0) {
            double calc = X / Y;
            Console.WriteLine(calc);
        } else {
            Console.WriteLine("divisao impossivel");
        }
    }
}

DividindoXPorY();
