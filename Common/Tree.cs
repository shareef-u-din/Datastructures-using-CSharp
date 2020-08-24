using System;

namespace Datastructures.Common
{
  public class Tree
  {
    private TreeNode root = null;

    public TreeNode Root { get { return this.root; } set { this.root = value; } }


    /// <summary>
    /// Create and initialize the tree with first node value
    /// </summary>
    /// <param name="rootValue">The value stored at the root level of the node.</param>
    public Tree(int rootValue)
    {
      root = new TreeNode(rootValue);
    }

    public TreeNode AddLeft(TreeNode treeNode, int value)
    {
      treeNode.Left = new TreeNode(value);
      return treeNode.Left;
    }

    public TreeNode AddRight(TreeNode treeNode, int value)
    {
      treeNode.Right = new TreeNode(value);
      return treeNode.Right;
    }

    /// <summary>
    /// add new element to the tree
    /// </summary>
    /// <param name="value">value to be added in the tree</param>
    public void AddIntoBST(int value)
    {
      if (Root == null) Root = new TreeNode(value);
      TreeNode node = Root;
      TreeNode newNode = new TreeNode(value);
      TreeNode prev = node;
      while (node != null)
      {
        prev = node;
        if (node.Value > value) node = node.Left;
        if (node.Value < value) node = node.Right;
      }

      if (prev.Value > value) prev.Left = newNode;
      else prev.Right = newNode;
    }

  }
}