using System; 

public class Program {

  public static void Main(string[] args) {
    float tempo = float.Parse(Console.ReadLine());
    float velocidade = float.Parse(Console.ReadLine());
    float qtdLitros = (velocidade / 12) * tempo;
    Console.WriteLine($"{qtdLitros:0.000}");
    
  }
}