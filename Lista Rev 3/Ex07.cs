using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite Uma Frase: ");
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    int x = v.Length;
    int i = 0;
    int i2 = 0;
    while(i < x){
      while(i2 < x){
        Console.Write(v[i2] + " ");
        i2++;
      }
      Console.WriteLine();
      i++;
      i2 = i;
    }
  }
}