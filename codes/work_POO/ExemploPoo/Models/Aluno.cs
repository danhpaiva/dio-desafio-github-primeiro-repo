namespace ExemploPoo.Models
{
  public class Aluno : Pessoa
  {
    public int Nota { get; set; }

    public override void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e minha nota é: {Nota} .");
    }
  }
}