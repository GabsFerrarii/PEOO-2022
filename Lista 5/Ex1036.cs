using System; 

public class Program {

  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    double a = double.Parse(v[0]);
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);
    double delta = Math.Pow(b, 2) - 4 * a * c;
    if(a != 0 && b != 0 && c != 0 && delta > 0){
      double bhaskara1 = (-b + Math.Sqrt(delta))/(2*a);
      double bhaskara2 = (-b - Math.Sqrt(delta))/(2*a);
      Console.WriteLine($"R1 = {bhaskara1:0.00000}");
      Console.WriteLine($"R2 = {bhaskara2:0.00000}");
    }
    else{
      Console.WriteLine("Impossivel calcular");
    }
  }
}