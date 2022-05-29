using System; 
public class Program {
  public static void Main(string[] args) {
    int w = int.Parse(Console.ReadLine());
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int z = int.Parse(Console.ReadLine());
    int media = (w + x + y + z)/4;
    Console.WriteLine($"Média = {media}");
    Console.WriteLine("Números menores que a média");
    if(w < media) Console.WriteLine(w);
    if(x < media) Console.WriteLine(x);
    if(y < media) Console.WriteLine(y);
    if(z < media) Console.WriteLine(z);
    Console.WriteLine("Números maiores ou iguais à média");
    if(w >= media) Console.WriteLine(w);
    if(x >= media) Console.WriteLine(x);
    if(y >= media) Console.WriteLine(y);
    if(z >= media) Console.WriteLine(z);
  }
}