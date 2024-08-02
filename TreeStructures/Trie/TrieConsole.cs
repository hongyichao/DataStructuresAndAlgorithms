using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Trie
{
    public class TrieConsole
    {
        public void Run() 
        {
            var trie = new Trie();

            trie.Insert("cat");
            trie.Insert("can");
            trie.Insert("category");
            trie.Insert("candy");

            Console.WriteLine("Contains: " + trie.Contains("cat"));
            Console.WriteLine("Contains: " + trie.Contains("car"));
            Console.WriteLine("Contains: " + trie.Contains("category"));


            Console.WriteLine("Pre-Order Traverse: " + new String(trie.PreOrderTraverse().ToArray()));
            Console.WriteLine("Post-Order Traverse: " + new String(trie.PostOrderTraverse().ToArray()));

            Console.WriteLine("remove category"); 
            trie.Delete("category");

            Console.WriteLine("remove hello");
            trie.Delete("hello");
            Console.WriteLine("Contains: " + trie.Contains("cat"));
            Console.WriteLine("Contains: " + trie.Contains("category"));


            trie.Insert("car");
            trie.Insert("care");
            trie.Insert("careful");
            trie.Insert("carefully");
            trie.Insert("holiday");
            trie.Insert("hello");

            var words = trie.FindWords("car");

            foreach (var word in words) 
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Contains: " + trie.HasTheWord("careful"));

            Console.WriteLine("Total number of words: " + trie.CountWords());


            Console.WriteLine("The longest prefix: " + Trie.LongestCommonPrefix(new string[] {"category", "careless", "care", "careful", "carefully"}));
            Console.WriteLine("The longest prefix: " + Trie.LongestCommonPrefix(new string[] { "category"}));
            Console.WriteLine("The longest prefix: " + Trie.LongestCommonPrefix(new string[] { }));
            Console.WriteLine("The longest prefix: " + Trie.LongestCommonPrefix(null));

            Console.WriteLine("done");
        } 


    }
}
