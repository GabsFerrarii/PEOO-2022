using System;
public class Program{
  public static void Main(string[] args){
    string a = Console.ReadLine();
    Console.WriteLine(Senha(a));
  }
  public static string Senha(string texto){
    string[] v = texto.Split();
    int x = v.Length;
    string s = "";
    int y = 0;
    for(int i = 0; i< x; i++){
      y = v[i].Length;
      s += y.ToString();
    }
    return s;
  }
}