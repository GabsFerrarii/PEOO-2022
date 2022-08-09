using System;
public class Program{
  public static void Main(){
    Ingresso x = new Ingresso();
    Console.WriteLine("Digite a hora:");
    x.hora = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o dia:");
    x.dia = Console.ReadLine();
    Console.WriteLine($"A Inteira é {x.Inteira()} e a meia é {x.Meia()}");
  }
  
}
class Ingresso{
  public string dia;
  public int hora;
  public double Inteira(){
    double valor = 0;
    switch(dia){
      case "seg":
      case "ter":
      case "qui": valor = 16; break;
      case "sex":
      case "sab":
      case "dom": valor = 20; break;
      case "qua": return 8;
    }
    if(hora == 0 || hora >= 17) valor = valor * 1.5;
    return valor;
  }
  public double Meia(){
    if(dia == "qua") return 8;
    return Inteira() / 2;
  }
}