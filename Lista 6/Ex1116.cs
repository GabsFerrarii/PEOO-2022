using System; 

public class Program {
  public static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    for(int i = 0; i < x; i++){
      string texto = Console.ReadLine();
      string[] v = texto.Split();
      double a = double.Parse(v[0]);
      double b = double.Parse(v[1]);
      double divisao = a / b;
      if(b == 0) Console.WriteLine("divisao impossivel");
      else if(divisao >= 0 && divisao < 1) Console.WriteLine($"{divisao:0.0}");
      else Console.WriteLine($"{divisao:.0}");
    }
  }
}