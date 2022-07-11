using System;
public class Program{
  public static void Main(string[] args){
    int i = 1;
    int i2 = 1;
    while(i <= 10){
      Console.WriteLine($"Tabuada de {i}");
      while(i2 <=10){
        Console.WriteLine($"{i} x {i2} = {i * i2}");
        i2++;
      }
      Console.WriteLine();
      i2 = 1;
      i++;
    }
  }
}