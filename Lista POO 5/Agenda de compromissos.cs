using System;
class Program{
  public static void Main(){
    Compromisso c1 = new Compromisso {Assunto = "Aniversário do Gomes", Local = "Casa do Gomes", Data = new DateTime(2022, 12, 19)};
    Compromisso c2 = new Compromisso {Assunto = "Aniversário do Somes", Local = "Casa do Somes", Data = new DateTime(2022, 12, 20)};
    Agenda a = new Agenda();
    a.Inserir(c1);
    a.Inserir(c2);
    foreach(Compromisso c in a.Listar()){
      Console.WriteLine(c);
    }
  }
}
class Agenda{
  private Compromisso[] comps = new Compromisso[100];
  private int k;
  public int Qtd{
    get {return k;}
  }
  public void Inserir(Compromisso c){
    comps[k] = c;
    k++;
  }
  // public void Excluir(Compromisso c){
    
  // }
  public Compromisso[] Listar(){
    Compromisso[] vetor = new Compromisso[k];
    Array.Copy(comps, vetor, k);
    return vetor;
  }
  
}

class Compromisso{
  public string Assunto{
    get; set;
  }
  public string Local{
    get; set;
  }
  public DateTime Data{
    get; set;
  }
  public override string ToString(){
    return $"{Assunto} está marcado para {Data} no local {Local}";
  }
}