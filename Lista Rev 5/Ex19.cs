using System;
public class Program{
  public static void Main(string[] args){
    double d = double.Parse(Console.ReadLine());
    string t = Console.ReadLine();
    Console.WriteLine(VelocidadeMedia(d, t));
  }
  public static double VelocidadeMedia(double distancia, string tempo){
    string[] v = tempo.Split(':');
    int h = int.Parse(v[0]);
    int m = int.Parse(v[1]);
    int s = int.Parse(v[2]);
    double tm = (h * 60) + m + (s/60);
    int dist2 = Convert.ToInt32(distancia);
    double vm = dist2 / (tm/60);
    return vm;
  }
}