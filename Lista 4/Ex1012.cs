using System; 

public class Program {

  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    double pi = 3.14159;
    double a = double.Parse(v[0]);
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);
    double triangulo = a * c/2;
    double circulo = pi * Math.Pow(c, 2);
    double trapezio = ((a + b) * c)/2;
    double quadrado = b * b;
    double retangulo = a * b;
    Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
    Console.WriteLine($"CIRCULO: {circulo:0.000}");
    Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
    Console.WriteLine($"QUADRADO: {quadrado:0.000}");
    Console.WriteLine($"RETANGULO: {retangulo:0.000}");
    
  }
}