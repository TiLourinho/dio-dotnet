/* Introdução ao operador de atribuição */

int a = 10;
int b = 20;

int c = a + b; // 30

Console.WriteLine(c);

/* Combinando operadores */

c += 5; // 35
c -= 5; // 25
c *= 5; // 150
c /= 5; // 6

Console.WriteLine(c);

/* Convertendo tipos de variáveis (Cast, casting) */

int d = Convert.ToInt32("5");
double e = double.Parse("20");

Console.WriteLine(d);
Console.WriteLine(e);

/* Diferença entre Convert e Parse */

// Se o Convert estiver tentando converter "null", ele retornará 0.
// O Parse quebrará o programa retornando um exceção.

/* Conversão para string */

int inteiro = 13;
string f = inteiro.ToString();

Console.WriteLine(f);

/* Cast implícito */

int g = 5;
double h = g; // int "cabe" dentro de double, logo o cast é implícito.

int i = 7;
long j = i; // int também "cabe" dentro de long.

long k = 11;
int l = Convert.ToInt32(k); // Neste caso a conversão deve ser manual.

Console.WriteLine(l);

/* Ordem dos operadores */

// Prioridade: () ^ / * + -

/* Convertendo de maneira segura */

string m = "15-";
int n = 0;

int.TryParse(m, out n);

Console.WriteLine(n);
Console.WriteLine("Conversão realizada com sucesso!");