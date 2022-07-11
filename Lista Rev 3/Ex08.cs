using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    int i = 0;
    int x = v.Length;
    int y;
    int y1;
    int y2;
    while(i < x){
      y = v[i].Length;
      y1 = y-2;
      y2 = y-1;
      Console.Write(v[i].Substring(y-1));
      i++;
    }
  }
}