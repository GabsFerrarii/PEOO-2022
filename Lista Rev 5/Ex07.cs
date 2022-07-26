using System;
public class Program{
  public static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    int b;
    int c;
    AntecessorSucessor(a, out b, out c);
    Console.Write(b);
    Console.Write(" " + c + "\n");
  }
  public static void AntecessorSucessor(int x, out int antecessor, out int sucessor){
    antecessor = x-1;
    sucessor = x+1;
  }
}