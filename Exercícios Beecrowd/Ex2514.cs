using System; 

public class Program {

  public static void Main(string[] args) {
    int f = 2;
    while(f != 0){
      int m1 = int.Parse(Console.ReadLine());
      f = m1;
      string t = Console.ReadLine();
      string[] v = t.Split();
      int x1 = int.Parse(v[0]);
      int y1 = int.Parse(v[1]);
      int z1 = int.Parse(v[2]);
    
      Console.WriteLine(MMC(m1, x1, y1, z1));
    }
  }
  public static int MMC(int m, int x, int y, int z){
    int maior = Math.Max(x, y);
    int foda = maior;
    while(!(foda % x == 0 && foda % y == 0 && foda % z == 0)){
      foda++;
    }
    return foda - m;
  }
}