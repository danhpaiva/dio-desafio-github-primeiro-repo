using static System.Console;

namespace ExemploConstrutores.Models
{
  public class Pessoa
  {
    private readonly string nome = "Dan";
    private readonly string sobrenome;
    public Pessoa()
    {
      nome = string.Empty;
      sobrenome = string.Empty;
    }
    public Pessoa(string nome, string sobrenome)
    {
      this.nome = nome;
      this.sobrenome = sobrenome;
      System.Console.WriteLine("Construtor Classe Pessoa");
    }

    public void ImprimirMensagemConsole()
    {
      WriteLine($"Olá, meu nome é {nome} .");
    }
  }
}