namespace Demos
{
  public class Pessoa
  {
    public int Idade { get; set; }
    public string Documento { get; set; }
    public string Nome { get; set; }

    public Pessoa()
    {
      Documento = "documento";
      Nome = "nome";
    }
  }
}