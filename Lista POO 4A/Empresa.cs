using System;
class Program{
  private static void Main(){
    
  }
}
class Empresa{
  private Cliente[] clientes = new Cliente[10];
  private string nome;
  private int k = 0;
  public Empresa(string n){
    nome = n;
  }
  public void Inserir(Cliente c){
    clientes[k] = c;
    k++;
  }
  public Cliente[] Listar(){
    return clientes;
  }
}

class Cliente{
  private string nome, cpf;
  private decimal limite;
  private Cliente socio;
  public Cliente(string nome, string cpf, decimal limite){
    this.nome = nome;
    this.cpf = cpf;
    this.limite = limite;
  }
  public void SetSocio(Cliente c){
    if (this.socio != null) {
      Cliente sociodethis = this.socio;
      sociodethis.socio = null;
    }
    // Testar se c tem algum sócio
    if (c.socio != null) c.socio.socio = null;    
    this.socio = c;
    c.socio = this;
  }
  public decimal GetLimite(){
    if(socio == null) return limite;
    else return limite + socio.limite;
  }
  public override string ToString(){
    return $"Nome: {nome}\nCpf: {cpf}\nLimite: {limite}";
  }
}