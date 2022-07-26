using System;
public class Program{
  public static void Main(string[] args){
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeLitros(a, b, c));
  }
  public static double VolumeLitros(double h, double l, double p){
    return h * l * p * 1000;
  }
}