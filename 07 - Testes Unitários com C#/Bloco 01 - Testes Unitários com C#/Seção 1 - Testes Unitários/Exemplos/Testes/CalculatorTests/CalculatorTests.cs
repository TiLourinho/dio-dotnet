using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    private CalculatorImp _calc;

    public CalculatorTests()
    {
        _calc = new();
    }

    [Fact]
    public void Add_50to25_Returns75()
    {
        // Arrange: monta o cenário
        int num1 = 50;
        int num2 = 25;

        // Act: colocar em ação, chamar a função
        int result = _calc.Sum(num1, num2);

        // Assert: valida se o resultado é o esperado
        Assert.Equal(75, result);

    }

    [Fact]
    public void Subtract_50to25_Returns25()
    {
        int num1 = 50;
        int num2 = 25;

        int result = _calc.Subtraction(num1, num2);
        Assert.Equal(25, result);
    }

    [Fact]
    public void Multiplicate_50to25_Returns1250()
    {
        int num1 = 50;
        int num2 = 25;

        int result = _calc.Multiplication(num1, num2);
        Assert.Equal(1250, result);
    }

    [Fact]
    public void Divide_50to25_Returns2()
    {
        int num1 = 50;
        int num2 = 25;

        int result = _calc.Division(num1, num2);
        Assert.Equal(2, result);
    }
}