using System;
class Program{
  public static void Main(){
    Frete gomes = new Frete();
    gomes.Distancia = 3;
    gomes.Peso = 2;
    Console.WriteLine(gomes);
  }
}

class Frete{
  private double distancia, peso;
  public double Distancia {
    get {return distancia;}
    set {if(value > 0) distancia = value;}
  }
  public double Peso {
    get {return peso;}
    set {if(value > 0) peso = value;}
  }
  public double ValorFrete {
    get {return (0.01 * peso) * distancia;}
  }
  public override string ToString(){
    return $"O peso foi de {peso}kg em uma distância de {distancia}km, então o frete será R${ValorFrete:.00}";
  }
}