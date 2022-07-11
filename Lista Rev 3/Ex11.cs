using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    string texto = Console.ReadLine();
    int x = texto.Length;
    int i = 0;
    int soma = 0;
    while(i < x){
      if(texto[i] == '1') soma += 1;
      if(texto[i] == '2') soma += 2;
      if(texto[i] == '3') soma += 3;
      if(texto[i] == '4') soma += 4;
      if(texto[i] == '5') soma += 5;
      if(texto[i] == '6') soma += 6;
      if(texto[i] == '7') soma += 7;
      if(texto[i] == '8') soma += 8;
      if(texto[i] == '9') soma += 9;
      i++;
    }
    Console.WriteLine(soma);
  }
}