using System;
public class Program{
  public static void Main(string[] args){
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(a));
  }
  public static double AreaCirculo(double raio){
    return 3.14 * Math.Pow(raio, 2);
    
  }
}