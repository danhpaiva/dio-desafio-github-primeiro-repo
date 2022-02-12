using static System.Console;

int a = 2;
int b = 2;

if (a == b)
{
  WriteLine("a e b são iguais.");
}
else
{
  WriteLine("a e b são diferentes.");
}


Numero c = new Numero(5);
Numero d = new Numero(5);

if (c.N == d.N)
{
  WriteLine("c e d são iguais.");
}
else
{
  WriteLine("c e d são diferentes.");
}

class Numero
{
  public int N { get; set; }
  public Numero(int n)
  {
    N = n;
  }
}