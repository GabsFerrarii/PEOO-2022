using System; 
public class Program {
  public static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    int y = 1;
    int z = 0;
    int a = y;
    for(int i = 0; i < x; i++){
      if(i != x-1) Console.Write($"{z} ");
      else Console.WriteLine($"{z}");
      a += z;
      z = y;
      y = a;
    }
  }
}