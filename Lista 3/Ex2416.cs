using System; 

public class Program {

  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    int x = int.Parse(v[0]);
    int y = int.Parse(v[1]);
    int resto = x % y;
    Console.WriteLine(resto);
  }
}