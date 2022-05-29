using System; 
public class Program {
  public static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    if(x > y) Console.WriteLine($"Maior = {x}");
    else if(y > x) Console.WriteLine($"Maior = {y}");
    else if(x == y) Console.WriteLine("Números iguais");
  }
}