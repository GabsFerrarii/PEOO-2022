using System; 
public class Program {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double delta = Math.Pow(b, 2) - 4 * a * c;
    if(a == 0 || delta < 0) Console.WriteLine("Impossivel calcular");
    else{
      double bhaskara1 = (-b + Math.Sqrt(delta))/(2*a);
      double bhaskara2 = (-b - Math.Sqrt(delta))/(2*a);
      Console.WriteLine($"As raízes são {bhaskara1} e {bhaskara2}");
    }
  }
}