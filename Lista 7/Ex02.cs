using System; 

public class Program {

  public static void Main(string[] args) {
    double a = int.Parse(Console.ReadLine());
    double b = int.Parse(Console.ReadLine());
    double c = int.Parse(Console.ReadLine());
    double d = Maior(a, b, c);
    Console.WriteLine(d);
  }
  public static double Maior(double x, double y, double z){
    double maior = x;
    if(y > maior) maior = y;
    if(z > maior) maior = z;
    return maior;
  }
}