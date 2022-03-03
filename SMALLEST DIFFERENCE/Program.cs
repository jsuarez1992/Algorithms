using System;

namespace Exercise002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SmallestDifference s = new SmallestDifference();
            Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
            Console.WriteLine(s.Calculate(new int[] { 1, 10, 100, 1000 })); // 9
            Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0
        }
    }
}
