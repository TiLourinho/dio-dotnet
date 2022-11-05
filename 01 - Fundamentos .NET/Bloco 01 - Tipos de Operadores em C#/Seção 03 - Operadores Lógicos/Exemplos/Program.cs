/* Operador OR (||) */

bool maiorDeIdade = false;
bool autorizacaoDoResponsavel = true;

if (maiorDeIdade || autorizacaoDoResponsavel)
{
  Console.WriteLine("Entrada liberada!");
}
else
{
  Console.WriteLine("Entrada não liberada!");
}

/* Operador AND (&&) */

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7.0)
{
  Console.WriteLine("Aprovado!");
}
else
{
  Console.WriteLine("Reprovado!");
}

/* Operador NOT (!) */

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
  Console.WriteLine("Vou pedalar!");
}
else
{
  Console.WriteLine("Vou pedalar outro dia.");
}