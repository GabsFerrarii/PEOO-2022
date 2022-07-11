using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite Uma Frase:");
    string texto = Console.ReadLine();
    string [] v = texto.Split();
    foreach(string p in v){
      int soma = 0;
      int i = 0;
      while(i < p.Length){
        if(p[i] == 'a' || p[i] == 'e' || p[i] == 'i' || p[i] == 'o' || p[i] == 'u'){
          soma++;
        }
        i++;
      }
      i = 0;
      while(i < soma){
        Console.Write(p + " ");
        i++;
      }
    }
  }
}