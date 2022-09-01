using System;
class Program{
  public static void Main(string[] args){
    Viagem paraiba = new Viagem();
    Console.WriteLine("Digite a distancia (em km) e o tempo (em h) da viagem:");
    paraiba.SetDistancia(double.Parse(Console.ReadLine()));
    paraiba.SetTempo(double.Parse(Console.ReadLine()));
    Console.WriteLine($"A distância foi de {paraiba.GetDistancia()}km\nO tempo gasto foi de {paraiba.GetTempo()}h\nA velocidade média foi {paraiba.VelocidadeMedia()}km/h");
  }
}
class Viagem{
  private double distancia;
  private double tempo;
  public void SetDistancia(double d){
    if(d > 0) distancia = d;
  }
  public double GetDistancia(){
    return distancia;
  }
  public void SetTempo(double t){
    if(t > 0) tempo = t;
  }
  public double GetTempo(){
    return tempo;
  }
  public double VelocidadeMedia(){
    return distancia / tempo;
  }
}