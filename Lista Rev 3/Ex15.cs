using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    int x = v.Length;
    int i = 0;
    int x2 = 0;
    while(i < x){
      x2 = v[i].Length;
      Console.Write(x2);
      i++;
    }
  }
}