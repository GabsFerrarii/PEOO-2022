using System; 

public class Program {

  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    Console.WriteLine(Iniciais(texto));
  }

  public static string Iniciais(string nome) {
    string[] v = nome.ToUpper().Split();
    string r = "";
    foreach(string p in v) {
      r += p.Substring(0,1);
    }
    return r;
  }
}