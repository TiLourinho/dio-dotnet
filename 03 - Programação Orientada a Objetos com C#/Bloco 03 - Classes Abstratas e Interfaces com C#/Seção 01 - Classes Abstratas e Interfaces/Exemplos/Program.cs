using Exemplos.Models;

/* Classe Abstrata */

// É uma classe que não pode ser instanciada. Ela serve como um modelo para ser herdada por outras classes.

// private: o tipo ou membro só pode ser acessado por código da mesma classe ou struct.
// protected: o tipo ou membro só pode ser acessado por código da mesma classe ou de uma classe filha.

CurrentAccount account1 = new();
account1.Credit(1550);
account1.Statement();

/* Construtor por Herança */

/* No contexto de herança, se a classe pai tiver um construtor, pedindo "name" por exemplo, as classes filhas também terão que pedir "name".
O construtor da classe filha ficará assim:

    public Student(string name) : base(name) { }

Como se "base(name)" fosse o construtor da classe pai. */

Student student1 = new("Jack");
student1.Age = 17;
student1.Grade = 9;
student1.Introduce();

/* Classe Selada (Sealed) */

// Ao contrário da classe abstrata, a classe selada não pode ser herdada. Métodos e atributos também podem ser selados.

/* Classe Object */

/* A classe System.Object é a mãe de todas as classes na hierarquia do .NET. Todas as classes derivam, direta ou indiretamente, da classe Object.
Ela tem como objetivo prover serviços de baixo nível para suas classes filhas */

Computer cpt = new();
Console.WriteLine(cpt);

/* Interfaces */

/* É um contrato que pode ser implementado por uma classe. Lembra o funcionamento de uma classe abstrata, podendo definir métodos abstratos
para serem implementados e também não podendo ser instanciada. */

Calculator calc = new();
Console.WriteLine($"The result of 20 + 5 is {calc.Sum(20, 5)}.");
Console.WriteLine($"The result of 20 - 5 is {calc.Subtract(20, 5)}.");
Console.WriteLine($"The result of 20 * 5 is {calc.Multiply(20, 5)}.");
Console.WriteLine($"The result of 20 / 5 is {calc.Divide(20, 5)}.");