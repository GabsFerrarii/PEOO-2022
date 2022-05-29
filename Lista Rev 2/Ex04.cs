using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string texto = Console.ReadLine();
    string[] v = texto.Split(':');
    int h1 = int.Parse(v[0]);
    int m1 = int.Parse(v[1]);
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string texto2 = Console.ReadLine();
    string[] v2 = texto2.Split(':');
    int h2 = int.Parse(v2[0]);
    int m2 = int.Parse(v2[1]);
    int h = h1 + h2;
    int m = m1 + m2;
    
    if (m > 60)
    {
      h = h + 1;
      m = m - 60;
    }
    else if (m == 60)
    {
      h = h + 1;
      m = 0;
    }
    Console.WriteLine($"Total de horas = {h:00}:{m}");
  }
}