using System;
class Program{
  public static void Main(string[] args){
    int[] x = new int[10];
    int n = int.Parse(Console.ReadLine());
    int cont = 1;
    for(int i = 0; i < x.Length; i++){
      x[i] = n * cont;
      cont = cont * 2;
    }
    for(int i2 = 0; i2 < x.Length; i2++){
      Console.WriteLine($"N[{i2}] = {x[i2]}");
    }
  }
}