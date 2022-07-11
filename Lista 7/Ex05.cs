using System; 

public class Program {

  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    Console.WriteLine(FormatarNome(texto));
  }

  public static string FormatarNome(string nome) {
    string[] v = nome.ToLower().Split();
    string r = "";
    foreach(string p in v) {
      string x = p.Substring(0,1).ToUpper() + p.Substring(1);
      r += x + " ";
    }
    return r;
  }
}