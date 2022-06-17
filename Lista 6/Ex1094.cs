using System; 

public class Program {

  public static void Main(string[] args) {
  double x = double.Parse(Console.ReadLine());
  double coelhos = 0;
  double ratos = 0;
  double sapos = 0;
    
  for(int i = 0; i < x; i++){
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    if(v[1] == "C") coelhos = coelhos + double.Parse(v[0]);
    else if(v[1] == "R") ratos = ratos + double.Parse(v[0]);
    else if(v[1] == "S") sapos = sapos + double.Parse(v[0]);
    
  }
  double cobaias = coelhos + sapos + ratos;
  Console.WriteLine($"Total: {cobaias} cobaias");
  Console.WriteLine($"Total de coelhos: {coelhos}");
  Console.WriteLine($"Total de ratos: {ratos}");
  Console.WriteLine($"Total de sapos: {sapos}");
  Console.WriteLine($"Percentual de coelhos: {(coelhos * 100) / cobaias:.00} %");
  Console.WriteLine($"Percentual de ratos: {(ratos * 100) / cobaias:.00} %");
  Console.WriteLine($"Percentual de sapos: {(sapos * 100) / cobaias:.00} %");
  }
}