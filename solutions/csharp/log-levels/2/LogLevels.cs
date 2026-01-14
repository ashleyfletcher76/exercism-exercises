static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(" ");
        string msg = logLine.Substring(index + 1);
        string trimmed = msg.Trim();
        return trimmed;
    }

    public static string LogLevel(string logLine)
    {
        int index = logLine.IndexOf("[");
        int lastIndex = logLine.IndexOf("]");
        string msg = logLine.Substring(index + 1, lastIndex - 1);
        string trimmedLower = msg.Trim().ToLower();
        return trimmedLower;
    }

    public static string Reformat(string logLine)
    {
        string msg = Message(logLine);
        string log = LogLevel(logLine);
        return $"{msg} ({log})";
    }
}
