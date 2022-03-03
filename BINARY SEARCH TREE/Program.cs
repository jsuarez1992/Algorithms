using System;

namespace Exercise005
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree bs = new BinarySearchTree();
            bs.Add(5); // Becomes your root
            bs.Add(4); // Goes to the left
            bs.Add(6); // Goes to the right
            Console.WriteLine(bs.Height()); // 1
            bs.Add(3);
            bs.Add(1);
            bs.Add(7);
            Console.WriteLine(bs.Height()); // 3
        }
    }
}
