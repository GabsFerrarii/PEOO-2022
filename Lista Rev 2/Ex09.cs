using System;
class exercicio9 {
  static void Main() {
    Console.WriteLine("Digite o horário no formato hh:mm");
    string texto = Console.ReadLine();
    string[] horas = texto.Split(":");
    int h = int.Parse(horas[0]);
    int min = int.Parse(horas[1]);
    if (h >= 12) h -= 12;
    int dist = Math.Abs((h*30 + min/2)-(min*6));
    if (dist > 180) dist = 360 - dist;
    Console.WriteLine($"Menor ângulo entre os ponteiros = {dist} graus");
  }
}