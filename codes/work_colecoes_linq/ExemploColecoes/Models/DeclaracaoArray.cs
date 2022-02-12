using ExemploColecoes.Helper;
using static System.Console;

namespace ExemploColecoes.Models
{
  public class DeclaracaoArray
  {
    public static void MetodoComArray()
    {
      int[] arrayInteiros = new int[3];

      arrayInteiros[0] = 10;
      arrayInteiros[1] = 20;
      arrayInteiros[2] = 30;

      WriteLine("Percorrendo array utilizando for: ");
      for (int i = 0; i < arrayInteiros.Length; i++)
      {
        WriteLine($"Array na posição {i} : {arrayInteiros[i]}");
      }

      WriteLine("Percorrendo array utilizando foreach: ");
      foreach (var item in arrayInteiros)
      {
        WriteLine($"Valor: {item}");
      }
    }

    public static void MetodoMatriz()
    {
      int[,] matriz = new int[4, 2]
      {
  {8,8},
  {10,20},
  {50,100},
  {90,200}
      };

      for (int i = 0; i < matriz.GetLength(0); i++)
      {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
          WriteLine(matriz[i, j]);
        }
      }
    }

    public void OperacoesArray()
    {
      OperacoesArray operacoesArray = new OperacoesArray();
      int[] array = new int[5] { 6, 3, 8, 1, 10 };
      int[] arrayCopia = new int[10];

      WriteLine("Array Original: ");
      operacoesArray.ImprimirArray(array);

      //operacoesArray.OrdenarBubbleSort(ref array);
      //operacoesArray.OrdenarArray(ref array);
      //System.Console.WriteLine("Array Ordenado: ");

      WriteLine($"Array antes da cópia: ");
      operacoesArray.ImprimirArray(arrayCopia);
      operacoesArray.CopiarArray(ref array, ref arrayCopia);
      WriteLine($"Array depois da cópia: ");
      operacoesArray.ImprimirArray(arrayCopia);

      WriteLine("Verificar elemento no array: ");
      int valorProcurado = 10;
      bool existe = operacoesArray.ExisteElemento(array, valorProcurado);
      if (existe)
      {
        WriteLine($"Encontrei o valor {valorProcurado}");
      }
      else
      {
        WriteLine($"Não encontrei o valor {valorProcurado}");
      }

      WriteLine("Verificar todos os elementos maiores que o valor X: ");
      bool todosMaioresQueX = operacoesArray.TodosMaiorQueValorX(array, valorProcurado);
      if (todosMaioresQueX)
      {
        WriteLine($"Todos os valores são maiores que: {valorProcurado}");
      }
      else
      {
        WriteLine($"Existe valores que não são maiores que: {valorProcurado}");
      }

      System.Console.WriteLine("\nObtendo Valor: ");
      int valorEncontrado = operacoesArray.ObterValor(array, valorProcurado);
      if (valorEncontrado != 0)
      {
        System.Console.WriteLine("Encontrei o valor");
      }
      else
      {
        System.Console.WriteLine("Não encontrei o valor");
      }

      System.Console.WriteLine("\nObtendo indice: ");
      int indiceValorArray = operacoesArray.ObterIndice(array, valorProcurado);
      if (indiceValorArray > -1)
      {
        System.Console.WriteLine($"O índice do elemento {valorProcurado} é {indiceValorArray}");
      }
      else
      {
        System.Console.WriteLine("Não encontrei o valor.");
      }

      System.Console.WriteLine($"\nCapacidade atual do array: {array.Length}");
      operacoesArray.RedimensionarArray(ref array, array.Length * 2);
      System.Console.WriteLine($"Nova capacidade do array: {array.Length}");

      System.Console.WriteLine($"\nConvertendo array: ");
      string[] arrayString = operacoesArray.ConverterParaArrayString(array);
      operacoesArray.ImprimirArray(arrayString);
    }
  }
}