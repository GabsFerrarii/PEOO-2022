using System;
public class Program{
  public static void Main(string[] args){
    Compra novaCompra = new Compra();
    Console.WriteLine("Digite o valor total:");
    novaCompra.SetTotal(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o número de prestações");
    novaCompra.SetNumPrestacoes(int.Parse(Console.ReadLine()));
    Console.WriteLine($"O valor de cada prestação foi R${novaCompra.GetValorPrestacao()}, mas com o desconto de 15% fica R${novaCompra.GetValorDesconto()}");
  }
}
class Compra{
  private double total;
  private int numPrestacoes;
  public void SetTotal(double t){
    if(t > 0) total = t;
  }
  public void SetNumPrestacoes(int n){
    if(n > 0) numPrestacoes = n;
  }
  public double GetValorPrestacao(){
    return total / numPrestacoes;
  }
  public double GetValorDesconto(){
    return GetValorPrestacao() - ((GetValorPrestacao() * 15) / 100);
  }
}