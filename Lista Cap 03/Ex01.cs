using System;
public class Program{
  public static void Main(string[] args){
    IMC meuIMC = new IMC();
    Console.WriteLine("Digite sua altura em metros:");
    meuIMC.SetAltura(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite seu peso em quilos:");
    meuIMC.SetPeso(double.Parse(Console.ReadLine()));
    Console.WriteLine($"O seu IMC é aproximadamente {meuIMC.CalcIMC():.00}");
  }
}
class IMC{
  private double peso;
  private double altura;
  public void SetPeso(double p){
    if(p > 0) peso = p;
  }
  public void SetAltura(double a){
    if(a > 0) altura = a;
  }
  public double GetPeso(){
    return peso;
  }
  public double GetAltura(){
    return altura;
  }
  public double CalcIMC(){
    return peso / Math.Pow(altura, 2);
  }
}