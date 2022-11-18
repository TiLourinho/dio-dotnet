static void IdadeEmDias()
{
    /*
    Desafio 1

    Você terá o desafio de ler um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias.
    Obs.: Apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
    Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.

    Entrada:
    O arquivo de entrada contém um valor inteiro.

    Saída:
    Imprima a saída conforme exemplo fornecido.

    Exemplos de entrada:          Exemplos de saída:
    400                           1 ano(s)
                                  1 mes(es)
                                  5 dia(s)

    800                           2 ano(s)
                                  2 mes(es)
                                  10 dia(s)

    30                            0 ano(s)
                                  1 mes(es)
                                  0 dia(s)
    */

    var dias = int.Parse(Console.ReadLine());

    var anos = dias / 365;
    dias = dias % 365;

    var meses = dias / 30;
    dias = dias % 30;
    
    Console.WriteLine($"{anos} ano(s)");
    Console.WriteLine($"{meses} mes(es)");
    Console.WriteLine($"{dias} dia(s)");
}

IdadeEmDias();

static void ConversaoDeTempo()
{
    /*
    Desafio 2

    Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja,
    e informe-o expresso no formato horas:minutos:segundos.

    Entrada:
    O arquivo de entrada contém um valor inteiro N.

    Saída:
    Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

    Exemplos de entrada:          Exemplos de saída:
    556                           0:9:16

    1                             0:0:1
    */

    var timeInSeconds = int.Parse(Console.ReadLine());

    var hours = timeInSeconds / 3600;
    timeInSeconds = timeInSeconds % 3600;

    var minutes = timeInSeconds / 60;
    var seconds = timeInSeconds % 60;

    Console.WriteLine($"{hours}:{minutes}:{seconds}");
}

ConversaoDeTempo();

static void TempoDoDobby()
{
    /*
    Desafio 3

    Para dar conta de toda a fabricação dos presentes de Natal, por várias vezes os elfos precisam ficar até tarde trabalhando
    para que tudo possa ser terminado a tempo. Para melhor gerenciar seus cronogramas, os elfos estipularam quantos minutos são
    necessários para fabricar cada presente.
    Já está quase no final do expediente, e um dos elfos pediu sua ajuda.
    Faltam N minutos para a hora de ir embora, e restam dois presentes para o elfo Dobby fabricar.
    Ajude-o a descobrir se ele conseguirá fabricar os dois ainda hoje, ou se deve deixar o trabalho para amanhã.

    Entrada:
    Cada caso de teste inicia com um inteiro N, indicando quantos minutos faltam para o final do expediente (2 <= N <= 100).
    Em seguida haverá dois inteiros A e B, indicando quantos minutos são necessários para fabricar os dois presentes que Dobby
    precisa fabricar (1 <= A, B <= 100).

    Saída:
    Imprima uma linha, contendo a frase "Farei hoje!" caso seja possível fabricar os dois presentes antes do final do expediente,
    ou "Deixa para amanha!" caso contrário.

    Exemplos de entrada:          Exemplos de saída:
    20                            Deixa para amanha!
    15 6

    20                            Farei hoje!
    10 10
    */

    int finalExpediente = Convert.ToInt32(Console.ReadLine());
    string[] presentes = Console.ReadLine().Split(" ");
    
    int presente1 = Convert.ToInt32(presentes[0]);
    int presente2 = Convert.ToInt32(presentes[1]);
    
    int totalNecessario = presente1 + presente2;
    
    if (totalNecessario > finalExpediente)
    {
      Console.WriteLine("Deixa para amanha!");
    }
    else
    {
      Console.WriteLine("Farei hoje!");
    }
}

TempoDoDobby();
