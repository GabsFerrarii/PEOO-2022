using System; 
public class Program {
  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int soma = a + b + c +d;
    int menor = a;
    int maior = a;
    bool vdd = a != b && a != c && a != d && b != c && b != d && c != d;
    if(vdd){
      if(b < menor) menor = b;
      if(c < menor) menor = c;
      if(d < menor) menor = d;

      if(b > maior) maior = b;
      if(c > maior) maior = c;
      if(d > maior) maior = d;

      soma = soma - menor - maior;
      Console.WriteLine("Maior valor = " + maior);
      Console.WriteLine("Menor valor = " + menor);
      Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + soma);
    }
    else Console.WriteLine("Erro. Os valores de entrada devem ser diferentes");
  }
}