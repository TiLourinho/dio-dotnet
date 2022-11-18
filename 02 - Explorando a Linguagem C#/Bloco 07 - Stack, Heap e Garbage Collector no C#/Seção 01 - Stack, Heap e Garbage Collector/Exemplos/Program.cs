using Exemplos.Models;

/* Entendendo Stack e Heap */

void Method()
{
    int a = 5;
    int b = 10;
    Person p1 = new("Jack", "Green", 51);

    Console.WriteLine($"{p1.FullName} sums {a} + {b} and gets {a + b} as result.\n");
}

Method();

/* 
    As variáveis "a" e "b" (simples) são armazenadas na Stack (Pilha, LIFO). A variável "p1" (complexa, objeto) é armazenda na Heap, mas uma cópia de referência fica armazenada
também na Stack.
*/

/* Limpeza de Memória */

/*
    Quando Method é executado a variável "a" é armazenada na Stack, depois a "b" e em seguida "p1". Após a execução de Method, pelo conceito de Stack, as variáveis serão
retiradas da Stack nessa ordem: "p1", "b", "a". Mas na memória Heap, a variável "p1" ainda persiste.
    Para limpar a memória Heap, o C# utiliza o Garbage Collector (GC) que varre a memória Heap e retira os objetos armazenados que não possuem uma cópia de referência na
memória Stack. Neste exemplo, como "p1" já foi removida da Stack, o GC removeria também "p1" da Heap.
*/

/* Tipos de Valor e Referência */

/*
    Os tipos de valor (value types) são armazenados na Stack. Neste exemplo são as variáveis "a" e "b". São tipos de valor porque são armazenados na Stack com seus próprios
valores 5 e 10. São tipos simples, primitivos. Os int armazenam um valor inteiro, os bool armazenam valores booleanos (true ou false), etc.
    Já os tipos de referência, por serem complexos, podendo ter neles mesmos vários valores de vários tipos, tem na Stack somente o nome de sua variável e uma referência
apontando ao objeto armazenado na Heap.
*/

/* Atribuindo Tipo de Referência */

Person p1 = new("Adam", "Bulk", 38);
Person p2 = new("Lia", "Chase", 29);

Console.WriteLine($"Fullname p1: {p1.FullName}"); // Fullname p1: Adam Bulk
Console.WriteLine($"Fullname p2: {p2.FullName}"); // Fullname p2: Lia Chase

p2 = p1;
p2.FirstName = "Beth";

Console.WriteLine($"Fullname p1: {p1.FullName}"); // Fullname p1: Beth Bulk
Console.WriteLine($"Fullname p2: {p2.FullName}"); // Fullname p1: Beth Bulk

/*
    Por que "p1" e "p2" tem a mesma saída no console? Quando atribuímos o valor de "p1" para "p2" estamos fazendo que essas duas variáveis apontem para o objeto de "p1" na Heap.
Por isso que quando atribuímos um novo FirstName para "p2" o FirstName de "p1" também muda. Estamos alterando o objeto de "p1" e esse objeto tem duas variáveis referência,
"p1" e "p2". O que for alterado no objeto de "p1" será refletido em suas referências.
*/

/* Atribuindo Tipo de Valor */

int a = 10;
int b = a;

Console.WriteLine($"\nValue a: {a}"); // Value a: 10
Console.WriteLine($"Value b: {b}"); // Value b: 10

b = 60;

Console.WriteLine($"\nValue a: {a}"); // Value a: 10
Console.WriteLine($"Value b: {b}"); // Value b: 60

/*
    O tratamento das variáveis "a" e "b" é diferente dos tipos de referência. Aqui, nos tipos de valor, quando se altera o valor de uma variável ela adere ao novo valor.
Não há apontamentos, referências porque estamos tratando de tipos primitivos e não objetos.
*/