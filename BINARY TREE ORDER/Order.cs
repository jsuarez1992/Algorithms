using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Exercise004
{

    public class Order
    {

        int[] preOrder, inOrder;
        private List<int> postOrder = new List<int>();

        static int search(int[] preOrder, int x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (preOrder[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        List<int> printPostOrder(int[] inOrder, int[] preOrder, int n, List<int> postOrder)
        {
            int root = search(inOrder, preOrder[0], n);
            int[] c;
            if (root != 0)
            {
                c = new int[n - 1];
                Array.Copy(preOrder, 1, c, 0, n - 1);
                printPostOrder(inOrder, c, root, postOrder);
            }

            if (root != n - 1)
            {
                c = new int[n - (root + 1)];
                Array.Copy(inOrder, root + 1, c, 0, n - (root + 1));

                int[] c1 = new int[n - (root + 1)];
                Array.Copy(preOrder, root + 1, c1, 0, n - (root + 1));
                printPostOrder(c, c1, n - root - 1, postOrder);

            }
            this.postOrder.Add(preOrder[0]);
            return this.postOrder;
        }

        public int[] Create(int[] a, int[] b)
        {

            List<int>postOrder = new List<int>();
            this.preOrder = a; // root -> left -> right
            this.inOrder = b; //left -> root -> right
            int[] post = printPostOrder(b, a, a.Length, postOrder).ToArray(); //post-order = left -> right -> root

            return post;
        }


    }
}
