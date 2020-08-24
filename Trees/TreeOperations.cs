using System;
using Datastructures.Common;

namespace Datastructures.Trees
{
  public static class TreeOperations
  {
    public static int SumOfLeftLeaves(TreeNode root)
    {
      int sum = 0;
      TreeNode treeNode = root;
      if (treeNode == null) return sum;
      sum = InOrderSumOfLeftLeaves(treeNode);
      return sum;
    }

    public static int InOrderSumOfLeftLeaves(TreeNode root)
    {
      int sum = 0;
      if (root == null) return sum;
      if (root.Left != null)
      {
        if (root.Left.Right != null || root.Left.Left != null)
          sum += 0 + InOrderSumOfLeftLeaves(root.Left);
        else
          sum += root.Left.Value + InOrderSumOfLeftLeaves(root.Left);
      }
      if (root.Right != null)
        sum += 0 + InOrderSumOfLeftLeaves(root.Right);
      return sum;
    }
  }
}