using System;
public class Program{
  public static void Main(string[] args){
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(a));
  }
  public static int MenorInteiro(double x){
    int y = Convert.ToInt32(x);
    if(y >= x) return y;
    else return y + 1;
  }
}