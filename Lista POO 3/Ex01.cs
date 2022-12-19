using System;
class Program{
  public static void Main(){
    Retangulo r = new Retangulo(3, 4);
    Console.WriteLine($"Diagonal do retangulo = {r.CalcDiagonal()}");
  }
}
class Retangulo{
  private double b, h;
  public Retangulo(double b, double h){
    if(b > 0) this.b = b;
    if(h > 0) this.h = h;
  }
  public void SetAltura(double h){
    if(h > 0) this.h = h;
  }
  public void SetBase(double b){
    if(b > 0) this.b = b;
  }
  public double GetAltura(){
    return h;
  }
  public double GetBase(){
    return b;
  }
  public double CalcArea(){
    return b * h;
  }
  public double CalcDiagonal(){
    return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
  }
  public override string ToString(){
    return $"Esse retângulo tem base {b} e altura {h}";
  }
}