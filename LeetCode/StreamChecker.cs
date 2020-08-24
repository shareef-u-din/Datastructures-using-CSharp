using System;
using Datastructures.Common;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Datastructures.LeetCode
{

  public class StreamChecker
  {
    private Trie _trie = null;
    private Stack<char> _inputList = null;

    public StreamChecker(string[] words)
    {
      _trie = new Trie();
      _inputList = new Stack<char>();
      _trie.LoadTrie(words);
    }
    public bool Find(string word)
    {
      return _trie.Search(word);
    }

    public bool Query(char letter)
    {
      _inputList.Push(letter);
      return _trie.FindPath(_inputList);
    }
  }
}