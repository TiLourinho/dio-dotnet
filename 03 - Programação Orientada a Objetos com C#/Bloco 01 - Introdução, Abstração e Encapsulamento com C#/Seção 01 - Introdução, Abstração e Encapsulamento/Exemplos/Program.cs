using Exemplos.Models;

/* Classes e Objetos */

/*
    Uma classe é uma representação de algo do mundo real, com suas características e o objeto é sua implementação, a concretização de uma classe.
*/

/* Paradigmas de Programação */

/*
    Um paradigma é um conjunto de regras para solucionar um problema específico. Uma linguagem de programação implementa um ou mais paradigmas.
*/

/* Abstração */

/*
    Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.
*/

Person p1 = new();
p1.Name = "Giovanna";
p1.Age = 3;

p1.Introduce();

/* Encapsulamento */

/*
    O encapsulamento serve para proteger uma classe e definir limites para alteração de suas propriedades. Oculta o seu comportamento e expõe somente o necessário.
*/

CurrentAccount account1 = new(356999, 1000);

account1.Statement();
account1.Withdraw(275);
account1.Statement();

account1.Statement();
account1.Withdraw(1250);
account1.Statement();