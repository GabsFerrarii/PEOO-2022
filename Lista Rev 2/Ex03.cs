using System; 
public class Program {
  public static void Main(string[] args) {
    int w = int.Parse(Console.ReadLine());
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int z = int.Parse(Console.ReadLine());
    int somaP = 0;
    int somaI = 0;
    if(w % 2 == 0) somaP = somaP + w;
    else somaI = somaI + w;
    if(x % 2 == 0) somaP = somaP + x;
    else somaI = somaI + x;
    if(y % 2 == 0) somaP = somaP + y;
    else somaI = somaI + y;
    if(z % 2 == 0) somaP = somaP + z;
    else somaI = somaI + z;
    Console.WriteLine("Soma dos pares = " + somaP);
    Console.WriteLine("Soma dos ímpares = " + somaI);
  }
}