using System;

namespace Exercise002
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CircleGame g = new CircleGame();
      Console.WriteLine(g.Last(7)); // 7
      Console.WriteLine(g.Last(4)); // 1
      Console.WriteLine(g.Last(123)); // 119
      Console.WriteLine(g.Last(1235)); // 423
      Console.WriteLine(g.Last(1234)); // 421
      Console.WriteLine(g.Last(100000)); // 68929
      Console.WriteLine(g.Last(1000000)); // 951425
    }
  }
}
