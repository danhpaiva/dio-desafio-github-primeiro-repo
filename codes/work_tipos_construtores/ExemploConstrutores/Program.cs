using ExemploConstrutores.Models;

Pessoa pessoa = new Pessoa("Daniel", "Paiva");
pessoa.ImprimirMensagemConsole();

Log log = Log.GetInstance();
log.PropriedadeLog = "teste_intancia";

Log log2 = Log.GetInstance();
System.Console.WriteLine(log2.PropriedadeLog);

Aluno aluno = new Aluno("Raphael", "Lucas", "teste");
aluno.ImprimirMensagemConsole();

Data data = new Data();
data.SetMes(11);
data.ApresentarMes();
data.Mes = 12;
System.Console.WriteLine(data.Mes);

const double pi = 3.14;
System.Console.WriteLine($"Valor de PI {pi} na constante.");