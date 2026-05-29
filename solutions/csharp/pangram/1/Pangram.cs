public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> mySet = new HashSet<char>();
        string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZY";
        string inputLower = input.ToLower();
        int i = 0;
        while (i < inputLower.Length)
        {
            if (alphabet.Contains(inputLower[i]))
                mySet.Add(inputLower[i]);
            i++;
        }
        if (mySet.Count == 26)
            return true;
        else
            return false;
    }
}
