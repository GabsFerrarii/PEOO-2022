using System;
public class Program{
  public static void Main(string[] args){
    Circulo circ1 = new Circulo();
    circ1.raio = 4;
    Console.WriteLine(circ1.CalcArea());
  }
}
class Circulo{
  public double raio;
  public double CalcArea(){
    return 3.14 * 2 * raio;
  }
}