public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        string trimmed = statement.TrimEnd();
        string check = trimmed.ToUpperInvariant();
        if (trimmed.EndsWith('?'))
        {
            if (check.Equals(trimmed)  && CheckChars(trimmed))
                return "Calm down, I know what I'm doing!";
            return "Sure.";
        }
        else if (check.Equals(trimmed) && CheckChars(trimmed))
            return "Whoa, chill out!"; 
        else
            return "Whatever.";
    }

    public static bool CheckChars(string input)
    {
        foreach(char c in input.ToCharArray())
        {
            if (char.IsLetter(c))
                return true;
        }
        return false;
    }
}