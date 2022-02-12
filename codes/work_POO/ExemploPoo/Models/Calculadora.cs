using ExemploPoo.Interfaces;

namespace ExemploPoo.Models
{
  public class Calculadora : ICalculadora
  {
    public int Multiplicar(int num_um, int num_dois)
    {
      return num_um * num_dois;
    }

    public int Somar(int num_um, int num_dois)
    {
      return num_um + num_dois;
    }

    public int Somar(int num_um, int num_dois, int num_tres)
    {
      return num_um + num_dois + num_tres;
    }

    public int Subtrair(int num_um, int num_dois)
    {
      return num_um - num_dois;
    }
  }
}