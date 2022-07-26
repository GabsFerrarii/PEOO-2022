using System;
public class Program{
  public static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(a, b));
  }
  public static int Soma(int inicio, int fim){
    int x = inicio;
    int soma = 0;
    while(x <= fim){
      soma += x;
      x++;
    }
    return soma;
  }
}