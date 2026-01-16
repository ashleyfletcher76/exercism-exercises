public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delim) => str.Substring(str.IndexOf(delim) + delim.Length);

    public static string SubstringBetween(this string str, string delimOne, string delimTwo)
    {
        string after = str.SubstringAfter(delimOne);
        return after.Substring(0, after.IndexOf(delimTwo));
    }
    
    public static string Message(this string str) => str.SubstringAfter(": ");

    public static string LogLevel(this string str) => SubstringBetween(str, "[", "]");
}