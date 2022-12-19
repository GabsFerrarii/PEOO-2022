using System;
class Program{
  public static void Main(){
    Pais albania = new Pais("Albânia", 300);
    Console.WriteLine(albania);
  }
}
class Pais{
  private string nome;
  private int populacao;
  public Pais(string n, int p){
    if(n != string.Empty) nome = n;
    if(p > 0) populacao = p;
  }
  public void SetNome(string n){
    if(n != string.Empty) nome = n;
  }
  public void SetPopulacao(int p){
    if(p > 0) populacao = p;
  }
  public string GetNome(){
    return nome;
  }
  public int GetPopulacao(){
    return populacao;
  }
  public override string ToString(){
    return $"O país {nome} tem uma populacao de {populacao} pessoas";
  }
}