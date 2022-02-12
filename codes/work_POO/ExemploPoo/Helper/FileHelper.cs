using static System.Console;
namespace ExemploPoo.Helper
{
  public class FileHelper
  {
    public void ListarDiretorios(string caminho)
    {
      var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

      foreach (var retorno in retornoCaminho)
      {
        WriteLine(retorno);
      }
    }

    public void ListarArquivosDiretorios(string caminho)
    {
      var retornoArquivos = Directory.GetFiles(caminho, "*dois*", SearchOption.AllDirectories);

      foreach (var arquivo in retornoArquivos)
      {
        WriteLine(arquivo);
      }
    }

    public void CriarDiretorio(string caminho)
    {
      var diretorioRetorno = Directory.CreateDirectory(caminho);
      WriteLine(diretorioRetorno.FullName);
    }

    public void DeletarDiretorio(string caminho, bool apagarArquivos)
    {
      Directory.Delete(caminho, apagarArquivos);
    }

    public void CriarArquivoTexto(string caminho, string conteudo)
    {
      if (!File.Exists(caminho))
        File.WriteAllText(caminho, conteudo);
    }

    public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
    {
      //Terminar a stream e garantir que o arquivo seja liberado para que outro processo possa trabalhar
      using (var stream = File.CreateText(caminho))
      {
        foreach (var linha in conteudo)
        {
          stream.WriteLine(linha);
        }
      }
    }

    public void AdicionarTexto(string caminho, string conteudo)
    {
      File.AppendAllText(caminho, conteudo);
    }

    public void AdicionarTextoStream(string caminho, List<string> conteudo)
    {
      //Terminar a stream e garantir que o arquivo seja liberado para que outro processo possa trabalhar
      using (var stream = File.AppendText(caminho))
      {
        foreach (var linha in conteudo)
        {
          stream.WriteLine(linha);
        }
      }
    }

    public void LerArquivo(string caminho)
    {
      var conteudo = File.ReadAllLines(caminho);

      foreach (var linha in conteudo)
      {
        WriteLine(linha);
      }
    }

    public void LerArquivoStream(string caminho)
    {
      string linha = string.Empty;

      using (var stream = File.OpenText(caminho))
      {
        while ((linha = stream.ReadLine()) != null)
        {
          WriteLine(linha);
        }
      }
    }

    public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
    {
      File.Move(caminho, novoCaminho, sobrescrever);
    }

    public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
    {
      File.Copy(caminho, novoCaminho, sobrescrever);
    }

    public void DeletarArquico(string caminho)
    {
      File.Delete(caminho);
    }
  }
}