using System; 

public class Program {

  public static void Main(string[] args) {
    double a = int.Parse(Console.ReadLine());
    double b = int.Parse(Console.ReadLine());
    double c = Maior(a, b);
    Console.WriteLine(c);
  }
  public static double Maior(double x, double y){
    if(x > y) return x;
    else return y;
  }
}