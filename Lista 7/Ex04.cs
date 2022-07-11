using System; 

public class Program {

  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    bool c = Aprovado(a, b);
    Console.WriteLine(c);
    
  }
  public static bool Aprovado(int nota1, int nota2){
    if((nota1 + nota2) / 2 >= 60) return true;
    else return false;
  }
}