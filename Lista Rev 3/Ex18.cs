using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma sequência de números separados por vírgula:");
    string texto = Console.ReadLine();
    string[] v = texto.Split(',');
    int x = v.Length;
    int i = 0;
    int soma = 0;
    while(i < x){
      soma += int.Parse(v[i]);
      i++;
    }
    Console.WriteLine(soma);
  }
}