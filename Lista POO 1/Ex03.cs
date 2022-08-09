using System;
public class Program{
  public static void Main(){
    Viagem viagem1 = new Viagem();
    Console.WriteLine("Digite a distância da viagem:");
    viagem1.dist = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o tempo da viagem:");
    viagem1.tempo = Console.ReadLine();
    Console.WriteLine($"A velocidade média da viagem foi {viagem1.VelocidadeMedia()}km/h");
  }
  
}
class Viagem{
  public double dist;
  public string tempo;
  public double VelocidadeMedia(){
    string[] tempoDiv = tempo.Split(':');
    double h = double.Parse(tempoDiv[0]);
    double min = double.Parse(tempoDiv[1]);
    double minTotais = h * 60 + min;
    double vm = dist / (minTotais / 60);
    return vm;
  }
}