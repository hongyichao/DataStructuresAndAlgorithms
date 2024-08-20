
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