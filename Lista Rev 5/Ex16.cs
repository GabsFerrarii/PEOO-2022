using System;
public class Program{
  public static void Main(string[] args){
    string d = Console.ReadLine();
    string nasc = Console.ReadLine();
    int x;
    int y;
    Idade(d, nasc, out x, out y);
    Console.WriteLine($"{x} anos e {y} meses");
  }
  public static void Idade(string hoje, string nascimento, out int anos, out int meses){
    string[] hoje2 = hoje.Split('/');
    string[] nasc2 = nascimento.Split('/');
    int diaHj = int.Parse(hoje2[0]);
    int mesHj = int.Parse(hoje2[1]);
    int anoHj = int.Parse(hoje2[2]);
    int diaNas = int.Parse(nasc2[0]);
    int mesNas = int.Parse(nasc2[1]);
    int anoNas = int.Parse(nasc2[2]);
    anos = anoHj - anoNas;
    meses = mesHj - mesNas;
  }
}