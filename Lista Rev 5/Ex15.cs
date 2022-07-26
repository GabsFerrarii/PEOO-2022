using System;
public class Program{
  public static void Main(string[] args){
    int m = int.Parse(Console.ReadLine());
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(UltimoDia(m, a));
  }
  public static string UltimoDia(int mes, int ano){
    if(mes % 2 != 0 && mes <= 7) return $"31/{mes}/{ano}";
    if(mes % 2 == 0 && mes <= 6 && mes != 2) return $"30/{mes}/{ano}";
    if(mes % 2 != 0 && mes >= 9) return $"30/{mes}/{ano}";
    if(mes % 2 == 0 && mes >= 8) return $"31/{mes}/{ano}";
    if(mes == 2 && ano % 4 == 0) return $"29/{mes}/{ano}";
    else return $"28/{mes}/{ano}";
  }
}