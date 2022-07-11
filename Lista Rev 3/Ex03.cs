using System;
public class Program{
  public static void Main(string[] args){
    int i = 1;
    while(i <= 10){
      if(i % 2 == 0) Console.Write($"-{i} ");
      else Console.Write(i + " ");
      i++;
    }
  }
}