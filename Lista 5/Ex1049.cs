using System; 
public class Program {
  public static void Main(string[] args) {
    string x1 = Console.ReadLine();
    string x2 = Console.ReadLine();
    string x3 = Console.ReadLine();
    if(x3 == "carnivoro"){
      Console.WriteLine("aguia");
    }
    //hematofagos
    else if(x3 == "hematofago" && x2 == "inseto"){
      Console.WriteLine("pulga");
    }
    else if(x3 == "hematofago" && x2 == "anelideo"){
      Console.WriteLine("sanguessuga");
    }
    //herbivoros
    else if(x3 == "herbivoro" && x2 == "mamifero"){
      Console.WriteLine("vaca");
    }
    else if(x3 == "herbivoro" && x2 == "inseto"){
      Console.WriteLine("lagarta");
    }
    //onivoros
    else if(x3 == "onivoro" && x2 == "ave"){
      Console.WriteLine("pomba");
    }
    else if(x3 == "onivoro" && x2 == "mamifero"){
      Console.WriteLine("homem");
    }
    else if(x3 == "onivoro" && x2 == "anelideo"){
      Console.WriteLine("minhoca");
    }
  }
}