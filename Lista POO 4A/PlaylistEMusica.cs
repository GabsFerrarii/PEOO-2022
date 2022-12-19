using System;
class Program{
  public static void Main(){
    PlayList p = new PlayList("Romantismo", "Músicas deveras românticas");
    Musica m = new Musica("BB (Garupa de Moto Amarela)", "Tim Bernardes" ,"Mil Coisas Invisíveis");
    p.Inserir(m);
    Console.WriteLine(m);
    foreach(Musica m2 in p.Listar()){
      Console.WriteLine(m2);
    }
  }
}
class PlayList{
  private string nome, descricao;
  private Musica[] musicas = new Musica[2];
  private int ultm = 0;
  public PlayList(string nome, string descricao){
    this.nome = nome;
    this.descricao = descricao;
  }
  public void Inserir(Musica m){
    if(musicas.Length == ultm){
      Array.Resize(ref musicas, musicas.Length+2);
    }
    musicas[ultm] = m;
    ultm += 1;
  }
  public Musica[] Listar(){
    return musicas;
  }
  // public TimeSpan TempoTotal(){
  //   TimeSpan SomaTs = TimeSpan.Zero;
  //   foreach (Musica m in musicas){
  //     SomaTs += m.GetDuracao();
  //   }
  //   return SomaTs;
  // }
  public override string ToString(){
    return $"Nome: {nome}, Descrição: {descricao}.";
  }
}
class Musica{
  private string titulo, artista, album;
  // private DateTime dataInclusao;
  // private TimeSpan duracao;
  public Musica(string titulo, string artista, string album){
    this.titulo = titulo;
    this.artista = artista;
    this.album = album;
    // this.dataInclusao = dataInclusao;
    // this.duracao = duracao;
  }
  public override string ToString(){
    return $"Título: {titulo}, Artista: {artista}, Álbum: {album}.";
  }
  // public TimeSpan GetDuracao(){
  //   return duracao;
  // }
}