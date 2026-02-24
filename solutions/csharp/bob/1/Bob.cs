public static class Bob
{
        public static string Response(string statement)
        {
            if (string.IsNullOrWhiteSpace(statement))
                return Fine();
            string trimmed = statement.TrimEnd();
            if (trimmed.EndsWith('?'))
            {
                if (AllCapitalized(trimmed))
                    return CalmDown();
                return Question();
            }
            else if (AllCapitalized(trimmed))
                return Chill();
            else
                return Whatever();
        }

        public static bool AllCapitalized(string input)
        {
            bool allUpper = false;
            bool lowerSeen = false;
            for (int i = 0; i < input.Length; i++)
            {
            if (!isChar(input[i]))
                continue;
            if (!char.IsUpper(input[i]))
                lowerSeen = true;
            if (!lowerSeen && char.IsUpper(input[i]))
                allUpper = true;
            if (!char.IsUpper(input[i]) )
                allUpper = false;
        }
        if (allUpper) 
            return true;
        return false;
    }

    public static bool isChar(char ch)
    {
        if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            return true;
        return false;
    }

    public static string Question() => "Sure.";
    public static string Chill() => "Whoa, chill out!";
    public static string CalmDown() => "Calm down, I know what I'm doing!";
    public static string Fine() => "Fine. Be that way!";
    public static string Whatever() => "Whatever.";

}