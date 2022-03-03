namespace Exercise005
{
  using System;
  public class TreeNode
  {
    public TreeNode leftChild;
    public TreeNode rightChild;
    private int value;

    public TreeNode(int value)
    {
      this.leftChild = null;
      this.rightChild = null;
      this.value = value;
    }

    public void AddChild(int value)
    {
      if (value < this.value && this.leftChild == null)
      {
        this.leftChild = new TreeNode(value);
      }
      else if (value < this.value)
      {
        this.leftChild.AddChild(value);
      }
      else if (value > this.value && this.rightChild == null)
      {
        this.rightChild = new TreeNode(value);
      }
      else if (value > this.value)
      {
        this.rightChild.AddChild(value);
      }
    }
  }
}
