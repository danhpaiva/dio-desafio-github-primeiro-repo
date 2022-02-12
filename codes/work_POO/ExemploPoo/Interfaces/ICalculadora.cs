namespace ExemploPoo.Interfaces
{
  public interface ICalculadora
  {
    int Somar(int num_um, int num_dois);
    int Subtrair(int num_um, int num_dois);
    int Multiplicar(int num_um, int num_dois);
    int Dividir(int num_um, int num_dois)
    {
      return num_um / num_dois;
    }
  }
}