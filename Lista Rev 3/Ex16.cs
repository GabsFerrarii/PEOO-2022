using System;
public class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    string texto = Console.ReadLine().ToLower();
    int x = texto.Length;
    int i = 0;
    int somaA = 0;
    int somaE = 0;
    int somaI = 0;
    int somaO = 0;
    int somaU = 0;
    while(i < x){
      if(texto[i] == 'a') somaA++;
      if(texto[i] == 'e') somaE++;
      if(texto[i] == 'i') somaI++;
      if(texto[i] == 'o') somaO++;
      if(texto[i] == 'u') somaU++;
      i++;
    }
    Console.WriteLine($"A - {somaA}");
    Console.WriteLine($"E - {somaE}");
    Console.WriteLine($"I - {somaI}");
    Console.WriteLine($"O - {somaO}");
    Console.WriteLine($"U - {somaU}");
  }
}