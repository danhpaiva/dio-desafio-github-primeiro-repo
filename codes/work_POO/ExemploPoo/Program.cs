using ExemploPoo.Interfaces;
using ExemploPoo.Models;
using ExemploPoo.Helper;
using static System.Console;

WriteLine("\nEstudando POO");

static void Abstrair()
{
  WriteLine("\nAbstração: ");
  Pessoa pessoa = new Pessoa();
  //p1.Nome = "danhpaiva"; Pega o nome que foi passado no construtor
  pessoa.Nome = "danhpaiva";
  pessoa.Idade = 29;
  pessoa.Apresentar();
}

static void Encapsular()
{
  WriteLine("\nEncapsulamento: ");
  Retangulo retangulo = new Retangulo();
  //Valores válidos
  retangulo.DefinirMedidas(10, 20);
  WriteLine($"Área: {retangulo.ObterArea()}");

  Retangulo retangulo_dois = new Retangulo();
  //Valores inválidos
  retangulo_dois.DefinirMedidas(-10, 20);
  WriteLine($"Área: {retangulo_dois.ObterArea()}");
}

static void Herdar()
{
  WriteLine("\nHerança: ");
  Aluno aluno = new Aluno();
  aluno.Nome = "João";
  aluno.Apresentar();

  Professor professor = new Professor();
  professor.Nome = "Wesley Dias Maciel";
  professor.Salario = 1000;
  professor.Idade = 30;
  professor.Apresentar();
}

static void MudarEstados()
{
  WriteLine("\nPolimorfismo em tempo de execução: ");
  Aluno aluno_dois = new Aluno();
  aluno_dois.Nome = "Gabriel";
  aluno_dois.Idade = 15;
  aluno_dois.Nota = 7;
  aluno_dois.Apresentar();

  Professor professor1 = new Professor();
  professor1.Nome = "Wesley Dias Maciel";
  professor1.Salario = 1000;
  professor1.Idade = 30;
  professor1.Apresentar();

  WriteLine("\nPolimorfismo em tempo de compilação: ");
  Calculadora calculadora = new Calculadora();
  WriteLine($"Resultado primeira soma: {calculadora.Somar(10, 10)} .");
  WriteLine($"Resultado segunda soma: {calculadora.Somar(10, 10, 30)} .");
}

static void ClassesEMetodos()
{
  WriteLine("\nClasse Abstrata: ");
  ContaCorrente contaCorrente = new ContaCorrente();
  contaCorrente.Creditar(1000);
  contaCorrente.ExibirSaldo();

  WriteLine("\nClasses e Métodos Selados: ");
  Diretor diretor = new Diretor();
  diretor.Nome = "Luiz";
  diretor.Apresentar();

  WriteLine("\nClasses Objects: ");
  Computador computador = new Computador();
  WriteLine(computador.ToString());

  WriteLine("\nInterfaces: ");
  ICalculadora interface_calculadora = new Calculadora();
  WriteLine($"Método vindo da Interface, Multiplicador: {interface_calculadora.Multiplicar(10, 10)}");
  WriteLine($"Divisão: {interface_calculadora.Dividir(10, 5)}");
}

WriteLine("\nManipulando Arquivos: ");

WriteLine("Listar Diretório: ");
FileHelper fileHelper = new FileHelper();
var caminho = @"C:\trabalhandoArquivo\";
fileHelper.ListarDiretorios(caminho);

WriteLine("\nListar Arquivos: ");
fileHelper.ListarArquivosDiretorios(caminho);

WriteLine("Criar Diretório: ");
var caminhoPathCombine = Path.Combine(caminho, "teste_tres", "subpasta_teste_tres");
fileHelper.CriarDiretorio(caminhoPathCombine);

WriteLine("Deletar Diretório: ");
WriteLine(caminhoPathCombine);
fileHelper.DeletarDiretorio(caminhoPathCombine, true);

WriteLine("Criar arquivo texto: ");
var caminhoArquivo = Path.Combine(caminho, "arquivo.txt");
fileHelper.CriarArquivoTexto(caminhoArquivo, "Hello World!");

WriteLine("Criar arquivo texto usando Stream: ");
var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var caminhoArquivoStream = Path.Combine(caminho, "arquivo_stream.txt");
fileHelper.CriarArquivoTextoStream(caminhoArquivoStream, listaString);

WriteLine("Adicionando texto nos arquivos: ");
var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };
fileHelper.AdicionarTextoStream(caminhoArquivoStream, listaStringContinuacao);

WriteLine("Ler arquivo: ");
fileHelper.LerArquivo(caminhoArquivoStream);

//WriteLine("Mover Arquivo: ");
//var novoCaminhoPathCombine = Path.Combine(caminho, "teste_dois", "arquivo_stream.txt");
//fileHelper.MoverArquivo(caminhoArquivoStream, novoCaminhoPathCombine, false);

WriteLine("Copiar Arquivo: ");
var novoCaminhoPathCombineCopiar = Path.Combine(caminho, "teste_dois", "arquivo.txt");
fileHelper.MoverArquivo(caminhoArquivoStream, novoCaminhoPathCombineCopiar, true);

WriteLine("Deletar Arquivo: ");
fileHelper.DeletarArquico(novoCaminhoPathCombineCopiar);