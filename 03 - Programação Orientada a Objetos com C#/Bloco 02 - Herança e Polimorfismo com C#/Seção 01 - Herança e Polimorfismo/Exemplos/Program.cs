using Exemplos.Models;

/* Herança */

/* A herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.
Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes. */

Student student1 = new();
student1.Name = "Mike";
student1.Age = 16;
student1.Grade = 10;
student1.Introduce();

Teacher teacher1 = new();
teacher1.Name = "Robert";
teacher1.Age = 41;
teacher1.Wage = 6500;
teacher1.Introduce();

/* Polimorfismo */

/* O polimorfismo nos possibilita sobrescrever métodos das classes filhas para que se comportem de maneira diferente.
Quando o polimorfismo depende de herança, ele é chamado de Polimorfismo em Tempo de Execução (Override/Late Binding).
O Polimorfismo em Tempo de Compilação (Overload/Early Binding) já não depende de herança. Os métodos tem o mesmo nome,
mas a quantidade de parâmetros diferentes.

public class Calculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
} */
