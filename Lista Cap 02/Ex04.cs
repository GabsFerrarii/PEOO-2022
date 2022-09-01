using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite o nome e a data de nascimento da 1a pessoa:");
    string nome1 = Console.ReadLine();
    string[] datas1 = Console.ReadLine().Split('/');
    int dia1 = int.Parse(datas1[0]);
    int mes1 = int.Parse(datas1[1]);
    int ano1 = int.Parse(datas1[2]);
    Console.WriteLine("Digite o nome e a data de nascimento da 2a pessoa:");
    string nome2 = Console.ReadLine();
    string[] datas2 = Console.ReadLine().Split('/');
    int dia2 = int.Parse(datas2[0]);
    int mes2 = int.Parse(datas2[1]);
    int ano2 = int.Parse(datas2[2]);
    if(ano1 == ano2){
      if(mes1 == mes2){
        if(dia1 == dia2) Console.WriteLine("Ambos tem a mesma idade");
        else if(dia1 < dia2) Console.WriteLine($"{nome2} é o mais novo");
        else if(dia2 < dia1) Console.WriteLine($"{nome1} é o mais novo");
      }
      else if(mes1 < mes2) Console.WriteLine($"{nome2} é o mais novo");
      else if(mes2 < mes1) Console.WriteLine($"{nome1} é o mais novo");
    }
    else if(ano1 < ano2) Console.WriteLine($"{nome2} é o mais novo");
    else if(ano2 < ano1) Console.WriteLine($"{nome1} é o mais novo");
  }
}