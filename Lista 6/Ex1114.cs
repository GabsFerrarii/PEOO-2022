using System; 

public class Program {

  public static void Main(string[] args) {
    bool senhaValida = false;
    for(int i = 0; senhaValida == false; i++){
      int senha = int.Parse(Console.ReadLine());
      if(senha != 2002) Console.WriteLine("Senha Invalida");
      else if(senha == 2002) senhaValida = true;
    }
    Console.WriteLine("Acesso Permitido");
  }
}