using System; 
public class Program {
  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int menor = a;
    int maior = a;
    if(b < menor) menor = b;
    if(c < menor) menor = c;
    if(b > maior) maior = b;
    if(c > maior) maior = c;
    int soma = maior + menor;
    Console.WriteLine("A soma do maior com o menor número é " + soma);
    
  }
}