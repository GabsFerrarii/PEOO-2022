using System;
public class Program{
  public static void Main(string[] args){
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(Frete(a,b));
  }
  public static double Frete(double massa, double distancia){
    return massa * distancia/100;
  }
}