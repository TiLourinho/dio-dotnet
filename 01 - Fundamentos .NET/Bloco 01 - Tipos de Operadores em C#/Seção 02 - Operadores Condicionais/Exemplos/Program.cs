/* If... Else */

int quantidadeEmEstoque = 10;
int quantidadeCompra = 12;
bool possivelVenda = quantidadeCompra > 0 && quantidadeCompra <= quantidadeEmEstoque;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Produtos no carrinho: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda: {possivelVenda}");

if (quantidadeCompra == 0)
{
  Console.Write("\nVenda inválida");
}
else if (possivelVenda)
{
  Console.WriteLine("\nVenda realizada!");
}
else
{
  Console.WriteLine("\nDesculpe. Não temos o produto em estoque.");
}

/* Switch Case */

Console.Write("Digite uma letra: ");
string letra = Console.ReadLine()!;

switch (letra)
{
  case "a":
  case "e":
  case "i":
  case "o":
  case "u":
    Console.WriteLine("Vogal");
    break;

  default:
    Console.WriteLine("Não é uma vogal");
    break;
}