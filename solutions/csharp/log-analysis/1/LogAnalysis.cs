public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delim)
    {
        int index = str.IndexOf(delim);
        return str.Substring(index + delim.Length);
    }

    public static string SubstringBetween(this string str, string delimOne, string delimTwo)
    {
        int index = str.IndexOf(delimOne);
        int lastIndex = str.IndexOf(delimTwo);
        return str.Substring(index + delimOne.Length, lastIndex - (index + delimOne.Length));
    }
    
    public static string Message(this string str) => str.SubstringAfter(": ");

    public static string LogLevel(this string str) => SubstringBetween(str, "[", "]");
}