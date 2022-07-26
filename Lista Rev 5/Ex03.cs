using System;
public class Program{
  public static void Main(string[] args){
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(a, b));
  }
  public static double Diagonal(double b, double h){
    return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
  }
}