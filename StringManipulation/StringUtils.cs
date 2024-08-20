using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class StringUtils
    {
        public int CountVowels(string str) 
        {
            int count = 0;
            string vowel = "aeiou";

            foreach (var s in str.ToLower()) 
            { 
                if(vowel.Contains(s))
                    count++;
            }

            return count;
        }

        public string ReverseString(string str) 
        {
            StringBuilder sb = new StringBuilder();

            for (int i= str.Length-1; i>=0; i--) 
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        public string ReverseWords(string str) 
        {
            var sb = new StringBuilder();

            var strings = str.Trim().Split(' ');

            for (int i = strings.Length - 1; i >= 0; i--) 
            {
                sb.Append(strings[i] + " ");
            }

            return sb.ToString().Trim();
        }

        public bool AreRotations(string str1, string str2) 
        {
            
            if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                return false;

            return (str1.Length == str2.Length && (str1 + str1).Contains(str2));
        }

        public string RemoveDuplicates(string str) 
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            var hashset = new HashSet<char>();

            foreach (var s in str) 
            { 
                if(!hashset.Contains(s))
                    hashset.Add(s);
            }

            return string.Join("",hashset);
        }

        public char GetMaxOccuringChar(string str) 
        {
            if (string.IsNullOrEmpty(str))
                return ' ';

            var strDic = new Dictionary<char, int>();

            foreach (var s in str) 
            {
                if(!strDic.ContainsKey(s))
                    strDic.Add(s, 1);

                strDic[s]++;
            }

            var maxCount = 0;
            var maxChar = ' ';

            foreach (var k in strDic.Keys) 
            {
                if (strDic[k] > maxCount)
                {
                    maxCount = strDic[k];
                    maxChar = k;
                }
            }

            return maxChar;
        }

        public string Ccapitalize(string str) 
        {
            var strings = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i=0; i<strings.Length; i++) 
            {
                if (!string.IsNullOrWhiteSpace(strings[i])) 
                {
                    strings[i] = char.ToUpper(strings[i][0]) + strings[i].Substring(1).ToLower();
                }
            }

            return string.Join(" ", strings);
        }
    }
}
