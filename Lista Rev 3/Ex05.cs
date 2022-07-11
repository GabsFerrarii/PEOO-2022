using System;
public class Program{
  public static void Main(string[] args){
    int i = 1;
    int i2 = 1;
    Console.Write("1 ");
    while(i + i2 <= 46){
      Console.Write(i + i2 + " ");
      i2 = i2 + i;
      i++;
    }
    Console.WriteLine();
  }
}