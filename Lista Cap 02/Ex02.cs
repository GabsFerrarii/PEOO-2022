using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite sua data de nascimento:");
    string[] datas = Console.ReadLine().Split('/');
    int idade = 2022 - int.Parse(datas[2]);
    Console.Write("Você está na faixa etária: ");
    if(idade >= 0 && idade <= 19) Console.WriteLine("Jovem");
    else if(idade >= 20 && idade <= 59) Console.WriteLine("Adulto");
    else if(idade >= 60) Console.WriteLine("Idoso");
  }
}