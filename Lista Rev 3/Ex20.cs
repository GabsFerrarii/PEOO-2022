using System;
public class Program{
  public static void Main(string[] args){
    int i = 1;
    int i2 = 1;
    while(i <= 10){
      Console.Write(i + " ");
      while(i2 <= i){
        if(i2 % 2 == 0) Console.Write(i2 + " ");
        i2++;
      }
      Console.WriteLine();
      i2 = 1;
      i++;
    }
  }
}