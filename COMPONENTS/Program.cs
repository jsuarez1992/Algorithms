using System;

namespace Exercise002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Components k = new Components(6);
            // One connected component
            k.AddConnection(1, 2);
            k.AddConnection(2, 3);
            k.AddConnection(1, 3);
            k.AddConnection(3, 4);
            // Another connected component
            k.AddConnection(5, 6);
            Console.WriteLine(k.Calculate()); // 2

            Components c = new Components(4);
            // Every node is its own connected component
            Console.WriteLine(c.Calculate()); // 4
        }
    }
}
