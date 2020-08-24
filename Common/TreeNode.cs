namespace Datastructures.Common
{

  /// <summary>
  /// Node class with left, right and value properties
  ///</summary>
  public class TreeNode
  {
    private int _data;
    private TreeNode _left;
    private TreeNode _right;

    public TreeNode Right
    {
      get { return this._right; }
      set { this._right = value; }
    }

    public TreeNode Left
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
    public TreeNode(int val)
    {
      this.Value = val;
      this.Right = null;
      this.Left = null;
    }
  }
}