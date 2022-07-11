using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    int x = v.Length;
    Console.WriteLine(x);
  }
}