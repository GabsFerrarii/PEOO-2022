using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite sua data de nascimento:");
    string[] datas = Console.ReadLine().Split('/');
    int idade = 2022 - int.Parse(datas[2]);
    Console.WriteLine($"No final de 2022, você terá {idade} anos");
  }
}