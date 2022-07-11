using System;
public class Program{
  public static void Main(string[] args){
    int x = int.Parse(Console.ReadLine());
    for(int i = 1; i <= x; i++){
      int num = int.Parse(Console.ReadLine());
      bool primo = true;
      for(int i2 = 2; i2 < num; i2++){
        if(num % i2 == 0){
          primo = false;
        }
      }
      if(primo) Console.WriteLine($"{num} eh primo");
      else Console.WriteLine($"{num} nao eh primo");
    }
  }
}