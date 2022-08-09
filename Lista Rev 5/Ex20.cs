using System;
public class Program{
  public static void Main(string[] args){
    int x = 4;
    int y = 7;
    int z = 2;
    bool a = false;
    Ordenar(a, ref x, ref y, ref z);
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
  }
  public static void Ordenar(bool crescente, ref int a, ref int b, ref int c){
    //int menor = Math.Min(a, b, c);
    //int maior = Math.Max(a, b, c);
    int menor1 = Math.Min(a, b);
    int menor2 = Math.Min(b, c);
    int menor = 0;
    if(menor1 == menor2) menor = b;
    if(menor1 != menor2) menor = Math.Min(a, c);

    int maior1 = Math.Max(a, b);
    int maior2 = Math.Max(b, c);
    int maior = 0;
    if(maior1 == maior2) maior = b;
    if(maior1 != maior2) maior = Math.Max(a, c);
    int medio = a;
    if(b != menor && b != maior) medio = b;
    if(c != menor && c != maior) medio = c;
    a = menor;
    b = medio;
    c = maior;
  }
}