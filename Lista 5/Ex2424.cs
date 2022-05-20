using System; 
public class Program {
  public static void Main(string[] args) {
    string a = Console.ReadLine();
    string[] v = a.Split();
    int x = int.Parse(v[0]);
    int y = int.Parse(v[1]);
    if(x > 432 || y > 468 || x < 0 || y < 0){
      Console.WriteLine("fora");
    }
    else{
      Console.WriteLine("dentro");
    }
  }
}