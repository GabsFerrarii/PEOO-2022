using System; 

public class Program {

  public static void Main(string[] args) {
    string s = Console.ReadLine();
    int a = int.Parse(s);
    int b = int.Parse(Console.ReadLine());
    int x = a * b;
    Console.WriteLine($"PROD = {x}");
  }
}