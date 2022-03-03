using System;

namespace Exercise004
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Order o = new Order();
            int[] a1 = { 1, 2, 4, 3, 5, 6, 7, 8 }; // pre-order
            int[] b1 = { 4, 2, 1, 5, 3, 7, 6, 8 }; // in-order
            int[] c1 = o.Create(a1, b1);
            Console.WriteLine(String.Join(" ", c1)); // 4 2 5 7 8 6 3 1     

            int[] a2 = { 4, 2, 1, 3, 5 }; // pre-order
            int[] b2 = { 2, 4, 3, 1, 5 }; // in-order
            int[] c2 = o.Create(a2, b2);
            Console.WriteLine(String.Join(" ", c2)); // 2 3 5 1 4      
        }
    }
}
