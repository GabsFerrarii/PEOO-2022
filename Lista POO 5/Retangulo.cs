using System;
class Program{
  public static void Main(){
    Retangulo r = new Retangulo();
    r.Base = 2;
    r.Altura = 3;
    Console.WriteLine(r);
  }
}
class Retangulo{
  private double b,h;
  public double Base{
    get {return b;}
    set {if(value > 0) b = value;}
    
  }
  public double Altura{
    get {return h;}
    set {if(value > 0) h = value;}
  }
  public double Area{
    get {return b * h;}
  }
  public double Diagonal{
    get {return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));}
  }
  public override string ToString(){
    return $"O retângulo de altura {h} e base {b} tem área {Area} e diagonal {Diagonal}";
  }
}