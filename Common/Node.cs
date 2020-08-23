namespace Datastructures.Common
{

  /// <summary>
  /// Node class with left, right and value properties
  ///</summary>
  public class Node
  {
    int _data;
    Node _left;
    Node _right;

    public Node Right
    {
      get { return this._right; }
      set { this._right = value; }
    }

    public Node Left
    {
      get { return this._left; }
      set { this._left = value; }
    }

    public int Value { get { return this._data; } set { this._data = value; } }

    /// <summary>
    /// initializes node object using constructor
    ///</summary>
    /// <param name="val"> the data value stored in a node</param>
    /// <returns> return Node instance with Value set to val passed,
    /// left and right references set to bull
    /// </returns>
    public Node(int val)
    {
      this.Value = val;
      this.Right = null;
      this.Left = null;
    }
  }
}