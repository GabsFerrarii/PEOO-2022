using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    string texto = Console.ReadLine();
    int x = texto.Length;
    int i = 1;
    string c = "";
    while(x >= i){
      c += texto.Substring(x-1);
      texto = texto.Remove(x-1);
      x--;
    }
    Console.WriteLine(c);
  }
}