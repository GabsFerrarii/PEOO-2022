using System;
public class Program{
  public static void Main(string[] args){
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(Menor(a, b));
  }
  public static double Menor(double x, double y){
    return Math.Min(x, y);
    // Operador condicional Ternário
    // return x < y ? x : y;
  }
}