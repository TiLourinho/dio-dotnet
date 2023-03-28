using System.Globalization;

static void ValidacaoDeNota()
{
    /*
    Desafio 1

    Para ajudar a calcular as notas referentes às duas avaliações dos alunos,
    uma professora pediu para que você desenvolva um programa que calcule e imprima a média semestral.
    Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]).
    Cada nota deve ser validada separadamente.

    Entrada:
    A entrada contém vários valores reais, positivos ou negativos.
    O programa deve ser encerrado quando forem lidas duas notas válidas.

    Saída:
    Se uma nota inválida for lida, deve ser impressa a mensagem "nota invalida".
    Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo.
    O valor deve ser apresentado com duas casas após o ponto decimal.

    Exemplos de entrada:           Exemplos de saída:
    -3.5                           nota invalida
    3.5
    11.0                           nota invalida
    10.0                           media = 6.75
    */

    CultureInfo.CurrentCulture = new CultureInfo("en-US");

    double grades = 0;
    int counter = 0;

    while (counter < 2)
    {
        double grade = Convert.ToDouble(Console.ReadLine());

        if (grade < 0 || grade > 10)
        {
            Console.WriteLine("nota invalida");
        }
        else
        {
            grades += grade;
            counter += 1;
        }
    }

    Console.WriteLine($"media = {(grades / 2).ToString("N2")}");
}

ValidacaoDeNota();

static void HoHoHo()
{
    /*
    Desafio 2

    Papai Noel está brincando com seus duendes para entretê-los durante a véspera do Natal.
    A brincadeira consiste nos elfos escreverem números em pedaços de papel e colocarem no gorro do Papai Noel.
    Após todos terminarem de colocar os números Noel sorteia um papel e aquele número representa quantos "Ho" o Noel deve falar.

    Seu trabalho é ajudar o Papai Noel montando um problema que mostre todos os "Ho" que ele deve falar dado o número sorteado.

    Entrada:
    A entrada é composta por um único inteiro N (0 < N ≤ 106) representando quantos "Ho" serão falados por Noel.

    Saída:
    A saída é composta por todos "Ho" que Papai Noel deve falar separados por um espaço.
    Após o último "Ho" deve ser apresentado um "!" encerrando o programa.

    Exemplos de entrada:           Exemplos de saída:
    5                              Ho Ho Ho Ho Ho!
    */

    int numberOfHos = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < numberOfHos; i += 1)
    {
        if (i != numberOfHos - 1)
        {
            Console.WriteLine("Ho ");
        }
        else
        {
            Console.WriteLine("Ho!");
        }
    }
}

HoHoHo();

static void OMundoDeOz()
{
    /*
    Desafio 3

    No jogo, O Mundo de Oz, Pedro Bento é o líder do Tribunal, por causa disso ele é uma das pessoas mais importantes do mundo, no jogo.
    Além disso, Pedro Bento possui um grande tesouro, o qual possui diversos tipos de jóias.
    Pedro Bento está muito curioso para saber quantos tipos de jóias diferentes seu tesouro possui.
    Sabendo que você é o melhor programador do mundo, Pedro Bento te contratou para verificar quantos tipos de jóias distintas ele tem em seu tesouro.

    Entrada:
    A entrada consiste de várias linhas e cada uma contém uma string que descreve uma das jóias de Pedro Bento.
    Essa string é composta apenas dos caracteres '(' e ')', a soma do tamanho de todas as string não excede 106.

    Saída:
    Imprima quantos tipos de jóias distintas Pedro Bento possui.

    Exemplos de entrada:           Exemplos de saída:
    ((                             3
    ))
    ((
    ))
    (
    */

    List<string> jewels = new();

    while (true)
    {
        string jewel = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(jewel))
        {
            jewels.Add(jewel);
        }
        else
        {
            break;
        }
    }

    Console.WriteLine(jewels.Distinct().Count());
}

OMundoDeOz();