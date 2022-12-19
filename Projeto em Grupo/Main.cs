using System;
class Program{
  public static void Main(){
    Time barauna = new Time();
    barauna.SetNome("Baraúna");
    barauna.SetEstado("RN");
    Jogador rixa = new Jogador();
    rixa.SetNome("Richarlison");
    rixa.SetCamisa("9");
    rixa.SetGols(2);
    Console.WriteLine(rixa);
    Jogador vini = new Jogador();
    vini.SetNome("Vini Jr");
    vini.SetCamisa("20");
    vini.SetGols(0);
    barauna.Inserir(rixa);
    barauna.Inserir(vini);
    foreach(Jogador j in barauna.Listar()){
      Console.WriteLine(j);
    }
    Console.WriteLine(barauna.Artilheiro());
    Console.WriteLine(barauna);
  }
}
class Time{
  private string nome, estado;
  private Jogador[] jogadores = new Jogador[11];
  private int k = 0;
  public void SetNome(string n){
    this.nome = n;
  }
  public void SetEstado(string e){
    this.estado = e;
  }
  public void Inserir(Jogador j){
    jogadores[k] = j;
    k++;
  }
  public Jogador[] Listar(){
    Jogador[] vetor = new Jogador[k];
    Array.Copy(jogadores, vetor, k);
    return vetor;
  }
  public Jogador Artilheiro(){
    if(k == 1) return jogadores[0];
    Jogador art = jogadores[0];
    for(int i = 1; i <= k-1; i++){
      if(jogadores[i].GetGols() > art.GetGols()) art = jogadores[i];
    }
    return art;
  }
  public override string ToString(){
    return $"o artilheiro do time {nome} do estado {estado} é o {Artilheiro().GetNome()}";
  }
}
class Jogador{
  private string nome, camisa;
  private int gols;
  public void SetNome(string n){
    this.nome = n;
  }
  public void SetCamisa(string c){
    this.camisa = c;
  }
  public void SetGols(int g){
    this.gols = g;
  }
  public string GetNome(){
    return nome;
  }
  public int GetGols(){
    return gols;
  }
  public override string ToString(){
    return $"{nome} - camisa {camisa} - {gols} gols";
  }
}