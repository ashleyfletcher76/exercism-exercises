using System;
using System.Text;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> mySet = new HashSet<char>();
        string lowerCaseString = word.ToLower();

        foreach (char c in lowerCaseString)
        {
            if (mySet.Contains(c))
                return false;
            if (c != ' ' && c != '-')
                mySet.Add(c);
        }
        return true;
    }
}
