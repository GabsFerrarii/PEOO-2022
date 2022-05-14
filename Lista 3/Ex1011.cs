using System; 

public class Program {

  public static void Main(string[] args) {
    double r = double.Parse(Console.ReadLine());
    double vol = (4.0/3) * 3.14159 * Math.Pow (r, 3);
    Console.WriteLine($"VOLUME = {vol:0.000}");
  }
}