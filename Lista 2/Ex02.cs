using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite seu nome completo:");
    string nome = Console.ReadLine();
    string[] nomeSeparado = nome.Split();
    Console.WriteLine($"Bem-vindo ao C#, {nomeSeparado[0]}");
  }
}