using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    
    int maior = a;
    if(b > maior) maior = b;
    if(c > maior) maior = c;

    int menor = a;
    if(b < menor) menor = b;
    if(c < menor) menor = c;
    int medio = a + b + c - maior - menor;
    if(menor + medio > maior) Console.WriteLine();
    Console.WriteLine($"{menor}, {medio}, {maior}");
  }
}