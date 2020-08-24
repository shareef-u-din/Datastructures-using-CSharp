using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Common
{

  public class Trie
  {
    private readonly TrieNode _rootNode;
    public Trie()
    {
      _rootNode = new TrieNode(default(char));
    }

    /// <summary>
		/// Add a new word to the trie.
		/// </summary>
		/// <param name="word">The word to be added to the trie.</param>
    public void AddWord(string word)
    {
      if (string.IsNullOrEmpty(word)) throw new Exception("Word is either null or empty");

      // reference to root node
      TrieNode currentNode = _rootNode;

      // iterate through all the characters in word
      foreach (char c in word)
      {
        // create empty reference of trienode
        TrieNode nextNode = null;
        // if the char already present in trie, then return its corresponding trienode
        // reference in its value part
        if (currentNode.Children.TryGetValue(c, out nextNode))
        {
          currentNode = nextNode;
        }
        else
        {
          currentNode.Children.Add(c, new TrieNode(c));
          currentNode = currentNode.Children[c];
        }
      }
      currentNode.IsCompleteWord = true;
    }

    /// <summary>
    /// search the word in the trie
    /// </summary>
    /// <param name="word">The word to be searched from the trie.</param>
    public bool Search(string word)
    {
      bool WordExists = true;

      TrieNode trieNode = _rootNode;

      if (trieNode == null) return !WordExists;

      TrieNode child = null;
      foreach (char c in word)
      {
        bool charExists = trieNode.Children.TryGetValue(c, out child);
        if (charExists)
        {
          trieNode = child;
        }
        else
        {
          return !WordExists;
        }
      }
      if (trieNode.IsCompleteWord)
      {
        return WordExists;
      }
      return !WordExists;
    }

    /// <summary>
    /// Build a trie
    /// </summary>
    /// <param name="words">The words to be inserted into the trie.</param>
    public void LoadTrie(string[] words)
    {

      foreach (string word in words)
      {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        if (!string.IsNullOrEmpty(word))
        {
          AddWord(new String(charArray));
        }
      }
    }

    /// <summary>
    /// check if some part of string word is present
    /// </summary>
    /// <param name="word">The word to be searched from the trie.</param>
    public bool CheckPrefixExists(string word)
    {
      bool Exists = true;

      StringBuilder makeWord = new StringBuilder();
      foreach (char c in word)
      {
        makeWord.Append(c);
        if (Search(makeWord.ToString()))
        {
          return Exists;
        }
      }
      return !Exists;
    }

    public bool FindPath(Stack<char> stack)
    {
      TrieNode currentNode = _rootNode;
      foreach (char c in stack)
      {
        TrieNode child = null;
        bool exists = currentNode.Children.TryGetValue(c, out child);
        if (child == null) break;
        if (exists)
        {
          if (child != null && child.Character == c)
          {
            if (child.IsCompleteWord) { return true; }
            else currentNode = child;
          }
          else break;
        }
      }
      return false;
    }
  }
}