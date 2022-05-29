using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    string tipoT = "escaleno";
    if(a == b && b == c) tipoT = "equilátero";
    else if(a == b || a == c || b == c) tipoT = "isósceles";
    if(a + b > c && a + c > b && b + c > a) Console.WriteLine($"Esses valores formam um triângulo do tipo {tipoT}");
    else Console.WriteLine("Esses valores não formam um triângulo");
    
  }
}