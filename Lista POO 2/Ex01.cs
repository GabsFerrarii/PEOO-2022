using System;
class Program{
  public static void Main(string[] args){
    Circulo circulo1 = new Circulo();
    Console.WriteLine("Digite o raio do circulo:");
    circulo1.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine($"O raio do circulo é {circulo1.GetRaio()}");
    Console.WriteLine($"A área do circulo é {circulo1.CalcArea()}");
    Console.WriteLine($"A circunferencia do circulo é {circulo1.CalcCircunferencia()}");
  }
}
class Circulo{
  private double raio;
  public void SetRaio(double v){
    if(v > 0) raio = v;
  }
  public double GetRaio(){
    return raio;
  }
  public double CalcArea(){
    return 3.14 * Math.Pow(raio, 2);
  }
  public double CalcCircunferencia(){
    return 2 * 3.14 * raio;
  }
}