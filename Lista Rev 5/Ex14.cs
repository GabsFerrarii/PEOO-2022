using System;
public class Program{
  public static void Main(string[] args){
    string texto = Console.ReadLine();
    Console.WriteLine(Referencia(texto));
  }
  public static string Referencia(string nome){
    string[] v = nome.Split();
    int x = v.Length;
    string referencia = v[x-1].ToUpper() + ", ";
    for(int i = 0; i < x-1; i++){
      referencia += v[i].Substring(0,1) + ". "; 
    }
    return referencia;
  }
}