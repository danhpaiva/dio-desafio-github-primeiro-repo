using Demos;
using static System.Console;
public class Program
{
  public static void Main()
  {
    List<Pessoa> pessoas = new List<Pessoa>()
    {
      new Pessoa(){Nome = "Jõao"},
      new Pessoa(){Nome = "Daniel"},
      new Pessoa(){Nome = "Paiva"},
      new Pessoa(){Nome = "Elias"},
      new Pessoa(){Nome = "Maria"}
    };

    WriteLine("Digite o nome da pessoa que deseja localizar: ");
    var nomeDesejado = ReadLine();
    var pessoa = new Pessoa() { Nome = nomeDesejado };
    var encontrado = EncontrarPessoa(pessoas, pessoa);
    if (encontrado)
    {
      WriteLine("Pessoa encontrada!");
    }
    else
    {
      WriteLine("Pessoa não encontrada.");
    }
  }

  static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
  {
    foreach (var item in pessoas)
    {
      if (item.Nome == pessoa.Nome)
      {
        return true;
      }
    }
    return false;
  }

  static int EncontrarNumero(int[] numeros, int numeroDesejado)
  {
    for (int i = 0; i < numeros.Length; i++)
    {
      if (numeros[i] == numeroDesejado)
        return i;
    }
    return -1;
  }

  static void MudarNumerosParaImpar(int[] pares)
  {
    for (int i = 0; i < pares.Length; i++)
    {
      pares[i] = pares[i] + 1;
    }
  }
  static int Adicionar100(int numero)
  {
    return numero + 100;
  }

  static void Demo1()
  {
    int numero = 1;
    WriteLine($"O valor da variável numero é: {Adicionar100(numero)}");
  }

  static void TrocarNome(Pessoa pessoa_um, string nomeNovo)
  {
    pessoa_um.Nome = nomeNovo;
  }

  static void Demo2()
  {
    Pessoa pessoa_um = new Pessoa();
    pessoa_um.Nome = "danhpaiva";
    pessoa_um.Idade = 29;
    pessoa_um.Documento = "555";

    TrocarNome(pessoa_um, "Paiva");
    WriteLine($"O novo nome é: {pessoa_um.Nome}");
  }

  static void TrocarNome(string nome, string nomeNovo)
  {
    nome = nomeNovo;
  }

  static void Demo3()
  {
    string nome = "Paiva";
    TrocarNome(nome, "Daniel");
    WriteLine(nome);
  }

  static void Demo4()
  {
    int[] pares = new int[] { 0, 2, 4, 6, 8 };
    MudarNumerosParaImpar(pares);
    WriteLine($"Os impares são: {string.Join(",", pares)}");
  }

  static void Demo5()
  {
    int[] numeros = new int[] { 0, 2, 4, 6, 8 };
    WriteLine("Digite o número que gostaria de encontrar: ");
    var numeroDesejado = int.Parse(ReadLine());
    var idxEncontrado = EncontrarNumero(numeros, numeroDesejado);
    if (idxEncontrado >= 0)
    {
      WriteLine($"O número digitado está na posição: {idxEncontrado} .");
    }
    else
    {
      WriteLine($"O número digitado não está na lista.");
    }
  }
}