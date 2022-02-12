using Aula03;
using static System.Console;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "danhpaiva";
pessoa.Idade = 29;
pessoa.EnderecoPessoa = new Endereco()
{
  Logradouro = "Rua 10",
  CEP = 1000,
  Numero = 10,
  Cidade = "Belo Horizonte"
};

WriteLine("End");