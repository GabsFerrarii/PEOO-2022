using System; 
public class Program {
  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    if(b >= c && b >= a){
      int num1 = (c + a) * 2;
      Console.WriteLine(num1);
    }
    else if(c >= a && (a + b) <= c){
      int num1 = a * 4 + b * 2;
      Console.WriteLine(num1);
    }
    else if(a >= c && (c + b) <= a){
      int num1 = c * 4 + b * 2;
      Console.WriteLine(num1);
    }
    else{
      int num1 = (c + a) * 2;
      Console.WriteLine(num1);
    }
  }
}