using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a base e a altura do retângulo:");
    double baseRet = double.Parse(Console.ReadLine());
    double alturaRet = double.Parse(Console.ReadLine());
    double area = baseRet * alturaRet;
    double perimetro = baseRet * 2 + alturaRet * 2;
    double diagonal = Math.Sqrt(Math.Pow(baseRet, 2) + Math.Pow(alturaRet, 2));
    Console.WriteLine("Àrea = {0:0.00}", area);
    Console.WriteLine("Perímetro = {0:0.00}", perimetro);
    Console.WriteLine("Diagonal = {0:0.00}", diagonal);
    
  }
}