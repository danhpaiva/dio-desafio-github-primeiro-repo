using static System.Console;

class Aula02
{
  static void Main()
  {
    var listaNomes = new string[] { "Raphael", "Daniel", "Miguel" };

    WriteLine($@"A lista de nomes é: 
      {string.Join(", \n", listaNomes)}
    ");

    WriteLine("Digite o nome que deseja trocar: ");
    var nomeAtual = ReadLine();

    if (nomeAtual == null)
      nomeAtual = "Carlinhos";

    WriteLine("Digite o novo nome: ");
    var novoNome = ReadLine();

    if (novoNome == null)
      novoNome = "Carlinhos";

    ref var nomeEncontrado = ref LocalizarNome(listaNomes, nomeAtual);

    if (!string.IsNullOrWhiteSpace(nomeEncontrado))
    {
      nomeEncontrado = novoNome;

      WriteLine($@"\nA lista de nomes alterada é: 
      {string.Join(", \n", listaNomes)}
    ");
    }
    else
    {
      WriteLine("Lista não alterada.");
    }
  }

  static ref string LocalizarNome(string[] nomes, string nome)
  {
    for (int i = 0; i < nomes.Length; i++)
    {
      if (nomes[i] == nome)
        return ref nomes[i];
    }
    throw new Exception("Nome não encontrado.");
  }
  static void AlterarNome(string[] nomes, string nomeAtual, string nomeNovo)
  {
    for (int i = 0; i < nomes.Length; i++)
    {
      if (nomes[i] == nomeAtual)
      {
        nomes[i] = nomeNovo;
      }
    }
  }

  static void Demo2()
  {
    var listaNomes = new string[] { "Raphael", "Daniel", "Miguel" };

    WriteLine($@"A lista de nomes é: 
      {string.Join(", \n", listaNomes)}
    ");

    WriteLine("Digite o nome que deseja trocar: ");
    var nomeAtual = ReadLine();
    if (nomeAtual == null)
      nomeAtual = "Carlinhos";
    WriteLine("Digite o novo nome: ");
    var novoNome = ReadLine();
    if (novoNome == null)
      novoNome = "Carlinhos";

    AlterarNome(listaNomes, nomeAtual, novoNome);
    WriteLine($@"A lista de nomes alterada é: 
      {string.Join(", \n", listaNomes)}
    ");
  }

  static void Demo1()
  {
    int numero = 5;
    Adicionar20(ref numero);
    WriteLine($"O valor do número é: {numero}");
  }
  static void Adicionar20(ref int x)
  {
    x += 20;
  }
}