namespace ExemploConstrutores.Models
{
  public class Calculadora
  {
    public static void Somar(int x, int y)
    {
      System.Console.WriteLine($"A soma é: {x + y}");
    }

    public static void Subtrair(int x, int y)
    {
      System.Console.WriteLine($"A subtração é: {x - y}");
    }
  }
}