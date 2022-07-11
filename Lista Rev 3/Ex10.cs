using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    string texto = Console.ReadLine();
    int x = texto.Length;
    int i = 1;
    string c;
    while(i <= x){
      c = texto.Substring(1) + texto.Substring(0, 1);
      texto = c;
      Console.WriteLine(texto);
      i++;
    }
  }
}