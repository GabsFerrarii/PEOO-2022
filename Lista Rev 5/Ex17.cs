using System;
public class Program{
  public static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(MMC(a, b));
  }
  public static int MMC(int x, int y){
    int maior = Math.Max(x, y);
    int mmc = 0;
    for(int i = maior; mmc == 0; i++){
      if(i % x == 0 && i % y == 0) mmc = i;
    }
    return mmc;
  }
}