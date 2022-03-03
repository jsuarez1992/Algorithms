namespace Exercise005
{
    using System;
    public class BinarySearchTree
    {
        private TreeNode root;
        public void Add(int x)
        {
            if (this.root == null)
            {
                this.root = new TreeNode(x);
            }
            else
            {
                this.root.AddChild(x);
            }
        }

        public int Height()
        {
            return NodeHeight(this.root);
        }
        private int NodeHeight(TreeNode node)
        {
            if (node == null) return -1;
            return 1 + Math.Max(NodeHeight(node.leftChild), NodeHeight(node.rightChild));
        }
    }
}
