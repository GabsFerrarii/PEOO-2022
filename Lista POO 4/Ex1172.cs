using System;
class Program{
  private static void Main(string[] args){
    int[] x = new int[10];
    for(int i = 0; i < x.Length; i++){
      x[i] = int.Parse(Console.ReadLine());
      if(x[i] <= 0) x[i] = 1;
    }
    for(int i = 0; i < x.Length; i++)
      Console.WriteLine($"X[{i}] = {x[i]}");
  }
}