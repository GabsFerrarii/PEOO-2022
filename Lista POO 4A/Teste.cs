using System;
class Program{
  public static void Main(){
    TimeSpan ts = new TimeSpan(1, 0, 2);
    TimeSpan ts2 = new TimeSpan(2, 14, 18);
    Console.WriteLine(ts + ts2);
  }
}