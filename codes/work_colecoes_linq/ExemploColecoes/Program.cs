using ExemploColecoes.Helper;

int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 1, 4, 100 };

var numerosParesQuery =
from num in arrayNumeros
where num % 2 == 0
orderby num
select num;

var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

System.Console.WriteLine($"Números Pares Query: {string.Join(", ", numerosParesQuery)}");
System.Console.WriteLine($"Números Pares Método: {string.Join(", ", numerosParesMetodo)}");

var valorMinimo = arrayNumeros.Min();
var valorMaximo = arrayNumeros.Max();
var valorMedia = arrayNumeros.Average();

System.Console.WriteLine($"\nValor Mínimo: {valorMinimo} \nValor Máximo: {valorMaximo} \nValor Médio: {valorMedia}");

var somaArray = arrayNumeros.Sum();
System.Console.WriteLine($"Soma: {somaArray}");

var valoresUnicos = arrayNumeros.Distinct().ToArray();
System.Console.WriteLine($"Valores distintos: {string.Join(", ", valoresUnicos)}");

static void TrabalhandoComDicionario()
{
  Dictionary<string, string> estados = new Dictionary<string, string>();
  estados.Add("SP", "São Paulo");
  estados.Add("RJ", "Rio de Janeiro");
  estados.Add("MG", "Minas Gerais");

  foreach (var item in estados)
  {
    System.Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}");
  }

  string valorProcurado = "MG";
  System.Console.WriteLine("\nProcurando valor...");
  System.Console.WriteLine(estados[valorProcurado]);

  System.Console.WriteLine("\nValor Original: ");
  valorProcurado = "RJ";
  System.Console.WriteLine(estados[valorProcurado]);

  estados[valorProcurado] = "RJ - Niterói";
  System.Console.WriteLine("\nValor Atualizado: ");
  System.Console.WriteLine(estados[valorProcurado]);

  System.Console.WriteLine($"Removendo o valor {valorProcurado}");
  estados.Remove(valorProcurado);

  foreach (var item in estados)
  {
    System.Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}");
  }

  if (estados.TryGetValue("MG", out string estadoEncontrado))
  {
    System.Console.WriteLine($"Estado encontrado: {estadoEncontrado}");
  }
  else
  {
    System.Console.WriteLine("Estado não encontrado.");
  }
}

static void TrabalhandoComListas()
{
  List<string> estadosSigla = new List<string> { "SP", "MG", "BA" };
  string[] estadosArray = new string[2] { "SC", "MT" };

  estadosSigla.Add("RJ");

  System.Console.WriteLine($"\nQuantidade de Elementos na Lista: {estadosSigla.Count}");

  OperacoesLista operacoesLista = new OperacoesLista();
  operacoesLista.ImprimirListaString(estadosSigla);

  System.Console.WriteLine("\nRemovendo o elemento...");
  estadosSigla.Remove("BA");
  operacoesLista.ImprimirListaString(estadosSigla);

  System.Console.WriteLine("\nAdicionando o array na lista: ");
  estadosSigla.AddRange(estadosArray);
  operacoesLista.ImprimirListaString(estadosSigla);

  System.Console.WriteLine("\nAdicionando elemento após um índice: ");
  estadosSigla.Insert(2, "ES");
  operacoesLista.ImprimirListaString(estadosSigla);
}

static void TrabalhandoComFila()
{
  Queue<string> fila = new Queue<string>();
  fila.Enqueue("Daniel");
  fila.Enqueue("Lúcia");
  fila.Enqueue("Marcos");

  System.Console.WriteLine($"Total de pessoas na fila: {fila.Count}");
  while (fila.Count > 0)
  {
    System.Console.WriteLine($"Vez de: {fila.Peek()}");
    System.Console.WriteLine($"{fila.Dequeue()} atendido.");
  }
  System.Console.WriteLine($"\nTotal de pessoas na fila: {fila.Count}");
}

static void TrabalhandoComPilha()
{
  Stack<string> pilhaLivros = new Stack<string>();
  pilhaLivros.Push("danhpaiva");
  pilhaLivros.Push(".Net");
  pilhaLivros.Push("CodeClean");
  pilhaLivros.Push("Programador Pragmático");

  System.Console.WriteLine($"Livros para ler este ano: {pilhaLivros.Count}");
  while (pilhaLivros.Count > 0)
  {
    System.Console.WriteLine($"Próximo livro para ler: {pilhaLivros.Peek()}");
    System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso.");
  }
  System.Console.WriteLine($"Livros a ler: {pilhaLivros.Count}");
}