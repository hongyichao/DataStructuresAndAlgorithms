using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Trie
{

    public class Trie
    {
        Node root = new Node(' ');

        public void Insert(string word)
        {
            var current = root;

            foreach (var ch in word)
            {
                if (!current.HasChild(ch))
                {
                    current.AddChild(ch);
                }
                current = current.GetChild(ch);
            }

            current.IsEndOfWord = true;
        }

        public bool Contains(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            var current = root;

            foreach (char ch in word)
            {
                if (!current.HasChild(ch))
                    return false;
                current = current.GetChild(ch);
            }

            return current.IsEndOfWord;
        }

        public bool HasTheWord(string word) 
        {
            if(string.IsNullOrEmpty(word))
                return false;

            return HasTheWord(root, word, 0);
        }

        private bool HasTheWord(Node root, string word, int index)
        {
            if (index == word.Length)
                return root.IsEndOfWord;

            if(root == null)
                return false;

            if (!root.HasChild(word[index]))
                return false;

            return HasTheWord(root.GetChild(word[index]), word, index + 1);
        }

        public int CountWords() 
        {
            return CountWords(root);
        }

        private int CountWords(Node root) 
        {
            int total = 0;

            if (root.IsEndOfWord)
                total++;

            foreach (var child in root.Getchildren())
            {
                total += CountWords(child);
            }

            return total;
        }


        public List<char> PreOrderTraverse() 
        { 
            var charList = new List<char>();

            PreOrderTraverse(charList, root);

            return charList;
        }

        private void PreOrderTraverse(List<char> charList, Node root) 
        {
            //Console.WriteLine(root.Value);
            charList.Add(root.Value);

            foreach (var child in root.Getchildren()) 
            { 
                PreOrderTraverse(charList, child);
            }
        }

        public List<char> PostOrderTraverse() 
        {
            var charList = new List<char>();

            PostOrderTraverse(charList, root);

            return charList;
        }

        private void PostOrderTraverse(List<char> charList, Node root) 
        {
            foreach (var child in root.Getchildren())
            {
                PostOrderTraverse(charList, child);
            }

            charList.Add(root.Value);
        }


        public void Delete(string word) 
        {
            if(string.IsNullOrEmpty(word))
                return;

            Delete(root, word, 0);
        }

        private void Delete(Node root, string word, int index) 
        {
            if (index == word.Length) 
            {
                root.IsEndOfWord = false;
                return;
            }
            

            var ch = word[index];

            var child = root.GetChild(ch);

            if (child == null)
                return;

            Delete(child, word, index + 1);

            if (!child.HasAnyChild() && !child.IsEndOfWord)
            {
                root.RemoveChild(ch);
            }
            
        }

        private Node FindTheLastNodeOfThePrefix(string prefix) 
        {
            if (string.IsNullOrEmpty(prefix))
                return null;

            var current = root;

            foreach (var ch in prefix) 
            {
                var child = current.GetChild(ch);
                if (child == null)
                    return null;

                current = child;
            }
            return current;
        }

        public List<string> FindWords(string prefix) 
        {
            var lastChildOfThePrefix = FindTheLastNodeOfThePrefix(prefix);

            var words = new List<string>();

            FindWords(lastChildOfThePrefix, prefix, words);

            return words;   
        }

        private void FindWords(Node root, string prefix, List<string> words) 
        {
            if (root == null)
                return;

            if(root.IsEndOfWord)
                words.Add(prefix);

            foreach (var child in root.Getchildren()) 
            {
                FindWords(child, prefix + child.Value, words);
            }

        }

        public static string LongestCommonPrefix(string[] words) 
        {
            if (words ==null || words.Length ==0) 
            {
                return "";
            }

            var trie = new Trie();

            foreach (var str in words) 
            {
                trie.Insert(str);
            }

            var current = trie.root;

            var prefix = new StringBuilder();

            var shortestWord = GetShortestWord(words);

            while (current.Getchildren().Length == 1) 
            {
                current = current.Getchildren()[0];
                prefix.Append(current.Value);

                if (prefix.ToString() == shortestWord)
                    break;
            }

            return prefix.ToString();
            
        }


        public static string GetShortestWord(string[] words)
        {
            if(words!=null && words.Length > 0)
                return words.OrderBy(w=>w.Length).FirstOrDefault();

            return null;
        }
    }


    public class Node
    {
        private static readonly int ALAHABET;
        public char Value;
        public Dictionary<char, Node> Children = new Dictionary<char, Node> ();
        public bool IsEndOfWord;

        public Node(char value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public bool HasChild(char key) 
        {
            return Children.ContainsKey(key);
        }

        public bool HasAnyChild() 
        {
            return Children.Count > 0;
        }

        public void AddChild(char key) 
        {
            Children.Add(key, new Node(key));
        }

        public Node GetChild(char key) 
        {
            if(Children.ContainsKey(key))
                return Children[key];
            return null;
        }

        public void RemoveChild(char key) 
        {
            Children.Remove(key);
        }

        public Node[] Getchildren() 
        { 
            return Children.Values.ToArray(); 
        }
    }



}
