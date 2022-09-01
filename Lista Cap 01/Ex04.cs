/*
int a = 3
int b = 1;
int c = 2
Math.Max(a, b); // 3
Math.Max(a, c); // 3
Math.Max(b, c); // 2
//1, 2, 3, 4, 5, 6, 7...
*/
using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite três números:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int soma = a + b + c;
    int menor = Math.Min(a, b);
    menor = Math.Min(menor, c);
    soma = soma - menor;
    Console.WriteLine($"A soma dos dois maiores é {soma}");
      // Math.Min  Math.Max  Math.Pi Math.Min
  }
}