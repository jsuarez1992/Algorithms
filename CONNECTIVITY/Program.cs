using System;

namespace Exercise001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Connectivity c = new Connectivity(10);
            c.AddConnection(1, 2);
            c.AddConnection(2, 3);
            c.AddConnection(1, 3);
            c.AddConnection(5, 4);
            c.AddConnection(5, 6);
            c.AddConnection(5, 7);
            c.AddConnection(7, 8);
            c.AddConnection(6, 9);
            c.AddConnection(9, 10);
            Console.WriteLine(c.Calculate(5)); // 6
        }
    }
}