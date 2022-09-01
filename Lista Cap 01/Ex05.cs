using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite o número de alunos");
    int nNotas = int.Parse(Console.ReadLine()); // 3
    Console.WriteLine("Digite a nota dos alunos:");
    int soma = 0;
    for(int i = 0; i < nNotas; i++){
      int entrada = int.Parse(Console.ReadLine());
      soma += entrada;
    }
    int media = soma / nNotas;
    Console.WriteLine($"Média das notas = {media}");
    
  }
}