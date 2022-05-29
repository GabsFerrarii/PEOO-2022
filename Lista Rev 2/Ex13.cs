using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite dez valores inteiros");
    string texto = Console.ReadLine();
    string[] v = texto.Split();
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(v[2]);
    int d = int.Parse(v[3]);
    int e = int.Parse(v[4]);
    int f = int.Parse(v[5]);
    int g = int.Parse(v[6]);
    int h = int.Parse(v[7]);
    int i = int.Parse(v[8]);
    int j = int.Parse(v[9]);
    int maior = a;
    if(b > maior) maior = b;
    if(c > maior) maior = c;
    if(d > maior) maior = d;
    if(e > maior) maior = e;
    if(f > maior) maior = f;
    if(g > maior) maior = g;
    if(h > maior) maior = h;
    if(i > maior) maior = i;
    if(j > maior) maior = j;
    int menor = a;
    if(b < menor) menor = b;
    if(c < menor) menor = c;
    if(d < menor) menor = d;
    if(e < menor) menor = e;
    if(f < menor) menor = f;
    if(g < menor) menor = g;
    if(h < menor) menor = h;
    if(i < menor) menor = i;
    if(j < menor) menor = j;
    Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");
  }
}