namespace Datastructures.Graphs
{
  public class Node {
    public int data;
    public Node Left;
    public Node Right;

    public Node(int val)
    {
        this.data=val;
        this.Left = null;
        this.Right = null;
    }
  }
}