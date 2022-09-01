using System;
public class Program{
  public static void Main(string[] args){
    Disciplina port = new Disciplina();
    port.nome = "Língua Portuguesa";
    port.n1 = 6;
    port.n2 = 6;
    port.n3 = 6;
    port.n4 = 6;
    port.nf = 8;
    Console.WriteLine(port.MediaParcial());
    Console.WriteLine(port.MediaFinal());
  }
}
class Disciplina{
  public string nome;
  public double n1, n2, n3, n4, nf;
  public double MediaParcial(){
    return (2 * n1 + 2 * n2 + 3 * n3 + 3 * n4) / 10;
  }
  public double MediaFinal(){
    return (MediaParcial() + nf)/2; 
  }
}