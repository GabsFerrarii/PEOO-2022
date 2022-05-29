using System;
class exercicio12 {
  static void Main(){
    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
    string conta = Console.ReadLine();
    bool soma = conta.Contains("+");
    bool subt = conta.Contains("-");
    bool mult = conta.Contains("*");
    bool divi = conta.Contains("/");
    string[] v = conta.Split();
    double resultado = 0;
    if (soma) {
      v = conta.Split("+");
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      resultado = x+y;
    }
    if (subt) {
      v = conta.Split("-");
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      resultado = x-y;
    }
    if (mult) {
      v = conta.Split("*");
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      resultado = x*y;
    }
    if (divi) {
      v = conta.Split("/");
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      resultado = x/y;
    }
    Console.WriteLine($"O resultado da operação é {resultado}");
  }
}