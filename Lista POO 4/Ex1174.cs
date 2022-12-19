using System;
class Program{
  private static void Main(){
    double[] v = new double[10];
    for(double i = 0; i < 10; i++){
      v[i] = double.Parse(Console.ReadLine());
    }
    for(double n = 0; n < 10; n++){
      if(v[n] <= 10) Console.WriteLine($"A[{n}] = {v[n]:.0}");
    }
  }
}