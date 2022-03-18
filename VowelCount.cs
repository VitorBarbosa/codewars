using System;
using System.Linq;

public static class KataVowelCount
{
    public static int GetVowelCount(string str)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        return str.Count(c => vowels.Contains(c));
    }
}