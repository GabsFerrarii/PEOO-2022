using System; 

public class Program {

  public static void Main(string[] args) {
  int maior = int.Parse(Console.ReadLine());
  int posicao = 0;
    for(int i = 1; i < 100; i++){
      int x = int.Parse(Console.ReadLine());
      if(x > maior){
        maior = x;
        posicao = i + 1;
      } 
    }
  Console.WriteLine(maior);
  Console.WriteLine(posicao);
  }
}