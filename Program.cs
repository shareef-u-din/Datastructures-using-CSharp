using System;
using Datastructures.Common;
using Datastructures.LeetCode;
using Datastructures.Trees;

namespace Datastructures
{
  class Program
  {
    static void Main(string[] args)
    {
      // string[] arr = { "cd", "f", "kl" };
      // StreamChecker stream = new StreamChecker(arr);

      // char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l' };
      // foreach (char c in charArray)
      // {
      //   bool x = stream.Query(c);
      // }

      Tree tree = new Tree(3);

      TreeNode treeNode = tree.AddLeft(tree.Root, 9);
      treeNode = tree.AddRight(tree.Root, 20);
      tree.AddLeft(treeNode, 15);
      tree.AddRight(treeNode, 7);
      TreeOperations.SumOfLeftLeaves(tree.Root);
      Console.Read();
    }
  }
}
