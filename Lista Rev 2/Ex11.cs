using System; 
public class Program {
  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    string[] v = texto.Split('/');
    int dia = int.Parse(v[0]);
    int mes = int.Parse(v[1]);
    int ano = int.Parse(v[2]);
    switch(mes){
      case 1: Console.WriteLine($"A data é {dia} de janeiro de {ano}"); break;
      case 2: Console.WriteLine($"A data é {dia} de fevereiro de {ano}"); break;
      case 3: Console.WriteLine($"A data é {dia} de março de {ano}"); break;
      case 4: Console.WriteLine($"A data é {dia} de abril de {ano}"); break;
      case 5: Console.WriteLine($"A data é {dia} de maio de {ano}"); break;
      case 6: Console.WriteLine($"A data é {dia} de junho de {ano}"); break;
      case 7: Console.WriteLine($"A data é {dia} de julho de {ano}"); break;
      case 8: Console.WriteLine($"A data é {dia} de agosto de {ano}"); break;
      case 9: Console.WriteLine($"A data é {dia} de setembro de {ano}"); break;
      case 10: Console.WriteLine($"A data é {dia} de outubro de {ano}"); break;
      case 11: Console.WriteLine($"A data é {dia} de novembro de {ano}"); break;
      case 12: Console.WriteLine($"A data é {dia} de dezembro de {ano}"); break;
    }
  }
}