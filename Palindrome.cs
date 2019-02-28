using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        string palWord = "";

        Console.WriteLine(word.Length);

        for (int i = word.Length; i > 0; i--)
        {
            Console.WriteLine(i);

            palWord += word.Substring(i - 1, 1);   
        }

        Console.WriteLine(palWord);

        return word.ToLower() == palWord.ToLower();
    }
}