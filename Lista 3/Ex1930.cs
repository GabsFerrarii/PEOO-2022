using System; 

public class Program {

  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    int x1 = int.Parse(v[0]);
    int x2 = int.Parse(v[1]);
    int x3 = int.Parse(v[2]);
    int x4 = int.Parse(v[3]);
    int res = x1 + x2 + x3 + x4 - 3;
    Console.WriteLine(res);
  }
}