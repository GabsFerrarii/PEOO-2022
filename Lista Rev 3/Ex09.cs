using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    string texto = Console.ReadLine();
    int x = texto.Length;
    int i = 1;
    while(i <= x){
      Console.WriteLine($"{i} - {texto}");
      i++;
    }
  }
}