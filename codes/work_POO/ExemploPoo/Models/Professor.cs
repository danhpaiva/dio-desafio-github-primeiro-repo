namespace ExemploPoo.Models
{
  public class Professor : Pessoa
  {
    public int Salario { get; set; }

    public override void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e meu salário é: {Salario} .");
    }

    /*public sealed override void Apresentar() Impossível herdar esse método por conta do selo
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e meu salário é: {Salario} .");
    }
    */
  }
}