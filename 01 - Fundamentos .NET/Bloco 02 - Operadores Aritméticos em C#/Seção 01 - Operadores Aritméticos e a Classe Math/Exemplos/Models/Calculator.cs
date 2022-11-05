namespace Examples
{
  public class Calculator
  {
    public void Addition(int x, int y)
    {
      Console.WriteLine($"{x} + {y} = {x + y}");
    }

    public void Subtraction(int x, int y)
    {
      Console.WriteLine($"{x} - {y} = {x - y}");
    }

    public void Multiplication(int x, int y)
    {
      Console.WriteLine($"{x} x {y} = {x * y}");
    }

    public void Division(int x, int y)
    {
      Console.WriteLine($"{x} / {y} = {x / y}");
    }

    public void Power(int x, int y)
    {
      double power = Math.Pow(x, y);
      Console.WriteLine($"{x} ^ {y} = {power}");
    }

    public void Sine(double angle)
    {
      double radian = angle * Math.PI / 180;
      double sine = Math.Sin(radian);
      Console.WriteLine($"Sine of {angle}° = {Math.Round(sine, 4)}");
    }

    public void Cosine(double angle)
    {
      double radian = angle * Math.PI / 180;
      double cosine = Math.Cos(radian);
      Console.WriteLine($"Cosine of {angle}° = {Math.Round(cosine, 4)}");
    }

    public void Tangent(double angle)
    {
      double radian = angle * Math.PI / 180;
      double tangent = Math.Tan(radian);
      Console.WriteLine($"Tangent of {angle}° = {Math.Round(tangent, 4)}");
    }

    public void SquareRoot(double x)
    {
      double squareRoot = Math.Sqrt(x);
      Console.WriteLine($"Square root of {x} = {squareRoot}");
    }
  }
}