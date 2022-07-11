using System;
public class Program{
  public static void Main(string[] args){
    int i = 1;
    while(i <= 30){
      if(i % 3 == 0) Console.Write($"{i} {i * 3 - 3} ");
      else Console.Write(i + " ");
      i++;
    }
  }
}