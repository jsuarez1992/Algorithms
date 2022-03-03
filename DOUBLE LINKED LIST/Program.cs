using System;

namespace Exercise001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList myLinks = new LinkedList();
            myLinks.AddLast(1);
            myLinks.AddFirst(2);
            myLinks.AddLast(3);
            myLinks.AddLast(12);
            myLinks.AddFirst(6);
            Console.WriteLine(myLinks); // 6 2 1 3 12
            Console.WriteLine(myLinks.GetNode(4)); // 12
            myLinks.RemoveFirst();
            Console.WriteLine(myLinks); // 2 1 3 12
            myLinks.RemoveFirst();
            Console.WriteLine(myLinks); // 1 3 12
            myLinks.RemoveLast();
            Console.WriteLine(myLinks.GetNode(0)); // 1
            Console.WriteLine(myLinks.GetNode(1)); // 3
            Console.WriteLine(myLinks); // 1 3
        }
    }
}