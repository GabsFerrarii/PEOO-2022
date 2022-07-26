using System;
public class Program{
  public static void Main(string[] args){
    string texto = Console.ReadLine();
    Console.WriteLine(Vogais(texto));
  }
  public static string Vogais(string s){
    int x = 0;
    string s2 = "";
    string[] s3 = s.Split();
    foreach (string p in s3){
      x = p.Length;
      for(int i = 0; i < x; i++){
        if(p[i] == 'a' || p[i] == 'e' || p[i] == 'i' || p[i] == 'o' || p[i] == 'u' || p[i]         == 'A' || p[i] == 'E' || p[i] == 'I' || p[i] == 'O' || p[i] == 'U') s2 += p[i];
      }
      s2 += " ";
    }
    
    return s2;
  }
  // (p[i] == 'a' || p[i] == 'e' || p[i] == 'i' || p[i] == 'o' || p[i] == 'u' || p[i] == 'A' || p[i] == 'E' || p[i] == 'I' || p[i] == 'O' || p[i] == 'U') 
}