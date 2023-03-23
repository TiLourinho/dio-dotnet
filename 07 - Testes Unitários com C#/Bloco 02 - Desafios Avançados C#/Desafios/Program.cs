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
