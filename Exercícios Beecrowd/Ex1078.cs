using System;

public class Program{
  
  public static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    for(int i = 1; i <= 10; i++){
      Console.WriteLine($"{i} x {x} = {x * i}");
    }
  }
}
