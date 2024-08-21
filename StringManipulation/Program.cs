
using StringManipulation;

var strUtils = new StringUtils();

var str = strUtils.ReverseString("abcdefg");

Console.WriteLine(str);

str = strUtils.ReverseWords("Hello~ world! I am dev 1!");
Console.WriteLine(str);


var outcome = strUtils.AreRotations("abc", "cba");

Console.WriteLine("are rotations " + outcome);

str = strUtils.RemoveDuplicates("aabbccddeeff");

Console.WriteLine("outcome: " + str);


var maxChar = strUtils.GetMaxOccuringChar("c gggbhhhhhhh");
Console.WriteLine("outcome: " + maxChar);

str = strUtils.Ccapitalize("hello             world! good          morning!                 ");
Console.WriteLine("Capitalize: " + str);

outcome = strUtils.AreAnagrams("abcd", "abcdd");
Console.WriteLine("are anagrams: " + outcome);

outcome = strUtils.AreAnagrams("abcd", "dcba");
Console.WriteLine("are anagrams: " + outcome);


outcome = strUtils.AreAnagrams2("abcd", "abcdd");
Console.WriteLine("are anagrams: " + outcome);

outcome = strUtils.AreAnagrams2("abcd", "dcba");
Console.WriteLine("are anagrams: " + outcome);

outcome = strUtils.IsPalindrome("abcda");
Console.WriteLine("is palinddrme: " + outcome);

outcome = strUtils.IsPalindrome("abcba");
Console.WriteLine("is palinddrme: " + outcome);


outcome = strUtils.IsPalindrome2("abcda");
Console.WriteLine("is palinddrme2: " + outcome);
outcome = strUtils.IsPalindrome2("abcba");
Console.WriteLine("is palinddrme2: " + outcome);