using System;
public class Program{
  public static void Main(string[] args){
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(Primo(num));
  }
  public static bool Primo(int n){
    for(int i = n-1; i > 1; i--){
      if(n % i == 0) return false;
    }
    return true;
  }
}