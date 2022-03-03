using System;

namespace Exercise005
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inversions inv = new Inversions();
            int[] t = inv.Create(5, 2);
            Console.WriteLine(String.Join(" ", t));

            int[] t2 = inv.Create(10, 45);
            Console.WriteLine(String.Join(" ", t2));
        }
    }
}
