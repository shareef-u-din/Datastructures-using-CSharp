using System;
using System.Collections.Generic;

namespace Datastructures.Common
{

  /// <summary>
  /// TrieNode class withproperties as
  /// Dictionary<char, TrieNode> Children to keep the below characters
  /// char Character, to get the current char
  /// bool IsCompleteWord, to flag that after adding the char, the word becomes complete or not
  /// </summary>
  public class TrieNode
  {

    public Dictionary<char, TrieNode> Children { get; }
    public bool IsCompleteWord { get; set; }

    public char Character { get; set; }

    public TrieNode(char c)
    {
      this.Character = c;
      this.IsCompleteWord = false;
      this.Children = new Dictionary<char, TrieNode>();
    }
  }
}