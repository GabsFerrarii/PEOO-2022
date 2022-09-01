using System;
class Program{
  public static void Main(string[] args){
    Disciplina discp = new Disciplina();
  Console.WriteLine("Digite o nome e em seguida as cinco notas da disciplina:");
  discp.SetNome(Console.ReadLine());
  discp.SetNota1(int.Parse(Console.ReadLine()));
  discp.SetNota2(int.Parse(Console.ReadLine()));
  discp.SetNota3(int.Parse(Console.ReadLine()));
  discp.SetNota4(int.Parse(Console.ReadLine()));
  discp.SetNotaFinal(int.Parse(Console.ReadLine()));
  Console.WriteLine($"Suas notas na disciplina de {discp.GetNome()} foram:\nNota1: {discp.GetNota1()}\nNota2: {discp.GetNota2()}\nNota3: {discp.GetNota3()}\nNota4: {discp.GetNota4()}\nNota Final: {discp.GetNotaFinal()}\nSua média parcial foi: {discp.CalcMediaParcial()}\nSua média final foi: {discp.CalcMediaFinal()}");
  }
}
class Disciplina{
  private string nome;
  private int nota1;
  private int nota2;
  private int nota3;
  private int nota4;
  private int notaFinal;
  public void SetNome(string s){
    nome = s;
  }
  public string GetNome(){
    return nome;
  }
  public void SetNota1(int n){
    if(n >= 0 && n <= 10) nota1 = n;
  }
  public int GetNota1(){
    return nota1;
  }
  public void SetNota2(int n){
    if(n >= 0 && n <= 10) nota2 = n;
  }
  public int GetNota2(){
    return nota2;
  }
  public void SetNota3(int n){
    if(n >= 0 && n <= 10) nota3 = n;
  }
  public int GetNota3(){
    return nota3;
  }
  public void SetNota4(int n){
    if(n >= 0 && n <= 10) nota4 = n;
  }
  public int GetNota4(){
    return nota4;
  }
  public void SetNotaFinal(int n){
    if(n >= 0 && n <= 10) notaFinal = n;
  }
  public int GetNotaFinal(){
    return notaFinal;
  }
  public int CalcMediaParcial(){
    return (2 * nota1 + 2 * nota2 + 3 * nota3 + 3 * nota4) / 10;
  }
  public int CalcMediaFinal(){
    return (CalcMediaParcial() + notaFinal)/2; 
  }
}