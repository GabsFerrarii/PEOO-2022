using System;
class Program{
  public static void Main(string[] args){
    Ingresso ingresso1 = new Ingresso();
    Console.WriteLine("Digite o dia da compra do Ingresso e o horário (em h)");
    ingresso1.SetDia(Console.ReadLine());
    ingresso1.SetHorario(int.Parse(Console.ReadLine()));
    Console.WriteLine($"O preço da inteira é {ingresso1.Inteira()} e o da meia {ingresso1.Meia()}");
  }
}
class Ingresso{
  private string dia;
  private int horario;
  public void SetDia(string d){
    if(d == "Domingo" || d == "Segunda" || d == "Terça" || d == "Quarta" || d == "Quinta" || d == "Sexta" || d == "Sábado") dia = d;
  }
  public string GetDia(){
    return dia;
  }
  public void SetHorario(int h){
    if(h >= 0 && h < 24) horario = h;
  }
  public int GetHorario(){
    return horario;
  }
  public double Inteira(){
    double valor = 0;
    switch(dia){
      case "Segunda":
      case "Terça":
      case "Quinta": valor = 16; break;
      case "Sexta":
      case "Sábado":
      case "Domingo": valor = 20; break;
      case "Quarta": return 8;
    }
    if(horario == 0 || horario >= 17) valor = valor * 1.5;
    return valor;
  }
  public double Meia(){
    if(dia == "Quarta") return 8;
    return Inteira() / 2;
  }
}